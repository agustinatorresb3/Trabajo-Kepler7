using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Kepler7.Core.Juego;

namespace Kepler7.Core.Proxy
{
    public class RegistroAccesos
    {
        public RegistroAccesos()
        {
            BaseDatos.Crear();
        }

        public void Registrar(string rol, string accion, string archivo)
        {
            using (var cn = new SqlConnection(BaseDatos.CadenaConexion))
            using (var cmd = new SqlCommand(
                "INSERT INTO AccesosDenegados (Fecha, Rol, Accion, Archivo) VALUES (@fecha, @rol, @accion, @archivo)", cn))
            {
                cmd.Parameters.AddWithValue("@fecha", DateTime.Now);
                cmd.Parameters.AddWithValue("@rol", rol);
                cmd.Parameters.AddWithValue("@accion", accion);
                cmd.Parameters.AddWithValue("@archivo", archivo);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public string[] Obtener()
        {
            var lineas = new List<string>();
            using (var cn = new SqlConnection(BaseDatos.CadenaConexion))
            using (var cmd = new SqlCommand("SELECT Fecha, Rol, Accion, Archivo FROM AccesosDenegados ORDER BY Id", cn))
            {
                cn.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                    while (dr.Read())
                        lineas.Add(dr.GetDateTime(0).ToString("dd/MM/yyyy HH:mm") + " | " + dr.GetString(1) +
                                   " intentó " + dr.GetString(2) + " " + dr.GetString(3));
            }
            return lineas.ToArray();
        }
    }
}
