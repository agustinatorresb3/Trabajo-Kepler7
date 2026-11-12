using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kepler7.Core.Facade;

namespace Kepler7.Game
{
    // Facade
    public partial class FrmControlCentral : Form
    {
        private readonly ControlCentral _controlCentral = new ControlCentral();

        public FrmControlCentral()
        {
            InitializeComponent();
            ActualizarEstado();
        }

        private async void btnIniciarTurno_Click(object sender, EventArgs e)
        {
            await Ejecutar(_controlCentral.IniciarTurno);
        }

        private async void btnEmergencia_Click(object sender, EventArgs e)
        {
            await Ejecutar(_controlCentral.EntrarEnEmergencia);
        }

        private async void btnApagar_Click(object sender, EventArgs e)
        {
            await Ejecutar(_controlCentral.ApagarEstacion);
        }

  
        private async Task Ejecutar(Func<IEnumerable<string>> operacion)
        {
            grpOperaciones.Enabled = false;
            foreach (string paso in operacion())
            {
                lstRegistro.Items.Add(paso);
                lstRegistro.TopIndex = lstRegistro.Items.Count - 1;
                await Task.Delay(300);
                if (IsDisposed) return;
            }
            lstRegistro.Items.Add("");
            grpOperaciones.Enabled = true;
            ActualizarEstado();
            Sesion.Dominar(this, "Facade");
        }


        private void ActualizarEstado()
        {
            btnIniciarTurno.Enabled = _controlCentral.PuedeIniciarTurno;
            btnEmergencia.Enabled = _controlCentral.PuedeEntrarEnEmergencia;
            btnApagar.Enabled = _controlCentral.PuedeApagar;
            btnIniciarTurno.Text = _controlCentral.EstadoActual == EstadoEstacion.Emergencia ? "Restablecer" : "Iniciar turno";

            lblEstado.Text = "Estado de la estación: " + _controlCentral.EstadoActual;
        }

        private void FrmControlCentral_Load(object sender, EventArgs e)
        {

        }
    }
}
