using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Modelo
{
    public class Conexion
    {
        private SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-3PQ4FGV\SQLEXPRESS;Initial Catalog=Nutricion;Integrated Security=True");
  
        public void abrirConexion()  {
            this.conexion.Open();
        }
        public void cerrarConexion() {
            this.conexion.Close();
        }
    }
}
