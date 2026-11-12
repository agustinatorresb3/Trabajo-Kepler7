using System.Data.SqlClient;

namespace Kepler7.Core.Juego
{
    public static class BaseDatos
    {
        private const string Servidor = @"Data Source= .;Integrated Security=True;";
        public const string CadenaConexion = Servidor + "Initial Catalog=Kepler7;";
        private static bool _creada;

        public static void Crear()
        {
            if (_creada)
                return;

            using (var cn = new SqlConnection(Servidor))
            {
                cn.Open();
                new SqlCommand("IF DB_ID('Kepler7') IS NULL CREATE DATABASE Kepler7;", cn).ExecuteNonQuery();
            }
            using (var cn = new SqlConnection(CadenaConexion))
            {
                cn.Open();
                new SqlCommand("IF OBJECT_ID('Progreso') IS NULL CREATE TABLE Progreso (Id INT PRIMARY KEY, XP INT NOT NULL, TutorialVisto BIT NOT NULL, Derrota BIT NOT NULL, MotivoDerrota NVARCHAR(200) NULL, Inicio DATETIME NOT NULL); " +
                    "IF OBJECT_ID('PatronesDominados') IS NULL CREATE TABLE PatronesDominados (Patron NVARCHAR(50) PRIMARY KEY); " +
                    "IF OBJECT_ID('AccesosDenegados') IS NULL CREATE TABLE AccesosDenegados (Id INT IDENTITY(1,1) PRIMARY KEY, Fecha DATETIME NOT NULL, Rol NVARCHAR(30) NOT NULL, Accion NVARCHAR(20) NOT NULL, Archivo NVARCHAR(20) NOT NULL);", cn).ExecuteNonQuery();
            }
            _creada = true;
        }
    }
}
