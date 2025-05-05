using Manejadores;
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

namespace TAP_FinalProyect
{
    public partial class FrmDatosPiezas : Form
    {
        ManejadorPiezas Mp;
        public FrmDatosPiezas()
        {
            InitializeComponent();
            Mp = new ManejadorPiezas();

            if (FrmPiezas.piezas.IdPieza > 0)
            {
                TxtNombre.Text = FrmPiezas.piezas.Nombre;
                NumUDStock.Value = FrmPiezas.piezas.Stock;
                TxtCosto.Text = FrmPiezas.piezas.Costo.ToString();
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (FrmPiezas.piezas.IdPieza == 0)
            {
                Mp.Guardar(new Piezas(0, TxtNombre.Text, int.Parse(NumUDStock.Value.ToString()), double.Parse(TxtCosto.Text)));
            }
            else
            {
                Mp.Editar(new Piezas(FrmPiezas.piezas.IdPieza, TxtNombre.Text, int.Parse(NumUDStock.Value.ToString()), double.Parse(TxtCosto.Text)));
            }
            Close();
        }
    }
}
