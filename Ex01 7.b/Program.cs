using System;

namespace Ex01_7.b
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("num");
            num = Convert.ToInt32(Console.ReadLine());
            ArrelSuma(num);
          
        }


        static void ArrelSuma(int num)
        {
            
            int i = 1;

            while (i * i <= num)
            {




                i++;
            }

            Console.WriteLine(i - 1);

            
        }

    }
}
