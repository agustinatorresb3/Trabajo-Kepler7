namespace Kepler7.Game
{
    partial class FrmPersonaje
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
            this.grpVisitor = new System.Windows.Forms.GroupBox();
            this.lblVisitor = new System.Windows.Forms.Label();
            this.cmbVisitante = new System.Windows.Forms.ComboBox();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.lstItems = new System.Windows.Forms.ListBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.grpState = new System.Windows.Forms.GroupBox();
            this.btnCambiarEstado = new System.Windows.Forms.Button();
            this.btnRecibirDanio = new System.Windows.Forms.Button();
            this.btnMover = new System.Windows.Forms.Button();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.btnAtacar = new System.Windows.Forms.Button();
            this.lstAcciones = new System.Windows.Forms.ListBox();
            this.grpVisitor.SuspendLayout();
            this.grpState.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpVisitor
            // 
            this.grpVisitor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grpVisitor.Controls.Add(this.lblVisitor);
            this.grpVisitor.Controls.Add(this.cmbVisitante);
            this.grpVisitor.Controls.Add(this.btnAplicar);
            this.grpVisitor.Controls.Add(this.lstItems);
            this.grpVisitor.Location = new System.Drawing.Point(18, 371);
            this.grpVisitor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpVisitor.Name = "grpVisitor";
            this.grpVisitor.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpVisitor.Size = new System.Drawing.Size(1496, 272);
            this.grpVisitor.TabIndex = 10;
            this.grpVisitor.TabStop = false;
            this.grpVisitor.Text = "Visitor – Inventario";
            // 
            // lblVisitor
            // 
            this.lblVisitor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.lblVisitor.AutoSize = true;
            this.lblVisitor.Location = new System.Drawing.Point(591, 208);
            this.lblVisitor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVisitor.Name = "lblVisitor";
            this.lblVisitor.Size = new System.Drawing.Size(51, 20);
            this.lblVisitor.TabIndex = 9;
            this.lblVisitor.Text = "label1";
            // 
            // cmbVisitante
            // 
            this.cmbVisitante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.cmbVisitante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbVisitante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.cmbVisitante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVisitante.FormattingEnabled = true;
            this.cmbVisitante.Items.AddRange(new object[] {
            "CalculadorPrecio ",
            "ContadorArmas ",
            "AplicadorVeneno "});
            this.cmbVisitante.Location = new System.Drawing.Point(18, 203);
            this.cmbVisitante.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbVisitante.Name = "cmbVisitante";
            this.cmbVisitante.Size = new System.Drawing.Size(253, 28);
            this.cmbVisitante.TabIndex = 6;
            // 
            // btnAplicar
            // 
            this.btnAplicar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.btnAplicar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAplicar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnAplicar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.btnAplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAplicar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnAplicar.Location = new System.Drawing.Point(282, 203);
            this.btnAplicar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(300, 46);
            this.btnAplicar.TabIndex = 4;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // lstItems
            // 
            this.lstItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.lstItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstItems.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.lstItems.FormattingEnabled = true;
            this.lstItems.ItemHeight = 20;
            this.lstItems.Location = new System.Drawing.Point(18, 38);
            this.lstItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(1459, 144);
            this.lstItems.TabIndex = 0;
            // 
            // lblEstado
            // 
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.lblEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEstado.Location = new System.Drawing.Point(18, 38);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(1460, 48);
            this.lblEstado.TabIndex = 8;
            this.lblEstado.Text = "label1";
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpState
            // 
            this.grpState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grpState.Controls.Add(this.btnCambiarEstado);
            this.grpState.Controls.Add(this.btnRecibirDanio);
            this.grpState.Controls.Add(this.btnMover);
            this.grpState.Controls.Add(this.lblEstado);
            this.grpState.Controls.Add(this.cmbEstado);
            this.grpState.Controls.Add(this.btnAtacar);
            this.grpState.Controls.Add(this.lstAcciones);
            this.grpState.Location = new System.Drawing.Point(18, 18);
            this.grpState.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpState.Name = "grpState";
            this.grpState.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpState.Size = new System.Drawing.Size(1496, 343);
            this.grpState.TabIndex = 9;
            this.grpState.TabStop = false;
            this.grpState.Text = "State – Estado del personaje";
            // 
            // btnCambiarEstado
            // 
            this.btnCambiarEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.btnCambiarEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCambiarEstado.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnCambiarEstado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.btnCambiarEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnCambiarEstado.Location = new System.Drawing.Point(1179, 100);
            this.btnCambiarEstado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCambiarEstado.Name = "btnCambiarEstado";
            this.btnCambiarEstado.Size = new System.Drawing.Size(300, 46);
            this.btnCambiarEstado.TabIndex = 10;
            this.btnCambiarEstado.Text = "Cambiar estado";
            this.btnCambiarEstado.Click += new System.EventHandler(this.btnCambiarEstado_Click);
            // 
            // btnRecibirDanio
            // 
            this.btnRecibirDanio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.btnRecibirDanio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecibirDanio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnRecibirDanio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.btnRecibirDanio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecibirDanio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnRecibirDanio.Location = new System.Drawing.Point(636, 100);
            this.btnRecibirDanio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRecibirDanio.Name = "btnRecibirDanio";
            this.btnRecibirDanio.Size = new System.Drawing.Size(300, 46);
            this.btnRecibirDanio.TabIndex = 10;
            this.btnRecibirDanio.Text = "Recibir daño";
            this.btnRecibirDanio.Click += new System.EventHandler(this.btnRecibirDanio_Click);
            // 
            // btnMover
            // 
            this.btnMover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.btnMover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMover.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnMover.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.btnMover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMover.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnMover.Location = new System.Drawing.Point(327, 100);
            this.btnMover.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMover.Name = "btnMover";
            this.btnMover.Size = new System.Drawing.Size(300, 46);
            this.btnMover.TabIndex = 9;
            this.btnMover.Text = "Mover";
            this.btnMover.Click += new System.EventHandler(this.btnMover_Click);
            // 
            // cmbEstado
            // 
            this.cmbEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.cmbEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Normal ",
            "Envenenado ",
            "Aturdido ",
            "Berserk"});
            this.cmbEstado.Location = new System.Drawing.Point(945, 100);
            this.cmbEstado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(223, 28);
            this.cmbEstado.TabIndex = 3;
            // 
            // btnAtacar
            // 
            this.btnAtacar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.btnAtacar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtacar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnAtacar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.btnAtacar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtacar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnAtacar.Location = new System.Drawing.Point(18, 100);
            this.btnAtacar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAtacar.Name = "btnAtacar";
            this.btnAtacar.Size = new System.Drawing.Size(300, 46);
            this.btnAtacar.TabIndex = 2;
            this.btnAtacar.Text = "Atacar";
            this.btnAtacar.Click += new System.EventHandler(this.btnAtacar_Click);
            // 
            // lstAcciones
            // 
            this.lstAcciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.lstAcciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstAcciones.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAcciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.lstAcciones.FormattingEnabled = true;
            this.lstAcciones.ItemHeight = 20;
            this.lstAcciones.Location = new System.Drawing.Point(18, 155);
            this.lstAcciones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstAcciones.Name = "lstAcciones";
            this.lstAcciones.Size = new System.Drawing.Size(1459, 164);
            this.lstAcciones.TabIndex = 0;
            // 
            // FrmPersonaje
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1536, 663);
            this.Controls.Add(this.grpVisitor);
            this.Controls.Add(this.grpState);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPersonaje";
            this.Text = "FormPersonaje";
            this.Load += new System.EventHandler(this.FrmPersonaje_Load);
            this.grpVisitor.ResumeLayout(false);
            this.grpVisitor.PerformLayout();
            this.grpState.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpVisitor;
        private System.Windows.Forms.Label lblVisitor;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbVisitante;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.ListBox lstItems;
        private System.Windows.Forms.GroupBox grpState;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Button btnAtacar;
        private System.Windows.Forms.ListBox lstAcciones;
        private System.Windows.Forms.Button btnRecibirDanio;
        private System.Windows.Forms.Button btnMover;
        private System.Windows.Forms.Button btnCambiarEstado;
    }
}