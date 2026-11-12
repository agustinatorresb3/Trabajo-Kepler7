using System;
using System.Collections.Generic;

namespace Kepler7.Core.Command
{

    public class Unidad
    {
        public string Nombre { get; set; }
        public int Posicion { get; set; }
        public int Vida { get; set; } = 100;
        public List<string> Construcciones { get; } = new List<string>();

        public override string ToString() =>
            Nombre + ": posición " + Posicion + ", vida " + Vida + ", torretas " + Construcciones.Count;
    }

    public interface IComando
    {
        string Descripcion { get; }
        void Ejecutar();
        void Deshacer();
    }

    public class MoverComando : IComando
    {
        private readonly Unidad _u;
        public MoverComando(Unidad u) { _u = u; }

        public string Descripcion => _u.Nombre + " se mueve";
        public void Ejecutar() => _u.Posicion++;
        public void Deshacer() => _u.Posicion--;
    }

    public class AtacarComando : IComando
    {
        private readonly Unidad _objetivo;
        public AtacarComando(Unidad objetivo) { _objetivo = objetivo; }

        public string Descripcion => "Ataque a " + _objetivo.Nombre + " (-20)";
        public void Ejecutar() => _objetivo.Vida -= 20;
        public void Deshacer() => _objetivo.Vida += 20;
    }

    public class CurarComando : IComando
    {
        private readonly Unidad _u;
        public CurarComando(Unidad u) { _u = u; }

        public string Descripcion => _u.Nombre + " se cura (+15)";
        public void Ejecutar() => _u.Vida += 15;
        public void Deshacer() => _u.Vida -= 15;
    }

    public class ConstruirComando : IComando
    {
        private readonly Unidad _u;
        public ConstruirComando(Unidad u) { _u = u; }

        public string Descripcion => _u.Nombre + " construye una torreta";
        public void Ejecutar() => _u.Construcciones.Add("Torreta");
        public void Deshacer() => _u.Construcciones.RemoveAt(_u.Construcciones.Count - 1);
    }
}
