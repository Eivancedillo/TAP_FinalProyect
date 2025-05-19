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
using System.Threading;

namespace TAP_FinalProyect
{
    public partial class FrmDatosMantenimientos : Form
    {
        ManejadorMantenimientos Mm;
        ManejadorDetallesMantenimientos Md;
        int idMantenimiento = 0;
        public FrmDatosMantenimientos()
        {
            InitializeComponent();
            Mm = new ManejadorMantenimientos();
            Md = new ManejadorDetallesMantenimientos();
            idMantenimiento = 0;

            Mm.LlenarMaquina(CmbMaquina);
            Mm.LlenarMecanico(CmbMecanico);

            if (FrmMantenimientos.mantenimientos.IdMantenimiento != 0)
            {
                CmbMaquina.SelectedValue = FrmMantenimientos.mantenimientos.FkIdMaquina;
                CmbMecanico.SelectedValue = FrmMantenimientos.mantenimientos.FkIdMecanico;
                DtpFecha.Value = DateTime.Parse(FrmMantenimientos.mantenimientos.Fecha);
                TxtDescripcion.Text = FrmMantenimientos.mantenimientos.Descipcion;
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (FrmMantenimientos.mantenimientos.IdMantenimiento == 0)
            {
                Mm.Guardar(new Mantenimientos(0, int.Parse(CmbMaquina.SelectedValue.ToString()),
                    int.Parse(CmbMecanico.SelectedValue.ToString()),
                    DtpFecha.Value.ToString("yyyy-MM-dd"), TxtDescripcion.Text));

                // Espere un poco de tiempo para que se guarde
                Thread.Sleep(100);

                idMantenimiento = Md.UltimoIdMantenimiento();

                var rs = MessageBox.Show("Desea agregar piezas al mantenimiento", "Agregar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    FrmDetallesMantenimientos frm = new FrmDetallesMantenimientos(idMantenimiento);
                    frm.ShowDialog();
                    Close();
                }
            }
            else
            {
                Mm.Editar(new Mantenimientos(FrmMantenimientos.mantenimientos.IdMantenimiento,
                    int.Parse(CmbMaquina.SelectedValue.ToString()),
                    int.Parse(CmbMecanico.SelectedValue.ToString()),
                    DtpFecha.Value.ToString("yyyy-MM-dd"), TxtDescripcion.Text));

                idMantenimiento = FrmMantenimientos.mantenimientos.IdMantenimiento;
            }
            Close();
        }
    }
}
