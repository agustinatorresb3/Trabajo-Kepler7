namespace Kepler7.Core.Bridge
{
  
    public abstract class Mensaje
    {
        public ICifrado Cifrado { get; set; }   

        protected Mensaje(ICifrado cifrado) { Cifrado = cifrado; }

        public abstract string Enviar(string contenido);
    }

    public class MensajeTexto : Mensaje
    {
        public MensajeTexto(ICifrado cifrado) : base(cifrado) { }
        public override string Enviar(string contenido) => "[TEXTO] " + Cifrado.Cifrar(contenido);
    }

    public class MensajeAlerta : Mensaje
    {
        public MensajeAlerta(ICifrado cifrado) : base(cifrado) { }
        public override string Enviar(string contenido) => "[ALERTA] " + Cifrado.Cifrar("ATENCIÓN: " + contenido);
    }

    public class MensajeEmergencia : Mensaje
    {
        public MensajeEmergencia(ICifrado cifrado) : base(cifrado) { }
        public override string Enviar(string contenido) => "[EMERGENCIA] " + Cifrado.Cifrar("SOS " + contenido.ToUpper());
    }
}
