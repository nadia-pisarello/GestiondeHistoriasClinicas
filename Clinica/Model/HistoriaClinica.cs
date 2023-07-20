using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica_v1.Model
{

    public class HistoriaClinica
    {
        private int id;
        private DateTime fecha;
        private string motivoConsulta;
        private string sintomas;
        private string diagnostico;
        private string estudios;
        private string medicacion;
        private int pacienteId;

        public HistoriaClinica()
        {
        }

        public HistoriaClinica(DateTime fecha, string motivoConsulta, string sintomas, string diagnostico, string estudios, string medicacion)
        {
            this.fecha = fecha;
            this.motivoConsulta = motivoConsulta;
            this.sintomas = sintomas;
            this.diagnostico = diagnostico;
            this.estudios = estudios;
            this.medicacion = medicacion;
        }

        public int Id { get => id; set => id = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string MotivoConsulta { get => motivoConsulta; set => motivoConsulta = value; }
        public string Sintomas { get => sintomas; set => sintomas = value; }
        public string Diagnostico { get => diagnostico; set => diagnostico = value; }
        public string Estudios { get => estudios; set => estudios = value; }
        public string Medicacion { get => medicacion; set => medicacion = value; }
        public int PacienteId { get => pacienteId; set => pacienteId = value; }
    }
}
