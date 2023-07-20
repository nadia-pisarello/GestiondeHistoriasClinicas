using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Clinica_v1
{
    public partial class Agenda : Form
    {
        public Agenda()
        {
            InitializeComponent();
        }

        private void Agenda_Load(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void Refrescar()
        {
            string connectionString = @"Data Source=MSI;Initial Catalog=consultas;Integrated Security=True";
            string query = "SELECT t.id, p.nombre, p.apellido, t.fechaTurno, t.horaTurno, t.motivo FROM turno t JOIN  pacientes p ON t.pacienteId = p.id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dgAgenda.DataSource = dataTable;
                if (dgAgenda.Columns["horaTurno"] != null)
                {
                    dgAgenda.Columns["horaTurno"].DefaultCellStyle.Format = "hh\\:mm";
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string mot;
            DateTime fecha,hora;

            if (dgAgenda.CurrentRow == null) return;
            int id = int.Parse(dgAgenda.CurrentRow.Cells["id"].Value.ToString());
            string connectionString = "Data Source=MSI;Initial Catalog=consultas;Integrated Security=True";
            string query = "UPDATE turno SET fechaTurno=@fechaTurno, horaTurno=@horaTurno, motivo=@motivo WHERE id=@id";
            TurnosForm turnos = new TurnosForm();
            
            mot = (dgAgenda.CurrentRow.Cells["motivo"].Value).ToString();
            hora = DateTime.Parse((dgAgenda.CurrentRow.Cells["horaTurno"].Value).ToString());
            fecha = DateTime.Parse((dgAgenda.CurrentRow.Cells["fechaTurno"].Value).ToString());
            turnos.Mostrar(fecha, hora, mot);

            turnos.ShowDialog();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    if (turnos.nuevo.FechaTurno < SqlDateTime.MinValue.Value || turnos.nuevo.FechaTurno > SqlDateTime.MaxValue.Value) return;
                    command.Parameters.AddWithValue("@fechaTurno", turnos.nuevo.FechaTurno);
                    if (turnos.nuevo.HoraTurno < SqlDateTime.MinValue.Value || turnos.nuevo.HoraTurno > SqlDateTime.MaxValue.Value) return;
                    command.Parameters.AddWithValue("@horaTurno", turnos.nuevo.HoraTurno);
                    command.Parameters.AddWithValue("@motivo", turnos.nuevo.Motivo);
                    command.ExecuteNonQuery();

                }
            }
            Refrescar();
            turnos.Close();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgAgenda.CurrentRow == null) return;
            int id = int.Parse(dgAgenda.CurrentRow.Cells["id"].Value.ToString());
            string connectionString = "Data Source=MSI;Initial Catalog=consultas;Integrated Security=True";

            string query = "DELETE FROM turno WHERE id=@id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }

            }
            dgAgenda.Rows.Remove(dgAgenda.CurrentRow);
        }

    }
}
