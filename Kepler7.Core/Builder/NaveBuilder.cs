namespace Kepler7.Core.Builder
{
   
    public class NaveBuilder : INaveBuilder
    {
        private Nave _nave = new Nave();

        public INaveBuilder Reiniciar()
        {
            _nave = new Nave();
            return this;
        }

        public INaveBuilder PonerCasco(string casco)
        {
            _nave.Casco = casco;
            return this;
        }

        public INaveBuilder PonerMotor(string motor)
        {
            _nave.Motor = motor;
            return this;
        }

        public INaveBuilder PonerEscudo(string escudo)
        {
            _nave.Escudo = escudo;
            return this;
        }

        public INaveBuilder PonerArmas(string armas)
        {
            _nave.Armas = armas;
            return this;
        }

        public INaveBuilder PonerRadar(string radar)
        {
            _nave.Radar = radar;
            return this;
        }

        public INaveBuilder PonerInteligenciaArtificial(string ia)
        {
            _nave.InteligenciaArtificial = ia;
            return this;
        }

        public INaveBuilder PonerTanqueCombustible(string tanque)
        {
            _nave.TanqueCombustible = tanque;
            return this;
        }

        public Nave Construir()
        {
            Nave resultado = _nave;
            Reiniciar();
            return resultado;
        }
    }
}
