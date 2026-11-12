using System;
using System.Drawing;
using System.Windows.Forms;
using Kepler7.Core.Juego;

namespace Kepler7.Game
{
   
    public partial class FrmMenuPrincipal : Form
    {
        private static readonly string[] Areas =
            { "Control central", "Hangar", "Combate", "Laboratorio", "Comunicaciones", "Personaje", "Batalla" };

        private static readonly string[][] PatronesPorArea =
        {
            new[] { "Facade" }, new[] { "Builder" }, new[] { "Strategy" },
            new[] { "Prototype", "Flyweight" }, new[] { "Bridge", "Proxy" },
            new[] { "State", "Visitor" }, new[] { "Command", "Template Method", "Chain of Responsibility" }
        };

        public FrmMenuPrincipal()
        {
            InitializeComponent();
            ActualizarProgreso();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            if (!Sesion.Progreso.TutorialVisto)
                btnTutorial_Click(this, EventArgs.Empty);
        }

        private void btnRecorrido_Click(object sender, EventArgs e)
        {
            if (Sesion.Progreso.Terminada)
            {
                Abrir(new FrmResumen());
                return;
            }

            Hide();
            for (int i = PrimeraAreaPendiente(); i < Areas.Length; i++)
            {
                using (Form area = CrearArea(i))
                {
                    AgregarBotonSiguiente(area, i);
                    DialogResult resultado = area.ShowDialog(this);
                    ActualizarProgreso();

                    if (Sesion.Progreso.Terminada)  
                    {
                        Abrir(new FrmResumen());
                        break;
                    }
                    if (resultado != DialogResult.OK)   
                        break;
                }
            }
            Show();
        }

        private void btnTutorial_Click(object sender, EventArgs e)
        {
            Abrir(new FrmTutorial());
        }

        private void btnLogros_Click(object sender, EventArgs e)
        {
            Abrir(new FrmResumen());
        }

        private void btnNuevaPartida_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Se borrara el progreso actual. ¿Continuar?", "Nueva partida",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Sesion.NuevaPartida();
                ActualizarProgreso();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private Form CrearArea(int i)
        {
            switch (i)
            {
                case 0: return new FrmControlCentral();    // Facade
                case 1: return new FrmConstructorNaves();  // Builder
                case 2: return new FrmSimuladorIA();       // Strategy
                case 3: return new FrmLaboratorio();       // Prototype + Flyweight
                case 4: return new FrmComunicaciones();    // Bridge + Proxy
                case 5: return new FrmPersonaje();         // State + Visitor
                default: return new FrmBatalla();          // Command + Template Method + Chain
            }
        }

        private void AgregarBotonSiguiente(Form area, int i)
        {
            area.ClientSize = new Size(area.ClientSize.Width, area.ClientSize.Height + 50);
            var siguiente = new Button
            {
                Text = i < Areas.Length - 1 ? "Siguiente: " + Areas[i + 1] + " >" : "Finalizar",
                Size = new Size(220, 32),
                Location = new Point(area.ClientSize.Width - 236, area.ClientSize.Height - 42),
                DialogResult = DialogResult.OK,
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(18, 26, 46),
                ForeColor = Color.FromArgb(255, 46, 136)
            };
            area.Controls.Add(siguiente);
        }

        private int PrimeraAreaPendiente()
        {
            for (int i = 0; i < Areas.Length; i++)
                foreach (string patron in PatronesPorArea[i])
                    if (!Sesion.Progreso.PatronesDominados.Contains(patron))
                        return i;
            return 0;
        }

        private void Abrir(Form f)
        {
            using (f) f.ShowDialog(this);
            ActualizarProgreso();
        }

        private void ActualizarProgreso()
        {
            Progreso p = Sesion.Progreso;
            lblProgreso.Text = "Nivel " + p.Nivel + "  |  " + p.XP + " XP  |  Patrones dominados: " +
                               p.PatronesDominados.Count + " de " + Progreso.Patrones.Length;
            btnRecorrido.Text = p.PatronesDominados.Count == 0 ? "Iniciar recorrido" : "Continuar recorrido";
            lblEstado.Text = "7 áreas. El recorrido sigue desde la primera área sin terminar.";
        }

        private void lblIntegrantes_Click(object sender, EventArgs e)
        {

        }
    }
}
