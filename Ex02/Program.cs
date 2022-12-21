using System;

namespace Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Resposta: ");
            char resposta = Convert.ToChar(Console.ReadLine());
            
            Console.WriteLine(siNo(resposta));
        }

        static bool siNo(char resposta)
        {
            return resposta == 's' || resposta == 'n';
        }
    }
}
