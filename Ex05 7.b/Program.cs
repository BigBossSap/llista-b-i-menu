using System;

namespace Ex05_7.b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("num:");
            int num = Convert.ToInt32(Console.ReadLine());

            if (NumReves(num)==num)
                Console.WriteLine("Es capi");
            else
                Console.WriteLine("No es capi");
        }

        static int NumReves(int num)
        {
            int numeroReves = 0;
            while (num != 0)
            {

                
                int digit = num % 10;
                num /= 10;
                numeroReves = numeroReves * 10 + digit;



            }

            return numeroReves;

        }
        


    }
}
