namespace TAP_FinalProyect
{
    partial class FrmPiezas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPiezas));
            this.BtnExcel = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.DtgDatos = new System.Windows.Forms.DataGridView();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnExcel
            // 
            this.BtnExcel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnExcel.BackgroundImage")));
            this.BtnExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnExcel.Location = new System.Drawing.Point(900, 11);
            this.BtnExcel.Name = "BtnExcel";
            this.BtnExcel.Size = new System.Drawing.Size(34, 30);
            this.BtnExcel.TabIndex = 26;
            this.BtnExcel.UseVisualStyleBackColor = true;
            this.BtnExcel.Click += new System.EventHandler(this.BtnExcel_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(860, 11);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(34, 30);
            this.BtnAgregar.TabIndex = 25;
            this.BtnAgregar.Text = "+";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // DtgDatos
            // 
            this.DtgDatos.AllowUserToAddRows = false;
            this.DtgDatos.BackgroundColor = System.Drawing.SystemColors.Info;
            this.DtgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgDatos.Location = new System.Drawing.Point(15, 47);
            this.DtgDatos.Name = "DtgDatos";
            this.DtgDatos.ReadOnly = true;
            this.DtgDatos.RowHeadersWidth = 51;
            this.DtgDatos.RowTemplate.Height = 24;
            this.DtgDatos.Size = new System.Drawing.Size(919, 310);
            this.DtgDatos.TabIndex = 24;
            this.DtgDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgDatos_CellClick);
            this.DtgDatos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgDatos_CellEnter);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(757, 11);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(97, 30);
            this.BtnBuscar.TabIndex = 23;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(97, 11);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(654, 30);
            this.TxtBuscar.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nombre";
            // 
            // FrmPiezas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 377);
            this.Controls.Add(this.BtnExcel);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.DtgDatos);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPiezas";
            this.Text = "FrmPiezas";
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnExcel;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.DataGridView DtgDatos;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label label1;
    }
}