namespace Ejercicios_UD2_1_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un número: ");
            string numeroInput = Console.ReadLine();

            int numero = int.Parse(numeroInput);
            
            int resultado = 0;
            int incremento = 0;
            while (incremento <= numero)
            {
                resultado += incremento;
                incremento++;
            }

            Console.WriteLine($"La suma de todos los numeros desde 0 hasta {numero} es {resultado}");
        }
    }
}