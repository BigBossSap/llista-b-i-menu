using System;
using System.Data.SqlTypes;
using System.Threading;
using System.Xml;

namespace menu
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Maxim(81, 70));
            //Console.WriteLine(MaximComuDivisor(26, 28));
            //Console.WriteLine(MinimComuMultilpe(36, 29));
            //Console.WriteLine(Factorial(10));
            //Console.WriteLine(Combinatoria(7, 3));
            //Console.WriteLine(MostrarDivisorMajor(28));
            //Console.WriteLine(EsPrimer(3));
            //NPrimersPrimers(8);
            
            Console.WindowWidth = 80;

            string num = Menu();
            Console.Clear();
            do
            {

                

                switch (num)
                {
                    case "1":
                        Case1();
                        break;

                    case "2":
                        Case2();
                        break;
                    case "3":
                        Case2();
                        break;
                    case "4":
                        Case2();
                        break;
                    case "5":
                        Case2();
                        break;
                    case "6":
                        Case2();
                        break;
                    case "7":
                        Case2();
                        break;
                    case "8":
                        Case2();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine(Format("No es un numero correcte!"));
                        Thread.Sleep(2000);
                        ContadorRetorn();
                        break;
                }
                num = Menu();

            } while (num != "9");



        }


        static string Menu()
        {

            int width = 80; 
            string[] menu = { "*********************************\n","1. Troba el numero més gran.\n", "2. Troba el Maxim Comu Divisor de dos nombres.\n", "3. Troba el Minim Comú Múltiple de dos nombres.\n", "4. Calcula el factorial d'un nombre.\n",
            "5. Calcula la combinatoria de dos nombres.\n","6. Calcula el Major Divisor de dos nombres.\n", "7. Indica si el nombre es primer.\n", "8. Mostra els N nombres primers.\n", "9. Sortir.\n", "*********************************\n"}; 

            foreach (string opcio in menu)
            {
                
                

                
                Console.WriteLine(Format(opcio));
            }
            string num = Console.ReadLine();
            return num;
        }

        static string Format(string text)
        {

            text = new string(' ', ((Console.WindowWidth - (text.Length)) / 2)) + text;
            return text;
        }
        static void ContadorRetorn()
        {
            for (int i = 5; i >= 0; i--)
            {
                Console.Clear();
                Console.WriteLine(Format($"Tornant al menu en {i}"));
                Thread.Sleep(1000);

            }
            Console.Clear();
        }

        static void Case1()
        {
            int num1, num2;
            Console.WriteLine();
            Console.WriteLine("Introdueix el primer numero per fer el maxim: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introdueix el segon numero per fer el maxim: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"El Maxim de {num1} i {num2} es {Maxim(num1, num2)}");
            Thread.Sleep(3000);
            ContadorRetorn();
        }
        static void Case2()
        {
            int num1, num2;
            Console.WriteLine("Introdueix el primer numero per fer el maxim comu divisor: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introdueix el segon numero per fer el maxim comu divisor: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"El Maxim Comu Divisor de {num1} i {num2} es {MaximComuDivisor(num1, num2)}");
            Thread.Sleep(3000);
            ContadorRetorn();
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
