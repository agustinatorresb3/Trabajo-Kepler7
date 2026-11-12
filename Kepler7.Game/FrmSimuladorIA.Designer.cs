namespace Kepler7.Game
{
    partial class FrmSimuladorIA
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
            this.lblEstrategia = new System.Windows.Forms.Label();
            this.cmbEstrategia = new System.Windows.Forms.ComboBox();
            this.btnTurno = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.grpHistorial = new System.Windows.Forms.GroupBox();
            this.lstHistorial = new System.Windows.Forms.ListBox();
            this.grpHistorial.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(16, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(314, 38);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Simulador de combate";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(140)))), ((int)(((byte)(170)))));
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Location = new System.Drawing.Point(18, 44);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(541, 28);
            this.lblSubtitulo.TabIndex = 6;
            this.lblSubtitulo.Text = "Patrón Strategy: cambiá la IA del enemigo durante la partida.";
            // 
            // lblEstrategia
            // 
            this.lblEstrategia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.lblEstrategia.AutoSize = true;
            this.lblEstrategia.Location = new System.Drawing.Point(16, 76);
            this.lblEstrategia.Name = "lblEstrategia";
            this.lblEstrategia.Size = new System.Drawing.Size(144, 28);
            this.lblEstrategia.TabIndex = 5;
            this.lblEstrategia.Text = "IA del enemigo";
            // 
            // cmbEstrategia
            // 
            this.cmbEstrategia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.cmbEstrategia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEstrategia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.cmbEstrategia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstrategia.Items.AddRange(new object[] {
            "Agresiva",
            "Defensiva",
            "Aleatoria",
            "Calculadora"});
            this.cmbEstrategia.Location = new System.Drawing.Point(16, 100);
            this.cmbEstrategia.Name = "cmbEstrategia";
            this.cmbEstrategia.Size = new System.Drawing.Size(200, 36);
            this.cmbEstrategia.TabIndex = 4;
            // 
            // btnTurno
            // 
            this.btnTurno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.btnTurno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTurno.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnTurno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.btnTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTurno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnTurno.Location = new System.Drawing.Point(226, 97);
            this.btnTurno.Name = "btnTurno";
            this.btnTurno.Size = new System.Drawing.Size(150, 30);
            this.btnTurno.TabIndex = 3;
            this.btnTurno.Text = "Jugar turno";
            this.btnTurno.Click += new System.EventHandler(this.btnTurno_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.btnReiniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReiniciar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnReiniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.btnReiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReiniciar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnReiniciar.Location = new System.Drawing.Point(386, 97);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(150, 30);
            this.btnReiniciar.TabIndex = 2;
            this.btnReiniciar.Text = "Nuevo combate";
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(16, 140);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(748, 28);
            this.lblEstado.TabIndex = 1;
            // 
            // grpHistorial
            // 
            this.grpHistorial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grpHistorial.Controls.Add(this.lstHistorial);
            this.grpHistorial.Location = new System.Drawing.Point(16, 175);
            this.grpHistorial.Name = "grpHistorial";
            this.grpHistorial.Size = new System.Drawing.Size(748, 250);
            this.grpHistorial.TabIndex = 0;
            this.grpHistorial.TabStop = false;
            this.grpHistorial.Text = "Historial del combate";
            // 
            // lstHistorial
            // 
            this.lstHistorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.lstHistorial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstHistorial.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstHistorial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.lstHistorial.ItemHeight = 28;
            this.lstHistorial.Location = new System.Drawing.Point(12, 25);
            this.lstHistorial.Name = "lstHistorial";
            this.lstHistorial.Size = new System.Drawing.Size(724, 200);
            this.lstHistorial.TabIndex = 0;
            // 
            // FrmSimuladorIA
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 440);
            this.Controls.Add(this.grpHistorial);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnTurno);
            this.Controls.Add(this.cmbEstrategia);
            this.Controls.Add(this.lblEstrategia);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSimuladorIA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Simulador de combate";
            this.Load += new System.EventHandler(this.FrmSimuladorIA_Load);
            this.grpHistorial.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblEstrategia;
        private System.Windows.Forms.ComboBox cmbEstrategia;
        private System.Windows.Forms.Button btnTurno;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.GroupBox grpHistorial;
        private System.Windows.Forms.ListBox lstHistorial;
    }
}
