using Control;
using System;
using System.Collections;
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
    public partial class Reporte : Form
    {
        public Reporte()
        {
            InitializeComponent();
            cargarGraficaImc();
        }
        void cargarGraficaImc() {
            ArrayList imc = new ArrayList();
            ArrayList cantidad = new ArrayList();
            CargarGraficaControl c = new CargarGraficaControl();
            imc = c.imc();
            cantidad = c.datoimc();
            chartImc.Series[0].Points.DataBindXY(imc, cantidad);
        }

        private void BtnAcceder_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
