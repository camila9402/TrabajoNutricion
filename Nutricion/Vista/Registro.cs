using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control;

namespace Vista
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAcceder_Click(object sender, EventArgs e)
        {
            CrearPersonaControl c = new CrearPersonaControl();
            String sexo;
            sexo = "";
            if (rbF.Checked)
            {
                sexo = "F";
            }
            else {
                sexo = "M";
            }
            c.crearPersona(txtNombre.Text,cbbIdentificacion.SelectedItem.ToString(),txtIdentificacion.Text.Trim(),cbbpais.SelectedItem.ToString(), Convert.ToInt32(txtPermanencia.Text.Trim()),sexo,dateFecha.Value.Date,cbbEstadoCivil.SelectedItem.ToString(), Convert.ToInt32(txtHijos.Text.Trim()),txtDireccion.Text,txtBarrio.Text.Trim(),txtTelefono.Text.Trim(),txtOcupacion.Text.Trim(),cbbEscolaridad.SelectedItem.ToString(),cbbEps.SelectedItem.ToString(),cbbRegimen.SelectedItem.ToString(),txtEmail.Text.Trim(),txtEmergencia.Text.Trim(),txtAntecedentes.Text);
        }
    }
}
