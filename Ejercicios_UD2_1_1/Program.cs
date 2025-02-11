﻿namespace Ejercicios_UD2_1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Año de nacimiento: ");
            string anoNacimientoInput = Console.ReadLine();

            int anoNacimiento;
            if (int.TryParse(anoNacimientoInput, out anoNacimiento) == false)
            { 
                Console.WriteLine("El año introducido es incorrecto.");
                return;            
            }

            Console.WriteLine("Año actual: ");
            string anoActualInput = Console.ReadLine();

            int anoActual;
            if (int.TryParse(anoActualInput, out anoActual) == false)
            {
                Console.WriteLine("El año actual es incorrecto.");
                return;
            }

            int edad = CalcularEdad(anoNacimiento, anoActual);

            Console.WriteLine($"Una persona nacida en {anoNacimiento} tendrá en {anoActual} {edad} años");            
        }

        static int CalcularEdad(int miAnoNacimiento, int miAnoActual) 
        {
            int edad = miAnoActual - miAnoNacimiento;

            return edad;
        }
    }
}