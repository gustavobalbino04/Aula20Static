using System;

namespace Aula22Static
{
    class Program
    {
        static void Main(string[] args)
        {
            //foregroundColor é usado para modificar a cor no terminal
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Conversor.ConverterRealparaDolar(53));
            Console.WriteLine(Conversor.ConverterDolarparaReal(53));
            Console.WriteLine(Conversor.ConverterRealparaEuro(53));
            Console.WriteLine(Conversor.ConverterEuroparaReal(53));
            Console.ResetColor();

        }
    }
}
