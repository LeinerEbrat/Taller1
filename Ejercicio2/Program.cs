using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad = 0;
            double pulsaciones = 0;
            char op = ' ';

            Console.WriteLine("Selecione su genero");
            Console.WriteLine("1. Masculino");
            Console.WriteLine("2. Femenino");
            Console.WriteLine("Digite (M) Si es Masculino o (F) Si es Femenino");
            op = Char.Parse(Console.ReadLine());

            Console.Write("Digite su edad: ");
            edad = Int32.Parse(Console.ReadLine());

            if (op == 'm' || op == 'M')
            {
                pulsaciones = (210 - edad) / 10d;
            }
            else
            {
                if (op == 'f' || op == 'F')
                {
                    pulsaciones = (220 - edad) / 10d;
                }
            }

            Console.WriteLine($"El numero de pulsasiones por segundo es: {pulsaciones}");
            Console.ReadKey();

        }
    }
}
