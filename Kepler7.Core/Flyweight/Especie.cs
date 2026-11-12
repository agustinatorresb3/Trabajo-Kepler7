namespace Kepler7.Core.Flyweight
{
 
    public interface IEspecie
    {
        string Nombre { get; }
        string Color { get; }
        string PlanetaOrigen { get; }
        string Dieta { get; }
    }

    public class Especie : IEspecie
    {
        public static int InstanciasCreadas { get; set; }  

        public string Nombre { get; }
        public string Color { get; }
        public string PlanetaOrigen { get; }
        public string Dieta { get; }

        public Especie(string nombre, string color, string planetaOrigen, string dieta)
        {
            Nombre = nombre;
            Color = color;
            PlanetaOrigen = planetaOrigen;
            Dieta = dieta;
            InstanciasCreadas++;
        }
    }
}
