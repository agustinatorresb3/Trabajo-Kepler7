namespace Kepler7.Game
{
    partial class FrmLaboratorio
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
            this.grpPrototype = new System.Windows.Forms.GroupBox();
            this.lstOriginal = new System.Windows.Forms.ListBox();
            this.lstClon = new System.Windows.Forms.ListBox();
            this.btnClonar = new System.Windows.Forms.Button();
            this.txtHabilidad = new System.Windows.Forms.TextBox();
            this.btnAgregarHabilidad = new System.Windows.Forms.Button();
            this.lblPrueba = new System.Windows.Forms.Label();
            this.grpFlyweight = new System.Windows.Forms.GroupBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.lblContador = new System.Windows.Forms.Label();
            this.lstTripulantes = new System.Windows.Forms.ListBox();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grpPrototype.SuspendLayout();
            this.grpFlyweight.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPrototype
            // 
            this.grpPrototype.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grpPrototype.Controls.Add(this.lstOriginal);
            this.grpPrototype.Controls.Add(this.lstClon);
            this.grpPrototype.Controls.Add(this.btnClonar);
            this.grpPrototype.Controls.Add(this.txtHabilidad);
            this.grpPrototype.Controls.Add(this.btnAgregarHabilidad);
            this.grpPrototype.Controls.Add(this.lblPrueba);
            this.grpPrototype.Location = new System.Drawing.Point(16, 75);
            this.grpPrototype.Name = "grpPrototype";
            this.grpPrototype.Size = new System.Drawing.Size(748, 215);
            this.grpPrototype.TabIndex = 1;
            this.grpPrototype.TabStop = false;
            this.grpPrototype.Text = "Prototype – Clonación de tripulantes";
            // 
            // lstOriginal
            // 
            this.lstOriginal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.lstOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstOriginal.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstOriginal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.lstOriginal.ItemHeight = 28;
            this.lstOriginal.Location = new System.Drawing.Point(12, 25);
            this.lstOriginal.Name = "lstOriginal";
            this.lstOriginal.Size = new System.Drawing.Size(358, 88);
            this.lstOriginal.TabIndex = 0;
            // 
            // lstClon
            // 
            this.lstClon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.lstClon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstClon.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstClon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.lstClon.ItemHeight = 28;
            this.lstClon.Location = new System.Drawing.Point(378, 25);
            this.lstClon.Name = "lstClon";
            this.lstClon.Size = new System.Drawing.Size(358, 88);
            this.lstClon.TabIndex = 1;
            // 
            // btnClonar
            // 
            this.btnClonar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.btnClonar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClonar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnClonar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.btnClonar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClonar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnClonar.Location = new System.Drawing.Point(12, 145);
            this.btnClonar.Name = "btnClonar";
            this.btnClonar.Size = new System.Drawing.Size(160, 30);
            this.btnClonar.TabIndex = 2;
            this.btnClonar.Text = "Clonar";
            this.btnClonar.Click += new System.EventHandler(this.btnClonar_Click);
            // 
            // txtHabilidad
            // 
            this.txtHabilidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.txtHabilidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHabilidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.txtHabilidad.Location = new System.Drawing.Point(182, 150);
            this.txtHabilidad.Name = "txtHabilidad";
            this.txtHabilidad.Size = new System.Drawing.Size(150, 33);
            this.txtHabilidad.TabIndex = 3;
            this.txtHabilidad.Text = "Pilotaje";
            // 
            // btnAgregarHabilidad
            // 
            this.btnAgregarHabilidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.btnAgregarHabilidad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarHabilidad.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnAgregarHabilidad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.btnAgregarHabilidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarHabilidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnAgregarHabilidad.Location = new System.Drawing.Point(342, 145);
            this.btnAgregarHabilidad.Name = "btnAgregarHabilidad";
            this.btnAgregarHabilidad.Size = new System.Drawing.Size(200, 30);
            this.btnAgregarHabilidad.TabIndex = 4;
            this.btnAgregarHabilidad.Text = "Agregar habilidad al clon";
            this.btnAgregarHabilidad.Click += new System.EventHandler(this.btnAgregarHabilidad_Click);
            // 
            // lblPrueba
            // 
            this.lblPrueba.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.lblPrueba.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrueba.Location = new System.Drawing.Point(12, 182);
            this.lblPrueba.Name = "lblPrueba";
            this.lblPrueba.Size = new System.Drawing.Size(724, 25);
            this.lblPrueba.TabIndex = 5;
            // 
            // grpFlyweight
            // 
            this.grpFlyweight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grpFlyweight.Controls.Add(this.btnGenerar);
            this.grpFlyweight.Controls.Add(this.lblContador);
            this.grpFlyweight.Controls.Add(this.lstTripulantes);
            this.grpFlyweight.Location = new System.Drawing.Point(16, 300);
            this.grpFlyweight.Name = "grpFlyweight";
            this.grpFlyweight.Size = new System.Drawing.Size(748, 205);
            this.grpFlyweight.TabIndex = 0;
            this.grpFlyweight.TabStop = false;
            this.grpFlyweight.Text = "Flyweight – Tripulación";
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.btnGenerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnGenerar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnGenerar.Location = new System.Drawing.Point(12, 25);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(230, 30);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.Text = "Generar 10.000 tripulantes";
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // lblContador
            // 
            this.lblContador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.lblContador.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContador.Location = new System.Drawing.Point(252, 30);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(484, 25);
            this.lblContador.TabIndex = 1;
            // 
            // lstTripulantes
            // 
            this.lstTripulantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.lstTripulantes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstTripulantes.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTripulantes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.lstTripulantes.ItemHeight = 28;
            this.lstTripulantes.Location = new System.Drawing.Point(12, 62);
            this.lstTripulantes.Name = "lstTripulantes";
            this.lstTripulantes.Size = new System.Drawing.Size(724, 116);
            this.lstTripulantes.TabIndex = 2;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(140)))), ((int)(((byte)(170)))));
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Location = new System.Drawing.Point(18, 44);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(707, 28);
            this.lblSubtitulo.TabIndex = 2;
            this.lblSubtitulo.Text = "Prototype: clonar tripulantes  ·  Flyweight: 10.000 tripulantes con solo 5 especi" +
    "es";
            this.lblSubtitulo.Click += new System.EventHandler(this.lblSubtitulo_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(16, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(170, 38);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Laboratorio";
            // 
            // FrmLaboratorio
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 520);
            this.Controls.Add(this.grpFlyweight);
            this.Controls.Add(this.grpPrototype);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLaboratorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Laboratorio";
            this.grpPrototype.ResumeLayout(false);
            this.grpPrototype.PerformLayout();
            this.grpFlyweight.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpPrototype;
        private System.Windows.Forms.ListBox lstOriginal;
        private System.Windows.Forms.ListBox lstClon;
        private System.Windows.Forms.Button btnClonar;
        private System.Windows.Forms.TextBox txtHabilidad;
        private System.Windows.Forms.Button btnAgregarHabilidad;
        private System.Windows.Forms.Label lblPrueba;
        private System.Windows.Forms.GroupBox grpFlyweight;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.ListBox lstTripulantes;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblTitulo;
    }
}
