using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class DaoImcimp : Conexion, DaoImc
    {
        public List<string> listar()
        {
            throw new NotImplementedException();
        }

        public void Registrar(string imc)
        {
            abrirConexion();
            cmd.Connection = conexion;
            cmd.CommandText = (string.Format("INSERT INTO IMC VALUES ('{0}')", imc));
            cmd.ExecuteNonQuery();
            cerrarConexion();
        }
    }
}
