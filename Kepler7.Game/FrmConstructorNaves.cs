using System;
using System.Windows.Forms;
using Kepler7.Core.Builder;

namespace Kepler7.Game
{
    //Builder
    public partial class FrmConstructorNaves : Form
    {
        private readonly IngenieroJefe _ingeniero = new IngenieroJefe();   
        private readonly INaveBuilder _builder = new NaveBuilder();         

        public FrmConstructorNaves()
        {
            InitializeComponent();
            cmbReceta.SelectedIndex = 0;
        }

        private void btnConstruir_Click(object sender, EventArgs e)
        {
            Nave nave;
            switch (cmbReceta.SelectedIndex)
            {
                case 0: nave = _ingeniero.RecetaExploradora(_builder); break;
                case 1: nave = _ingeniero.RecetaCombate(_builder); break;
                default: nave = _ingeniero.RecetaCarga(_builder); break;
            }

            lstComponentes.Items.Clear();
            lstComponentes.Items.Add("Nave " + cmbReceta.Text);
            Agregar("Casco", nave.Casco);
            Agregar("Motor", nave.Motor);
            Agregar("Escudo", nave.Escudo);
            Agregar("Armas", nave.Armas);
            Agregar("Radar", nave.Radar);
            Agregar("Inteligencia artificial", nave.InteligenciaArtificial);
            Agregar("Tanque de combustible", nave.TanqueCombustible);

            Sesion.Dominar(this, "Builder");
        }

        private void Agregar(string componente, string valor)
        {
            lstComponentes.Items.Add("  " + componente + ": " + (valor == "-" ? "No instalado" : valor));
        }

        private void FrmConstructorNaves_Load(object sender, EventArgs e)
        {

        }
    }
}
