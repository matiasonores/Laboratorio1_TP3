using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
   class Vehiculo
   {
      private int pesoA = 5; //Constante de peso A
      private int pesoB = 15; //Constante de peso A
      private int pesoC = 30; //Constante de peso A
      public string Tipovehiculo { get; private set; }
      public double Capacidad { get; private set; }
      private int tipoA;
      private int tipoB;
      private int tipoC;
      public int Patente { get; private set; }
      public int Carga { get; private set; }
      
      bool multado;
      public bool ValorFijo { get; set; }
      public double Abona { get; private set; }


      public Vehiculo(string vehiculo, int patente, double capacidad, int tipoA, int tipoB, int tipoC)
      {
         this.Patente = patente;
         this.Tipovehiculo = vehiculo;
         this.Capacidad = capacidad;
         this.tipoA = tipoA;
         this.tipoB = tipoB;
         this.tipoC = tipoC;
         multado = false;
         ValorFijo = false;
         Carga = DeterminarCarga(tipoA,tipoB,tipoC);
      }

      public int DeterminarCarga(int cantidadA, int cantidadB, int cantidadC)
      {
         Carga = pesoA * cantidadA + pesoB * cantidadB + pesoC * cantidadC;
         return Carga;
      }
      public void MultarVehiculo() //Alternativa a plantear una propiedad
      {
         multado = true;
      }

      public void Abonar(double montoAPagar)
      {
         Abona = montoAPagar;
      }
   }
}
