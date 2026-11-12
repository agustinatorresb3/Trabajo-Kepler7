using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Kepler7.Core.Flyweight;
using Kepler7.Core.Prototype;

namespace Kepler7.Game
{
    // Prototype 
    public partial class FrmLaboratorio : Form
    {
        private readonly PrototipoTripulante _original = new PrototipoTripulante
        {
            Nombre = "Dra. Ríos",
            Habilidades = { "Medicina", "Genética" }
        };
        private PrototipoTripulante _clon;

        public FrmLaboratorio()
        {
            InitializeComponent();
            Mostrar();
        }

        private void btnClonar_Click(object sender, EventArgs e)
        {
            _clon = (PrototipoTripulante)_original.Clonar();
            _clon.Nombre += " (clon)";
            Mostrar();
        }

        private void btnAgregarHabilidad_Click(object sender, EventArgs e)
        {
            if (_clon == null)
            {
                lblPrueba.Text = "Primero clona al tripulante";
                return;
            }
            if (txtHabilidad.Text.Trim() == "") return;

            _clon.Habilidades.Add(txtHabilidad.Text);
            Mostrar();

            lblPrueba.Text = "Se modifico el clon y el original no cambio: la copia es independiente";
            Sesion.Dominar(this, "Prototype");
        }

        private void Mostrar()
        {
            Llenar(lstOriginal, "ORIGINAL", _original);
            Llenar(lstClon, "CLON", _clon);
        }

        private static void Llenar(ListBox lista, string titulo, PrototipoTripulante t)
        {
            lista.Items.Clear();
            lista.Items.Add(titulo);
            if (t == null) return;
            lista.Items.Add("Nombre: " + t.Nombre);
            lista.Items.Add("Habilidades: " + string.Join(", ", t.Habilidades));
        }

        //flyweight
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Especie.InstanciasCreadas = 0;
            List<Tripulante> tripulacion = GeneradorTripulacion.Generar(10000, new FabricaEspecies());
            int con = Especie.InstanciasCreadas;

            Especie.InstanciasCreadas = 0;
            GeneradorTripulacion.Generar(10000, null);
            int sin = Especie.InstanciasCreadas;

            lblContador.Text = "10.000 tripulantes: " + con + " objetos Especie (sin Flyweight: " + sin.ToString("N0") + ")";

            lstTripulantes.Items.Clear();
            for (int i = 0; i < 10; i++)
            {
                Tripulante t = tripulacion[i];
                lstTripulantes.Items.Add("#" + t.Id + " " + t.Nombre + " | " + t.Rango + " | " + t.Especie.Nombre +
                                         " (" + t.Especie.Color + ", " + t.Especie.PlanetaOrigen + ", " + t.Especie.Dieta + ")");
            }
            lstTripulantes.Items.Add("Memoria aprox.: con Flyweight " + con * 48 + " bytes | sin Flyweight " + (sin * 48).ToString("N0") + " bytes");

            Sesion.Dominar(this, "Flyweight");
        }

        private void lblSubtitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
