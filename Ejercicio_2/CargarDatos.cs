using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_2
{
    public partial class CargarDatos : Form
    {
       public int puntaje;
       public bool XChecked;
        public CargarDatos()
        {
            InitializeComponent();
            puntaje = 0;
            XChecked = false;
        }

        private void btnAgregarPuntaje_Click(object sender, EventArgs e)
        {
            int puntaje = -1;
            if (rb0.Checked)
            {
                puntaje = 0;
            } else if(rb1.Checked)
            {
                puntaje = 1;
            }
            else if (rb2.Checked)
            {
                puntaje = 2;
            }
            else if (rb3.Checked)
            {
                puntaje = 3;
            }
            else if (rb4.Checked)
            {
                puntaje = 4;
            }
            else if (rb5.Checked)
            {
                puntaje = 5;
            }
            else if (rb6.Checked)
            {
                puntaje = 6;
            }
            else if (rb7.Checked)
            {
                puntaje = 7;
            }
            else if (rb8.Checked)
            {
                puntaje = 8;
            }
            else if (rb9.Checked)
            {
                puntaje = 9;
            }
            else if (rb10.Checked)
            {
                puntaje = 10;
                bool Xchecked = checkX.Checked;
               this.XChecked = Xchecked;
            }
            this.puntaje = puntaje;
            
        }

        private void rb10_CheckedChanged(object sender, EventArgs e)
        {
            if (rb10.Checked)
            {
                checkX.Enabled = true;
            } else
            {
                checkX.Enabled = false;
                checkX.Checked = false;
            }
        }
    }
}
