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
      public int TipoA { get; private set; }
      public int TipoB { get; private set; }
      public int TipoC { get; private set; }
      public int Patente { get; private set; }
      public int Carga { get; private set; }
      public bool Multado { get; private set; }
      public bool ValorFijo { get; private set; }
      public double Abona { get; private set; }
      public string FechaRegistro { get; private set; }


      public Vehiculo(string vehiculo, int patente, double capacidad, int tipoA, int tipoB, int tipoC, string fechaRegistro)
      {
         this.Patente = patente;
         this.Tipovehiculo = vehiculo;
         this.Capacidad = capacidad;
         TipoA = tipoA;
         TipoB = tipoB;
         TipoC = tipoC;
         Multado = false;
         ValorFijo = false;
         FechaRegistro = fechaRegistro;
         Carga = DeterminarCarga(TipoA, TipoB, TipoC);
      }

      public int DeterminarCarga(int cantidadA, int cantidadB, int cantidadC)
      {
         Carga = pesoA * cantidadA + pesoB * cantidadB + pesoC * cantidadC;
         return Carga;
      }
      public void MultarVehiculo()
      {
         Multado = true;
      }
      public void AplicarFijo()
      {
         ValorFijo = true;
      }

      public void Abonar(double montoAPagar)
      {
         Abona = montoAPagar;
      }
   }
}
