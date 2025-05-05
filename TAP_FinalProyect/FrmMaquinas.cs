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
    public partial class FrmMaquinas : Form
    {
        ManejadorMaquinas Mm;
        int fila = 0, columna = 0;
        public static Maquinas maquinas = new Maquinas(0, "", "");

        public FrmMaquinas()
        {
            InitializeComponent();
            Mm = new ManejadorMaquinas();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            maquinas.IdMaquina = 0;
            maquinas.Nombre = "";
            maquinas.Descripcion = "";

            FrmDatosMaquinas frm = new FrmDatosMaquinas();
            frm.ShowDialog();
        }

        private void DtgDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Llenar datos
            maquinas.IdMaquina = int.Parse(DtgDatos.Rows[fila].Cells["idmaquina"].Value.ToString());
            maquinas.Nombre = DtgDatos.Rows[fila].Cells["nombre"].Value.ToString();
            maquinas.Descripcion = DtgDatos.Rows[fila].Cells["descripcion"].Value.ToString();

            switch (columna)
            {
                case 3:
                    {
                        FrmDatosMaquinas Frm = new FrmDatosMaquinas();
                        Frm.ShowDialog();
                        DtgDatos.Columns.Clear();
                    }
                    ; break;
                case 4:
                    {
                        Mm.Borrar(maquinas);
                        DtgDatos.Columns.Clear();
                    }
                    ; break;
            }
        }

        private void DtgDatos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex; columna = e.ColumnIndex;
        }

        private void BtnExcel_Click(object sender, EventArgs e)
        {
            // verificar si esta vacio el datagridview
            if (DtgDatos.Rows.Count == 0)
                MessageBox.Show("No hay datos para exportar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                Mm.GenerarExcel(DtgDatos);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Mm.Mostrar($"select * from tbl_maquinas where nombre like '%{TxtBuscar.Text}%'", DtgDatos, "tbl_maquinas");
        }
    }
}
