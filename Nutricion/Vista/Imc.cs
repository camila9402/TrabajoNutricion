using Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class Imc : Form
    {
        public Imc()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAcceder_Click(object sender, EventArgs e)
        {
            if (txtPeso.Text != "")
            {

                if (txtEstatura.Text != "")
                {
                    try
                    {
                        ImcControl c = new ImcControl(Convert.ToDouble(txtPeso.Text.Trim()), Convert.ToDouble(txtEstatura.Text.Trim()));
                        MessageBox.Show("IMC de "+c.Resultado+"y el paciente esta en una condición de "+c.Imc,"Imc",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    }
                    catch (Exception ) {
                        mensajeError("Datos invalidos");
                    }
                }
                else {
                    mensajeError("Campo de estatura vacio");
                }
            }
            else {
                mensajeError("Campo de peso vacio");
            }

            
        }
        void mensajeError(string mensaje)
        {
            lblerror.Text = "          " + mensaje;
            lblerror.Visible = true;

        }
    }
}
