namespace Kepler7.Core.State
{

    public class Personaje
    {
        public int Vida { get; set; } = 100;
        public int Posicion { get; set; }
        public IEstadoPersonaje Estado { get; set; }

        public Personaje() { Estado = new Normal(); }

        public string Atacar() => Estado.Atacar();
        public string Mover() => Estado.Mover(this);
        public string RecibirDanio(int cantidad) => Estado.RecibirDanio(this, cantidad);
    }
}
