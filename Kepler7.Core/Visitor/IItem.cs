using System.Collections.Generic;

namespace Kepler7.Core.Visitor
{
    
    public interface IItem
    {
        void Aceptar(IVisitor visitor);
    }

    public class Arma : IItem
    {
        public string Nombre { get; set; }
        public int Precio { get; set; }
        public bool Envenenada { get; set; }

        public void Aceptar(IVisitor visitor) => visitor.Visitar(this);
        public override string ToString() => "Arma: " + Nombre + " $" + Precio + (Envenenada ? " (ENVENENADA)" : "");
    }

    public class Pocion : IItem
    {
        public string Nombre { get; set; }
        public int Precio { get; set; }

        public void Aceptar(IVisitor visitor) => visitor.Visitar(this);
        public override string ToString() => "Poción: " + Nombre + " $" + Precio;
    }

    public class Armadura : IItem
    {
        public string Nombre { get; set; }
        public int Precio { get; set; }

        public void Aceptar(IVisitor visitor) => visitor.Visitar(this);
        public override string ToString() => "Armadura: " + Nombre + " $" + Precio;
    }

    public class Inventario
    {
        public List<IItem> Items { get; } = new List<IItem>
        {
            new Arma { Nombre = "Rifle de plasma", Precio = 300 },
            new Arma { Nombre = "Cuchillo térmico", Precio = 80 },
            new Pocion { Nombre = "Nanobots médicos", Precio = 120 },
            new Armadura { Nombre = "Traje orbital", Precio = 450 }
        };

        public string Aplicar(IVisitor visitor)
        {
            foreach (IItem item in Items)
                item.Aceptar(visitor);
            return visitor.Resultado;
        }
    }
}
