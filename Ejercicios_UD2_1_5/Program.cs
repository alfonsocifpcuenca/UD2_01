namespace Ejercicios_UD2_1_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el operador uno: ");
            string operadorUnoInput = Console.ReadLine();

            Console.WriteLine("Intoruce el operador dos: ");
            string operadorDosInput = Console.ReadLine();

            Console.WriteLine("Introduce la operación [+, -, *, /]: ");
            string operacion = Console.ReadLine();

            int operadorUno = int.Parse(operadorUnoInput);
            int operadorDos = int.Parse(operadorDosInput);

            float resultado = 0f;
            switch (operacion)
            {
                case "+":
                    resultado = operadorUno + operadorDos;
                    break;
                case "-":
                    resultado = operadorUno - operadorDos;
                    break;
                case "/":
                    resultado = operadorUno / operadorDos;
                    break;
                case "*":
                    resultado = operadorUno * operadorDos;
                    break;
            }

            Console.WriteLine($"{operadorUno} {operacion} {operadorDos} = {resultado}");
        }
    }
}