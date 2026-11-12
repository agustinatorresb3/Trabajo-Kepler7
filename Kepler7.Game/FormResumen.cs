using System;
using System.Windows.Forms;
using Kepler7.Core.Juego;

namespace Kepler7.Game
{
    public partial class FrmResumen : Form
    {
        public FrmResumen()
        {
            InitializeComponent();
            Progreso p = Sesion.Progreso;

            lblResultado.Text = p.Victoria ? "¡Victoria! Kepler-7 está a salvo."
                              : p.Derrota ? "Derrota. Kepler-7 cayó."
                              : "Logros";

            lblDatos.Text = (p.Derrota ? "Motivo: " + p.MotivoDerrota + "\n" : "") +
                            "Nivel " + p.Nivel + "  |  " + p.XP + " XP  |  " +
                            p.PatronesDominados.Count + " de " + Progreso.Patrones.Length + " patrones\n" +
                            "Duración: " + (int)(DateTime.Now - p.Inicio).TotalMinutes + " minutos";

            foreach (string patron in Progreso.Patrones)
                lstLogros.Items.Add(p.PatronesDominados.Contains(patron) ? "★  " + patron : "     " + patron + " (bloqueado)");

            btnNuevaPartida.Enabled = p.Terminada;
        }

        private void btnNuevaPartida_Click(object sender, EventArgs e)
        {
            Sesion.NuevaPartida();
            Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblDatos_Click(object sender, EventArgs e)
        {

        }
    }
}
