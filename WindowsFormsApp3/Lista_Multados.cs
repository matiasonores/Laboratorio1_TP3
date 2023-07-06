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
    public partial class Lista_Multados : Form
    {
        Vehiculo[] multados;
        public Lista_Multados(Vehiculo[] multados)
        {
            InitializeComponent();
            this.multados = multados;
            Sistema.OrdenarMultados(this.multados);
        }

        private void lbMultas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string patente = lbMultas.SelectedItem.ToString();
            int indexMultado = Sistema.BuscarMultado(patente, this.multados);
            if (indexMultado == -1)
            {
                MessageBox.Show("No se encontro la Multa");

            } else
            {

            string resumen = Sistema.GenerarResumenMulta(indexMultado, this.multados);
            MessageBox.Show(resumen);
            }
        }
    }
}
