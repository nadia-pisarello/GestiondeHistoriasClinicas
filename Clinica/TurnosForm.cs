using Clinica_v1.Model;
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
    public partial class TurnosForm : Form
    {
        public Turno nuevo = new Turno();

        public TurnosForm()
        {
            InitializeComponent();
        }

        public void Mostrar(DateTime fecha, DateTime hora, string mot)
        {
            dtp_Fecha.Value = fecha;
            dtp_Hora.Value = hora;
            motivoBox.Text = mot;
        }

        private void TurnosForm_Load(object sender, EventArgs e)
        {
            dtp_Hora.Format = DateTimePickerFormat.Custom;
            dtp_Hora.CustomFormat = "HH:mm";
            dtp_Hora.ShowUpDown = true;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (dtp_Fecha.Value != null)
            {

                DateTime fechaTurno = dtp_Fecha.Value;
                DateTime horaTurno = dtp_Hora.Value;
                if (ExisteSolapamiento(fechaTurno, horaTurno))
                {
                    MessageBox.Show("Ya existe un turno en la misma fecha y hora. Por favor, seleccione una fecha y hora diferentes.");
                }
                else
                {
                    this.nuevo.FechaTurno = dtp_Fecha.Value;
                    this.nuevo.HoraTurno = dtp_Hora.Value;
                    this.nuevo.Motivo = motivoBox.Text;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar una fecha válida.");
            }


        }
        private bool ExisteSolapamiento(DateTime fecha, DateTime hora)
        {
            string connectionString = "Data Source=MSI;Initial Catalog=consultas;Integrated Security=True";
            string consulta = "SELECT COUNT(*) FROM turno WHERE fechaTurno = @Fecha AND horaTurno = @Hora";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(consulta, connection))
                {
                    command.Parameters.AddWithValue("@Fecha", fecha.Date);
                    command.Parameters.AddWithValue("@Hora", hora.ToString("HH:mm"));

                    int count = (int)command.ExecuteScalar();

                    return count > 0;
                }
            }
        }
    }
}
