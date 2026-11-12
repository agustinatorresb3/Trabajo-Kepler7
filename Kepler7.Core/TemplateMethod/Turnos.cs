namespace Kepler7.Core.TemplateMethod
{
    public class TurnoSoldado : TurnoUnidad
    {
        protected override string Decidir() => "elige al enemigo más cercano.";
        protected override string Actuar() => "dispara su rifle (15 de daño).";
    }

    public class TurnoMedico : TurnoUnidad
    {
        protected override string Decidir() => "busca al aliado más herido.";
        protected override string Actuar() => "lo cura 20 puntos.";
    }

    public class TurnoFrancotirador : TurnoUnidad
    {
        protected override string Iniciar() => "el francotirador se camufla.";
        protected override string Decidir() => "apunta al objetivo más lejano.";
        protected override string Actuar() => "disparo de precisión (40 de daño).";
    }

    public class TurnoComandante : TurnoUnidad
    {
        protected override string Decidir() => "evalúa el campo de batalla.";
        protected override string Actuar() => "ordena un ataque coordinado.";
        protected override string Finalizar() => "sube +5 la moral del equipo.";
    }
}
