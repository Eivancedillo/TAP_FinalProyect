using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;
using Entidades;

namespace Manejadores
{
    public class ManejadorDetallesMantenimientos
    {
        Base b = new Base("localhost", "root", "lirroy", "db_TAPFinalProyect");

        public void Guardar(DetallesMantenimiento detalle)
        {
            b.Comando($"call p_insertar_detallesmantenimiento({detalle.IdPieza}, {detalle.IdMantenimiento}, {detalle.Cantidad}, {detalle.Costo})", true);
        }

        public void Editar(DetallesMantenimiento detalle)
        {
            b.Comando($"call p_editar_detallesmantenimiento({detalle.IdDetalle}, {detalle.Cantidad}, {detalle.Costo})", true);
        }

        public void Borrar(DetallesMantenimiento detalle)
        {
            var rs = MessageBox.Show($"¿Está seguro de borrar la pieza?", "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                b.Comando($"delete from tbl_detallemantenimientos where iddetalle = {detalle.IdDetalle}", true);
            }
        }

        public int UltimoIdMantenimiento()
        {
            return int.Parse(b.Consultar("select id from v_ultimomantenimiento", "v_ultimomantenimiento").Tables[0].Rows[0][0].ToString());
        }

        public void ActualizarStock(int idpieza, int cantidad, bool estado)
        {
            if (estado)
                b.Comando($"call p_actualizar_stock({idpieza}, {cantidad})", true);
            else
                b.Comando($"call p_actualizar_stock({idpieza}, -{cantidad})", true);
        }

        public void TraerCosto(int idpieza, TextBox txt)
        {
            var costo = b.Consultar($"select costo from v_piezasdisponibles where idpieza = {idpieza}", "v_piezasdisponibles").Tables[0].Rows[0][0].ToString();
            txt.Text = costo;
        }

        public void MostrarDisponibles(string query, DataGridView tabla, string datos)
        {
            tabla.Columns.Clear();
            tabla.DataSource = b.Consultar(query, datos, true).Tables[0];
            tabla.Columns["idpieza"].Visible = false;
            tabla.Columns.Insert(4, ManejadorMecanico.Boton("Seleccionar", System.Drawing.Color.Green));
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }

        public void MostrarUsadas(string query, DataGridView tabla, string datos)
        {
            tabla.Columns.Clear();
            tabla.DataSource = b.Consultar(query, datos, true).Tables[0];
            tabla.Columns["idmantenimiento"].Visible = false;
            tabla.Columns["iddetalle"].Visible = false;
            tabla.Columns["idpieza"].Visible = false;
            tabla.Columns.Insert(7, ManejadorMecanico.Boton("Editar", System.Drawing.Color.Green));
            tabla.Columns.Insert(8, ManejadorMecanico.Boton("Quitar", System.Drawing.Color.Red));
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }

        public void MostrarMecanicos(string query, DataGridView tabla, string datos)
        {
            tabla.Columns.Clear();
            tabla.DataSource = b.Consultar(query, datos, true).Tables[0];
            tabla.Columns["idmecanico"].Visible = false;
            tabla.Columns.Insert(2, ManejadorMecanico.Boton("Seleccionar", System.Drawing.Color.Green));
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }

        public void MostrarMecanicosUsados(string query, DataGridView tabla, string datos)
        {
            tabla.Columns.Clear();
            tabla.DataSource = b.Consultar(query, datos, true).Tables[0];
            tabla.Columns["idmecanicomantenimiento"].Visible = false;
            tabla.Columns["fkidmantenimiento"].Visible = false;
            tabla.Columns["fkidmecanico"].Visible = false;
            tabla.Columns.Insert(4, ManejadorMecanico.Boton("Quitar", System.Drawing.Color.Red));
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }

        public void GuardarMecanico(int mantenimiento, int mecanico)
        {
            b.Comando($"call p_insertar_detallematenimientomecanico({mantenimiento}, {mecanico})", true);
        }

        public void BorrarMecanico(int id)
        {
            var rs = MessageBox.Show($"¿Está seguro de borrar el mecanico?", "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                b.Comando($"delete from tbl_mecanicosmantenimientos where idmecanicomantenimiento = {id}", true);
            }
        }

        public void SetCommit(bool estado)
        {
            b.Comando($"SET AUTOCOMMIT = {(estado ? 1 : 0)}", true);
        }

        public void CommitRollback(bool estado)
        {
            b.Comando(estado ? "COMMIT" : "ROLLBACK", true);
        }

        public void StartTransaction()
        {
            b.Comando("START TRANSACTION", true);
        }
    }
}
