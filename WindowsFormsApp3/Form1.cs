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
            this.Text = "Tp3 Laboratorio";
        }
      Sistema sistema = new Sistema();

      private void btnAgregar_Click(object sender, EventArgs e)
        {
         int patente = Convert.ToInt32(txtPatente.Text);
            bool existe = sistema.VerificarExistenciaPatente(patente);
            if (existe == true)
            {
                MessageBox.Show("Ya tenemos un vehiculo con esa patente registrado");
            } else
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
            bool domingo_feriado = false;
            if (rBEspeciales.Checked)
            {
                domingo_feriado = true;

            }
         double capacidad = Convert.ToDouble(txtCapacidad.Text);
         string dia = (txtDias.Text);
         int tipoA = Convert.ToInt32(numPaquetesA.Value);
         int tipoB = Convert.ToInt32(numPaquetesA.Value);
         int tipoC = Convert.ToInt32(numPaquetesA.Value);
         int minutos = Convert.ToInt32(numHr.Value) * 60;
         minutos += Convert.ToInt32(numMin.Value);
         string fechaRegistro = dia;
         bool multa = sistema.CargarVehiculo(vehiculo, patente, capacidad, tipoA, tipoB, tipoC, domingo_feriado, minutos, fechaRegistro);
         string ticket = sistema.GenerarTicket();

         MessageBox.Show(ticket);
            }
            

        }

        private void btnFinalizarDia_Click(object sender, EventArgs e)
        {
            ConfirmacionFinalizacion confirmacion = new ConfirmacionFinalizacion();
            confirmacion.ShowDialog();
            if (confirmacion.DialogResult == DialogResult.OK)
            {
                Vehiculo[] multas = this.sistema.GenerarArrayNuevoMultas();
                if (multas.Length > 0)
                {

                Lista_Multados listamultados = new Lista_Multados(multas);
                foreach(Vehiculo i in multas)
                    {
                        listamultados.lbMultas.Items.Add(i.Patente.ToString());
                    }
                listamultados.ShowDialog();
                } else
                {
                    MessageBox.Show("No existen Multas");
                }
                this.Close();
            }
        }
    }
}
