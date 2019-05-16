using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Control
{
    public class CrearPersonaControl
    {
        public void crearPersona(string nombre, string tipo_id, string id, string pais, int permanencia, string genero, DateTime fecha,String estado,int hijos,String direccion,String residencia
            ,String telefono,String ocupacion,String escolaridad,String eps,String regimen,String email,String contacto,String antecedentes) {

            Persona p = new Persona();
            p.Nombre = nombre;
            p.Tipo_Id = tipo_id;
            p.Id = id;
            p.Pais = pais;
            p.Permanencia = permanencia;
            p.Genero = genero;
            p.Fecha = fecha;
            p.Estado = estado;
            p.Hijos = hijos;
            p.Direccion = direccion;
            p.Residencia = residencia;
            p.Telefono = telefono;
            p.Ocupacion = ocupacion;
            p.Escolaridad = escolaridad;
            p.Eps = eps;
            p.Regimen = regimen;
            p.Email = email;
            p.Contacto = contacto;
            p.Antecedentes = antecedentes;
            DaoPersonaimp dao = new DaoPersonaimp();
            dao.Registrar(p);
        }
    }
}
