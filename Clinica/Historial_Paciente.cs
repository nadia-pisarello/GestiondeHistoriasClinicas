using Clinica_v1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Clinica_v1
{
    public partial class Historial_Paciente : Form
    {
        public HistoriaClinica hp = new HistoriaClinica();
        private int id;
        public Historial_Paciente(int id)
        {
            InitializeComponent();
            this.id = id;
        }
        public Historial_Paciente()
        {
            InitializeComponent();
        }
        public DataGridView HistoriaDataGridView
        {
            get { return historiaDataGridView; }
        }

        public void Historial_Paciente_Load(object sender, EventArgs e)
        {
            RefrescarPaciente();
        }

        public void RefrescarPaciente()
        {

            string connectionString = "Data Source=MSI;Initial Catalog=consultas;Integrated Security=True";
            string query = "SELECT hc.id, p.nombre, p.apellido, hc.fecha, hc.motivoConsulta, hc.sintomas, hc.diagnostico, hc.estudios, hc.medicacion FROM historiasClinicas hc INNER JOIN pacientes p ON p.id = hc.pacienteId WHERE p.id = @id";
            try
            {

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
                        historiaDataGridView.DataSource = dataTable;
                       
                    }
                }
            } catch { MessageBox.Show("Error al cargar los datos");}

               
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=MSI;Initial Catalog=consultas;Integrated Security=True";
            string query = "INSERT INTO historiasClinicas (fecha, motivoConsulta, sintomas, diagnostico, estudios, medicacion, pacienteId) VALUES (@fecha, @motivoConsulta, @sintomas, @diagnostico, @estudios, @medicacion, @id)";

            HC_Paciente historia = new HC_Paciente();
            historia.ShowDialog();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlParameter parameter = new SqlParameter("@id", SqlDbType.Int);
                    parameter.Value = id;
                    command.Parameters.Add(parameter);
                    command.Parameters.AddWithValue("@fecha", historia.hp.Fecha);
                    command.Parameters.AddWithValue("@motivoConsulta", historia.hp.MotivoConsulta);
                    command.Parameters.AddWithValue("@sintomas", historia.hp.Sintomas);
                    command.Parameters.AddWithValue("@diagnostico", historia.hp.Diagnostico);
                    command.Parameters.AddWithValue("@estudios", historia.hp.Estudios);
                    command.Parameters.AddWithValue("@medicacion", historia.hp.Medicacion);
                    command.Parameters.AddWithValue("@pacienteId", id);
                    if (historia.hp.Fecha < SqlDateTime.MinValue.Value || historia.hp.Fecha > SqlDateTime.MaxValue.Value) return;
                    command.ExecuteNonQuery();

                }
            }
            RefrescarPaciente();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            string mot, diag, sinto, est, med;
            DateTime fecha;

            if (historiaDataGridView.CurrentRow == null) return;
            int historia_id = int.Parse(historiaDataGridView.CurrentRow.Cells["id"].Value.ToString());
            string connectionString = "Data Source=MSI;Initial Catalog=consultas;Integrated Security=True";
            string query = "UPDATE historiasClinicas SET fecha=@fecha, motivoConsulta=@motivoConsulta ,sintomas=@sintomas,diagnostico=@diagnostico, estudios=@estudios, medicacion=@medicacion, pacienteId=@id WHERE id = @historia_id";
            HC_Paciente historia = new HC_Paciente();

            fecha = DateTime.Parse((historiaDataGridView.CurrentRow.Cells["fecha"].Value).ToString());
            mot = (historiaDataGridView.CurrentRow.Cells["motivoConsulta"].Value).ToString();
            sinto = (historiaDataGridView.CurrentRow.Cells["sintomas"].Value).ToString();
            diag = (historiaDataGridView.CurrentRow.Cells["diagnostico"].Value).ToString();
            est = (historiaDataGridView.CurrentRow.Cells["estudios"].Value).ToString();
            med = (historiaDataGridView.CurrentRow.Cells["medicacion"].Value).ToString();
            
            historia.Mostrar(fecha, mot, diag, sinto, est, med);

            historia.ShowDialog();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlParameter parameter = new SqlParameter("@id", SqlDbType.Int);
                    parameter.Value = id;
                    command.Parameters.Add(parameter);
                    command.Parameters.AddWithValue("@historia_id", historia_id);
                    if (historia.hp.Fecha < SqlDateTime.MinValue.Value || historia.hp.Fecha > SqlDateTime.MaxValue.Value) return;
                    command.Parameters.AddWithValue("@fecha", historia.hp.Fecha);
                    command.Parameters.AddWithValue("@motivoConsulta", historia.hp.MotivoConsulta);
                    command.Parameters.AddWithValue("@sintomas", historia.hp.Sintomas);
                    command.Parameters.AddWithValue("@diagnostico", historia.hp.Diagnostico);
                    command.Parameters.AddWithValue("@estudios", historia.hp.Estudios);
                    command.Parameters.AddWithValue("@medicacion", historia.hp.Medicacion);
                    command.Parameters.AddWithValue("@pacienteId", id);
                    command.ExecuteNonQuery();

                }
            }
            RefrescarPaciente();
            historia.Close();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (historiaDataGridView.CurrentRow == null) return;
            int historia_id = int.Parse(historiaDataGridView.CurrentRow.Cells["id"].Value.ToString());
            string connectionString = "Data Source=MSI;Initial Catalog=consultas;Integrated Security=True";
            string query = "DELETE FROM historiasClinicas WHERE id = @historia_id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@historia_id", historia_id);
                    command.ExecuteNonQuery();
                }

            }
            historiaDataGridView.Rows.Remove(historiaDataGridView.CurrentRow);

        }

    }
}
