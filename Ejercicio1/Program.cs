using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int nota1 = 0, nota2 = 0, nota3 = 0;
            float promedio = 0;
            Console.Write("Digite la primera nota: ");
            nota1 = Int32.Parse(Console.ReadLine());
            Console.Write("Digite la segunda nota: ");
            nota2 = Int32.Parse(Console.ReadLine());
            Console.Write("Digite la tercera nota: ");
            nota3 = Int32.Parse(Console.ReadLine());

            promedio = (nota1 + nota2 + nota3) / 3f;

            Console.WriteLine($"Su promedio es: {promedio}");
            Console.ReadKey();
        }
    }
}
