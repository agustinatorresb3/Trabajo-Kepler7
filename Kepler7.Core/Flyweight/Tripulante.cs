using System.Collections.Generic;

namespace Kepler7.Core.Flyweight
{

    public class Tripulante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Rango { get; set; }
        public IEspecie Especie { get; set; }
    }


    public static class GeneradorTripulacion
    {
        private static readonly string[][] Especies =
        {
            new[] { "Humano", "Beige", "Tierra", "Omnívora" },
            new[] { "Kepleriano", "Azul", "Kepler-7b", "Minerales" },
            new[] { "Zorgon", "Verde", "Zorg", "Herbívora" },
            new[] { "Vulkari", "Rojo", "Vulkar", "Carnívora" },
            new[] { "Aqualis", "Celeste", "Oceanus", "Plancton" }
        };
        private static readonly string[] Rangos = { "Cadete", "Técnico", "Oficial", "Teniente", "Capitán" };

        public static List<Tripulante> Generar(int cantidad, FabricaEspecies fabrica)
        {
            var lista = new List<Tripulante>();
            for (int i = 0; i < cantidad; i++)
            {
                string[] e = Especies[i % 5];
                lista.Add(new Tripulante
                {
                    Id = i + 1,
                    Nombre = "Tripulante-" + (i + 1),
                    Rango = Rangos[i % 5],
                    Especie = fabrica != null ? fabrica.ObtenerEspecie(e[0], e[1], e[2], e[3])
                                              : new Especie(e[0], e[1], e[2], e[3])
                });
            }
            return lista;
        }
    }
}
