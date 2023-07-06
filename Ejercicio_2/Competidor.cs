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
        private string[,] TirosAl10;


        public Competidor(string nombre, int edad, string club, int rondas)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.club = club;
            this.puntaje = new int[rondas, 5];
            this.TirosAl10 = new string[rondas, 5];
        }

        public string Nombre { get { return nombre; } } 
        public string Club { get { return club; } }
        public int Edad { get { return edad; } }
        public int[,] Puntaje { get { return puntaje; } }

        public void RellenarPuntaje(int ronda, int numerotiro, int puntaje, bool x) {
            Puntaje[ronda,numerotiro] = puntaje;
            if (puntaje == 10 && x == true)
            {
                TirosAl10[ronda, numerotiro] = "X";
            }
        }

    }
}
