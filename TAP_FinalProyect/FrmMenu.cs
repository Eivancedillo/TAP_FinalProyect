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
    }
}
