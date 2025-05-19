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
    public partial class FrmUsuarios : Form
    {
        ManejadorUsuarios Mu;
        public static Usuarios usuario = new Usuarios(0, "", "");
        int fila = 0, columna = 0;

        public FrmUsuarios()
        {
            InitializeComponent();
            Mu = new ManejadorUsuarios();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Mu.Mostrar($"select * from usuarios where nombre like '%{TxtBuscar.Text}%'", DtgDatos, "usuarios");
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            usuario.Id = 0;
            usuario.Nombre = "";
            usuario.Clave = "";

            FrmDatosUsuarios frmDatosUsuarios = new FrmDatosUsuarios();
            frmDatosUsuarios.ShowDialog();

            DtgDatos.Columns.Clear();
        }

        private void DtgDatos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex; columna = e.ColumnIndex;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DtgDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Llenar datos

            usuario.Id = int.Parse(DtgDatos.Rows[fila].Cells["idu"].Value.ToString());
            usuario.Nombre = DtgDatos.Rows[fila].Cells["nombre"].Value.ToString();
            usuario.Clave = DtgDatos.Rows[fila].Cells["clave"].Value.ToString();

            switch (columna)
            {
                case 2:
                    {
                        FrmDatosUsuarios frmDatosUsuarios = new FrmDatosUsuarios();
                        frmDatosUsuarios.ShowDialog();
                        DtgDatos.Columns.Clear();
                    }
                    ; break;
                case 3:
                    {
                        Mu.Borrar(usuario);
                        DtgDatos.Columns.Clear();
                    }
                    ; break;
            }
        }
    }
}
