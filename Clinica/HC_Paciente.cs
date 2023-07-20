using Clinica_v1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica_v1
{
    public partial class HC_Paciente : Form
    {
        public HistoriaClinica hp = new HistoriaClinica();

        public int Historia_id { get; }

        public HC_Paciente()
        {
            InitializeComponent();
        }

        public HC_Paciente(int historia_id)
        {
            Historia_id = historia_id;
        }

        public void Mostrar(DateTime fecha, string mot, string diag, string sinto, string est, string med) 
        {
            fechaDTP.Value = fecha;
            motivoBox.Text = mot;
            sintomasBox.Text = sinto;
            diagnosticoBox.Text = diag;
            estudiosBox.Text = est;
            medicacionBox.Text = med;
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (fechaDTP.Value != null)
            {
                this.hp.Fecha = fechaDTP.Value;
                this.hp.MotivoConsulta = motivoBox.Text;
                this.hp.Sintomas = sintomasBox.Text;
                this.hp.Diagnostico = diagnosticoBox.Text;
                this.hp.Estudios = estudiosBox.Text;
                this.hp.Medicacion = medicacionBox.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe ingresar una fecha válida.");
            }
            
            
        }

    }
}
