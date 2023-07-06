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
      double valorMulta;
      double valorFijo;
      bool nuevoMultado;

      public Sistema()
      {
         multados = new Vehiculo[20];
         vehiculos = new Vehiculo[100];
         multas = 0;
         cantidadVehiculos = 0;
         costoKg = 2.54;
         valorMulta = 5000;
         valorFijo = 3500;
         nuevoMultado = false;

      }
      public void CargarVehiculo(string tipo, int patente, double capacidad, int tipoA, int tipoB, int tipoC, bool dia, int minutos, string fechaRegistro)
      {
         Vehiculo vehiculo = new Vehiculo(tipo, patente, capacidad, tipoA, tipoB, tipoC, fechaRegistro);
         vehiculos[cantidadVehiculos] = vehiculo;
         recargoPeso = CalcularRecargoPeso(vehiculo.Carga, vehiculo.Capacidad);
         if (nuevoMultado)
         {
            OrdenarMultados();
            nuevoMultado = false;
         }
         recargoDia = VerificarDiaHora(dia, minutos);
         CalcularCosto();
         GenerarTicket();
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
            nuevoMultado = true;
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
            vehiculos[cantidadVehiculos].AplicarFijo();
         }
         else
         {
            recargo = 0.98; //Bonificacion 2%
         }
         return recargo;
      }

      public void CalcularCosto()
      {
         double costoFinal = 0;
         double costoBase = vehiculos[cantidadVehiculos].Carga * costoKg; //100
         double costoConPeso = costoBase * recargoPeso;                   //150
         double costoConDia = costoConPeso * recargoDia;                  //150*1.08 (+8%)
         costoFinal += costoConDia;                                       //162
         if (vehiculos[cantidadVehiculos].Multado)
         {
            costoFinal = valorMulta;                                      //+5000
         }
         if (vehiculos[cantidadVehiculos].ValorFijo)
         {
            costoFinal += valorFijo;                                      //+3500
         }
         vehiculos[cantidadVehiculos].Abonar(costoFinal);
      }
      public string GenerarTicket()
      {

         string patente = "Patente: " + vehiculos[cantidadVehiculos].Patente.ToString();
         string tipo = "Tipo: " + vehiculos[cantidadVehiculos].Tipovehiculo.ToString();
         string paquetes = "Paquetes tipo A: " + vehiculos[cantidadVehiculos].TipoA.ToString() +
                           "Paquetes tipo B: " + vehiculos[cantidadVehiculos].TipoB.ToString() +
                           "Paquetes tipo C: " + vehiculos[cantidadVehiculos].TipoC.ToString();
         string capacidad = "Capacidad: " + vehiculos[cantidadVehiculos].Capacidad.ToString();
         string carga = "Carga: " + vehiculos[cantidadVehiculos].Carga.ToString();
         string abona = "Abona: " + vehiculos[cantidadVehiculos].Abona.ToString();

         string ticket = patente + "\n" + tipo + "\n" + paquetes + "\n" + capacidad + "\n" + carga + "\n" + abona;

         return ticket;
      }

      public void OrdenarMultados()
      {
         int n = multados.Length;
         Vehiculo vehiculoTemp = null;
         for (int i = 0; i < n - 1; i++)
         {
            for (int j = 0; j < n - i - 1; j++)
            {
               if (multados[j].Patente > multados[j + 1].Patente)
               {
                  vehiculoTemp = multados[j];
                  multados[j] = multados[j + 1];
                  multados[j + 1] = vehiculoTemp;
               }
            }
         }

      }

      public int BuscarMultado(string patente)
      {
         int multado = 0;
         for (int i = 0; i < multados.Length; i++)
         {
            if (multados[i].Patente.ToString() == patente)
            {
               multado = i;
            }
            else
            {
               multado = -2;
            }
         }
         return multado;
      }

      public string GenerarResumenMulta(int multado)
      {
         string dia = "Fecha de registro: " + multados[multado].FechaRegistro.ToString();
         string pat = "Patente: " + multados[multado].Patente.ToString();
         string tipo = "Tipo: " + multados[multado].Tipovehiculo.ToString();
         string abona = "Abona: " + multados[multado].Abona.ToString();

         string resumen = dia + "\n" + pat + "\n" + tipo + "\n" + abona;

         return resumen;
      }
   }
}
