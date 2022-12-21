using System;

namespace Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nota: ");
            int nota = int.Parse(Console.ReadLine());
            Console.WriteLine(NotaValid(nota));


           
        }

        static bool NotaValid(int nota)
        {
            return (!(nota > 10 || nota < 0));
        }

       
    }
}
