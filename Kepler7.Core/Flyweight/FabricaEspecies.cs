using System.Collections.Generic;

namespace Kepler7.Core.Flyweight
{
    public class FabricaEspecies
    {
        private readonly Dictionary<string, IEspecie> _especies = new Dictionary<string, IEspecie>();

        public int CantidadCreadas => _especies.Count;

        public IEspecie ObtenerEspecie(string nombre, string color, string planetaOrigen, string dieta)
        {
            if (!_especies.ContainsKey(nombre))
                _especies[nombre] = new Especie(nombre, color, planetaOrigen, dieta);
            return _especies[nombre];
        }
    }
}
