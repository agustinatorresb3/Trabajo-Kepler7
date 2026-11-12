using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Kepler7.Core.Bridge;
using Kepler7.Core.Proxy;

namespace Kepler7.Game
{
    // Bridge + Proxy
    public partial class FrmComunicaciones : Form
    {
        private readonly ICifrado[] _cifrados = { new SinCifrado(), new CifradoAES(), new CifradoCuantico() };
        private readonly HashSet<string> _combinaciones = new HashSet<string>();
        private readonly ProxyBoveda _boveda = new ProxyBoveda();
        private bool _permitido, _denegado;

        public FrmComunicaciones()
        {
            InitializeComponent();
            cmbTipo.SelectedIndex = 0;
            cmbCifrado.SelectedIndex = 0;
            cmbRol.SelectedIndex = 0;
            cmbArchivo.SelectedIndex = 0;
            MostrarRegistro();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {

            ICifrado cifrado = _cifrados[cmbCifrado.SelectedIndex];
            Mensaje mensaje;
            switch (cmbTipo.SelectedIndex)
            {
                case 0: mensaje = new MensajeTexto(cifrado); break;
                case 1: mensaje = new MensajeAlerta(cifrado); break;
                default: mensaje = new MensajeEmergencia(cifrado); break;
            }

            lstEnviados.Items.Add(cmbTipo.Text + " + " + cmbCifrado.Text + "  ->  " + mensaje.Enviar(txtMensaje.Text));

            _combinaciones.Add(cmbTipo.Text + cmbCifrado.Text);
            if (_combinaciones.Count >= 3)
                Sesion.Dominar(this, "Bridge");
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            _boveda.RolUsuario = (Rol)cmbRol.SelectedIndex;
            Mostrar(_boveda.LeerArchivo(cmbArchivo.Text));
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            _boveda.RolUsuario = (Rol)cmbRol.SelectedIndex;
            Mostrar(_boveda.EscribirArchivo(cmbArchivo.Text, "Modificado por " + cmbRol.Text));
        }

        private void Mostrar(string resultado)
        {
            bool denegado = resultado.StartsWith("ACCESO DENEGADO");
            lblResultado.Text = resultado;
            lblResultado.ForeColor = denegado ? Color.FromArgb(255, 46, 136) : Color.FromArgb(57, 255, 20);
            if (denegado) _denegado = true; else _permitido = true;

            MostrarRegistro();
            if (_permitido && _denegado)
                Sesion.Dominar(this, "Proxy");
        }

        private void FrmComunicaciones_Load(object sender, EventArgs e)
        {

        }

        private void MostrarRegistro()
        {
            lstRegistro.Items.Clear();
            lstRegistro.Items.Add("Intentos denegados:");
            lstRegistro.Items.AddRange(_boveda.ObtenerRegistro());
        }
    }
}
