using System.Collections.Generic;

namespace Kepler7.Core.Proxy
{
    public enum Rol { Capitan, OficialSeguridad, Ingeniero, Tripulante }

    public interface IBoveda
    {
        string LeerArchivo(string id);
        string EscribirArchivo(string id, string contenido);
    }


    public class BovedaDatos : IBoveda
    {
        private readonly Dictionary<string, string> _archivos = new Dictionary<string, string>
        {
            { "A-01", "Coordenadas del agujero de gusano" },
            { "A-02", "Códigos de autodestrucción" },
            { "A-03", "Informe secreto de la crisis" }
        };

        public string LeerArchivo(string id) =>
            _archivos.ContainsKey(id) ? id + ": " + _archivos[id] : "El archivo " + id + " no existe.";

        public string EscribirArchivo(string id, string contenido)
        {
            _archivos[id] = contenido;
            return "Archivo " + id + " guardado.";
        }
    }
}
