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
    public partial class FrmMecanicos : Form
    {
        ManejadorMecanico Mm;
        int fila = 0, columna = 0;
        public static Mecanicos mecanicos = new Mecanicos(0, "", "");
        public FrmMecanicos()
        {
            InitializeComponent();
            Mm = new ManejadorMecanico();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Mm.Mostrar($"select * from tbl_mecanicos where nombre like '%{TxtBuscar.Text}%'", DtgDatos, "tbl_mecanicos");
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

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            mecanicos.IdMecanico = 0;
            mecanicos.Nombre = "";
            mecanicos.Apellidos = "";

            FrmDatosMecanicos frm = new FrmDatosMecanicos();
            frm.ShowDialog();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DtgDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Llenar datos
            mecanicos.IdMecanico = int.Parse(DtgDatos.Rows[fila].Cells["idmecanico"].Value.ToString());
            mecanicos.Nombre = DtgDatos.Rows[fila].Cells["nombre"].Value.ToString();
            mecanicos.Apellidos = DtgDatos.Rows[fila].Cells["apellidos"].Value.ToString();

            switch (columna)
            {
                case 3:
                    {
                        FrmDatosMecanicos Frm = new FrmDatosMecanicos();
                        Frm.ShowDialog();
                        DtgDatos.Columns.Clear();
                    }
                    ; break;
                case 4:
                    {
                        Mm.Borrar(mecanicos);
                        DtgDatos.Columns.Clear();
                    }
                    ; break;
            }
        }
    }
}
