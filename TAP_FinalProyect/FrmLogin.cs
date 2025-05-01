using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manejadores;
namespace TAP_FinalProyect
{
    public partial class FrmLogin : Form
    {
        ManejadorLogin ml;
        int contador = 0;
        public FrmLogin()
        {
            InitializeComponent();
            ml = new ManejadorLogin();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (ml.Validar(TxtUsuario, TxtClave))
            {
                MessageBox.Show("Bienvenido al sistema", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //idusuario = ml.ObtenerIdUsuario(TxtUsuario);
                FrmMenu frm = new FrmMenu();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o clave incorrecta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                contador++;

                if (contador >= 3)
                {
                    MessageBox.Show("Ha superado el número de intentos permitidos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtUsuario.Enabled = false;
                    TxtClave.Enabled = false;

                    Thread.Sleep(3000); // dormir hilo principal
                    MessageBox.Show("Ahora puede continuar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtUsuario.Enabled = true;
                    TxtClave.Enabled = true;

                    contador = 0;
                }
            }
        }
    }
}
