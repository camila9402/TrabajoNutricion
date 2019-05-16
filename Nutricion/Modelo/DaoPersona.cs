using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public interface DaoPersona
    {
        void Registrar(Persona p);
        List<Persona> listar();
    }
}
