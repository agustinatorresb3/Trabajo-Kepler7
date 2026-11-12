namespace Kepler7.Core.Builder
{
 
    public interface INaveBuilder
    {
        INaveBuilder Reiniciar();
        INaveBuilder PonerCasco(string casco);
        INaveBuilder PonerMotor(string motor);
        INaveBuilder PonerEscudo(string escudo);
        INaveBuilder PonerArmas(string armas);
        INaveBuilder PonerRadar(string radar);
        INaveBuilder PonerInteligenciaArtificial(string ia);
        INaveBuilder PonerTanqueCombustible(string tanque);

        Nave Construir();
    }
}
