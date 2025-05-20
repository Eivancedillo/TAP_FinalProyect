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
    public partial class FrmDetallesMantenimientos : Form
    {
        ManejadorDetallesMantenimientos Md;
        public static DetallesMantenimiento detallesmantenimiento = new DetallesMantenimiento(0, 0, 0, 0, 0);
        int actualizado = 0, idguardado = 0, idMantenimiento = 0;
        int filadis = 0, columnadis = 0, filausa = 0, columnausa = 0, 
            filameca = 0, columnameca = 0, filamecausa = 0, columnamecausa = 0;

        public FrmDetallesMantenimientos(int idmantenimiento, bool activo = true)
        {
            InitializeComponent();
            Md = new ManejadorDetallesMantenimientos();
            idMantenimiento = idmantenimiento;

            // Activar menu si esta pendiente o apagar caso contrario
            if(activo)
                BtnGuardar.Enabled = true;
            else
                BtnGuardar.Enabled = false;

            // Piezas
            Md.MostrarDisponibles("select * from v_piezasdisponibles", DtgDatosDisponibles, "v_piezasdisponibles");
            Md.MostrarUsadas($"select * from v_piezasusadas where idmantenimiento = {idMantenimiento}", DtgDatosUsadas, "v_piezasusadas");

            // Mecanicos
            Md.MostrarMecanicos("select * from v_mecanicos", DtgMecanicos, "v_mecanicos");
            Md.MostrarMecanicosUsados($"select * from v_mecanicosusados where fkidmantenimiento = {idMantenimiento}", DtgMecanicosUso, "v_mecanicosusados");

            Md.SetCommit(false);
            Md.StartTransaction();
        }

        private void DtgDatosDisponibles_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            filadis = e.RowIndex; columnadis = e.ColumnIndex;
        }

        private void DtgDatosUsadas_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            filausa = e.RowIndex; columnausa = e.ColumnIndex;
        }

        private void DtgMecanicosUso_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            filamecausa = e.RowIndex; columnamecausa = e.ColumnIndex;
        }

        private void DtgMecanicos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            filameca = e.RowIndex; columnameca = e.ColumnIndex;
        }

        private void DtgDatosDisponibles_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (DtgDatosDisponibles.Columns[e.ColumnIndex].Name == "Seleccionar")
            {
                // Validar que el stock sea mayor a 0
                if (int.Parse(DtgDatosDisponibles.Rows[filadis].Cells["Stock restante"].Value.ToString()) <= 0)
                    MessageBox.Show("No hay stock disponible", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    // Agregar pieza al txtpieza, su costo
                    TxtPieza.Text = DtgDatosDisponibles.Rows[filadis].Cells["Nombre"].Value.ToString();
                    txtCosto.Text = DtgDatosDisponibles.Rows[filadis].Cells["Costo"].Value.ToString();

                    // Activar txt y btn
                    TxtCantidad.Enabled = true;
                    BtnAñadir.Enabled = true;
                }
            }
        }

        private void DtgDatosUsadas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DtgDatosUsadas.Columns[e.ColumnIndex].Name == "Editar")
            {
                actualizado = 1;

                // Rellenar Txts con los datos de la pieza usada
                TxtPieza.Text = DtgDatosUsadas.Rows[filausa].Cells["Nombre"].Value.ToString();
                Md.TraerCosto(int.Parse(DtgDatosUsadas.Rows[filausa].Cells["idpieza"].Value.ToString()), txtCosto);
                TxtCantidad.Text = DtgDatosUsadas.Rows[filausa].Cells["Cantidad"].Value.ToString();
                idguardado = int.Parse(DtgDatosUsadas.Rows[filausa].Cells["iddetalle"].Value.ToString());

                Md.ActualizarStock(int.Parse(DtgDatosUsadas.Rows[filausa].Cells["idpieza"].Value.ToString()), int.Parse(TxtCantidad.Text), false);

                // Actualizar dtg
                Md.MostrarDisponibles("select * from v_piezasdisponibles", DtgDatosDisponibles, "v_piezasdisponibles");

                // Activar txt y btn
                TxtCantidad.Enabled = true;
                BtnAñadir.Enabled = true;
            }

            else if(DtgDatosUsadas.Columns[e.ColumnIndex].Name == "Quitar")
            {
                Md.Borrar(new DetallesMantenimiento(int.Parse(DtgDatosUsadas.Rows[filausa].Cells["iddetalle"].Value.ToString()), 0, 0, 0, 0));
                Md.MostrarUsadas($"select * from v_piezasusadas where idmantenimiento = {idMantenimiento}", DtgDatosUsadas, "v_piezasusadas");
            }
        }

        private void DtgMecanicos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(DtgMecanicos.Columns[e.ColumnIndex].Name == "Seleccionar")
            {
                Md.GuardarMecanico(idMantenimiento, int.Parse(DtgMecanicos.Rows[filameca].Cells["idmecanico"].Value.ToString()));
                Md.MostrarMecanicos("select * from v_mecanicos", DtgMecanicos, "v_mecanicos");
                Md.MostrarMecanicosUsados($"select * from v_mecanicosusados where fkidmantenimiento = {idMantenimiento}", DtgMecanicosUso, "v_mecanicosusados");
            }
        }

        private void DtgMecanicosUso_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DtgMecanicosUso.Columns[e.ColumnIndex].Name == "Quitar")
            {
                Md.BorrarMecanico(int.Parse(DtgMecanicosUso.Rows[filamecausa].Cells["idmecanicomantenimiento"].Value.ToString()));
                Md.MostrarMecanicos("select * from v_mecanicos", DtgMecanicos, "v_mecanicos");
                Md.MostrarMecanicosUsados($"select * from v_mecanicosusados where fkidmantenimiento = {idMantenimiento}", DtgMecanicosUso, "v_mecanicosusados");
            }
        }

        private void BtnAñadir_Click(object sender, EventArgs e)
        {
            // Validar que la cantidad sea mayor a 0
            if (int.Parse(TxtCantidad.Text) <= 0)
                MessageBox.Show("La cantidad debe ser mayor a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (int.Parse(TxtCantidad.Text) > int.Parse(DtgDatosDisponibles.Rows[filadis].Cells["Stock restante"].Value.ToString()))
                    MessageBox.Show("No hay stock suficiente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (actualizado == 1)
                    {
                        Md.Editar(new DetallesMantenimiento(idguardado, 0, 0, int.Parse(TxtCantidad.Text), Double.Parse(txtCosto.Text)));

                        // Actualizar stock
                        Md.ActualizarStock(int.Parse(DtgDatosUsadas.Rows[filausa].Cells["idpieza"].Value.ToString()), int.Parse(TxtCantidad.Text), true);

                        actualizado = 0;
                        idguardado = 0;
                    }

                    else
                    {
                        Md.Guardar(new DetallesMantenimiento(
                            0,
                            int.Parse(DtgDatosDisponibles.Rows[filadis].Cells["idpieza"].Value.ToString()), idMantenimiento,
                            int.Parse(TxtCantidad.Text),
                            double.Parse(txtCosto.Text)
                        ));

                        // Actualizar el stock de la pieza
                        Md.ActualizarStock(int.Parse(DtgDatosDisponibles.Rows[filadis].Cells["idpieza"].Value.ToString()), int.Parse(TxtCantidad.Text), true);
                    }

                    // Actualizar el datagridview de piezas usadas
                    Md.MostrarUsadas($"select * from v_piezasusadas where idmantenimiento = {idMantenimiento}", DtgDatosUsadas, "v_piezasusadas");
                    // Actualizar el datagridview de piezas disponibles
                    Md.MostrarDisponibles("select * from v_piezasdisponibles", DtgDatosDisponibles, "v_piezasdisponibles");

                    // Limpiar TextBoxs
                    TxtPieza.Clear();
                    TxtCantidad.Clear();
                    txtCosto.Clear();

                    TxtCantidad.Enabled = false;
                    BtnAñadir.Enabled = false;
                }
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Md.CommitRollback(true);
            Md.SetCommit(true);
            Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Md.CommitRollback(false);
            Md.SetCommit(true);
            Close();
        }
    }
}
