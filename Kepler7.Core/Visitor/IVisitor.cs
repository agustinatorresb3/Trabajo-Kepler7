namespace Kepler7.Core.Visitor
{
    public interface IVisitor
    {
        string Resultado { get; }
        void Visitar(Arma arma);
        void Visitar(Pocion pocion);
        void Visitar(Armadura armadura);
    }

    public class CalculadorPrecio : IVisitor
    {
        private int _total;
        public string Resultado => "Valor total: $" + _total;

        public void Visitar(Arma arma) => _total += arma.Precio;
        public void Visitar(Pocion pocion) => _total += pocion.Precio;
        public void Visitar(Armadura armadura) => _total += armadura.Precio;
    }

    public class ContadorArmas : IVisitor
    {
        private int _cantidad;
        public string Resultado => "Cantidad de armas: " + _cantidad;

        public void Visitar(Arma arma) => _cantidad++;
        public void Visitar(Pocion pocion) { }
        public void Visitar(Armadura armadura) { }
    }

    public class AplicadorVeneno : IVisitor
    {
        public string Resultado => "Veneno aplicado a las armas.";

        public void Visitar(Arma arma) => arma.Envenenada = true;
        public void Visitar(Pocion pocion) { }
        public void Visitar(Armadura armadura) { }
    }
}
