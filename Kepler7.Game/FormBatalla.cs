using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kepler7.Core.ChainOfResponsibility;
using Kepler7.Core.Command;
using Kepler7.Core.TemplateMethod;

namespace Kepler7.Game
{
    public partial class FrmBatalla : Form
    {
        // Command
        private readonly GestorComandos _gestor = new GestorComandos();
        private readonly Unidad _operador = new Unidad { Nombre = "Operador", Vida = 60 };
        private readonly Unidad _dron = new Unidad { Nombre = "Dron" };
        private bool _deshizo, _rehizo;

        // Template Method
        private readonly TurnoUnidad[] _unidades =
            { new TurnoSoldado(), new TurnoMedico(), new TurnoFrancotirador(), new TurnoComandante() };
        private readonly HashSet<int> _turnosJugados = new HashSet<int>();

        // Chain of Responsibility
        private readonly CadenaDefensas _cadena = new CadenaDefensas();
        private readonly Vida _vida = new Vida();
        private readonly Random _rng = new Random();
        private int _ataques;

        public FrmBatalla()
        {
            InitializeComponent();
            cmbUnidad.SelectedIndex = 0;
            cmbDefensa.SelectedIndex = 0;

            _cadena.Agregar(new Esquiva());
            _cadena.Agregar(new Bloqueo());
            _cadena.Agregar(new Armadura());
            _cadena.Agregar(new Escudo());
            _cadena.Agregar(_vida);

            ActualizarComandos();
            MostrarCadena();
        }
        private void btnMover_Click(object sender, EventArgs e)
        {
            Ejecutar(new MoverComando(_operador));
        }

        private void btnAtacar_Click(object sender, EventArgs e)
        {
            Ejecutar(new AtacarComando(_dron));
        }

        private void btnCurar_Click(object sender, EventArgs e)
        {
            Ejecutar(new CurarComando(_operador));
        }

        private void btnConstruir_Click(object sender, EventArgs e)
        {
            Ejecutar(new ConstruirComando(_operador));
        }


        private void btnDeshacer_Click(object sender, EventArgs e)
        {
            _gestor.Deshacer();
            _deshizo = true;
            ActualizarComandos();
        }

        private void btnRehacer_Click(object sender, EventArgs e)
        {
            _gestor.Rehacer();
            _rehizo = true;
            ActualizarComandos();
        }

        private void Ejecutar(IComando comando)
        {
            _gestor.Ejecutar(comando);
            ActualizarComandos();
        }

        private void ActualizarComandos()
        {
            lblUnidades.Text = _operador + "\n" + _dron;
            btnDeshacer.Enabled = _gestor.PuedeDeshacer;
            btnRehacer.Enabled = _gestor.PuedeRehacer;

            lstComandos.Items.Clear();
            foreach (string linea in _gestor.Historial)
                lstComandos.Items.Add(linea);

            if (_deshizo && _rehizo)
                Sesion.Dominar(this, "Command");
        }

        private void btnTurno_Click(object sender, EventArgs e)
        {
            int i = cmbUnidad.SelectedIndex;
            _unidades[i].EjecutarTurno();   

            lstTurnos.Items.Add("--- " + cmbUnidad.Text + " ---");
            foreach (string etapa in _unidades[i].Historial)
                lstTurnos.Items.Add(etapa);

            _turnosJugados.Add(i);
            if (_turnosJugados.Count == 4)
                Sesion.Dominar(this, "Template Method");
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            _cadena.Subir(lstCadena.SelectedIndex);
            MostrarCadena();
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (lstCadena.SelectedIndex >= 0 && _cadena.Eslabones[lstCadena.SelectedIndex] != _vida)
                _cadena.Quitar(lstCadena.SelectedIndex);
            MostrarCadena();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            switch (cmbDefensa.SelectedIndex)
            {
                case 0: _cadena.Agregar(new Esquiva()); break;
                case 1: _cadena.Agregar(new Bloqueo()); break;
                case 2: _cadena.Agregar(new Armadura()); break;
                default: _cadena.Agregar(new Escudo()); break;
            }
            MostrarCadena();
        }

        private async void btnAtaque_Click(object sender, EventArgs e)
        {
            btnAtaque.Enabled = false;
            Danio danio = _cadena.RecibirAtaque(_rng.Next(5, 41));

            foreach (string paso in danio.Recorrido)
            {
                lstRecorrido.Items.Add(paso);
                lstRecorrido.TopIndex = lstRecorrido.Items.Count - 1;
                await Task.Delay(350);
                if (IsDisposed) return;
            }

            _ataques++;
            MostrarCadena();
            btnAtaque.Enabled = true;

            if (_vida.Puntos == 0)
                Sesion.Perder(this, "La Vida de la estación llegó a 0 Kepler-7 fue destruida.");
            else if (_ataques >= 5)
                Sesion.Dominar(this, "Chain of Responsibility");
        }

        private void FrmBatalla_Load(object sender, EventArgs e)
        {

        }

        private void grpCommand_Enter(object sender, EventArgs e)
        {

        }

        private void MostrarCadena()
        {
            lstCadena.Items.Clear();
            foreach (IManejadorDanio eslabon in _cadena.Eslabones)
                lstCadena.Items.Add(eslabon.Nombre);

            lblVida.Text = "Vida: " + _vida.Puntos + "  |  Ataques resistidos: " + _ataques + "/5";
        }
    }
}
