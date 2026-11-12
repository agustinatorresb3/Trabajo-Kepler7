namespace Kepler7.Game
{
    partial class FrmBatalla
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
            this.grpChain = new System.Windows.Forms.GroupBox();
            this.lstCadena = new System.Windows.Forms.ListBox();
            this.btnSubir = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblVida = new System.Windows.Forms.Label();
            this.cmbDefensa = new System.Windows.Forms.ComboBox();
            this.btnAtaque = new System.Windows.Forms.Button();
            this.lstRecorrido = new System.Windows.Forms.ListBox();
            this.grpCommand = new System.Windows.Forms.GroupBox();
            this.btnRehacer = new System.Windows.Forms.Button();
            this.btnDeshacer = new System.Windows.Forms.Button();
            this.btnMover = new System.Windows.Forms.Button();
            this.lblUnidades = new System.Windows.Forms.Label();
            this.btnCurar = new System.Windows.Forms.Button();
            this.btnConstruir = new System.Windows.Forms.Button();
            this.btnAtacar = new System.Windows.Forms.Button();
            this.lstComandos = new System.Windows.Forms.ListBox();
            this.cmbUnidad = new System.Windows.Forms.ComboBox();
            this.grpTemplate = new System.Windows.Forms.GroupBox();
            this.btnTurno = new System.Windows.Forms.Button();
            this.lstTurnos = new System.Windows.Forms.ListBox();
            this.grpChain.SuspendLayout();
            this.grpCommand.SuspendLayout();
            this.grpTemplate.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpChain
            // 
            this.grpChain.Controls.Add(this.lstCadena);
            this.grpChain.Controls.Add(this.btnSubir);
            this.grpChain.Controls.Add(this.btnQuitar);
            this.grpChain.Controls.Add(this.btnAgregar);
            this.grpChain.Controls.Add(this.lblVida);
            this.grpChain.Controls.Add(this.cmbDefensa);
            this.grpChain.Controls.Add(this.btnAtaque);
            this.grpChain.Controls.Add(this.lstRecorrido);
            this.grpChain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grpChain.Location = new System.Drawing.Point(16, 359);
            this.grpChain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpChain.Name = "grpChain";
            this.grpChain.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpChain.Size = new System.Drawing.Size(1128, 341);
            this.grpChain.TabIndex = 12;
            this.grpChain.TabStop = false;
            this.grpChain.Text = "Chain of Responsibility – Defensas";
            // 
            // lstCadena
            // 
            this.lstCadena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.lstCadena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstCadena.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCadena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.lstCadena.FormattingEnabled = true;
            this.lstCadena.ItemHeight = 18;
            this.lstCadena.Location = new System.Drawing.Point(16, 25);
            this.lstCadena.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstCadena.Name = "lstCadena";
            this.lstCadena.Size = new System.Drawing.Size(265, 182);
            this.lstCadena.TabIndex = 13;
            // 
            // btnSubir
            // 
            this.btnSubir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.btnSubir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnSubir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.btnSubir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnSubir.Location = new System.Drawing.Point(16, 234);
            this.btnSubir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSubir.Name = "btnSubir";
            this.btnSubir.Size = new System.Drawing.Size(267, 37);
            this.btnSubir.TabIndex = 12;
            this.btnSubir.Text = "Subir";
            this.btnSubir.UseVisualStyleBackColor = false;
            this.btnSubir.Click += new System.EventHandler(this.btnSubir_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.btnQuitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnQuitar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnQuitar.Location = new System.Drawing.Point(291, 234);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(267, 37);
            this.btnQuitar.TabIndex = 11;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnAgregar.Location = new System.Drawing.Point(291, 278);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(267, 37);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblVida
            // 
            this.lblVida.AutoSize = true;
            this.lblVida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.lblVida.Location = new System.Drawing.Point(562, 30);
            this.lblVida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVida.Name = "lblVida";
            this.lblVida.Size = new System.Drawing.Size(44, 16);
            this.lblVida.TabIndex = 9;
            this.lblVida.Text = "label1";
            // 
            // cmbDefensa
            // 
            this.cmbDefensa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.cmbDefensa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDefensa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDefensa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.cmbDefensa.FormattingEnabled = true;
            this.cmbDefensa.Items.AddRange(new object[] {
            "Esquiva ",
            "Bloqueo ",
            "Armadura",
            "Escudo "});
            this.cmbDefensa.Location = new System.Drawing.Point(16, 278);
            this.cmbDefensa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbDefensa.Name = "cmbDefensa";
            this.cmbDefensa.Size = new System.Drawing.Size(265, 24);
            this.cmbDefensa.TabIndex = 6;
            // 
            // btnAtaque
            // 
            this.btnAtaque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.btnAtaque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtaque.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnAtaque.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.btnAtaque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtaque.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnAtaque.Location = new System.Drawing.Point(291, 25);
            this.btnAtaque.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAtaque.Name = "btnAtaque";
            this.btnAtaque.Size = new System.Drawing.Size(267, 37);
            this.btnAtaque.TabIndex = 4;
            this.btnAtaque.Text = "Recibir ataque";
            this.btnAtaque.UseVisualStyleBackColor = false;
            this.btnAtaque.Click += new System.EventHandler(this.btnAtaque_Click);
            // 
            // lstRecorrido
            // 
            this.lstRecorrido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.lstRecorrido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstRecorrido.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstRecorrido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.lstRecorrido.FormattingEnabled = true;
            this.lstRecorrido.ItemHeight = 18;
            this.lstRecorrido.Location = new System.Drawing.Point(291, 74);
            this.lstRecorrido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstRecorrido.Name = "lstRecorrido";
            this.lstRecorrido.Size = new System.Drawing.Size(822, 146);
            this.lstRecorrido.TabIndex = 0;
            // 
            // grpCommand
            // 
            this.grpCommand.Controls.Add(this.btnRehacer);
            this.grpCommand.Controls.Add(this.btnDeshacer);
            this.grpCommand.Controls.Add(this.btnMover);
            this.grpCommand.Controls.Add(this.lblUnidades);
            this.grpCommand.Controls.Add(this.btnCurar);
            this.grpCommand.Controls.Add(this.btnConstruir);
            this.grpCommand.Controls.Add(this.btnAtacar);
            this.grpCommand.Controls.Add(this.lstComandos);
            this.grpCommand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grpCommand.Location = new System.Drawing.Point(16, 14);
            this.grpCommand.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpCommand.Name = "grpCommand";
            this.grpCommand.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpCommand.Size = new System.Drawing.Size(1128, 338);
            this.grpCommand.TabIndex = 11;
            this.grpCommand.TabStop = false;
            this.grpCommand.Text = "Command – Acciones";
            this.grpCommand.Enter += new System.EventHandler(this.grpCommand_Enter);
            // 
            // btnRehacer
            // 
            this.btnRehacer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.btnRehacer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRehacer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnRehacer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.btnRehacer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRehacer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnRehacer.Location = new System.Drawing.Point(565, 124);
            this.btnRehacer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRehacer.Name = "btnRehacer";
            this.btnRehacer.Size = new System.Drawing.Size(541, 37);
            this.btnRehacer.TabIndex = 12;
            this.btnRehacer.Text = "Rehacer";
            this.btnRehacer.UseVisualStyleBackColor = false;
            this.btnRehacer.Click += new System.EventHandler(this.btnRehacer_Click);
            // 
            // btnDeshacer
            // 
            this.btnDeshacer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.btnDeshacer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeshacer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnDeshacer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.btnDeshacer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeshacer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnDeshacer.Location = new System.Drawing.Point(16, 124);
            this.btnDeshacer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeshacer.Name = "btnDeshacer";
            this.btnDeshacer.Size = new System.Drawing.Size(541, 37);
            this.btnDeshacer.TabIndex = 11;
            this.btnDeshacer.Text = "Deshacer";
            this.btnDeshacer.UseVisualStyleBackColor = false;
            this.btnDeshacer.Click += new System.EventHandler(this.btnDeshacer_Click);
            // 
            // btnMover
            // 
            this.btnMover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.btnMover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMover.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnMover.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.btnMover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMover.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnMover.Location = new System.Drawing.Point(16, 80);
            this.btnMover.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMover.Name = "btnMover";
            this.btnMover.Size = new System.Drawing.Size(267, 37);
            this.btnMover.TabIndex = 9;
            this.btnMover.Text = "Mover";
            this.btnMover.UseVisualStyleBackColor = false;
            this.btnMover.Click += new System.EventHandler(this.btnMover_Click);
            // 
            // lblUnidades
            // 
            this.lblUnidades.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUnidades.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.lblUnidades.Location = new System.Drawing.Point(16, 30);
            this.lblUnidades.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnidades.Name = "lblUnidades";
            this.lblUnidades.Size = new System.Drawing.Size(1090, 45);
            this.lblUnidades.TabIndex = 8;
            this.lblUnidades.Text = "label1";
            this.lblUnidades.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCurar
            // 
            this.btnCurar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.btnCurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCurar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnCurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.btnCurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnCurar.Location = new System.Drawing.Point(565, 80);
            this.btnCurar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCurar.Name = "btnCurar";
            this.btnCurar.Size = new System.Drawing.Size(267, 37);
            this.btnCurar.TabIndex = 10;
            this.btnCurar.Text = "Curar";
            this.btnCurar.UseVisualStyleBackColor = false;
            this.btnCurar.Click += new System.EventHandler(this.btnCurar_Click);
            // 
            // btnConstruir
            // 
            this.btnConstruir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.btnConstruir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConstruir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnConstruir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.btnConstruir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConstruir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnConstruir.Location = new System.Drawing.Point(840, 80);
            this.btnConstruir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConstruir.Name = "btnConstruir";
            this.btnConstruir.Size = new System.Drawing.Size(267, 37);
            this.btnConstruir.TabIndex = 10;
            this.btnConstruir.Text = "Construir";
            this.btnConstruir.UseVisualStyleBackColor = false;
            this.btnConstruir.Click += new System.EventHandler(this.btnConstruir_Click);
            // 
            // btnAtacar
            // 
            this.btnAtacar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.btnAtacar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtacar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnAtacar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.btnAtacar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtacar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnAtacar.Location = new System.Drawing.Point(291, 80);
            this.btnAtacar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAtacar.Name = "btnAtacar";
            this.btnAtacar.Size = new System.Drawing.Size(267, 37);
            this.btnAtacar.TabIndex = 2;
            this.btnAtacar.Text = "Atacar";
            this.btnAtacar.UseVisualStyleBackColor = false;
            this.btnAtacar.Click += new System.EventHandler(this.btnAtacar_Click);
            // 
            // lstComandos
            // 
            this.lstComandos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.lstComandos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstComandos.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstComandos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.lstComandos.FormattingEnabled = true;
            this.lstComandos.ItemHeight = 18;
            this.lstComandos.Location = new System.Drawing.Point(16, 178);
            this.lstComandos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstComandos.Name = "lstComandos";
            this.lstComandos.Size = new System.Drawing.Size(1089, 128);
            this.lstComandos.TabIndex = 0;
            // 
            // cmbUnidad
            // 
            this.cmbUnidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.cmbUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbUnidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.cmbUnidad.FormattingEnabled = true;
            this.cmbUnidad.Items.AddRange(new object[] {
            "Soldado",
            "Médico ",
            "Francotirador ",
            "Comandante "});
            this.cmbUnidad.Location = new System.Drawing.Point(16, 30);
            this.cmbUnidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbUnidad.Name = "cmbUnidad";
            this.cmbUnidad.Size = new System.Drawing.Size(223, 24);
            this.cmbUnidad.TabIndex = 3;
            // 
            // grpTemplate
            // 
            this.grpTemplate.Controls.Add(this.btnTurno);
            this.grpTemplate.Controls.Add(this.cmbUnidad);
            this.grpTemplate.Controls.Add(this.lstTurnos);
            this.grpTemplate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grpTemplate.Location = new System.Drawing.Point(1152, 14);
            this.grpTemplate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpTemplate.Name = "grpTemplate";
            this.grpTemplate.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpTemplate.Size = new System.Drawing.Size(498, 686);
            this.grpTemplate.TabIndex = 13;
            this.grpTemplate.TabStop = false;
            this.grpTemplate.Text = "Template Method – Turnos";
            // 
            // btnTurno
            // 
            this.btnTurno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.btnTurno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTurno.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnTurno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.btnTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTurno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnTurno.Location = new System.Drawing.Point(247, 30);
            this.btnTurno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTurno.Name = "btnTurno";
            this.btnTurno.Size = new System.Drawing.Size(233, 37);
            this.btnTurno.TabIndex = 9;
            this.btnTurno.Text = "Jugar turno";
            this.btnTurno.UseVisualStyleBackColor = false;
            this.btnTurno.Click += new System.EventHandler(this.btnTurno_Click);
            // 
            // lstTurnos
            // 
            this.lstTurnos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.lstTurnos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstTurnos.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTurnos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.lstTurnos.FormattingEnabled = true;
            this.lstTurnos.ItemHeight = 18;
            this.lstTurnos.Location = new System.Drawing.Point(16, 82);
            this.lstTurnos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstTurnos.Name = "lstTurnos";
            this.lstTurnos.Size = new System.Drawing.Size(464, 578);
            this.lstTurnos.TabIndex = 0;
            // 
            // FrmBatalla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1659, 715);
            this.Controls.Add(this.grpTemplate);
            this.Controls.Add(this.grpChain);
            this.Controls.Add(this.grpCommand);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmBatalla";
            this.Text = "FormBatlla";
            this.Load += new System.EventHandler(this.FrmBatalla_Load);
            this.grpChain.ResumeLayout(false);
            this.grpChain.PerformLayout();
            this.grpCommand.ResumeLayout(false);
            this.grpTemplate.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpChain;
        private System.Windows.Forms.Label lblVida;
        private System.Windows.Forms.ComboBox cmbDefensa;
        private System.Windows.Forms.Button btnAtaque;
        private System.Windows.Forms.ListBox lstRecorrido;
        private System.Windows.Forms.GroupBox grpCommand;
        private System.Windows.Forms.Button btnCurar;
        private System.Windows.Forms.Button btnConstruir;
        private System.Windows.Forms.Button btnMover;
        private System.Windows.Forms.Label lblUnidades;
        private System.Windows.Forms.ComboBox cmbUnidad;
        private System.Windows.Forms.Button btnAtacar;
        private System.Windows.Forms.ListBox lstComandos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSubir;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnRehacer;
        private System.Windows.Forms.Button btnDeshacer;
        private System.Windows.Forms.ListBox lstCadena;
        private System.Windows.Forms.GroupBox grpTemplate;
        private System.Windows.Forms.Button btnTurno;
        private System.Windows.Forms.ListBox lstTurnos;
    }
}