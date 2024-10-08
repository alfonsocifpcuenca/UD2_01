namespace Ejercicios_UD2_1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce los grados grados celsius: ");
            string gradosCelsiusInput = Console.ReadLine();

            decimal gradosCelsius = decimal.Parse(gradosCelsiusInput);

            decimal gradosFahrenheit = (gradosCelsius * 9 / 5) + 32;

            Console.WriteLine($"{gradosCelsius}º celsius son {gradosFahrenheit}º fahrenheit");
        }
    }
}