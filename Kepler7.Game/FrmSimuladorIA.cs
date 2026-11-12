using System;
using System.Windows.Forms;
using Kepler7.Core.Strategy;

namespace Kepler7.Game
{
    // Strategy
    public partial class FrmSimuladorIA : Form
    {
        private readonly IEstrategiaIA[] _estrategias =
            { new IAAgresiva(), new IADefensiva(), new IAAleatoria(), new IACalculadora() };
        private readonly Enemigo _enemigo;
        private Contexto _contexto;

        public FrmSimuladorIA()
        {
            InitializeComponent();
            _enemigo = new Enemigo("Dron invasor", _estrategias[0]);
            cmbEstrategia.SelectedIndex = 0;
            cmbEstrategia.SelectedIndexChanged += CambiarEstrategia;
            NuevoCombate();
        }


        private void CambiarEstrategia(object sender, EventArgs e)
        {
            _enemigo.Estrategia = _estrategias[cmbEstrategia.SelectedIndex];
            lstHistorial.Items.Add("La IA del enemigo ahora es " + _enemigo.Estrategia.Nombre + ".");
            MostrarEstado();
        }

        private void btnTurno_Click(object sender, EventArgs e)
        {
            lstHistorial.Items.Add(_contexto.JugarTurnoJugador());
            if (!_contexto.PartidaTerminada)
                lstHistorial.Items.Add(_enemigo.JugarTurno(_contexto));   
            lstHistorial.TopIndex = lstHistorial.Items.Count - 1;
            MostrarEstado();

            if (_contexto.PartidaTerminada)
            {
                btnTurno.Enabled = false;
                if (_contexto.VidaEnemigo <= 0)
                    Sesion.Dominar(this, "Strategy");
                else
                    Sesion.Perder(this, "El dron invasor te derrotó en el simulador de combate.");
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            NuevoCombate();
        }

        private void NuevoCombate()
        {
            _contexto = new Contexto(100, 100, 5);
            lstHistorial.Items.Clear();
            lstHistorial.Items.Add("Nuevo combate contra el dron. IA: " + _enemigo.Estrategia.Nombre + ".");
            btnTurno.Enabled = true;
            MostrarEstado();
        }

        private void MostrarEstado()
        {
            lblEstado.Text = "Tu vida: " + _contexto.VidaJugador + "   |   Vida del dron: " + _contexto.VidaEnemigo +
                             "   |   Distancia: " + _contexto.Distancia + "   |   IA: " + _enemigo.Estrategia.Nombre;
        }

        private void FrmSimuladorIA_Load(object sender, EventArgs e)
        {

        }
    }
}
