namespace Kepler7.Core.Builder
{
  
    public class IngenieroJefe
    {
        public Nave RecetaExploradora(INaveBuilder b) =>
            b.Reiniciar()
             .PonerCasco("Ligero")
             .PonerMotor("Largo alcance")
             .PonerEscudo("Básico")
             .PonerRadar("Avanzado de rastreo")
             .PonerInteligenciaArtificial("Navegación autónoma")
             .PonerTanqueCombustible("Extendido")
             .Construir();

        public Nave RecetaCombate(INaveBuilder b) =>
            b.Reiniciar()
             .PonerCasco("Blindado")
             .PonerMotor("Fusión")
             .PonerEscudo("Doble blindaje")
             .PonerArmas("Láser x4")
             .PonerRadar("Táctico")
             .PonerInteligenciaArtificial("Puntería asistida")
             .Construir();

        public Nave RecetaCarga(INaveBuilder b) =>
            b.Reiniciar()
             .PonerCasco("Pesado reforzado")
             .PonerMotor("Turbo de carga")
             .PonerEscudo("Básico")
             .PonerArmas("Torre defensiva")
             .PonerRadar("Estándar")
             .PonerTanqueCombustible("Doble")
             .Construir();
    }
}
