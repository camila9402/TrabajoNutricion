using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control
{
    public class ImcControl
    {
        public ImcControl(double peso,double estarura) {
            string imc = "";
            double resultado;
            resultado = peso / Math.Pow(estarura,2);
            Console.Write(resultado);
            if (resultado < 16.00)
            {
                imc = "delgadez severa";
            }
            else {
                if (resultado <= 16.99)
                {
                    imc = "delgadez moderada";
                }
                else {
                    if (resultado <= 18.49)
                    {
                        imc = "delgadez aceptable";
                    }
                    else {
                        if (resultado <= 24.99)
                        {
                            imc = "Peso normal";
                        }
                        else{
                            if (resultado <= 29.99)
                            {
                                imc = "Sobrepeso";

                            }

                            else{
                                if (resultado <= 34.99)
                                {
                                    imc = "Obeso tipo I";
                                }
                                else{

                                    if (resultado <= 40.00)
                                    {
                                        imc = "Obeso tipo II";

                                    }
                                    else {
                                        imc = "Obeso tipo III";
                                    }
                                }
                            }
                        }
                    }
                }
            }
            DaoImcimp dao = new DaoImcimp();
            dao.Registrar(imc);

        }
    }
}

