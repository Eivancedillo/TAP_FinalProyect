using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoDatos;
using System.Windows.Forms;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

namespace Manejadores
{
    public class ManejadorMantenimientos
    {
        Base b = new Base("localhost", "root", "lirroy", "db_TAPFinalProyect");

        public void Guardar(Mantenimientos mantenimiento)
        {
            b.Comando($"call p_insertar_mantenimientos({mantenimiento.FkIdMaquina}, {mantenimiento.FkIdMecanico}, '{mantenimiento.Fecha}', '{mantenimiento.Descipcion}')");
        }

        public void Borrar(Mantenimientos mantenimiento)
        {
            var rs = MessageBox.Show($"¿Está seguro de borrar el mantenimiento de la máquina {mantenimiento.FkIdMaquina}?", "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                b.Comando($"delete from tbl_mantenimientos where idmantenimiento = {mantenimiento.IdMantenimiento}");
            }
        }

        public void Editar(Mantenimientos mantenimiento)
        {
            b.Comando($"call p_editar_mantenimientos({mantenimiento.IdMantenimiento}, {mantenimiento.FkIdMaquina}, {mantenimiento.FkIdMecanico}, '{mantenimiento.Fecha}', '{mantenimiento.Descipcion}')");
        }

        public void EditarEstado(Mantenimientos mantenimiento)
        {
            var rs = MessageBox.Show($"¿Está seguro de finalizar el mantenimiento?", "Finalizar mantenimiento", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rs == DialogResult.Yes)
            {
                b.Comando($"call p_editar_estado_mantenimiento({mantenimiento.IdMantenimiento}, '{mantenimiento.Estado}')");
            }
        }

        public void LlenarMaquina(ComboBox cmb)
        {
            cmb.DataSource = b.Consultar("select idmaquina, nombre from v_maquinas", "v_maquinas").Tables[0];
            cmb.DisplayMember = "nombre";
            cmb.ValueMember = "idmaquina";
        }

        public void LlenarMecanico(ComboBox cmb)
        {
            cmb.DataSource = b.Consultar("select idmecanico, nombre from v_mecanicos", "v_mecanicos").Tables[0];
            cmb.DisplayMember = "nombre";
            cmb.ValueMember = "idmecanico";
        }

        public void Mostrar(string query, DataGridView tabla, string datos)
        {
            tabla.Columns.Clear();
            tabla.DataSource = b.Consultar(query, datos).Tables[0];
            tabla.Columns["idmantenimiento"].Visible = false;
            tabla.Columns["idmaquina"].Visible = false;
            tabla.Columns["idmecanico"].Visible = false;
            tabla.Columns.Insert(8, ManejadorMecanico.Boton("Mantenimiento", System.Drawing.Color.Orange));
            tabla.Columns.Insert(9, ManejadorMecanico.Boton("Editar", System.Drawing.Color.Green));
            tabla.Columns.Insert(10, ManejadorMecanico.Boton("Borrar", System.Drawing.Color.Red));
            tabla.Columns.Insert(11, ManejadorMecanico.Boton("Finalizar", System.Drawing.Color.BlueViolet));
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }

        public void Mostrar2(string query, DataGridView tabla, string datos)
        {
            tabla.Columns.Clear();
            tabla.DataSource = b.Consultar(query, datos).Tables[0];
            tabla.Columns["idmantenimiento"].Visible = false;
            tabla.Columns["idmaquina"].Visible = false;
            tabla.Columns["idmecanico"].Visible = false;
            tabla.Columns.Insert(8, ManejadorMecanico.Boton("Mantenimiento", System.Drawing.Color.Orange));
            tabla.Columns.Insert(9, ManejadorMecanico.Boton("Editar", System.Drawing.Color.Green));
            tabla.Columns.Insert(10, ManejadorMecanico.Boton("Borrar", System.Drawing.Color.Red));
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }

        public void GenerarExcel(DataGridView tabla)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook excelWorkBook = null;
            Excel.Worksheet excelWorkSheet = null;

            try
            {
                // Crear una nueva instancia de Excel
                excelApp = new Excel.Application();
                excelWorkBook = excelApp.Workbooks.Add();
                excelWorkSheet = (Excel.Worksheet)excelWorkBook.Worksheets[1];
                excelApp.Visible = false; // No se muestra durante la creacion

                // Exportar encabezados de columnas
                for (int i = 0; i < tabla.Columns.Count; i++)
                {
                    excelWorkSheet.Cells[1, i + 1] = tabla.Columns[i].HeaderText;
                }

                // Exportar filas de datos
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    for (int j = 0; j < tabla.Columns.Count; j++)
                    {
                        excelWorkSheet.Cells[i + 2, j + 1] = tabla.Rows[i].Cells[j].Value;
                    }
                }

                // Configurar el nombre y la ubicacion del archivo excel
                string dateTime = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");
                string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string fileName = $"Mantenimientos_{dateTime}.xlsx";
                string filePath = Path.Combine(documentsPath, fileName);

                excelWorkBook.SaveAs(filePath);

                // Mensaje de confirmacion
                MessageBox.Show($"Archivo Excel generado exitosamente en: {filePath}", "Exportar a Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el archivo Excel: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Cerrar Excel
                if (excelWorkBook != null) excelWorkBook.Close(false);
                if (excelApp != null) excelApp.Quit();

                // Liberar recursos
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelWorkBook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelWorkBook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
            }
        }
    }
}
