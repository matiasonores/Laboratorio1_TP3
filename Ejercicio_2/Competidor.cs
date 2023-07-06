using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    public class Competidor
    {
        private string nombre;
        private string club;
        private int edad;
        private int[,] puntaje;
        private int contadorX;


        public Competidor(string nombre, int edad, string club, int rondas)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.club = club;
            this.puntaje = new int[rondas, 5];
            this.contadorX = 0;
            for (int i = 0; i < rondas; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    puntaje[i, j] = 0;
                }
            }
        }

        public string Nombre { get { return nombre; } } 
        public string Club { get { return club; } }
        public int Edad { get { return edad; } }
        public int ContadorX { get { return contadorX; } }

        public int[,] Puntaje { get { return puntaje; } }

        public void RellenarPuntaje(int ronda, int numerotiro, int puntaje, bool x) {
            Puntaje[ronda,numerotiro] = puntaje;
            if (puntaje == 10 && x == true)
            {
                contadorX++;
            }
        }

        public int CalcularPuntaje(int rondas)
        {
            int puntos = 0;
            for(int i = 0; i < rondas; i++)
            {
                for(int j = 0; j<5; j++)
                {
                    puntos += puntaje[i, j];
                }
            }
            return puntos;
        }

    }
}
