using System.Collections.Generic;

namespace Kepler7.Core.TemplateMethod
{
    public abstract class TurnoUnidad
    {
        public List<string> Historial { get; } = new List<string>();

        public void EjecutarTurno()
        {
            Historial.Clear();
            Historial.Add("1. Inicio: " + Iniciar());
            Historial.Add("2. Decisión: " + Decidir());
            Historial.Add("3. Acción: " + Actuar());
            Historial.Add("4. Fin: " + Finalizar());
        }

        protected virtual string Iniciar() => GetType().Name + " se prepara.";  
        protected abstract string Decidir();
        protected abstract string Actuar();
        protected virtual string Finalizar() => "termina el turno.";  
    }
}
