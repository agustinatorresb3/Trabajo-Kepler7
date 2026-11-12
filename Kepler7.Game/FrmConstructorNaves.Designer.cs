namespace Kepler7.Game
{
    partial class FrmConstructorNaves
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
            this.lblReceta = new System.Windows.Forms.Label();
            this.cmbReceta = new System.Windows.Forms.ComboBox();
            this.btnConstruir = new System.Windows.Forms.Button();
            this.grpNave = new System.Windows.Forms.GroupBox();
            this.lstComponentes = new System.Windows.Forms.ListBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.grpNave.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblReceta
            // 
            this.lblReceta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.lblReceta.AutoSize = true;
            this.lblReceta.Location = new System.Drawing.Point(16, 76);
            this.lblReceta.Name = "lblReceta";
            this.lblReceta.Size = new System.Drawing.Size(69, 28);
            this.lblReceta.TabIndex = 3;
            this.lblReceta.Text = "Receta";
            // 
            // cmbReceta
            // 
            this.cmbReceta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.cmbReceta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbReceta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.cmbReceta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReceta.Items.AddRange(new object[] {
            "Exploradora",
            "Combate",
            "Carga"});
            this.cmbReceta.Location = new System.Drawing.Point(16, 100);
            this.cmbReceta.Name = "cmbReceta";
            this.cmbReceta.Size = new System.Drawing.Size(220, 36);
            this.cmbReceta.TabIndex = 2;
            // 
            // btnConstruir
            // 
            this.btnConstruir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.btnConstruir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConstruir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnConstruir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.btnConstruir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConstruir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnConstruir.Location = new System.Drawing.Point(246, 97);
            this.btnConstruir.Name = "btnConstruir";
            this.btnConstruir.Size = new System.Drawing.Size(160, 30);
            this.btnConstruir.TabIndex = 1;
            this.btnConstruir.Text = "Construir nave";
            this.btnConstruir.Click += new System.EventHandler(this.btnConstruir_Click);
            // 
            // grpNave
            // 
            this.grpNave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grpNave.Controls.Add(this.lstComponentes);
            this.grpNave.Location = new System.Drawing.Point(16, 140);
            this.grpNave.Name = "grpNave";
            this.grpNave.Size = new System.Drawing.Size(748, 230);
            this.grpNave.TabIndex = 0;
            this.grpNave.TabStop = false;
            this.grpNave.Text = "Nave construida";
            // 
            // lstComponentes
            // 
            this.lstComponentes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.lstComponentes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstComponentes.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstComponentes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.lstComponentes.ItemHeight = 28;
            this.lstComponentes.Location = new System.Drawing.Point(12, 25);
            this.lstComponentes.Name = "lstComponentes";
            this.lstComponentes.Size = new System.Drawing.Size(724, 172);
            this.lstComponentes.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(16, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(113, 38);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Hangar";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(140)))), ((int)(((byte)(170)))));
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Location = new System.Drawing.Point(18, 44);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(651, 28);
            this.lblSubtitulo.TabIndex = 4;
            this.lblSubtitulo.Text = "Patrón Builder: el ingeniero jefe arma naves paso a paso según una receta.";
            // 
            // FrmConstructorNaves
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 385);
            this.Controls.Add(this.grpNave);
            this.Controls.Add(this.btnConstruir);
            this.Controls.Add(this.cmbReceta);
            this.Controls.Add(this.lblReceta);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConstructorNaves";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hangar";
            this.Load += new System.EventHandler(this.FrmConstructorNaves_Load);
            this.grpNave.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblReceta;
        private System.Windows.Forms.ComboBox cmbReceta;
        private System.Windows.Forms.Button btnConstruir;
        private System.Windows.Forms.GroupBox grpNave;
        private System.Windows.Forms.ListBox lstComponentes;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
    }
}
