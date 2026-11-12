using System.Collections.Generic;

namespace Kepler7.Core.Prototype
{
   
    public class PrototipoTripulante : IPrototipo
    {
        public string Nombre { get; set; }
        public List<string> Habilidades { get; set; } = new List<string>();

     
        public IPrototipo Clonar() => new PrototipoTripulante
        {
            Nombre = Nombre,
            Habilidades = new List<string>(Habilidades)
        };
    }
}
