using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica_v1.Model
{
    public class Turno
    {
        private int id;
        private DateTime fechaTurno;
        private DateTime horaTurno;
        private string motivo;
        private int pacienteId;

        public Turno(){}

        public Turno(DateTime fechaTurno, DateTime horaTurno, string motivo,int pacienteId)
        {
            this.fechaTurno = fechaTurno;
            this.horaTurno = horaTurno;
            this.motivo = motivo;
            this.pacienteId = pacienteId;
        }

        public int Id { get => id; set => id = value; }
        public DateTime FechaTurno { get => fechaTurno; set => fechaTurno = value; }
        public DateTime HoraTurno { get => horaTurno; set => horaTurno = value; }
        public string Motivo { get => motivo; set => motivo = value; }
        public int PacienteId { get => pacienteId; set => pacienteId = value; }
    }
}
