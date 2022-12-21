using System;

namespace menu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Maxim(81, 70));
            Console.WriteLine(MaximComuDivisor(26, 28));
            Console.WriteLine(MinimComuMultilpe(36, 29));
            Console.WriteLine(Factorial(10));
            Console.WriteLine(Combinatoria(7, 3));
            Console.WriteLine(MostrarDivisorMajor(28));
            Console.WriteLine(EsPrimer(3));
            NPrimersPrimers(8);

        }


        static int Maxim(int num1, int num2)
        {
            return Math.Max(num1, num2);
        }

        static int MaximComuDivisor(int num1, int num2)
        {
            int i = 1;
            int mcd = 0;
            while (i <= num1 && i <= num2)


            {
                if (num1 % i == 0 && num2 % i == 0)

                    mcd = i;



                i++;

            }

            return mcd;
        }

        static int MinimComuMultilpe(int num1, int num2)
        {
            int i = 1;
            int mcd = 0;
            int mcm = 0;
            while (i <= num1 && i <= num2)


            {
                if (num1 % i == 0 && num2 % i == 0)
                {

                    mcd = i;
                    mcm = (num1 * num2 / mcd);
                }




                i++;

            }
            return mcm;
        }

        static int Factorial(int num)
        {
            int factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }

            return factorial;
        }

        static int Combinatoria(int n, int k)
        {
            n = Math.Max(n, k);
            k = Math.Min(n, k);
            int combinatoria = Factorial(n) / (Factorial(k) * Factorial(n - k));



            return combinatoria;
        }

        static int MostrarDivisorMajor(int num1)
        {

            int divisor = 0, maximDivisor = int.MinValue;
            for (int i = 1; i < num1; i++)
            {

                if (num1 % i == 0)
                {
                    divisor = i;
                }

                if (divisor > maximDivisor)
                {
                    maximDivisor = divisor;

                }
            }


            return maximDivisor;



        }

        static bool EsPrimer(int num1)
        {
            int cont = 0, i = 1;

            while (i <= num1)
            {
                if (num1 % i == 0)
                    cont++;

                i++;
            }

            return (cont == 2);


        }

        static void NPrimersPrimers(int num)
        {
            int numero = 1, cont, i, primers = 0;




            while (primers < num)
            {
                cont = 1;
                i = 1;
                while (i <= numero / 2 && cont < 3)
                {
                    if (numero % i == 0)
                        cont++;

                    i++;

                }

                if (cont == 2)
                {
                    Console.Write(numero+ " ");
                    primers++;



                }
                numero++;
            }

        }
    }

}
