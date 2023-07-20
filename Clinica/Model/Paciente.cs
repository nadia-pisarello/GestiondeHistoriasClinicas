using Clinica_v1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica_v1
{
    public class Paciente
    {
        private int id;
        private string dni;
        private string nombre;
        private string apellido;
        private string direccion;
        private string telefono;
        private string email;
        private DateTime fechaNacimiento; 
        private string genero;

        public Paciente() { }
        public Paciente(string dni, string nombre, string apellido, string direccion, string telefono, string email, DateTime fechaNac , string genero)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.direccion = direccion;
            this.telefono = telefono;
            this.email = email;
            this.fechaNacimiento = fechaNac;
            this.genero = genero;
        }

        public int Id { get => id; set => id = value; }
        public string DNI { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
        public DateTime FechaNac { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string Genero { get => genero; set => genero = value; }
    }
}
