using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Vehiculo[] multado = new Vehiculo[20];
        

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string vehiculo="";
            if (rBFurgon.Checked) 
            {
                vehiculo = "Furgon";
            }
            if (rBCamion.Checked )
            {
                vehiculo = "Camion";
            }
            int patente = Convert.ToInt32(txtPatente.Text);
            double capacidad = Convert.ToDouble(txtCapacidad.Text);
            string dia = (txtDias.Text);
            int tipoA = Convert.ToInt32(numPaquetesA);
            int tipoB = Convert.ToInt32(numPaquetesB);
            int tipoC = Convert.ToInt32(numPaquetesC);

            Vehiculo transporte = new Vehiculo(vehiculo, patente, capacidad, tipoA, tipoB, tipoC);

        }
    }
}
