using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control;

namespace Vista
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void TxtUsuario_Enter(object sender, EventArgs e)
        {

            if (txtUsuario.Text.Equals("USUARIO")){
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
            }
                
        }

        private void TxtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals(""))
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void TxtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text.Equals("CONTRASEÑA"))
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.LightGray;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void TxtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text.Equals(""))
            {
                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.ForeColor = Color.DimGray;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnAcceder_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "USUARIO")
            {
                if (txtContraseña.Text != "CONTRASEÑA")
                {
                    ValidarLoginControl c = new ValidarLoginControl();
                    if (c.validarLogin(txtUsuario.Text, txtContraseña.Text))
                    {
                        Inicio i = new Inicio();
                        this.Hide();
                        i.Show();
                    }
                    else {
                        mensajeError("Usuario y contraseña invalidos");
                    }
                }
                else {
                    mensajeError("ingrese una contraseña al campo");
                }
            }
            else {
                mensajeError("ingrese un usuario al campo");
            }
           
            
        }
        void mensajeError(string mensaje) {
            lblerror.Text = "          " + mensaje;
            lblerror.Visible = true;

        }
        private void Lblerror_Click(object sender, EventArgs e)
        {

        }
    }
}
