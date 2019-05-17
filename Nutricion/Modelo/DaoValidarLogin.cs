using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    interface DaoValidarLogin
    {
        bool validar(String usuario,String contraseña);
    }
}
