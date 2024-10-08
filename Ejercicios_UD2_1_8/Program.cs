namespace Ejercicios_UD2_1_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un número: ");
            string numeroInput = Console.ReadLine();

            int numero = int.Parse(numeroInput);

            int resultado = 1;
            for (int i = numero; i > 0; i--)
            {
                resultado *= i;
            }

            Console.WriteLine($"El factorial de {numero} es {resultado}");
        }
    }
}