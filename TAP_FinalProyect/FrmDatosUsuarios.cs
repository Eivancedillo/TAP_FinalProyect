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
    public partial class FrmDatosUsuarios : Form
    {

        ManejadorUsuarios Mu;

        public FrmDatosUsuarios()
        {
            InitializeComponent();
            Mu = new ManejadorUsuarios();

            if (FrmUsuarios.usuario.Id > 0)
            {
                TxtNombre.Text = FrmUsuarios.usuario.Nombre;
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (FrmUsuarios.usuario.Id == 0)
            {
                Mu.Guardar(new Usuarios(0, TxtNombre.Text, TxtClave.Text));
            }

            else
            {
                if (TxtClave.Text.Equals(""))
                {
                    Mu.Editar(new Usuarios(FrmUsuarios.usuario.Id, TxtNombre.Text, TxtClave.Text), false);
                }
                else
                {
                    Mu.Editar(new Usuarios(FrmUsuarios.usuario.Id, TxtNombre.Text, TxtClave.Text), true);
                }
            }

            Close();
        }
    }
}
