using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    public class Torneo
    {
        Competidor[] competidores;
        int CantidadMayores = 0;
        int CantidadMenores = 0;
        int CantCompetidores = 0;
        int CantRondas;
        int RondaActual = 0;

        public Torneo(int cantRondas)
        {
            competidores = new Competidor[100];
            cantRondas = cantRondas;
        }

        public void AgregarCompetidor(string nombre,string club,int edad)
        {
            competidores[CantCompetidores] = new Competidor(nombre, edad, club,this.CantRondas);
        }

    }
}
