using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Manejadores;
namespace TAP_FinalProyect
{
    public partial class FrmDatosMaquinas : Form
    {
        ManejadorMaquinas Mm;
        public FrmDatosMaquinas()
        {
            InitializeComponent();
            Mm = new ManejadorMaquinas();

            if (FrmMaquinas.maquinas.IdMaquina > 0)
            {
                TxtNombre.Text = FrmMaquinas.maquinas.Nombre;
                TxtDescripcion.Text = FrmMaquinas.maquinas.Descripcion;
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (FrmMaquinas.maquinas.IdMaquina == 0)
            {
                Mm.Guardar(new Maquinas(0, TxtNombre.Text, TxtDescripcion.Text));
            }
            else
            {
                Mm.Editar(new Maquinas(FrmMaquinas.maquinas.IdMaquina, TxtNombre.Text, TxtDescripcion.Text));
            }
            Close();
        }
    }
}
