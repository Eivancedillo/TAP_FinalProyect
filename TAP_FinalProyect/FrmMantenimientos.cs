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
        Mantenimientos mantenimientos = new Mantenimientos(0, 0, 0, "", "");
        int fila = 0, columna = 0;
        public FrmMantenimientos()
        {
            InitializeComponent();
            Mm = new ManejadorMantenimientos();
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
            mantenimientos.FkIdMaquina = int.Parse(DtgDatos.Rows[fila].Cells["Maquina"].Value.ToString());
            mantenimientos.FkIdMecanico = int.Parse(DtgDatos.Rows[fila].Cells["Mecanico"].Value.ToString());
            mantenimientos.Fecha = DtgDatos.Rows[fila].Cells["Fecha"].Value.ToString();
            mantenimientos.Descipcion = DtgDatos.Rows[fila].Cells["Descripcion"].Value.ToString();
            switch (columna)
            {
                case 5:
                    {
                        FrmDatosMantenimientos Frm = new FrmDatosMantenimientos();
                        Frm.ShowDialog();
                        DtgDatos.Columns.Clear();
                    }
                    ; break;
                case 6:
                    {
                        Mm.Borrar(mantenimientos);
                        DtgDatos.Columns.Clear();
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
            Mm.Mostrar($"select * from v_mantenimientos where Descripcion like '%{TxtBuscar.Text}%'", DtgDatos, "v_mantenimientos");
        }
    }
}
