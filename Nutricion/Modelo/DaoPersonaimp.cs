using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Modelo
{
    class DaoPersonaimp : Conexion,DaoPersona
    {
        public List<Persona> listar()
        {
            throw new NotImplementedException();
        }

        public void Registrar(Persona p)
        {
            abrirConexion();
            SqlCommand cmd = new SqlCommand(string.Format("INSERT INTO Nutricion VALUES '{0}','{1}', '{2}', '{3}', {4}, '{5}', '{6}', '{7}', '{8}', " +
                "{9}, '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}', '{18}'",p.Nombre,p.Tipo_Id,p.Id,p.Pais,p.Permanencia,p.Genero
                ,p.Fecha,p.Estado,p.Hijos,p.Direccion,p.Residencia,p.Telefono,p.Ocupacion,p.Escolaridad,p.Eps,p.Regimen,p.Email,p.Contacto,p.Antecedentes));
            cmd.ExecuteNonQuery();
            cerrarConexion();
        }
    }
}
