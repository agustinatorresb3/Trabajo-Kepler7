namespace Kepler7.Game
{
    partial class FrmMenuPrincipal
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblIntegrantes = new System.Windows.Forms.Label();
            this.grpPartida = new System.Windows.Forms.GroupBox();
            this.btnRecorrido = new System.Windows.Forms.Button();
            this.btnTutorial = new System.Windows.Forms.Button();
            this.btnLogros = new System.Windows.Forms.Button();
            this.btnNuevaPartida = new System.Windows.Forms.Button();
            this.lblProgreso = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.grpPartida.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(16, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(201, 54);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "KEPLER-7";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(140)))), ((int)(((byte)(170)))));
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Location = new System.Drawing.Point(18, 54);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(404, 28);
            this.lblSubtitulo.TabIndex = 4;
            this.lblSubtitulo.Text = "Estación orbital  ·  El universo de los patrones";
            // 
            // lblIntegrantes
            // 
            this.lblIntegrantes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.lblIntegrantes.Location = new System.Drawing.Point(18, 80);
            this.lblIntegrantes.Name = "lblIntegrantes";
            this.lblIntegrantes.Size = new System.Drawing.Size(484, 40);
            this.lblIntegrantes.TabIndex = 3;
            this.lblIntegrantes.Text = "Integrantes: Agustina Torres, Ariana Campos";
            this.lblIntegrantes.Click += new System.EventHandler(this.lblIntegrantes_Click);
            // 
            // grpPartida
            // 
            this.grpPartida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grpPartida.Controls.Add(this.btnRecorrido);
            this.grpPartida.Controls.Add(this.btnTutorial);
            this.grpPartida.Controls.Add(this.btnLogros);
            this.grpPartida.Controls.Add(this.btnNuevaPartida);
            this.grpPartida.Controls.Add(this.lblProgreso);
            this.grpPartida.Location = new System.Drawing.Point(16, 125);
            this.grpPartida.Name = "grpPartida";
            this.grpPartida.Size = new System.Drawing.Size(488, 170);
            this.grpPartida.TabIndex = 2;
            this.grpPartida.TabStop = false;
            this.grpPartida.Text = "Partida";
            // 
            // btnRecorrido
            // 
            this.btnRecorrido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.btnRecorrido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecorrido.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnRecorrido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.btnRecorrido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecorrido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnRecorrido.Location = new System.Drawing.Point(12, 28);
            this.btnRecorrido.Name = "btnRecorrido";
            this.btnRecorrido.Size = new System.Drawing.Size(464, 36);
            this.btnRecorrido.TabIndex = 0;
            this.btnRecorrido.Text = "Iniciar recorrido";
            this.btnRecorrido.Click += new System.EventHandler(this.btnRecorrido_Click);
            // 
            // btnTutorial
            // 
            this.btnTutorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.btnTutorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTutorial.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnTutorial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.btnTutorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTutorial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnTutorial.Location = new System.Drawing.Point(12, 74);
            this.btnTutorial.Name = "btnTutorial";
            this.btnTutorial.Size = new System.Drawing.Size(150, 32);
            this.btnTutorial.TabIndex = 1;
            this.btnTutorial.Text = "Tutorial";
            this.btnTutorial.Click += new System.EventHandler(this.btnTutorial_Click);
            // 
            // btnLogros
            // 
            this.btnLogros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.btnLogros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogros.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnLogros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.btnLogros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnLogros.Location = new System.Drawing.Point(169, 74);
            this.btnLogros.Name = "btnLogros";
            this.btnLogros.Size = new System.Drawing.Size(150, 32);
            this.btnLogros.TabIndex = 2;
            this.btnLogros.Text = "Logros";
            this.btnLogros.Click += new System.EventHandler(this.btnLogros_Click);
            // 
            // btnNuevaPartida
            // 
            this.btnNuevaPartida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.btnNuevaPartida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevaPartida.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnNuevaPartida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.btnNuevaPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaPartida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnNuevaPartida.Location = new System.Drawing.Point(326, 74);
            this.btnNuevaPartida.Name = "btnNuevaPartida";
            this.btnNuevaPartida.Size = new System.Drawing.Size(150, 32);
            this.btnNuevaPartida.TabIndex = 3;
            this.btnNuevaPartida.Text = "Nueva partida";
            this.btnNuevaPartida.Click += new System.EventHandler(this.btnNuevaPartida_Click);
            // 
            // lblProgreso
            // 
            this.lblProgreso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.lblProgreso.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgreso.Location = new System.Drawing.Point(12, 120);
            this.lblProgreso.Name = "lblProgreso";
            this.lblProgreso.Size = new System.Drawing.Size(464, 30);
            this.lblProgreso.TabIndex = 4;
            this.lblProgreso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnSalir.Location = new System.Drawing.Point(16, 305);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(488, 32);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.lblEstado.Location = new System.Drawing.Point(16, 345);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(488, 22);
            this.lblEstado.TabIndex = 0;
            // 
            // FrmMenuPrincipal
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 380);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.grpPartida);
            this.Controls.Add(this.lblIntegrantes);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kepler-7";
            this.grpPartida.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblIntegrantes;
        private System.Windows.Forms.GroupBox grpPartida;
        private System.Windows.Forms.Button btnRecorrido;
        private System.Windows.Forms.Button btnTutorial;
        private System.Windows.Forms.Button btnLogros;
        private System.Windows.Forms.Button btnNuevaPartida;
        private System.Windows.Forms.Label lblProgreso;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblEstado;
    }
}
