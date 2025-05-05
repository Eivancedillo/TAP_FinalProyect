using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoDatos;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace Manejadores
{
    public class ManejadorPiezas
    {
        Base b = new Base("localhost", "root", "lirroy", "db_TAPFinalProyect");

        public void Guardar(Piezas pieza)
        {
            b.Comando($"call p_insertar_piezas('{pieza.Nombre}', {pieza.Stock}, {pieza.Costo})");
        }

        public void Borrar(Piezas pieza)
        {
            var rs = MessageBox.Show($"¿Está seguro de borrar a {pieza.Nombre}?", "Borrrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                b.Comando($"delete from tbl_piezas where idpieza = {pieza.IdPieza}");
            }
        }

        public void Editar(Piezas pieza)
        {
            b.Comando($"call p_editar_piezas({pieza.IdPieza}, '{pieza.Nombre}', {pieza.Stock}, {pieza.Costo})");
        }

        public void Mostrar(string query, DataGridView tabla, string datos)
        {
            tabla.Columns.Clear();
            tabla.DataSource = b.Consultar(query, datos).Tables[0];
            tabla.Columns["idpieza"].Visible = false;
            tabla.Columns["created_at"].Visible = false;
            tabla.Columns["updated_at"].Visible = false;
            tabla.Columns.Insert(4, ManejadorMecanico.Boton("Editar", System.Drawing.Color.Green));
            tabla.Columns.Insert(5, ManejadorMecanico.Boton("Borrar", System.Drawing.Color.Red));
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
                string fileName = $"Piezas_{dateTime}.xlsx";
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
