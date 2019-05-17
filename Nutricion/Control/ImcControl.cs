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
        private string imc;
        private double resultado;

        public string Imc { get => imc; set => imc = value; }
        public double Resultado { get => resultado; set => resultado = value; }

        public ImcControl(double peso,double estarura) {
            Imc = "";
            Resultado = peso / Math.Pow(estarura,2);
            Console.Write(Resultado);
            if (Resultado < 16.00)
            {
                Imc = "delgadez severa";
            }
            else {
                if (Resultado <= 16.99)
                {
                    Imc = "delgadez moderada";
                }
                else {
                    if (Resultado <= 18.49)
                    {
                        Imc = "delgadez aceptable";
                    }
                    else {
                        if (Resultado <= 24.99)
                        {
                            Imc = "Peso normal";
                        }
                        else{
                            if (Resultado <= 29.99)
                            {
                                Imc = "Sobrepeso";

                            }

                            else{
                                if (Resultado <= 34.99)
                                {
                                    Imc = "Obeso tipo I";
                                }
                                else{

                                    if (Resultado <= 40.00)
                                    {
                                        Imc = "Obeso tipo II";

                                    }
                                    else {
                                        Imc = "Obeso tipo III";
                                    }
                                }
                            }
                        }
                    }
                }
            }
            DaoImcimp dao = new DaoImcimp();
            dao.Registrar(Imc);

        }
    }
}

