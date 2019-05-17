using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    interface DaoImc
    {
        void Registrar(String imc);
        ArrayList  listar();
    }
}
