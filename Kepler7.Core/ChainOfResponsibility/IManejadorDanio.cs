using System.Collections.Generic;

namespace Kepler7.Core.ChainOfResponsibility
{

    public class Danio
    {
        public int Cantidad { get; set; }
        public List<string> Recorrido { get; } = new List<string>();
    }


    public interface IManejadorDanio
    {
        string Nombre { get; }
        IManejadorDanio Siguiente { get; set; }
        void Manejar(Danio danio);
    }

    public abstract class ManejadorDanio : IManejadorDanio
    {
        public string Nombre => GetType().Name;
        public IManejadorDanio Siguiente { get; set; }
        public abstract void Manejar(Danio danio);

        protected void Pasar(Danio danio, string mensaje)
        {
            danio.Recorrido.Add(Nombre + ": " + mensaje);
            if (danio.Cantidad > 0 && Siguiente != null)
                Siguiente.Manejar(danio);
        }
    }
}
