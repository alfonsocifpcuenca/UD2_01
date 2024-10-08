namespace Ejercicios_UD2_1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el primer número: ");
            string numeroUnoInput = Console.ReadLine();

            Console.WriteLine("Introduce el segundo número: ");
            string numeroDosInput = Console.ReadLine();

            Console.WriteLine("Introduce el tercer número: ");
            string numeroTresInput = Console.ReadLine();

            int numeroUno = int.Parse(numeroUnoInput);
            int numeroDos = int.Parse(numeroDosInput);
            int numeroTres = int.Parse(numeroTresInput);

            if (numeroUno == numeroDos && numeroUno == numeroTres)
            {
                Console.WriteLine("Los tres números son iguales");
            } 
            else if (numeroUno >= numeroDos && numeroUno >= numeroTres)
            {
                Console.WriteLine("El primer número es el mayor");
            } 
            else if (numeroDos >= numeroUno && numeroDos >= numeroTres)
            {
                Console.WriteLine("El segundo número es el mayor");
            }
            else
            {
                Console.WriteLine("El tercer número es el mayor");
            }

            if (numeroUno != numeroDos || numeroUno != numeroTres)
            {
                if (numeroUno <= numeroDos && numeroUno <= numeroTres)
                {
                    Console.WriteLine("El primer número es el menor");
                }
                else if (numeroDos <= numeroUno && numeroDos <= numeroTres)
                {
                    Console.WriteLine("El segundo número es el menor");
                }
                else
                {
                    Console.WriteLine("El tercer número es el menor");
                }
            }
        }
    }
}