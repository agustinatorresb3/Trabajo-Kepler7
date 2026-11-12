using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Kepler7.Core.Juego
{
    // Progreso del jugador: XP, nivel, patrones dominados (logros) y resultado.
    public class Progreso
    {
        public static readonly string[] Patrones =
        {
            "Facade", "Builder", "Strategy", "Prototype", "Flyweight", "Bridge",
            "Proxy", "State", "Visitor", "Command", "Template Method", "Chain of Responsibility"
        };

        public int XP { get; set; }
        public List<string> PatronesDominados { get; set; } = new List<string>();
        public bool TutorialVisto { get; set; }
        public bool Derrota { get; set; }
        public string MotivoDerrota { get; set; }
        public DateTime Inicio { get; set; } = DateTime.Now;

        public int Nivel => 1 + XP / 300;
        public bool Victoria => PatronesDominados.Count == Patrones.Length;
        public bool Terminada => Victoria || Derrota;

        public bool Dominar(string patron)
        {
            if (PatronesDominados.Contains(patron))
                return false;

            PatronesDominados.Add(patron);
            XP += 100;
            return true;
        }
    }

    public static class Persistencia
    {
        public static void Guardar(Progreso progreso)
        {
            BaseDatos.Crear();
            using (var cn = new SqlConnection(BaseDatos.CadenaConexion))
            {
                cn.Open();
                SqlTransaction tr = cn.BeginTransaction();

                new SqlCommand("DELETE FROM Progreso; DELETE FROM PatronesDominados;", cn, tr).ExecuteNonQuery();

                var cmd = new SqlCommand(
                    "INSERT INTO Progreso (Id, XP, TutorialVisto, Derrota, MotivoDerrota, Inicio) " +
                    "VALUES (1, @xp, @tutorial, @derrota, @motivo, @inicio)", cn, tr);
                cmd.Parameters.AddWithValue("@xp", progreso.XP);
                cmd.Parameters.AddWithValue("@tutorial", progreso.TutorialVisto);
                cmd.Parameters.AddWithValue("@derrota", progreso.Derrota);
                cmd.Parameters.AddWithValue("@motivo", (object)progreso.MotivoDerrota ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@inicio", progreso.Inicio);
                cmd.ExecuteNonQuery();

                foreach (string patron in progreso.PatronesDominados)
                {
                    var cmdPatron = new SqlCommand("INSERT INTO PatronesDominados (Patron) VALUES (@patron)", cn, tr);
                    cmdPatron.Parameters.AddWithValue("@patron", patron);
                    cmdPatron.ExecuteNonQuery();
                }

                tr.Commit();
            }
        }

        public static Progreso Cargar()
        {
            BaseDatos.Crear();
            var progreso = new Progreso();
            using (var cn = new SqlConnection(BaseDatos.CadenaConexion))
            {
                cn.Open();
                using (var dr = new SqlCommand(
                    "SELECT XP, TutorialVisto, Derrota, MotivoDerrota, Inicio FROM Progreso WHERE Id = 1", cn).ExecuteReader())
                {
                    if (!dr.Read())
                        return progreso;

                    progreso.XP = dr.GetInt32(0);
                    progreso.TutorialVisto = dr.GetBoolean(1);
                    progreso.Derrota = dr.GetBoolean(2);
                    progreso.MotivoDerrota = dr.IsDBNull(3) ? null : dr.GetString(3);
                    progreso.Inicio = dr.GetDateTime(4);
                }
                using (var dr = new SqlCommand("SELECT Patron FROM PatronesDominados", cn).ExecuteReader())
                    while (dr.Read())
                        progreso.PatronesDominados.Add(dr.GetString(0));
            }
            return progreso;
        }
    }
}
