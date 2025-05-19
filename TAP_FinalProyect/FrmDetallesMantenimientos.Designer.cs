namespace TAP_FinalProyect
{
    partial class FrmDetallesMantenimientos
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
            this.DtgDatosDisponibles = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAñadir = new System.Windows.Forms.Button();
            this.TxtPieza = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DtgDatosUsadas = new System.Windows.Forms.DataGridView();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.DtgMecanicos = new System.Windows.Forms.DataGridView();
            this.DtgMecanicosUso = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatosDisponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatosUsadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgMecanicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgMecanicosUso)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgDatosDisponibles
            // 
            this.DtgDatosDisponibles.AllowUserToAddRows = false;
            this.DtgDatosDisponibles.BackgroundColor = System.Drawing.SystemColors.Info;
            this.DtgDatosDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgDatosDisponibles.Location = new System.Drawing.Point(12, 37);
            this.DtgDatosDisponibles.Name = "DtgDatosDisponibles";
            this.DtgDatosDisponibles.ReadOnly = true;
            this.DtgDatosDisponibles.RowHeadersWidth = 51;
            this.DtgDatosDisponibles.RowTemplate.Height = 24;
            this.DtgDatosDisponibles.Size = new System.Drawing.Size(531, 242);
            this.DtgDatosDisponibles.TabIndex = 25;
            this.DtgDatosDisponibles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgDatosDisponibles_CellClick);
            this.DtgDatosDisponibles.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgDatosDisponibles_CellEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Piezas disponibles";
            // 
            // BtnAñadir
            // 
            this.BtnAñadir.Enabled = false;
            this.BtnAñadir.Location = new System.Drawing.Point(559, 243);
            this.BtnAñadir.Name = "BtnAñadir";
            this.BtnAñadir.Size = new System.Drawing.Size(87, 36);
            this.BtnAñadir.TabIndex = 27;
            this.BtnAñadir.Text = "Añadir";
            this.BtnAñadir.UseVisualStyleBackColor = true;
            this.BtnAñadir.Click += new System.EventHandler(this.BtnAñadir_Click);
            // 
            // TxtPieza
            // 
            this.TxtPieza.Enabled = false;
            this.TxtPieza.Location = new System.Drawing.Point(552, 61);
            this.TxtPieza.Name = "TxtPieza";
            this.TxtPieza.Size = new System.Drawing.Size(100, 26);
            this.TxtPieza.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(572, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Pieza";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(570, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Costo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(557, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Cantidad";
            // 
            // txtCosto
            // 
            this.txtCosto.Enabled = false;
            this.txtCosto.Location = new System.Drawing.Point(552, 129);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(100, 26);
            this.txtCosto.TabIndex = 32;
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Enabled = false;
            this.TxtCantidad.Location = new System.Drawing.Point(552, 197);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(100, 26);
            this.TxtCantidad.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(971, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "Piezas usadas";
            // 
            // DtgDatosUsadas
            // 
            this.DtgDatosUsadas.AllowUserToAddRows = false;
            this.DtgDatosUsadas.BackgroundColor = System.Drawing.SystemColors.Info;
            this.DtgDatosUsadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgDatosUsadas.Location = new System.Drawing.Point(658, 37);
            this.DtgDatosUsadas.Name = "DtgDatosUsadas";
            this.DtgDatosUsadas.ReadOnly = true;
            this.DtgDatosUsadas.RowHeadersWidth = 51;
            this.DtgDatosUsadas.RowTemplate.Height = 24;
            this.DtgDatosUsadas.Size = new System.Drawing.Size(531, 246);
            this.DtgDatosUsadas.TabIndex = 34;
            this.DtgDatosUsadas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgDatosUsadas_CellClick);
            this.DtgDatosUsadas.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgDatosUsadas_CellEnter);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Red;
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(945, 494);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(166, 49);
            this.BtnCancelar.TabIndex = 37;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.Lime;
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.Location = new System.Drawing.Point(739, 494);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(166, 49);
            this.BtnGuardar.TabIndex = 36;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 38;
            this.label6.Text = "Mecanicos";
            // 
            // DtgMecanicos
            // 
            this.DtgMecanicos.AllowUserToAddRows = false;
            this.DtgMecanicos.BackgroundColor = System.Drawing.SystemColors.Info;
            this.DtgMecanicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgMecanicos.Location = new System.Drawing.Point(12, 321);
            this.DtgMecanicos.Name = "DtgMecanicos";
            this.DtgMecanicos.ReadOnly = true;
            this.DtgMecanicos.RowHeadersWidth = 51;
            this.DtgMecanicos.RowTemplate.Height = 24;
            this.DtgMecanicos.Size = new System.Drawing.Size(531, 161);
            this.DtgMecanicos.TabIndex = 39;
            this.DtgMecanicos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgMecanicos_CellClick);
            this.DtgMecanicos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgMecanicos_CellEnter);
            // 
            // DtgMecanicosUso
            // 
            this.DtgMecanicosUso.AllowUserToAddRows = false;
            this.DtgMecanicosUso.BackgroundColor = System.Drawing.SystemColors.Info;
            this.DtgMecanicosUso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgMecanicosUso.Location = new System.Drawing.Point(658, 321);
            this.DtgMecanicosUso.Name = "DtgMecanicosUso";
            this.DtgMecanicosUso.ReadOnly = true;
            this.DtgMecanicosUso.RowHeadersWidth = 51;
            this.DtgMecanicosUso.RowTemplate.Height = 24;
            this.DtgMecanicosUso.Size = new System.Drawing.Size(531, 161);
            this.DtgMecanicosUso.TabIndex = 40;
            this.DtgMecanicosUso.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgMecanicosUso_CellClick);
            this.DtgMecanicosUso.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgMecanicosUso_CellEnter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(845, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(216, 20);
            this.label7.TabIndex = 41;
            this.label7.Text = "Mecanicos en mantenimiento";
            // 
            // FrmDetallesMantenimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1201, 555);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DtgMecanicosUso);
            this.Controls.Add(this.DtgMecanicos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DtgDatosUsadas);
            this.Controls.Add(this.TxtCantidad);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtPieza);
            this.Controls.Add(this.BtnAñadir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DtgDatosDisponibles);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmDetallesMantenimientos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDetallesMantenimientos";
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatosDisponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatosUsadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgMecanicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgMecanicosUso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgDatosDisponibles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAñadir;
        private System.Windows.Forms.TextBox TxtPieza;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView DtgDatosUsadas;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView DtgMecanicos;
        private System.Windows.Forms.DataGridView DtgMecanicosUso;
        private System.Windows.Forms.Label label7;
    }
}