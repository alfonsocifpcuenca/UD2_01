namespace Ejercicios_UD2_1_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un número: ");
            string numeroInput = Console.ReadLine();

            bool esPrimo = true;
            int numero = int.Parse(numeroInput);
            for (int i = 2; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    esPrimo = false;
                    break;
                }
            }

            if (esPrimo)
            {
                Console.WriteLine($"El número {numero} es primo");
            } 
            else
            {
                Console.WriteLine($"El número {numero} no es primo");
            }
        }
    }
}