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
    }
}
