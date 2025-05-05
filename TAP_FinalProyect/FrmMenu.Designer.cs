namespace TAP_FinalProyect
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.OptMecanicos = new System.Windows.Forms.ToolStripButton();
            this.OptMaquinas = new System.Windows.Forms.ToolStripButton();
            this.OptPiezas = new System.Windows.Forms.ToolStripButton();
            this.OptMantenimientos = new System.Windows.Forms.ToolStripButton();
            this.OptUsuarios = new System.Windows.Forms.ToolStripButton();
            this.OptCambiarUsuario = new System.Windows.Forms.ToolStripButton();
            this.OptSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OptMecanicos,
            this.OptMaquinas,
            this.OptPiezas,
            this.OptMantenimientos,
            this.OptUsuarios,
            this.OptCambiarUsuario,
            this.OptSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(71, 594);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // OptMecanicos
            // 
            this.OptMecanicos.AutoSize = false;
            this.OptMecanicos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OptMecanicos.Image = ((System.Drawing.Image)(resources.GetObject("OptMecanicos.Image")));
            this.OptMecanicos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OptMecanicos.Name = "OptMecanicos";
            this.OptMecanicos.Size = new System.Drawing.Size(70, 70);
            this.OptMecanicos.Text = "Mecanicos";
            this.OptMecanicos.Click += new System.EventHandler(this.OptMecanicos_Click);
            // 
            // OptMaquinas
            // 
            this.OptMaquinas.AutoSize = false;
            this.OptMaquinas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OptMaquinas.Image = ((System.Drawing.Image)(resources.GetObject("OptMaquinas.Image")));
            this.OptMaquinas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OptMaquinas.Name = "OptMaquinas";
            this.OptMaquinas.Size = new System.Drawing.Size(70, 70);
            this.OptMaquinas.Text = "Maquinas";
            this.OptMaquinas.Click += new System.EventHandler(this.OptMaquinas_Click);
            // 
            // OptPiezas
            // 
            this.OptPiezas.AutoSize = false;
            this.OptPiezas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OptPiezas.Image = ((System.Drawing.Image)(resources.GetObject("OptPiezas.Image")));
            this.OptPiezas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OptPiezas.Name = "OptPiezas";
            this.OptPiezas.Size = new System.Drawing.Size(70, 70);
            this.OptPiezas.Text = "Piezas";
            this.OptPiezas.Click += new System.EventHandler(this.OptPiezas_Click);
            // 
            // OptMantenimientos
            // 
            this.OptMantenimientos.AutoSize = false;
            this.OptMantenimientos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OptMantenimientos.Image = ((System.Drawing.Image)(resources.GetObject("OptMantenimientos.Image")));
            this.OptMantenimientos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OptMantenimientos.Name = "OptMantenimientos";
            this.OptMantenimientos.Size = new System.Drawing.Size(70, 70);
            this.OptMantenimientos.Text = "Mantenimientos";
            this.OptMantenimientos.Click += new System.EventHandler(this.OptMantenimientos_Click);
            // 
            // OptUsuarios
            // 
            this.OptUsuarios.AutoSize = false;
            this.OptUsuarios.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OptUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("OptUsuarios.Image")));
            this.OptUsuarios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OptUsuarios.Name = "OptUsuarios";
            this.OptUsuarios.Size = new System.Drawing.Size(70, 70);
            this.OptUsuarios.Text = "Usuarios";
            // 
            // OptCambiarUsuario
            // 
            this.OptCambiarUsuario.AutoSize = false;
            this.OptCambiarUsuario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OptCambiarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("OptCambiarUsuario.Image")));
            this.OptCambiarUsuario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OptCambiarUsuario.Name = "OptCambiarUsuario";
            this.OptCambiarUsuario.Size = new System.Drawing.Size(70, 70);
            this.OptCambiarUsuario.Text = "Cambiar usuario";
            this.OptCambiarUsuario.Click += new System.EventHandler(this.OptCambiarUsuario_Click);
            // 
            // OptSalir
            // 
            this.OptSalir.AutoSize = false;
            this.OptSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OptSalir.Image = ((System.Drawing.Image)(resources.GetObject("OptSalir.Image")));
            this.OptSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OptSalir.Name = "OptSalir";
            this.OptSalir.Size = new System.Drawing.Size(70, 70);
            this.OptSalir.Text = "Salir";
            this.OptSalir.Click += new System.EventHandler(this.OptSalir_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 594);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton OptMecanicos;
        private System.Windows.Forms.ToolStripButton OptMaquinas;
        private System.Windows.Forms.ToolStripButton OptPiezas;
        private System.Windows.Forms.ToolStripButton OptMantenimientos;
        private System.Windows.Forms.ToolStripButton OptUsuarios;
        private System.Windows.Forms.ToolStripButton OptCambiarUsuario;
        private System.Windows.Forms.ToolStripButton OptSalir;
    }
}