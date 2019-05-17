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
            pordefecto();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAcceder_Click(object sender, EventArgs e)
        {
            borrarError();
            if (validarCampos()) {
                CrearPersonaControl c = new CrearPersonaControl();
                String sexo;
                sexo = "";
                if (rbF.Checked)
                {
                    sexo = "F";
                }
                else
                {
                    sexo = "M";
                }
                try
                {
                    c.crearPersona(txtNombre.Text, cbbIdentificacion.SelectedItem.ToString(), txtIdentificacion.Text.Trim(), cbbpais.SelectedItem.ToString(), Convert.ToInt32(txtPermanencia.Text.Trim()), sexo, dateFecha.Value.Date, cbbEstadoCivil.SelectedItem.ToString(), Convert.ToInt32(txtHijos.Text.Trim()), txtDireccion.Text, txtBarrio.Text.Trim(), txtTelefono.Text.Trim(), txtOcupacion.Text.Trim(), cbbEscolaridad.SelectedItem.ToString(), cbbEps.SelectedItem.ToString(), cbbRegimen.SelectedItem.ToString(), txtEmail.Text.Trim(), txtEmergencia.Text.Trim(), txtAntecedentes.Text);
                    MessageBox.Show("Usuario creado con exito " , "Exito", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch (Exception exep) {
                    MessageBox.Show("Error de tipo "+exep,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                

            }
       
        }
        bool validarCampos() {
            bool validar;
            validar = true;
            if (txtAntecedentes.Text == "") {
                validar = false;
                errorProvider1.SetError(txtAntecedentes,"Ingrese campo");
            }
            if (txtBarrio.Text == "")
            {
                validar = false;
                errorProvider1.SetError(txtBarrio, "Ingrese campo");
            }
            if (txtDireccion.Text == "")
            {
                validar = false;
                errorProvider1.SetError(txtDireccion, "Ingrese campo");
            }
            if(txtEmail.Text == "")
            {
                validar = false;
                errorProvider1.SetError(txtEmail, "Ingrese campo");
            }
            if (txtEmergencia.Text == "")
            {
                validar = false;
                errorProvider1.SetError(txtEmergencia, "Ingrese campo");
            }
            if (txtHijos.Text == "")
            {
                validar = false;
                errorProvider1.SetError(txtHijos, "Ingrese campo");
            }
            if (txtIdentificacion.Text == "")
            {
                validar = false;
                errorProvider1.SetError(txtIdentificacion, "Ingrese campo");
            }
            if (txtNombre.Text == "")
            {
                validar = false;
                errorProvider1.SetError(txtNombre, "Ingrese campo");
            }
            if (txtOcupacion.Text == "")
            {
                validar = false;
                errorProvider1.SetError(txtOcupacion, "Ingrese campo");
            }
            if (txtPermanencia.Text == "")
            {
                validar = false;
                errorProvider1.SetError(txtPermanencia, "Ingrese campo");
            }
            if (txtTelefono.Text == "")
            {
                validar = false;
                errorProvider1.SetError(txtTelefono, "Ingrese campo");
            }
            return validar;   
        }
        void borrarError() {
            errorProvider1.SetError(txtAntecedentes, "");
            errorProvider1.SetError(txtBarrio, "");
            errorProvider1.SetError(txtDireccion, "");
            errorProvider1.SetError(txtEmail, "");
            errorProvider1.SetError(txtEmergencia, "");
            errorProvider1.SetError(txtHijos, "");
            errorProvider1.SetError(txtIdentificacion, "");
            errorProvider1.SetError(txtNombre, "");
            errorProvider1.SetError(txtOcupacion, "");
            errorProvider1.SetError(txtPermanencia, "");
            errorProvider1.SetError(txtTelefono, "");
        }

        private void TxtPermanencia_Validating(object sender, CancelEventArgs e)
        {
            int num;
            if (!int.TryParse(txtPermanencia.Text, out num)) {

                errorProvider1.SetError(txtPermanencia, "Ingrese campo correcto");
            }
            else {
                errorProvider1.SetError(txtPermanencia, "");
            }

        }

        private void TxtHijos_Validating(object sender, CancelEventArgs e)
        {
            int num;
            if (!int.TryParse(txtHijos.Text, out num))
            {

                errorProvider1.SetError(txtHijos, "Ingrese campo correcto");
            }
            else
            {
                errorProvider1.SetError(txtHijos, "");
            }
        }
        void pordefecto() {
            cbbEps.SelectedIndex = 0;
            cbbEscolaridad.SelectedIndex = 0;
            cbbEstadoCivil.SelectedIndex = 0;
            cbbIdentificacion.SelectedIndex = 0;
            cbbpais.SelectedIndex = 0;
            cbbRegimen.SelectedIndex = 0;
            rbM.Checked = true;
        }
    }
}
