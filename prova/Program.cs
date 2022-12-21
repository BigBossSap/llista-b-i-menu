using System;

namespace Ex30
{
    class Program
    {
        static void Main(string[] args)
        {
            /*30. Fer un programa que demani un número N i escrigui els N primers números
   primers
   */





            int num = 1, cont, i, primers = 0, n;


            Console.WriteLine("n: ");
            n = Convert.ToInt32(Console.ReadLine());

            while (primers < n)
            {
                cont = 1;
                i = 1;
                while (i <= num / 2 && cont < 3)
                {
                    if (num % i == 0)
                        cont++;

                    i++;

                }

                if (cont == 2)
                {
                    Console.WriteLine(num);
                    primers++;



                }
                num++;
            }



        }
    }
}