namespace Kepler7.Core.Proxy
{
    public class ProxyBoveda : IBoveda
    {
        private readonly BovedaDatos _bovedaReal = new BovedaDatos();
        private static readonly RegistroAccesos Registro = new RegistroAccesos();

        public Rol RolUsuario { get; set; }

        public string LeerArchivo(string id) =>
            TienePermiso() ? _bovedaReal.LeerArchivo(id) : Denegar("leer", id);

        public string EscribirArchivo(string id, string contenido) =>
            TienePermiso() ? _bovedaReal.EscribirArchivo(id, contenido) : Denegar("escribir", id);

        public string[] ObtenerRegistro() => Registro.Obtener();

        private bool TienePermiso() => RolUsuario == Rol.Capitan || RolUsuario == Rol.OficialSeguridad;

        private string Denegar(string accion, string id)
        {
            Registro.Registrar(RolUsuario.ToString(), accion, id);
            return "ACCESO DENEGADO: " + RolUsuario + " no puede " + accion + " " + id;
        }
    }
}
