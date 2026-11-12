namespace Kepler7.Game
{
    partial class FrmComunicaciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpBridge = new System.Windows.Forms.GroupBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.cmbCifrado = new System.Windows.Forms.ComboBox();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lstEnviados = new System.Windows.Forms.ListBox();
            this.grpProxy = new System.Windows.Forms.GroupBox();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.cmbArchivo = new System.Windows.Forms.ComboBox();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnEscribir = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lstRegistro = new System.Windows.Forms.ListBox();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grpBridge.SuspendLayout();
            this.grpProxy.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBridge
            // 
            this.grpBridge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grpBridge.Controls.Add(this.cmbTipo);
            this.grpBridge.Controls.Add(this.cmbCifrado);
            this.grpBridge.Controls.Add(this.txtMensaje);
            this.grpBridge.Controls.Add(this.btnEnviar);
            this.grpBridge.Controls.Add(this.lstEnviados);
            this.grpBridge.Location = new System.Drawing.Point(16, 75);
            this.grpBridge.Name = "grpBridge";
            this.grpBridge.Size = new System.Drawing.Size(748, 190);
            this.grpBridge.TabIndex = 1;
            this.grpBridge.TabStop = false;
            this.grpBridge.Text = "Bridge – Mensajes a la Tierra";
            // 
            // cmbTipo
            // 
            this.cmbTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.cmbTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.Items.AddRange(new object[] {
            "Texto",
            "Alerta",
            "Emergencia"});
            this.cmbTipo.Location = new System.Drawing.Point(12, 28);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(150, 36);
            this.cmbTipo.TabIndex = 0;
            // 
            // cmbCifrado
            // 
            this.cmbCifrado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.cmbCifrado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCifrado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.cmbCifrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCifrado.Items.AddRange(new object[] {
            "Sin cifrado",
            "AES",
            "Cuántico"});
            this.cmbCifrado.Location = new System.Drawing.Point(172, 28);
            this.cmbCifrado.Name = "cmbCifrado";
            this.cmbCifrado.Size = new System.Drawing.Size(150, 36);
            this.cmbCifrado.TabIndex = 1;
            // 
            // txtMensaje
            // 
            this.txtMensaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.txtMensaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMensaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.txtMensaje.Location = new System.Drawing.Point(332, 28);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(270, 33);
            this.txtMensaje.TabIndex = 2;
            this.txtMensaje.Text = "Solicitamos suministros";
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnEnviar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnEnviar.Location = new System.Drawing.Point(612, 26);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(124, 28);
            this.btnEnviar.TabIndex = 3;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lstEnviados
            // 
            this.lstEnviados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.lstEnviados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstEnviados.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstEnviados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.lstEnviados.HorizontalScrollbar = true;
            this.lstEnviados.ItemHeight = 28;
            this.lstEnviados.Location = new System.Drawing.Point(12, 65);
            this.lstEnviados.Name = "lstEnviados";
            this.lstEnviados.Size = new System.Drawing.Size(724, 88);
            this.lstEnviados.TabIndex = 4;
            // 
            // grpProxy
            // 
            this.grpProxy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grpProxy.Controls.Add(this.cmbRol);
            this.grpProxy.Controls.Add(this.cmbArchivo);
            this.grpProxy.Controls.Add(this.btnLeer);
            this.grpProxy.Controls.Add(this.btnEscribir);
            this.grpProxy.Controls.Add(this.lblResultado);
            this.grpProxy.Controls.Add(this.lstRegistro);
            this.grpProxy.Location = new System.Drawing.Point(16, 275);
            this.grpProxy.Name = "grpProxy";
            this.grpProxy.Size = new System.Drawing.Size(748, 210);
            this.grpProxy.TabIndex = 0;
            this.grpProxy.TabStop = false;
            this.grpProxy.Text = "Proxy – Bóveda de datos";
            // 
            // cmbRol
            // 
            this.cmbRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.cmbRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRol.Items.AddRange(new object[] {
            "Capitán",
            "Oficial de Seguridad",
            "Ingeniero",
            "Tripulante"});
            this.cmbRol.Location = new System.Drawing.Point(12, 28);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(170, 36);
            this.cmbRol.TabIndex = 0;
            // 
            // cmbArchivo
            // 
            this.cmbArchivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.cmbArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbArchivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.cmbArchivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArchivo.Items.AddRange(new object[] {
            "A-01",
            "A-02",
            "A-03"});
            this.cmbArchivo.Location = new System.Drawing.Point(192, 28);
            this.cmbArchivo.Name = "cmbArchivo";
            this.cmbArchivo.Size = new System.Drawing.Size(90, 36);
            this.cmbArchivo.TabIndex = 1;
            // 
            // btnLeer
            // 
            this.btnLeer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.btnLeer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLeer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnLeer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.btnLeer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnLeer.Location = new System.Drawing.Point(292, 26);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(100, 28);
            this.btnLeer.TabIndex = 2;
            this.btnLeer.Text = "Leer";
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnEscribir
            // 
            this.btnEscribir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.btnEscribir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEscribir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnEscribir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.btnEscribir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEscribir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnEscribir.Location = new System.Drawing.Point(402, 26);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(100, 28);
            this.btnEscribir.TabIndex = 3;
            this.btnEscribir.Text = "Escribir";
            this.btnEscribir.Click += new System.EventHandler(this.btnEscribir_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(12, 62);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(724, 22);
            this.lblResultado.TabIndex = 4;
            // 
            // lstRegistro
            // 
            this.lstRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.lstRegistro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstRegistro.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstRegistro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.lstRegistro.ItemHeight = 28;
            this.lstRegistro.Location = new System.Drawing.Point(12, 90);
            this.lstRegistro.Name = "lstRegistro";
            this.lstRegistro.Size = new System.Drawing.Size(724, 88);
            this.lstRegistro.TabIndex = 5;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(140)))), ((int)(((byte)(170)))));
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Location = new System.Drawing.Point(18, 44);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(693, 28);
            this.lblSubtitulo.TabIndex = 2;
            this.lblSubtitulo.Text = "Bridge: mensajes con cualquier cifrado  ·  Proxy: acceso controlado a la bóveda";
            // 
            // lblTitulo
            // 
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(16, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(229, 38);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Comunicaciones";
            // 
            // FrmComunicaciones
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 500);
            this.Controls.Add(this.grpProxy);
            this.Controls.Add(this.grpBridge);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmComunicaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Comunicaciones";
            this.Load += new System.EventHandler(this.FrmComunicaciones_Load);
            this.grpBridge.ResumeLayout(false);
            this.grpBridge.PerformLayout();
            this.grpProxy.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpBridge;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.ComboBox cmbCifrado;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.ListBox lstEnviados;
        private System.Windows.Forms.GroupBox grpProxy;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.ComboBox cmbArchivo;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnEscribir;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.ListBox lstRegistro;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblTitulo;
    }
}
