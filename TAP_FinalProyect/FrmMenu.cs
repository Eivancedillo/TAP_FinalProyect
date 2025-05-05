using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAP_FinalProyect
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void OptSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OptMecanicos_Click(object sender, EventArgs e)
        {
            FrmMecanicos frm = new FrmMecanicos();
            frm.ShowDialog();
        }

        private void OptMaquinas_Click(object sender, EventArgs e)
        {
            FrmMaquinas frm = new FrmMaquinas();
            frm.ShowDialog();
        }

        private void OptPiezas_Click(object sender, EventArgs e)
        {
            FrmPiezas frm = new FrmPiezas();
            frm.ShowDialog();
        }

        private void OptMantenimientos_Click(object sender, EventArgs e)
        {
            FrmMantenimientos frm = new FrmMantenimientos();
            frm.ShowDialog();
        }

        private void OptCambiarUsuario_Click(object sender, EventArgs e)
        {
            // mensaje para decirle si quiere cambiar o no
            var rs = MessageBox.Show("¿Desea cambiar de usuario?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                this.Close();
                FrmLogin frm = new FrmLogin();
                frm.ShowDialog();
            }
        }
    }
}
