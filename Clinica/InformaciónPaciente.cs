using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica_v1
{
    public partial class InformacionPaciente : Form
    {
        private int id;
        public InformacionPaciente(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        public void CargarInformacionPaciente(int id)
        {

            string connectionString = "Data Source=MSI;Initial Catalog=consultas;Integrated Security=True";
            string query = "SELECT * FROM pacientes p WHERE p.id = @id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    DataTable dataTable = new DataTable();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                    infoDataGridView.DataSource = dataTable;
                }
            }
        }

        public void CargarHistoiaPaciente(int id)
        {

            string connectionString = "Data Source=MSI;Initial Catalog=consultas;Integrated Security=True";
            string query = "SELECT * FROM historiasClinicas hc  WHERE hc.pacienteId = @id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    DataTable dataTable = new DataTable();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                    historia_Dgv.DataSource = dataTable;
                }
            }
        }

        public void CargarTurnoPaciente(int id)
        {

            string connectionString = "Data Source=MSI;Initial Catalog=consultas;Integrated Security=True";
            string query = "SELECT * FROM turno t WHERE t.pacienteId= @id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    DataTable dataTable = new DataTable();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                    turno_Dgv.DataSource = dataTable;
                }
            }
        }

        private void ExportarDataGridViewExcel(DataGridView grd, DataGridView grd1, DataGridView grd2)
        {
            SaveFileDialog fichero = new SaveFileDialog();
            fichero.Filter = "Excel (*.xls)|*.xls";
            if (fichero.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel.Application aplicacion;
                Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
                aplicacion = new Microsoft.Office.Interop.Excel.Application();
                libros_trabajo = aplicacion.Workbooks.Add();
                hoja_trabajo = (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);

                // Exportar primer DataGridView (grd)
                for (int j = 1; j < grd.Columns.Count; j++) // Comenzamos en j = 1 para omitir la primera columna
                {
                    hoja_trabajo.Cells[1, j] = grd.Columns[j].HeaderText;
                }

                for (int i = 0; i < grd.Rows.Count; i++)
                {
                    for (int j = 1; j < grd.Columns.Count; j++) // Comenzamos en j = 1 para omitir la primera columna
                    {
                        hoja_trabajo.Cells[i + 2, j] = grd.Rows[i].Cells[j].Value?.ToString();
                    }
                }

                // Exportar segundo DataGridView (grd1)
                int rowIndex = grd.Rows.Count + 4;
                for (int j = 1; j < grd1.Columns.Count - 1; j++) 
                {
                    hoja_trabajo.Cells[rowIndex, j] = grd1.Columns[j].HeaderText;
                }

                rowIndex++;
                for (int i = 0; i < grd1.Rows.Count; i++)
                {
                    for (int j = 1; j < grd1.Columns.Count - 1; j++) 
                    {
                        hoja_trabajo.Cells[rowIndex + i, j] = grd1.Rows[i].Cells[j].Value?.ToString();
                    }
                }

                // Exportar tercer DataGridView (grd2)
                rowIndex = grd.Rows.Count + grd1.Rows.Count + 7;
                for (int j = 1; j < grd2.Columns.Count - 1; j++) 
                {
                    hoja_trabajo.Cells[rowIndex, j] = grd2.Columns[j].HeaderText;
                }

                rowIndex++;
                for (int i = 0; i < grd2.Rows.Count; i++)
                {
                    for (int j = 1; j < grd2.Columns.Count - 1; j++) 
                    {
                        hoja_trabajo.Cells[rowIndex + i, j] = grd2.Rows[i].Cells[j].Value?.ToString();
                    }
                }

                libros_trabajo.SaveAs(fichero.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                aplicacion.Quit();
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            ExportarDataGridViewExcel(infoDataGridView, historia_Dgv, turno_Dgv);
        }
    }
}
