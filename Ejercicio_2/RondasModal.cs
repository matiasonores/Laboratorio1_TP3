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
   public partial class RondasModal : Form
   {
      Torneo torneo;

      public RondasModal(Torneo torneo)
      {
         this.torneo = torneo;
         InitializeComponent();
         torneo.rondaActual = 1;
         button1.Text = "Comenzar Ronda: " + torneo.rondaActual;
      }

      private void button1_Click(object sender, EventArgs e)
      {
         CargarDatos datos = new CargarDatos();

         for (int i = 0; i < torneo.cantCompetidores; i++)
         {
            for (int j = 0; j < 5; j++)
            {
               datos.Text = "Ronda " + torneo.rondaActual + " Competidor: " + torneo.competidores[i].Nombre + " Tiro: " + (j + 1);
               datos.StartPosition = FormStartPosition.CenterParent;
               datos.ShowDialog();
               if (datos.DialogResult == DialogResult.OK)
               {
                  torneo.competidores[i].RellenarPuntaje(torneo.rondaActual - 1, j, datos.puntaje, datos.XChecked);
               }
            }
         }
         torneo.FinalizarRonda();
         lbPodio.Items.Clear();
         lbPodio.Items.Add("Primera Posicion: " + torneo.podio[0].Nombre + " Con un Puntaje: " + torneo.podio[0].CalcularPuntaje(torneo.cantRondas - 1));
         lbPodio.Items.Add("Segunda Posicion: " + torneo.podio[1].Nombre + " Con un Puntaje: " + torneo.podio[1].CalcularPuntaje(torneo.cantRondas - 1));
         if (torneo.cantCompetidores > 2)
         {
            lbPodio.Items.Add("Tercera Posicion: " + torneo.podio[2].Nombre + " Con un Puntaje: " + torneo.podio[2].CalcularPuntaje(torneo.cantRondas - 1));
         }
         torneo.rondaActual++;
         if (torneo.rondaActual <= torneo.cantRondas)
         {

            button1.Text = "Comenzar Ronda: " + torneo.rondaActual;
            labelRonda.Text = torneo.rondaActual.ToString();
         }
         else
         {
            button1.Enabled = false;
            btnSalirRondas.Enabled = true;
            LabelGanadores.Text = "Ganadores finales: ";
         }
      }
   }
}
