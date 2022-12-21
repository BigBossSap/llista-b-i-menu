using System;

namespace Ex08_Llista7b
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.WriteLine("num1: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("num2: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine(Euclides(num1,num2));
          

            
        }

        static int Euclides(int num1, int num2)
        {
            int a = Math.Max(num1, num2);
            int b = Math.Min(num1, num2);
            int residu = 0;
            while (b != 0)
            {
                residu = a % b;

                a = b;
                b = residu;

            }


            

            return a;
        }
    }
}
