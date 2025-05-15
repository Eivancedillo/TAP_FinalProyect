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
    public partial class FrmPiezas : Form
    {
        int fila = 0, columna = 0;
        public static Piezas piezas = new Piezas(0, "", 0, 0.0);
        ManejadorPiezas Mp;
        public FrmPiezas()
        {
            InitializeComponent();
            Mp = new ManejadorPiezas();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            piezas.IdPieza = 0;
            piezas.Nombre = "";
            piezas.Stock = 0;
            piezas.Costo = 0.0;

            FrmDatosPiezas frm = new FrmDatosPiezas();
            frm.ShowDialog();
        }

        private void BtnExcel_Click(object sender, EventArgs e)
        {
            // verificar si esta vacio el datagridview
            if (DtgDatos.Rows.Count == 0)
                MessageBox.Show("No hay datos para exportar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                Mp.GenerarExcel(DtgDatos);
        }

        private void DtgDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Llenar datos
            piezas.IdPieza = int.Parse(DtgDatos.Rows[fila].Cells["idpieza"].Value.ToString());
            piezas.Nombre = DtgDatos.Rows[fila].Cells["nombre"].Value.ToString();
            piezas.Stock = int.Parse(DtgDatos.Rows[fila].Cells["stock"].Value.ToString());
            piezas.Costo = double.Parse(DtgDatos.Rows[fila].Cells["costo"].Value.ToString());

            switch (columna)
            {
                case 4:
                    {
                        FrmDatosPiezas Frm = new FrmDatosPiezas();
                        Frm.ShowDialog();
                        DtgDatos.Columns.Clear();
                    }
                    ; break;
                case 5:
                    {
                        Mp.Borrar(piezas);
                        DtgDatos.Columns.Clear();
                    }
                    ; break;
            }
        }

        private void DtgDatos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex; columna = e.ColumnIndex;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Mp.Mostrar($"select * from tbl_piezas where nombre like '%{TxtBuscar.Text}%'", DtgDatos, "tbl_piezas");
        }
    }
}
