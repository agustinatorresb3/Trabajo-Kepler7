using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kepler7.Core.Facade
{
    internal class Energia {
        public string Encender() => "Reactor principal en Linea";
        public string Apagar() => "Reactor en modo reposo o apagado";
    }
    internal class SoporteVital {
        public string Activar() => "Soporte vital estabilizado";
        public string Minimizar() => "Soporte vital en minimos";

    }
    internal class Navegacion {
        public string Calibrar() => "Navegacion  calibrada y orientada";
    }
    internal class Comunicaciones {
        public string Abrir() => "Canal con tierra abierto";
        public string Cerrar() => "Canal con tierra cerrado";

    }
    internal class Seguridad {
        public string Rondar() => "Protocolos de seguridad activos";
    }
    internal class Defensa {
        public string ArmarEscudos() => "Escudos de defensa armados y activos";
        public string BajarEscudos() => "Escudos desactivados";
    }
}
