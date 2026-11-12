using System;

namespace Kepler7.Core.ChainOfResponsibility
{

    public class Esquiva : ManejadorDanio
    {
        private readonly Random _rng = new Random();

        public override void Manejar(Danio danio)
        {
            if (_rng.Next(100) < 25) danio.Cantidad = 0;
            Pasar(danio, danio.Cantidad == 0 ? "¡esquivado!" : "falla, pasa " + danio.Cantidad);
        }
    }


    public class Bloqueo : ManejadorDanio
    {
        public override void Manejar(Danio danio)
        {
            if (danio.Cantidad <= 10) danio.Cantidad = 0;
            Pasar(danio, danio.Cantidad == 0 ? "bloqueado" : "muy fuerte, pasa " + danio.Cantidad);
        }
    }


    public class Armadura : ManejadorDanio
    {
        public override void Manejar(Danio danio)
        {
            danio.Cantidad = Math.Max(0, danio.Cantidad - 5);
            Pasar(danio, "absorbe 5, pasa " + danio.Cantidad);
        }
    }


    public class Escudo : ManejadorDanio
    {
        private int _energia = 30;

        public override void Manejar(Danio danio)
        {
            int absorbido = Math.Min(_energia, danio.Cantidad);
            _energia -= absorbido;
            danio.Cantidad -= absorbido;
            Pasar(danio, "absorbe " + absorbido + " (energía " + _energia + "), pasa " + danio.Cantidad);
        }
    }


    public class Vida : ManejadorDanio
    {
        public int Puntos { get; private set; } = 100;

        public override void Manejar(Danio danio)
        {
            Puntos = Math.Max(0, Puntos - danio.Cantidad);
            danio.Recorrido.Add("Vida: recibe " + danio.Cantidad + ", quedan " + Puntos);
            danio.Cantidad = 0;
        }
    }
}
