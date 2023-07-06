using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_2
{
    public class Torneo
    {
        public Competidor[] competidores { get; set; }
        public int cantidadMayores { get; set; }
        public int cantidadMenores { get; set; }
        public int cantCompetidores { get; set; }
        public int cantRondas { get; set; }
        public int rondaActual { get; set; }
        public Competidor[] podio { get; set; }
        public int[] puntajePodio { get; set; }






        public Torneo(int cantRondas)
        {
            competidores = new Competidor[100];
            cantidadMenores = 0;
            cantidadMayores = 0;
            cantCompetidores = 0;
            rondaActual = 0;
            this.cantRondas = cantRondas;
            podio = new Competidor[3];
            //puntajePodio = new int[3];
            //for(int i = 0;i< puntajePodio.Length; i++)
            //{
            //    puntajePodio[i] = 0;
            //}
        }

        //    Los datos se deben
        //   cargar en tiempo real, según orden de inscripción, mostrando en una listBox el nombre
        //   del jugador La cantidad de rondas un numero al azar entre 5 y 10 que se define al iniciar
        //   el torneo
        //   Al finalizar cada ronda se debe informar:
        //   Nombre, puntaje y cantidad de centros del Ganador, Segundo y Tercer puesto


        public void AgregarCompetidor(string nombre,string club,int edad)
        {
            competidores[cantCompetidores] = new Competidor(nombre, edad, club,this.cantRondas);
            if (edad > 18)
            {
                cantidadMayores++;
            } else
            {
                cantidadMenores++;
            }
            cantCompetidores++;
        }

        public void AgregarPuntaje(int competidor, int numerotiro, int puntaje, bool x)
        {
            competidores[competidor].RellenarPuntaje(rondaActual, numerotiro, puntaje, x);
        }

        public void FinalizarRonda()
        {
            Competidor[] ListaOrdenadaCompetidores = OrdenarCopiaCompetidores(competidores);
            podio[0] = ListaOrdenadaCompetidores[0];
            podio[1] = ListaOrdenadaCompetidores[1];
            podio[2] = ListaOrdenadaCompetidores[2];


        }
        public Competidor[] OrdenarCopiaCompetidores(Competidor[] competidores2)
        {
            Competidor[] competidoresCopia = new Competidor[100];

            for (int i = 0; i< cantCompetidores; i++)
            {
                competidoresCopia[i] = competidores2[i];
            }


            for (int i = 0; i < cantCompetidores; i++)
            {
                for (int j = 0; j < cantCompetidores - 1; j++)
                {
                    int puntaje1 = competidoresCopia[j].CalcularPuntaje(cantRondas-1);
                    int puntaje2 = competidoresCopia[j + 1].CalcularPuntaje(cantRondas-1);
                    if (puntaje1 < puntaje2)
                    {
                        Competidor temporal = competidoresCopia[j];
                        competidoresCopia[j] = competidoresCopia[j + 1];
                        competidoresCopia[j + 1] = temporal;
                    }
                    else if (puntaje1 == puntaje2)
                    {
                        if (competidoresCopia[j].ContadorX < competidoresCopia[j + 1].ContadorX)
                        {
                            Competidor temporal = competidoresCopia[j];
                            competidoresCopia[j] = competidoresCopia[j + 1];
                            competidoresCopia[j + 1] = temporal;
                        }

                    }


                }
            }
            return competidoresCopia;
        }
       

    }
}
//int puntaje = competidores[i].CalcularPuntaje(cantRondas);
//for (int j = puntajePodio.Length-1; j<0; j--)
//{
//    if (puntajePodio[j] > puntaje)
//    {
//        puntajePodio[j] = puntaje;
//        podio[j] = competidores[i];
//    } else
//    {

//    }
//}