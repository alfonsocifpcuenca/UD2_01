namespace Ejercicios_UD2_1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Año de nacimiento: ");
            string anoNacimientoInput = Console.ReadLine();

            Console.WriteLine("Año actual: ");
            string anoActualInput = Console.ReadLine();

            int anoNacimiento = int.Parse(anoNacimientoInput);
            int anoActual = int.Parse(anoActualInput);

            Console.WriteLine($"Una persona nacida en {anoNacimiento} tendrá en {anoActual} {(anoActual - anoNacimiento)} años");            
        }
    }
}