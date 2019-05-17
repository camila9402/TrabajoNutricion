using Modelo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control
{
    public class CargarGraficaControl
    {
        public ArrayList imc() {
            ArrayList i = new ArrayList();
            i.Add("delgadez severa");
            i.Add("delgadez moderada");
            i.Add("delgadez aceptable");
            i.Add("Peso normal");
            i.Add("Sobrepeso");
            i.Add("Obeso tipo I");
            i.Add("Obeso tipo II");
            i.Add("Obeso tipo III");
            return i;


        }
        public ArrayList datoimc() {
            ArrayList i = new ArrayList();
            DaoImcimp dao = new DaoImcimp();
            i = dao.listar();
            return i;

        }
    }
}
