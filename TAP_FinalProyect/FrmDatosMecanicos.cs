using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manejadores;
using Entidades;
namespace TAP_FinalProyect
{
    public partial class FrmDatosMecanicos : Form
    {
        ManejadorMecanico Mm;
        public FrmDatosMecanicos()
        {
            InitializeComponent();
            Mm = new ManejadorMecanico();

            if (FrmMecanicos.mecanicos.IdMecanico > 0)
            {
                TxtNombre.Text = FrmMecanicos.mecanicos.Nombre;
                TxtApellidos.Text = FrmMecanicos.mecanicos.Apellidos;
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (FrmMecanicos.mecanicos.IdMecanico == 0)
            {
                Mm.Guardar(new Mecanicos(0, TxtNombre.Text, TxtApellidos.Text));
            }
            else
            {
                Mm.Editar(new Mecanicos(FrmMecanicos.mecanicos.IdMecanico, TxtNombre.Text, TxtApellidos.Text));
            }
            Close();
        }
    }
}
