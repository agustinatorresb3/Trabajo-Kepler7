namespace Kepler7.Game
{
    partial class FrmControlCentral
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
            this.grpOperaciones = new System.Windows.Forms.GroupBox();
            this.btnIniciarTurno = new System.Windows.Forms.Button();
            this.btnEmergencia = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.grpRegistro = new System.Windows.Forms.GroupBox();
            this.lstRegistro = new System.Windows.Forms.ListBox();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grpOperaciones.SuspendLayout();
            this.grpRegistro.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOperaciones
            // 
            this.grpOperaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grpOperaciones.Controls.Add(this.btnIniciarTurno);
            this.grpOperaciones.Controls.Add(this.btnEmergencia);
            this.grpOperaciones.Controls.Add(this.btnApagar);
            this.grpOperaciones.Location = new System.Drawing.Point(16, 75);
            this.grpOperaciones.Name = "grpOperaciones";
            this.grpOperaciones.Size = new System.Drawing.Size(748, 65);
            this.grpOperaciones.TabIndex = 2;
            this.grpOperaciones.TabStop = false;
            this.grpOperaciones.Text = "Operaciones";
            // 
            // btnIniciarTurno
            // 
            this.btnIniciarTurno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.btnIniciarTurno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciarTurno.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnIniciarTurno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.btnIniciarTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarTurno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnIniciarTurno.Location = new System.Drawing.Point(12, 25);
            this.btnIniciarTurno.Name = "btnIniciarTurno";
            this.btnIniciarTurno.Size = new System.Drawing.Size(230, 30);
            this.btnIniciarTurno.TabIndex = 0;
            this.btnIniciarTurno.Text = "Iniciar turno";
            this.btnIniciarTurno.Click += new System.EventHandler(this.btnIniciarTurno_Click);
            // 
            // btnEmergencia
            // 
            this.btnEmergencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.btnEmergencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmergencia.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnEmergencia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.btnEmergencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmergencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnEmergencia.Location = new System.Drawing.Point(252, 25);
            this.btnEmergencia.Name = "btnEmergencia";
            this.btnEmergencia.Size = new System.Drawing.Size(230, 30);
            this.btnEmergencia.TabIndex = 1;
            this.btnEmergencia.Text = "Activar emergencia";
            this.btnEmergencia.Click += new System.EventHandler(this.btnEmergencia_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.btnApagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApagar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnApagar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnApagar.Location = new System.Drawing.Point(492, 25);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(244, 30);
            this.btnApagar.TabIndex = 2;
            this.btnApagar.Text = "Apagar estación";
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.lblEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(16, 150);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(748, 30);
            this.lblEstado.TabIndex = 1;
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpRegistro
            // 
            this.grpRegistro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grpRegistro.Controls.Add(this.lstRegistro);
            this.grpRegistro.Location = new System.Drawing.Point(16, 190);
            this.grpRegistro.Name = "grpRegistro";
            this.grpRegistro.Size = new System.Drawing.Size(748, 235);
            this.grpRegistro.TabIndex = 0;
            this.grpRegistro.TabStop = false;
            this.grpRegistro.Text = "Secuencia coordinada por la fachada";
            // 
            // lstRegistro
            // 
            this.lstRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.lstRegistro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstRegistro.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstRegistro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.lstRegistro.ItemHeight = 28;
            this.lstRegistro.Location = new System.Drawing.Point(12, 25);
            this.lstRegistro.Name = "lstRegistro";
            this.lstRegistro.Size = new System.Drawing.Size(724, 172);
            this.lstRegistro.TabIndex = 0;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(140)))), ((int)(((byte)(170)))));
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Location = new System.Drawing.Point(18, 44);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(610, 28);
            this.lblSubtitulo.TabIndex = 3;
            this.lblSubtitulo.Text = "Patrón Facade: operaciones simples que coordinan los 6 subsistemas.";
            // 
            // lblTitulo
            // 
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(16, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(213, 38);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Control central";
            // 
            // FrmControlCentral
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 440);
            this.Controls.Add(this.grpRegistro);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.grpOperaciones);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmControlCentral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Control central";
            this.Load += new System.EventHandler(this.FrmControlCentral_Load);
            this.grpOperaciones.ResumeLayout(false);
            this.grpRegistro.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpOperaciones;
        private System.Windows.Forms.Button btnIniciarTurno;
        private System.Windows.Forms.Button btnEmergencia;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.GroupBox grpRegistro;
        private System.Windows.Forms.ListBox lstRegistro;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblTitulo;
    }
}
