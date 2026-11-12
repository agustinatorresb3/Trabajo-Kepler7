namespace Kepler7.Game
{
    partial class FrmResumen
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
            this.btnNuevaPartida = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lstLogros = new System.Windows.Forms.ListBox();
            this.lblDatos = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNuevaPartida
            // 
            this.btnNuevaPartida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.btnNuevaPartida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevaPartida.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnNuevaPartida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.btnNuevaPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaPartida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnNuevaPartida.Location = new System.Drawing.Point(24, 643);
            this.btnNuevaPartida.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNuevaPartida.Name = "btnNuevaPartida";
            this.btnNuevaPartida.Size = new System.Drawing.Size(360, 52);
            this.btnNuevaPartida.TabIndex = 0;
            this.btnNuevaPartida.Text = "Nueva partida";
            this.btnNuevaPartida.Click += new System.EventHandler(this.btnNuevaPartida_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnCerrar.Location = new System.Drawing.Point(396, 643);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(360, 52);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lstLogros
            // 
            this.lstLogros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.lstLogros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstLogros.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLogros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.lstLogros.FormattingEnabled = true;
            this.lstLogros.ItemHeight = 20;
            this.lstLogros.Location = new System.Drawing.Point(24, 208);
            this.lstLogros.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstLogros.Name = "lstLogros";
            this.lstLogros.Size = new System.Drawing.Size(730, 404);
            this.lstLogros.TabIndex = 2;
            // 
            // lblDatos
            // 
            this.lblDatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.lblDatos.Location = new System.Drawing.Point(27, 77);
            this.lblDatos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(726, 123);
            this.lblDatos.TabIndex = 3;
            this.lblDatos.Text = "label1";
            this.lblDatos.Click += new System.EventHandler(this.lblDatos_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(24, 22);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(58, 20);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "Logros";
            // 
            // FrmResumen
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 718);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.lstLogros);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnNuevaPartida);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmResumen";
            this.Text = "FormResumen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNuevaPartida;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ListBox lstLogros;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Label lblResultado;
    }
}