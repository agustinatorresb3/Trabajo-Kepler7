namespace Kepler7.Core.State
{

    public interface IEstadoPersonaje
    {
        bool PuedeActuar { get; }
        string Atacar();
        string Mover(Personaje p);
        string RecibirDanio(Personaje p, int cantidad);
    }

    public class Normal : IEstadoPersonaje
    {
        public bool PuedeActuar => true;
        public string Atacar() => "Ataca: 10 de daño.";
        public string Mover(Personaje p) { p.Posicion += 1; return "Avanza 1 casilla."; }
        public string RecibirDanio(Personaje p, int c) { p.Vida -= c; return "Recibe " + c + " de daño."; }
    }

    public class Envenenado : IEstadoPersonaje
    {
        public bool PuedeActuar => true;
        public string Atacar() => "Ataque débil: 5 de daño.";
        public string Mover(Personaje p) { p.Posicion += 1; p.Vida -= 5; return "Avanza 1 y el veneno quita 5."; }
        public string RecibirDanio(Personaje p, int c) { p.Vida -= c + 5; return "Recibe " + c + " + 5 de veneno."; }
    }

    public class Aturdido : IEstadoPersonaje
    {
        public bool PuedeActuar => false;
        public string Atacar() => "Está aturdido: no puede atacar.";
        public string Mover(Personaje p) => "Está aturdido: no puede moverse.";
        public string RecibirDanio(Personaje p, int c) { p.Vida -= c; return "Recibe " + c + " de daño."; }
    }

    public class Berserk : IEstadoPersonaje
    {
        public bool PuedeActuar => true;
        public string Atacar() => "¡Ataque furioso: 25 de daño!";
        public string Mover(Personaje p) { p.Posicion += 2; return "Carga 2 casillas."; }
        public string RecibirDanio(Personaje p, int c) { p.Vida -= c * 2; return "Sin guardia: recibe el doble (" + c * 2 + ")."; }
    }
}
