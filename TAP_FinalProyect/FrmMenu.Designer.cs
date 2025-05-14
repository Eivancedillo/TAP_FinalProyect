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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.OptMecanicos = new System.Windows.Forms.ToolStripButton();
            this.OptMaquinas = new System.Windows.Forms.ToolStripButton();
            this.OptPiezas = new System.Windows.Forms.ToolStripButton();
            this.OptMantenimientos = new System.Windows.Forms.ToolStripButton();
            this.OptUsuarios = new System.Windows.Forms.ToolStripButton();
            this.OptCambiarUsuario = new System.Windows.Forms.ToolStripButton();
            this.OptSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(81)))), ((int)(((byte)(92)))));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OptMecanicos,
            this.OptMaquinas,
            this.OptPiezas,
            this.OptMantenimientos,
            this.OptUsuarios,
            this.OptCambiarUsuario,
            this.OptSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 38);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(100, 755);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(127)))), ((int)(((byte)(130)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 38);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(107)))), ((int)(((byte)(110)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(660, 35);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(127)))), ((int)(((byte)(130)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(100, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 755);
            this.panel3.TabIndex = 2;
            // 
            // OptMecanicos
            // 
            this.OptMecanicos.AutoSize = false;
            this.OptMecanicos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OptMecanicos.Image = ((System.Drawing.Image)(resources.GetObject("OptMecanicos.Image")));
            this.OptMecanicos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OptMecanicos.Name = "OptMecanicos";
            this.OptMecanicos.Size = new System.Drawing.Size(100, 100);
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
            this.OptMaquinas.Size = new System.Drawing.Size(100, 100);
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
            this.OptPiezas.Size = new System.Drawing.Size(100, 100);
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
            this.OptMantenimientos.Size = new System.Drawing.Size(100, 100);
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
            this.OptUsuarios.Size = new System.Drawing.Size(100, 100);
            this.OptUsuarios.Text = "Usuarios";
            // 
            // OptCambiarUsuario
            // 
            this.OptCambiarUsuario.AutoSize = false;
            this.OptCambiarUsuario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OptCambiarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("OptCambiarUsuario.Image")));
            this.OptCambiarUsuario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OptCambiarUsuario.Name = "OptCambiarUsuario";
            this.OptCambiarUsuario.Size = new System.Drawing.Size(100, 100);
            this.OptCambiarUsuario.Text = "Cambiar usuario";
            this.OptCambiarUsuario.Click += new System.EventHandler(this.OptCambiarUsuario_Click);
            // 
            // OptSalir
            // 
            this.OptSalir.AutoSize = false;
            this.OptSalir.BackgroundImage = global::TAP_FinalProyect.Properties.Resources.icons8_macos_cerrar_601;
            this.OptSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OptSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OptSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OptSalir.Name = "OptSalir";
            this.OptSalir.Size = new System.Drawing.Size(100, 100);
            this.OptSalir.Text = "Salir";
            this.OptSalir.Click += new System.EventHandler(this.OptSalir_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(107)))), ((int)(((byte)(110)))));
            this.ClientSize = new System.Drawing.Size(660, 793);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}