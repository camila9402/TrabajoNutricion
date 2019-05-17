using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Control
{
    public class ValidarLoginControl
    {
        public bool validarLogin(String usuario,String contraseña) {
            DaoValidarLoginimp i = new DaoValidarLoginimp();
            return i.validar(usuario, contraseña);
        }
    }
}
