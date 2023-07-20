using Clinica_v1.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Clinica_v1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
               
        private void Form1_Load(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=MSI;Initial Catalog=consultas;Integrated Security=True";
            string query = "INSERT INTO pacientes (dni,nombre,apellido, direccion, telefono, email,fechaNacimiento, genero) VALUES (@dni,@nombre,@apellido,@direccion, @telefono,@email, @fechaNacimiento, @genero)";
            FichaPaciente ficha = new FichaPaciente();
            ficha.ShowDialog();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@dni", ficha._paciente.DNI);
                    command.Parameters.AddWithValue("@nombre", ficha._paciente.Nombre);
                    command.Parameters.AddWithValue("@apellido", ficha._paciente.Apellido);
                    command.Parameters.AddWithValue("@direccion", ficha._paciente.Direccion);
                    command.Parameters.AddWithValue("@telefono", ficha._paciente.Telefono);
                    command.Parameters.AddWithValue("@email", ficha._paciente.Email);
                    if (ficha._paciente.FechaNac < SqlDateTime.MinValue.Value || ficha._paciente.FechaNac > SqlDateTime.MaxValue.Value) return;
                    command.Parameters.AddWithValue("@fechaNacimiento", ficha._paciente.FechaNac);
                    command.Parameters.AddWithValue("@genero", ficha._paciente.Genero);
                    command.ExecuteNonQuery();
                    
                }
            }
            Refrescar();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (pacientesDataGridView.CurrentRow == null) return;
            int id = int.Parse((pacientesDataGridView.CurrentRow.Cells["id"].Value).ToString());
            string connectionString = "Data Source=MSI;Initial Catalog=consultas;Integrated Security=True";

            // Eliminar los registros relacionados en la tabla 'turno'
            string deleteTurnoQuery = "DELETE FROM turno WHERE pacienteId = @id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(deleteTurnoQuery, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
            }

            //Eliminar los  registros relacionados en la tabla 'historiasClinicas'
            string deleteHistoriaCQuery = "DELETE FROM historiasClinicas WHERE pacienteId = @id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(deleteHistoriaCQuery, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
            }

            string query = "DELETE FROM pacientes WHERE id=@id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id",id);
                    command.ExecuteNonQuery();
                }

            }
            pacientesDataGridView.Rows.Remove(pacientesDataGridView.CurrentRow);
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            string dni, nom, ape, dir, tel, email, gen;
            DateTime fecha;

            if (pacientesDataGridView.CurrentRow == null) return;
            int id = int.Parse((pacientesDataGridView.CurrentRow.Cells["id"].Value).ToString());
            string connectionString = "Data Source=MSI;Initial Catalog=consultas;Integrated Security=True";
            string query = "UPDATE pacientes SET dni=@dni,nombre=@nombre,apellido=@apellido, direccion=@direccion, telefono= @telefono, email=@email,fechaNacimiento= @fechaNacimiento, genero= @genero WHERE id=@id";
            FichaPaciente ficha = new FichaPaciente();
            
            dni = (pacientesDataGridView.CurrentRow.Cells["dni"].Value).ToString();
            nom = (pacientesDataGridView.CurrentRow.Cells["nombre"].Value).ToString();
            ape = (pacientesDataGridView.CurrentRow.Cells["apellido"].Value).ToString();
            dir = (pacientesDataGridView.CurrentRow.Cells["direccion"].Value).ToString();
            tel = (pacientesDataGridView.CurrentRow.Cells["telefono"].Value).ToString();
            email = (pacientesDataGridView.CurrentRow.Cells["email"].Value).ToString();
            fecha = DateTime.Parse((pacientesDataGridView.CurrentRow.Cells["fechaNacimiento"].Value).ToString());
            gen = (pacientesDataGridView.CurrentRow.Cells["genero"].Value).ToString();

            ficha.Mostrar(dni, nom, ape, dir, tel, email, fecha, gen);

            ficha.ShowDialog();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id",id);
                    command.Parameters.AddWithValue("@dni", ficha._paciente.DNI);
                    command.Parameters.AddWithValue("@nombre", ficha._paciente.Nombre);
                    command.Parameters.AddWithValue("@apellido", ficha._paciente.Apellido);
                    command.Parameters.AddWithValue("@direccion", ficha._paciente.Direccion);
                    command.Parameters.AddWithValue("@telefono", ficha._paciente.Telefono);
                    command.Parameters.AddWithValue("@email", ficha._paciente.Email);
                    if(ficha._paciente.FechaNac < SqlDateTime.MinValue.Value || ficha._paciente.FechaNac > SqlDateTime.MaxValue.Value) return;                    
                    command.Parameters.AddWithValue("@fechaNacimiento", ficha._paciente.FechaNac);
                    command.Parameters.AddWithValue("@genero", ficha._paciente.Genero);
                    command.ExecuteNonQuery();
                   
                }
            }
            Refrescar();
            ficha.Close();           
        }
        private void pacientesDataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (pacientesDataGridView.CurrentRow == null) return;
            int id = int.Parse(pacientesDataGridView.CurrentRow.Cells["id"].Value.ToString());
            Historial_Paciente hp = new Historial_Paciente(id);
            hp.RefrescarPaciente();
            hp.Text = pacientesDataGridView.CurrentRow.Cells["nombre"].Value.ToString() + " " + pacientesDataGridView.CurrentRow.Cells["Apellido"].Value.ToString();
            hp.Show();

        }


        private void Refrescar()
        {
            string connectionString = "Data Source=MSI;Initial Catalog=consultas;Integrated Security=True";
            string query = "SELECT * FROM pacientes";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                pacientesDataGridView.DataSource = dataTable;
            }
        }

        private void btn_Turno_Click(object sender, EventArgs e)
        {
            if (pacientesDataGridView.CurrentRow == null) return;
            int id = int.Parse(pacientesDataGridView.CurrentRow.Cells["id"].Value.ToString());
            string connectionString = "Data Source=MSI;Initial Catalog=consultas;Integrated Security=True";
            string query = "INSERT INTO turno (fechaTurno, horaTurno,motivo, pacienteId) VALUES (@fechaTurno, @horaTurno, @motivo, @id)";
            TurnosForm turnos = new TurnosForm();
            turnos.ShowDialog();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlParameter parameter = new SqlParameter("@id", SqlDbType.Int);
                        parameter.Value = id;
                        command.Parameters.Add(parameter);
                        if (turnos.nuevo.FechaTurno < SqlDateTime.MinValue.Value || turnos.nuevo.FechaTurno > SqlDateTime.MaxValue.Value) return;
                        command.Parameters.AddWithValue("@fechaTurno", turnos.nuevo.FechaTurno);
                        if (turnos.nuevo.HoraTurno < SqlDateTime.MinValue.Value || turnos.nuevo.HoraTurno > SqlDateTime.MaxValue.Value) return;
                        command.Parameters.AddWithValue("@horaTurno", turnos.nuevo.HoraTurno.ToShortTimeString());
                        command.Parameters.AddWithValue("@motivo", turnos.nuevo.Motivo);
                        command.Parameters.AddWithValue("@pacientId", id);
                        command.ExecuteNonQuery();

                    }
                }
                Refrescar();    
            } catch { }
           
        }

        private void btn_Agenda_Click(object sender, EventArgs e)
        {
            Agenda agenda = new Agenda();
            agenda.ShowDialog();
        }

        private void btn_Info_Click(object sender, EventArgs e)
        {
            if (pacientesDataGridView.CurrentRow == null) return;
            int id = int.Parse(pacientesDataGridView.CurrentRow.Cells["id"].Value.ToString());
            InformacionPaciente info = new InformacionPaciente(id);
            info.CargarInformacionPaciente(id);
            info.CargarHistoiaPaciente(id);
            info.CargarTurnoPaciente(id);
            info.Text = pacientesDataGridView.CurrentRow.Cells["nombre"].Value.ToString() + " " + pacientesDataGridView.CurrentRow.Cells["apellido"].Value.ToString();
            info.Show();
        }
    }
}

