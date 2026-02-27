using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tarifaPorHora = 1.50;
            double horas;
            double total;

            Console.WriteLine("===== SISTEMA DE PARQUEO =====");

            Console.Write("Ingrese hora de entrada (ejemplo 8.5 = 8:30): ");
            double horaEntrada = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese hora de salida (ejemplo 14.5 = 14:30): ");

            double horaSalida = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Error: la hora de salida debe ser mayor que la de entrada.");
            if (horaSalida <= horaEntrada)
            {
                Console.WriteLine("Error: la hora de salida debe ser mayor que la de entrada.");
            }
            else
            {
                horas = horaSalida - horaEntrada;
                total = horas * tarifaPorHora;

                Console.WriteLine("\nTiempo total: " + horas + " horas");
                Console.WriteLine("Tarifa por hora: $" + tarifaPorHora);
                Console.WriteLine("TOTAL A PAGAR: $" + total);
            }

            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadKey();
            cambio1
        }

    }
}
