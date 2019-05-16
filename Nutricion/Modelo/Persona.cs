using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Persona
    {
        private String nombre;
        private String tipo_Id;
        private String id;
        private String pais;
        private int permanencia;
        private DateTime fecha;
        private String genero;
        private String estado;
        private int hijos;
        private String direccion;
        private String residencia;
        private String telefono;
        private String ocupacion;
        private String escolaridad;
        private String eps;
        private String regimen;
        private String email;
        private String contacto;
        private String antecedentes;


        public string Nombre { get => nombre; set => nombre = value; }
        public string Tipo_Id { get => tipo_Id; set => tipo_Id = value; }
        public string Id { get => id; set => id = value; }
        public string Pais { get => pais; set => pais = value; }
        public int Permanencia { get => permanencia; set => permanencia = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Estado { get => estado; set => estado = value; }
        public int Hijos { get => hijos; set => hijos = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Residencia { get => residencia; set => residencia = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Ocupacion { get => ocupacion; set => ocupacion = value; }
        public string Escolaridad { get => escolaridad; set => escolaridad = value; }
        public string Eps { get => eps; set => eps = value; }
        public string Regimen { get => regimen; set => regimen = value; }
        public string Email { get => email; set => email = value; }
        public string Contacto { get => contacto; set => contacto = value; }
        public string Antecedentes { get => antecedentes; set => antecedentes = value; }
        public string Genero { get => genero; set => genero = value; }
    }
}
