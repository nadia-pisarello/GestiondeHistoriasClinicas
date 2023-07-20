using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica_v1
{
    public partial class FichaPaciente : Form
    {
        public Paciente _paciente = new Paciente();
        public event EventHandler Form1_Load; //para invocar al Form1
        public FichaPaciente()
        {
            InitializeComponent();
        }

        public void Mostrar(string dni, string nom, string ape, string dir, string tel, string email, DateTime fecha, string gen)
        {
            textBoxDNI.Text = dni;
            textBoxNombre.Text = nom;
            textBoxApellido.Text = ape;
            textBoxDireccion.Text = dir;
            textBoxTelef.Text = tel;
            textBoxEmail.Text = email;
            FechaNacDateTimePicker1.Value = fecha;
            textBoxGenero.Text = gen;
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            this._paciente.DNI = textBoxDNI.Text;
            this._paciente.Nombre = textBoxNombre.Text;
            this._paciente.Apellido = textBoxApellido.Text;
            this._paciente.Direccion = textBoxDireccion.Text;
            this._paciente.Telefono = textBoxTelef.Text;
            this._paciente.Email = textBoxEmail.Text;
            if (FechaNacDateTimePicker1.Value != null)
            {
                this._paciente.FechaNac = FechaNacDateTimePicker1.Value;
            }
            else
            {
                MessageBox.Show("La fecha de nacimiento no es válida.");
            }
            this._paciente.Genero = textBoxGenero.Text;
            Form1_Load?.Invoke(this, EventArgs.Empty);
            this.Close();
        }
    }
}
