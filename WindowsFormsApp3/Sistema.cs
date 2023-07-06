using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
   class Sistema
   {
      private double costoKg;
      Vehiculo[] multados;
      Vehiculo[] vehiculos;
      int multas;
      int cantidadVehiculos;
      double recargoPeso;
      double recargoDia;

      public Sistema()
      {
         multados = new Vehiculo[20];
         vehiculos = new Vehiculo[100];
         multas=0;
         cantidadVehiculos=0;
         costoKg= 2.54;
      }
      public void CargarVehiculo(string tipo, int patente, double capacidad, int tipoA, int tipoB, int tipoC, bool dia, int minutos)
      {
         Vehiculo vehiculo = new Vehiculo(tipo, patente, capacidad, tipoA, tipoB, tipoC);
         vehiculos[cantidadVehiculos] = vehiculo;
         recargoPeso=CalcularRecargoPeso(vehiculo.Carga,vehiculo.Capacidad);
         recargoDia=VerificarDiaHora(dia, minutos);
         cantidadVehiculos++;
      }

      public double CalcularRecargoPeso(int cargaVehiculo, double capacidadVehiculo)
      {
         int carga = cargaVehiculo;
         double capacidad = capacidadVehiculo;
         double recargo = 0;
         double excesoCarga = carga - capacidad;

         if (excesoCarga > 50)
         {
            recargo = 1.5; //Recargo 50%
            vehiculos[cantidadVehiculos].MultarVehiculo(); //y multa
            multados[multas] = vehiculos[cantidadVehiculos];
            multas++;
         }
         else if (excesoCarga > 10)
         {
            recargo = 1.18; //Recargo 18%
         }
         else if (excesoCarga > -10)
         {
            recargo = 0.95; //Bonificacion 5%
         }
         else if (excesoCarga > -150)
         {
            recargo = 1.07; //Recargo 7%
         }
         else
         {
            recargo = 1.10; //Recargo 10%
         }
         return recargo;
      }

      public double VerificarDiaHora(bool domingo, int minutos)
      {
         double recargo;
         if (minutos < 360 && minutos > 1200)
         {
            recargo = 1.08; //Recargo 8%
            vehiculos[cantidadVehiculos].ValorFijo = true;
         }
         else
         {
            recargo = 0.98; //Bonificacion 2%
         }
         return recargo;
      }

      public double CalcularCosto()
      {
         double costoBase = vehiculos[cantidadVehiculos].Carga * costoKg;
         vehiculos[cantidadVehiculos].Abonar(costoBase);
         return costoBase;
      }
      public string GenerarTicket()
      {
         string ticket="";
         return ticket;
      }
   }
}
