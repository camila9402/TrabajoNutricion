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

        public SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-3PQ4FGV\\SQLEXPRESS;Initial Catalog=Nutricion;Integrated Security=True");
        public SqlCommand cmd = new SqlCommand();

        public void abrirConexion()  {
             conexion.Open();
         }
         public void cerrarConexion() {
             conexion.Close();
         }
     }
    
}
