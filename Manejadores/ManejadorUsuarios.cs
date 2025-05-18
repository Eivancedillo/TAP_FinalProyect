using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoDatos;
using System.Windows.Forms;
using System.Drawing;

namespace Manejadores
{
    public class ManejadorUsuarios
    {
        Base b = new Base("localhost", "root", "lirroy", "db_TAPFinalProyect");

        public void Guardar(Usuarios usuario)
        {
            b.Comando($"insert into usuarios values(null, '{usuario.Nombre}', '{ManejadorLogin.Sha1(usuario.Clave)}')");
        }

        public void Borrar(Usuarios usuario)
        {
            var rs = MessageBox.Show($"¿Estás seguro de eliminar {usuario.Nombre}?",
                "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rs == DialogResult.Yes)
            {
                b.Comando($"delete from usuarios where idu = {usuario.Id}");
            }
        }

        public void Editar(Usuarios usuario, bool estado)
        {
            if (estado)
            {
                b.Comando($"update usuarios set nombre = '{usuario.Nombre}', clave = '{ManejadorLogin.Sha1(usuario.Clave)}' where idu = {usuario.Id}");
            }
            else
            {
                b.Comando($"update usuarios set nombre = '{usuario.Nombre}' where idu = {usuario.Id}");
            }
        }


        public void Mostrar(string query, DataGridView tabla, string datos)
        {
            tabla.Columns.Clear();
            tabla.DataSource = b.Consultar(query, datos).Tables[0];
            tabla.Columns["idu"].Visible = false;
            tabla.Columns["clave"].Visible = false;

            tabla.Columns.Insert(2, ManejadorMecanico.Boton("Editar", Color.Green));
            tabla.Columns.Insert(3, ManejadorMecanico.Boton("Eliminar", Color.Red));

            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }
    }
}
