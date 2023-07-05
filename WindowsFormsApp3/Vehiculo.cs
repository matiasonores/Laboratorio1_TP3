using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class Vehiculo
    {
        public string Tipovehiculo{ get; private set; }
        private int patente;
        private double capacidad;
        private int tipoA;
        private int tipoB;
        private int tipoC;
        public int Patente { get; private set; }
        private double precio;


        public Vehiculo(string vehiculo, int patente, double capacidad, int tipoA, int tipoB, int tipoC  ) 
        {
            this.Patente = patente;
            this.Tipovehiculo = vehiculo;
            this.capacidad = capacidad;
            this.tipoA = tipoA;
            this.tipoB = tipoB;
            this.tipoC = tipoC;
        }
        public void PrecioxPeso() 
        {
            int totalPeso;
            double precioxPeso;
            totalPeso = 5 * tipoA + 15 * tipoB + 30 * tipoC;
            precioxPeso=(totalPeso*2.54);
        }

        public void Cobro() 
        {
            //verificar peso, recargos dependiendo del dia etc

        }

    }
}
