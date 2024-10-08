namespace Ejercicios_UD2_1_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Tabla del {i}");
                Console.WriteLine($"______________");
                for (int u = 1; u <= 10; u++)
                {
                    Console.WriteLine($"{i} * {u} = {(i*u)}");
                }
            }
        }
    }
}