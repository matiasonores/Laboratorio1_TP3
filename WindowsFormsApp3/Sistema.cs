using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class Sistema
    {
        private double costoKg;
        private Vehiculo[] multados;
        private Vehiculo[] vehiculos;
        private int multas;
        private int cantidadVehiculos;
        private double recargoPeso;
        private double recargoDia;
        private double valorMulta;
        private double valorFijo;
        private bool nuevoMultado;

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
       
        public bool CargarVehiculo(string tipo, int patente, double capacidad, int tipoA, int tipoB, int tipoC, bool dia, int minutos, string fechaRegistro)
        {
            bool multado = false;
            Vehiculo vehiculo = new Vehiculo(tipo, patente, capacidad, tipoA, tipoB, tipoC, fechaRegistro);
            vehiculos[cantidadVehiculos] = vehiculo;
            recargoPeso = CalcularRecargoPeso(vehiculo.Carga, vehiculo.Capacidad);
            if (nuevoMultado)
            {
                multado = true;
                //OrdenarMultados();
                nuevoMultado = false;
            }
            recargoDia = VerificarDiaHora(dia, minutos);
            CalcularCosto();
            cantidadVehiculos++;

            return multado;
        }
        public Vehiculo[] Multados
        {
            get { return this.multados; }
        }
        public bool VerificarExistenciaPatente(int patente)
        {
            bool Encontrado = false;
            foreach (Vehiculo j in vehiculos)
            {
                if (j != null)
                {

                if (j.Patente == patente)
                {
                    Encontrado = true;
                }
                }
            }
            return Encontrado;
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
                if (domingo)
                {
                    vehiculos[cantidadVehiculos].AplicarFijo();
                }
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
            int cant = cantidadVehiculos -1;
            string patente = "Patente: " + vehiculos[cant].Patente.ToString();
            string tipo = "Tipo: " + vehiculos[cant].Tipovehiculo.ToString();
            string paquetes = "Paquetes tipo A: " + vehiculos[cant].TipoA.ToString() +
                              "\nPaquetes tipo B: " + vehiculos[cant].TipoB.ToString() +
                              "\nPaquetes tipo C: " + vehiculos[cant].TipoC.ToString();
            string capacidad = "Capacidad: " + vehiculos[cant].Capacidad.ToString();
            string carga = "Carga: " + vehiculos[cant].Carga.ToString();
            string abona = "Abona: " + vehiculos[cant].Abona.ToString();

            string ticket = patente + "\n" + tipo + "\n" + paquetes + "\n" + capacidad + "\n" + carga + "\n" + abona;

            return ticket;
        }

        public static void OrdenarMultados(Vehiculo[] multados)
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

        public static int BuscarMultado(string patente, Vehiculo[] multados)
        {
            int multado = 0;
            bool Encontrado = false;
            while(Encontrado == false)
            {
                if (multados[multado].Patente.ToString() == patente)
                {
                    Encontrado = true;
                }
                else
                {
                    multado++;
                }
                if (multado == multados.Length)
                {
                    multado = -1;
                    Encontrado = true;
                }

            }
            return multado;
        }

        public static string GenerarResumenMulta(int multado, Vehiculo[] multados)
        {
            string dia = "Fecha de registro: " + multados[multado].FechaRegistro.ToString();
            string pat = "Patente: " + multados[multado].Patente.ToString();
            string tipo = "Tipo: " + multados[multado].Tipovehiculo.ToString();
            string abona = "Abona: " + multados[multado].Abona.ToString();

            string resumen = dia + "\n" + pat + "\n" + tipo + "\n" + abona;

            return resumen;
        }


        public Vehiculo[] GenerarArrayNuevoMultas()
        {
            int cont = 0;
            for (int i = 0; i < Multados.Length; i++)
            {
                if (Multados[i] != null)
                {
                    cont++;
                }
            }
            Vehiculo[] vehiculos= new Vehiculo[cont];
            int contaux = 0;
            for (int i = 0; i < Multados.Length; i++)
            {
                if (Multados[i] != null)
                {
                    vehiculos[contaux] = Multados[i];
                    contaux++;
                }
            }
            return vehiculos;

        }
    }
}
