using System;
using System.Windows.Forms;

namespace Kepler7.Game
{
 
    public partial class FrmTutorial : Form
    {
        private readonly string[] _titulos = { "1. La crisis de Kepler-7", "2. Cómo se juega", "3. Victoria y derrota" };
        private readonly string[] _textos =
        {
            "La Estación Orbital Kepler-7 está en crisis: sus subsistemas fallaron.\n\n" +
            "El Consejo de Ingeniería te convocó para recuperarlos uno por uno.",

            "La estación tiene 7 áreas y en cada una se usan uno o más patrones de diseño.\n\n" +
            "Avanzá con el botón \"Siguiente\" y usá las mecánicas de cada área. " +
            "Cada patrón dominado da +100 XP y una insignia. Cada 300 XP subís de nivel.\n" +
            "El progreso se guarda solo.",

            "VICTORIA: dominar los 12 patrones.\n\n" +
            "DERROTA: perder el combate contra el dron o que la Vida de la estación llegue a 0 en la Batalla final."
        };
        private int _pagina;

        public FrmTutorial()
        {
            InitializeComponent();
            Mostrar();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            _pagina--;
            Mostrar();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (_pagina == 2)
            {
                Sesion.Progreso.TutorialVisto = true;
                Sesion.Guardar();
                Close();
                return;
            }
            _pagina++;
            Mostrar();
        }

        private void Mostrar()
        {
            lblTitulo.Text = _titulos[_pagina];
            lblTexto.Text = _textos[_pagina];
            lblPagina.Text = "Pantalla " + (_pagina + 1) + " de 3";
            btnAnterior.Enabled = _pagina > 0;
            btnSiguiente.Text = _pagina == 2 ? "Comenzar" : "Siguiente";
        }

        private void lblTexto_Click(object sender, EventArgs e)
        {

        }
    }
}
