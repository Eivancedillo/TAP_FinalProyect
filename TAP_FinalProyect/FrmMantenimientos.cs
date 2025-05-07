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
    public partial class FrmMantenimientos : Form
    {
        ManejadorMantenimientos Mm;
        public static Mantenimientos mantenimientos = new Mantenimientos(0, 0, 0, "", "");
        int fila = 0, columna = 0;
        public FrmMantenimientos()
        {
            InitializeComponent();
            Mm = new ManejadorMantenimientos();

            CmbEstado.Items.Add("Pendiente");
            CmbEstado.Items.Add("Finalizado");
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            mantenimientos.IdMantenimiento = 0;
            mantenimientos.FkIdMaquina = 0;
            mantenimientos.FkIdMecanico = 0;
            mantenimientos.Fecha = "";
            mantenimientos.Descipcion = "";

            FrmDatosMantenimientos frm = new FrmDatosMantenimientos();
            frm.ShowDialog();
        }

        private void BtnExcel_Click(object sender, EventArgs e)
        {
            // verificar si esta vacio el datagridview
            if (DtgDatos.Rows.Count == 0)
                MessageBox.Show("No hay datos para exportar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                Mm.GenerarExcel(DtgDatos);
        }

        private void DtgDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Llenar datos
            mantenimientos.IdMantenimiento = int.Parse(DtgDatos.Rows[fila].Cells["idmantenimiento"].Value.ToString());
            mantenimientos.FkIdMaquina = int.Parse(DtgDatos.Rows[fila].Cells["idmaquina"].Value.ToString());
            mantenimientos.FkIdMecanico = int.Parse(DtgDatos.Rows[fila].Cells["idmecanico"].Value.ToString());
            mantenimientos.Fecha = DtgDatos.Rows[fila].Cells["Fecha"].Value.ToString();
            mantenimientos.Descipcion = DtgDatos.Rows[fila].Cells["Descripcion"].Value.ToString();

            switch (columna)
            {
                case 8:
                    {
                        if(DtgDatos.Rows[fila].Cells["Estado"].Value.ToString() == "Pendiente")
                        {
                            FrmDetallesMantenimientos frm = new FrmDetallesMantenimientos(mantenimientos.IdMantenimiento);
                            frm.ShowDialog();
                            DtgDatos.Columns.Clear();
                        }
                        else
                        {
                            FrmDetallesMantenimientos frm = new FrmDetallesMantenimientos(mantenimientos.IdMantenimiento, false);
                            frm.ShowDialog();
                            DtgDatos.Columns.Clear();
                        }
                    }
                    ; break;
                case 9:
                    {
                        FrmDatosMantenimientos Frm = new FrmDatosMantenimientos();
                        Frm.ShowDialog();
                        DtgDatos.Columns.Clear();
                    }
                    ; break;
                case 10:
                    {
                        Mm.Borrar(mantenimientos);
                        DtgDatos.Columns.Clear();
                    }
                    ; break;
                case 11:
                    {
                        Mm.EditarEstado(new Mantenimientos(mantenimientos.IdMantenimiento,0,0,"","", "Finalizado"));
                    }
                    ; break;
            }
        }

        private void DtgDatos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex; columna = e.ColumnIndex;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (CmbEstado.Text == "")
                MessageBox.Show("Seleccione un estado para el filtro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if(CmbEstado.Text == "Pendiente")
                    Mm.Mostrar($"select * from v_mantenimientos where Mecanico like '%{TxtBuscar.Text}%' and estado = 'Pendiente'", DtgDatos, "v_mantenimientos");
                else
                    Mm.Mostrar2($"select * from v_mantenimientos where Mecanico like '%{TxtBuscar.Text}%' and estado = 'Finalizado'", DtgDatos, "v_mantenimientos");
            }
        }
    }
}
