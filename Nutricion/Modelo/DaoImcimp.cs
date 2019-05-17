using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class DaoImcimp : Conexion, DaoImc
    {
        public ArrayList listar()
        {
            ArrayList result;
            result = new ArrayList();
            SqlDataReader leer;
            DataTable t = new DataTable();
            abrirConexion();
            cmd.Connection = conexion;
            cmd.CommandText = ("SELECT * FROM Indice ");
            leer = cmd.ExecuteReader();
            while (leer.Read()) {
                result.Add(leer.GetInt32(1));
            }
            leer.Close();
            cerrarConexion();
            return result;
        }

        public void Registrar(string imc)
        {
            abrirConexion();
            cmd.Connection = conexion;
            cmd.CommandText = (string.Format("UPDATE Indice SET contador = contador + 1  WHERE imc = '{0}' ", imc));
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            cerrarConexion();
        }
    }
}
