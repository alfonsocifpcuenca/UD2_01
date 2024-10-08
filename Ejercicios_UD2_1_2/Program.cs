namespace Ejercicios_UD2_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numero a comprobar: ");
            string numeroInput = Console.ReadLine();

            int numero = int.Parse(numeroInput);

            if (numero % 2 == 0)
            {
                Console.WriteLine($"El número {numero} es par");
            }
            else
            {
                Console.WriteLine($"El número  {numero} es impar");
            }
        }
    }
}