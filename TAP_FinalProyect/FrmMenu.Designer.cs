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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.OptMecanicos = new System.Windows.Forms.ToolStripButton();
            this.OptMaquinas = new System.Windows.Forms.ToolStripButton();
            this.OptPiezas = new System.Windows.Forms.ToolStripButton();
            this.OptMantenimientos = new System.Windows.Forms.ToolStripButton();
            this.OptUsuarios = new System.Windows.Forms.ToolStripButton();
            this.OptCambiarUsuario = new System.Windows.Forms.ToolStripButton();
            this.OptSalir = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
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
            this.toolStrip1.Location = new System.Drawing.Point(0, 47);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(115, 1055);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // OptMecanicos
            // 
            this.OptMecanicos.AutoSize = false;
            this.OptMecanicos.BackgroundImage = global::TAP_FinalProyect.Properties.Resources.icons8_mecánico_100;
            this.OptMecanicos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OptMecanicos.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptMecanicos.ForeColor = System.Drawing.SystemColors.Window;
            this.OptMecanicos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OptMecanicos.Name = "OptMecanicos";
            this.OptMecanicos.Size = new System.Drawing.Size(115, 115);
            this.OptMecanicos.Text = "Mecanicos";
            this.OptMecanicos.Click += new System.EventHandler(this.OptMecanicos_Click);
            // 
            // OptMaquinas
            // 
            this.OptMaquinas.AutoSize = false;
            this.OptMaquinas.BackgroundImage = global::TAP_FinalProyect.Properties.Resources.icons8_ice_maker_100;
            this.OptMaquinas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OptMaquinas.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptMaquinas.ForeColor = System.Drawing.SystemColors.Window;
            this.OptMaquinas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OptMaquinas.Name = "OptMaquinas";
            this.OptMaquinas.Size = new System.Drawing.Size(115, 115);
            this.OptMaquinas.Text = "Maquinas";
            this.OptMaquinas.Click += new System.EventHandler(this.OptMaquinas_Click);
            // 
            // OptPiezas
            // 
            this.OptPiezas.AutoSize = false;
            this.OptPiezas.BackgroundImage = global::TAP_FinalProyect.Properties.Resources.icons8_engranajes_100_gris;
            this.OptPiezas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OptPiezas.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptPiezas.ForeColor = System.Drawing.SystemColors.Window;
            this.OptPiezas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OptPiezas.Name = "OptPiezas";
            this.OptPiezas.Size = new System.Drawing.Size(115, 115);
            this.OptPiezas.Text = "Piezas";
            this.OptPiezas.Click += new System.EventHandler(this.OptPiezas_Click);
            // 
            // OptMantenimientos
            // 
            this.OptMantenimientos.AutoSize = false;
            this.OptMantenimientos.BackgroundImage = global::TAP_FinalProyect.Properties.Resources.icons8_mantenimiento_100;
            this.OptMantenimientos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.OptMantenimientos.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold);
            this.OptMantenimientos.ForeColor = System.Drawing.SystemColors.Window;
            this.OptMantenimientos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OptMantenimientos.Name = "OptMantenimientos";
            this.OptMantenimientos.Size = new System.Drawing.Size(115, 115);
            this.OptMantenimientos.Text = "Mantenimientos";
            this.OptMantenimientos.Click += new System.EventHandler(this.OptMantenimientos_Click);
            // 
            // OptUsuarios
            // 
            this.OptUsuarios.AutoSize = false;
            this.OptUsuarios.BackgroundImage = global::TAP_FinalProyect.Properties.Resources.icons8_usuario_100;
            this.OptUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OptUsuarios.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptUsuarios.ForeColor = System.Drawing.SystemColors.Window;
            this.OptUsuarios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OptUsuarios.Name = "OptUsuarios";
            this.OptUsuarios.Size = new System.Drawing.Size(115, 115);
            this.OptUsuarios.Text = "Usuarios";
            this.OptUsuarios.Click += new System.EventHandler(this.OptUsuarios_Click);
            // 
            // OptCambiarUsuario
            // 
            this.OptCambiarUsuario.AutoSize = false;
            this.OptCambiarUsuario.BackgroundImage = global::TAP_FinalProyect.Properties.Resources.icons8_cerrar_sesión_100;
            this.OptCambiarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OptCambiarUsuario.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.OptCambiarUsuario.ForeColor = System.Drawing.SystemColors.Window;
            this.OptCambiarUsuario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OptCambiarUsuario.Name = "OptCambiarUsuario";
            this.OptCambiarUsuario.Size = new System.Drawing.Size(115, 115);
            this.OptCambiarUsuario.Text = "Cerrar sesión";
            this.OptCambiarUsuario.Click += new System.EventHandler(this.OptCambiarUsuario_Click);
            // 
            // OptSalir
            // 
            this.OptSalir.AutoSize = false;
            this.OptSalir.BackgroundImage = global::TAP_FinalProyect.Properties.Resources.icons8_macos_cerrar_601;
            this.OptSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OptSalir.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptSalir.ForeColor = System.Drawing.SystemColors.Window;
            this.OptSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OptSalir.Name = "OptSalir";
            this.OptSalir.Size = new System.Drawing.Size(115, 115);
            this.OptSalir.Text = "Salir";
            this.OptSalir.Click += new System.EventHandler(this.OptSalir_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(127)))), ((int)(((byte)(130)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(880, 47);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(107)))), ((int)(((byte)(110)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(880, 43);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(127)))), ((int)(((byte)(130)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(115, 47);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(4, 1055);
            this.panel3.TabIndex = 2;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(107)))), ((int)(((byte)(110)))));
            this.ClientSize = new System.Drawing.Size(880, 1102);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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