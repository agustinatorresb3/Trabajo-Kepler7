using System.Collections.Generic;

namespace Kepler7.Core.Command
{
    public class GestorComandos
    {
        private readonly Stack<IComando> _deshacer = new Stack<IComando>();
        private readonly Stack<IComando> _rehacer = new Stack<IComando>();

        public List<string> Historial { get; } = new List<string>();
        public bool PuedeDeshacer => _deshacer.Count > 0;
        public bool PuedeRehacer => _rehacer.Count > 0;

        public void Ejecutar(IComando c)
        {
            c.Ejecutar();
            _deshacer.Push(c);
            _rehacer.Clear();
            Historial.Add("Ejecutar: " + c.Descripcion);
        }

        public void Deshacer()
        {
            IComando c = _deshacer.Pop();
            c.Deshacer();
            _rehacer.Push(c);
            Historial.Add("Deshacer: " + c.Descripcion);
        }

        public void Rehacer()
        {
            IComando c = _rehacer.Pop();
            c.Ejecutar();
            _deshacer.Push(c);
            Historial.Add("Rehacer: " + c.Descripcion);
        }
    }
}
