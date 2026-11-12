using System.Collections.Generic;

namespace Kepler7.Core.ChainOfResponsibility
{
  
    public class CadenaDefensas
    {
        public List<IManejadorDanio> Eslabones { get; } = new List<IManejadorDanio>();

        public void Agregar(IManejadorDanio e) { Eslabones.Add(e); Enlazar(); }
        public void Quitar(int i) { Eslabones.RemoveAt(i); Enlazar(); }

        public void Subir(int i)
        {
            if (i <= 0 || i >= Eslabones.Count) return;
            Eslabones.Insert(i - 1, Eslabones[i]);
            Eslabones.RemoveAt(i + 1);
            Enlazar();
        }

        public Danio RecibirAtaque(int cantidad)
        {
            var danio = new Danio { Cantidad = cantidad };
            danio.Recorrido.Add("Ataque de " + cantidad);
            if (Eslabones.Count > 0) Eslabones[0].Manejar(danio);
            return danio;
        }

        private void Enlazar()
        {
            for (int i = 0; i < Eslabones.Count; i++)
                Eslabones[i].Siguiente = i + 1 < Eslabones.Count ? Eslabones[i + 1] : null;
        }
    }
}
