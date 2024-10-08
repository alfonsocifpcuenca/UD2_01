namespace Ejercicios_UD2_1_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un número: ");
            string numeroInput = Console.ReadLine();

            int numero = int.Parse(numeroInput);
            for (int i = 1; i <= numero; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine($"El número {i} es múltiplo de 3");
                }
            }
        }
    }
}