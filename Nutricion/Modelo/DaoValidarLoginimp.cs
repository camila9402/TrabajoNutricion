using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class DaoValidarLoginimp : Conexion, DaoValidarLogin
    {
        public bool validar(string usuario, string contraseña)
        {
            SqlDataReader leer;
            DataTable t = new DataTable();
            abrirConexion();
            cmd.Connection = conexion;
            cmd.CommandText = (string.Format("SELECT * FROM usuario WHERE usuario='{0}' and contraseña='{1}' ",usuario,contraseña));
            leer = cmd.ExecuteReader();
            if (leer.HasRows) {
                leer.Close();
                cerrarConexion();
                return true;
            }
            leer.Close();
            cerrarConexion();
            return false;
        }
    }
}
