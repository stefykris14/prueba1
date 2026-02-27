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
        }
    }
}
