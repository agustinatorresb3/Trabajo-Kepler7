using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Kepler7.Core.State;
using Kepler7.Core.Visitor;

namespace Kepler7.Game
{
    //State + Visitor
    public partial class FrmPersonaje : Form
    {
        private Personaje _personaje = new Personaje();
        private readonly HashSet<string> _estadosVistos = new HashSet<string>();
        private readonly Inventario _inventario = new Inventario();
        private readonly HashSet<int> _visitantesUsados = new HashSet<int>();

        public FrmPersonaje()
        {
            InitializeComponent();
            cmbEstado.SelectedIndex = 0;
            cmbVisitante.SelectedIndex = 0;
            lblVisitor.Text = "Elegí un visitante y aplicalo al inventario.";
            ActualizarEstado();
            MostrarItems();
        }
        private void btnAtacar_Click(object sender, EventArgs e)
        {
            Registrar(_personaje.Atacar());
        }

        private void btnMover_Click(object sender, EventArgs e)
        {
            Registrar(_personaje.Mover());
        }

        private void btnRecibirDanio_Click(object sender, EventArgs e)
        {
            Registrar(_personaje.RecibirDanio(10));
        }


        private void btnCambiarEstado_Click(object sender, EventArgs e)
        {
            switch (cmbEstado.SelectedIndex)
            {
                case 0: _personaje.Estado = new Normal(); break;
                case 1: _personaje.Estado = new Envenenado(); break;
                case 2: _personaje.Estado = new Aturdido(); break;
                default: _personaje.Estado = new Berserk(); break;
            }
            Registrar("Nuevo estado: " + cmbEstado.Text);
        }

        private void Registrar(string texto)
        {
            lstAcciones.Items.Add(texto);
            if (_personaje.Vida <= 0)
            {
                lstAcciones.Items.Add("El personaje cayó. Se reinicia.");
                _personaje = new Personaje();
            }
            ActualizarEstado();
        }

        private void ActualizarEstado()
        {
            string estado = _personaje.Estado.GetType().Name;
            lblEstado.Text = Icono(estado) + "  Estado: " + estado + "   |   Vida: " + _personaje.Vida + "   |   Posicion: " + _personaje.Posicion;
            lblEstado.BackColor = ColorDe(estado);
            lblEstado.ForeColor = estado == "Aturdido" ? Color.Black : Color.White;
            lblEstado.Font = new Font(lblEstado.Font, FontStyle.Bold);
            btnAtacar.Enabled = btnMover.Enabled = _personaje.Estado.PuedeActuar;

            _estadosVistos.Add(estado);
            if (_estadosVistos.Count == 4)
                Sesion.Dominar(this, "State");
        }

        private static Color ColorDe(string estado)
        {
            switch (estado)
            {
                case "Envenenado": return Color.FromArgb(120, 60, 170);  // violeta
                case "Aturdido": return Color.FromArgb(240, 190, 40);    // amarillo
                case "Berserk": return Color.FromArgb(200, 40, 40);      // rojo
                default: return Color.FromArgb(40, 150, 70);             // verde (Normal)
            }
        }

        private static string Icono(string estado)
        {
            switch (estado)
            {
                case "Envenenado": return "\u2620";   // calavera
                case "Aturdido": return "\u2735";     // estrella (mareado)
                case "Berserk": return "\u2694";      // espadas
                default: return "\u2714";             // tilde
            }
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            IVisitor visitante;
            switch (cmbVisitante.SelectedIndex)
            {
                case 0: visitante = new CalculadorPrecio(); break;
                case 1: visitante = new ContadorArmas(); break;
                default: visitante = new AplicadorVeneno(); break;
            }

            lblVisitor.Text = _inventario.Aplicar(visitante);
            MostrarItems();

            _visitantesUsados.Add(cmbVisitante.SelectedIndex);
            if (_visitantesUsados.Count == 3)
                Sesion.Dominar(this, "Visitor");
        }

        private void MostrarItems()
        {
            lstItems.Items.Clear();
            foreach (IItem item in _inventario.Items)
                lstItems.Items.Add(item);
        }

        private void FrmPersonaje_Load(object sender, EventArgs e)
        {

        }
    }
}
