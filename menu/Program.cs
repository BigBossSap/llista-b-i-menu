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
            Console.WindowHeight = 25;
            Console.ForegroundColor = ConsoleColor.DarkCyan;   

            string num = Menu();
            Console.Clear();
            while (num != "9") 
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
                        Case3();
                        break;
                    case "4":
                        Case4();
                        break;
                    case "5":
                        Case5();
                        break;
                    case "6":
                        Case6();
                        break;
                    case "7":
                        Case7();
                        break;
                    case "8":
                        Case8();
                        break;
                    
                    default:
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine(Format("No es un numero correcte!"));
                        Thread.Sleep(2000);
                        ContadorRetorn();
                        break;
                }
                num = Menu();
                
            }

            if (num == "9")
                Case9();



        }


        static string Menu()
        {

            
            string[] menu = { "****************************************************\n"," 1. Troba el numero més gran.\n ", " 2. Troba el Maxim Comu Divisor de dos nombres.\n" , "3. Troba el Minim Comú Múltiple de dos nombres.\n", "4. Calcula el factorial d'un nombre.\n",
            "5. Calcula la combinatoria de dos nombres.\n","6. Calcula el Major Divisor de dos nombres.\n", "7. Indica si el nombre es primer.\n", "8. Mostra els N nombres primers.\n", "9. Sortir.\n", "****************************************************\n"}; 

            foreach (string opcio in menu)
            {
                
                

                
                Console.WriteLine(Format(opcio));
            }
            Console.Write(Format("Selecciona una opció: "));
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
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(Format("Presiona qualsevol tecla per continuar..."));
            Console.ReadKey();

            for (int i = 3; i >= 1; i--)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine(Format($"Tornant al menu en {i}"));
                Thread.Sleep(1000);

            }
            Console.Clear();
        }
        static void Case1()
        {
            int num1, num2;
            Console.Clear();
            Console.WriteLine();
            Console.Write(Format("Introdueix el primer numero per fer el maxim: "));
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write(Format("Introdueix el segon numero per fer el maxim: "));
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(Format($"El Maxim de {num1} i {num2} es: {Maxim(num1, num2)}"));
            Thread.Sleep(1500);
            ContadorRetorn();
        }
        static int Maxim(int num1, int num2)
        {
            return Math.Max(num1, num2);
        }

        static void Case2()
        {

            int num1, num2;
            Console.Clear();
            Console.WriteLine();
            Console.Write(Format("Introdueix el primer numero per fer el maxim comu divisor: "));
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write(Format("Introdueix el segon numero per fer el maxim comu divisor: "));
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine(Format($"El Maxim Comu Divisor de {num1} i {num2} es: {MaximComuDivisor(num1, num2)}"));
            Thread.Sleep(1500);
            ContadorRetorn();
           
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
        static void Case3()
        {
            int num1, num2;
            Console.Clear();
            Console.WriteLine();
            Console.Write(Format("Introdueix el primer numero per fer el minim comu multiple: "));
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write(Format("Introdueix el segon numero per fer el minim comu multiple: "));
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine(Format($"El Minim Comu Multiple de {num1} i {num2} es {MinimComuMultilpe(num1, num2)}"));
            Thread.Sleep(1500);
            ContadorRetorn();
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
        static void Case4()
        {
            double num;
            Console.Clear();
            Console.WriteLine();
            Console.Write(Format("Introdueix un numero per calcular el se Factorial: "));
            num = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine(Format($"El Factorial de {num} es: {Factorial(num)}"));
            Thread.Sleep(1500);
            ContadorRetorn();
        }
        static double Factorial(double num)
        {
            double factorial = 1;
            for (double i = 1; i <= num; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
        static void Case5()
        {
            double num1, num2;
            Console.Clear();
            Console.WriteLine();
            Console.Write(Format("Introdueix el primer numero per calcular la Combinatoria: "));
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write(Format("Introdueix el segon numero per calcular la Combinatoria: "));
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            Console.WriteLine(Format($"La combinatoria de {num1} i {num2} es {Combinatoria(num1, num2)}"));
            Thread.Sleep(1500);
            ContadorRetorn();
            
        }
        static double Combinatoria(double n, double k )
        {
            double a = Math.Max(n, k);
            double b = Math.Min(n, k);
            double combinatoria = Factorial(a) / (Factorial(b) * Factorial(a - b));



            return combinatoria;
        }
        static void Case6()
        {
            int num1;
            Console.Clear();
            Console.WriteLine();
            Console.Write(Format("Introdueix un numero per calcular el seu Divisor Major: "));
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine(Format($"El Major Divisor de {num1} es {MostrarDivisorMajor(num1)}"));
            Thread.Sleep(1500);
            ContadorRetorn();


            
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
        static void Case7()
        {
            int num;
            Console.Clear();
            Console.WriteLine();
            Console.Write(Format($"Introdueix un numero per comprovar si es primer: "));
            num = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (EsPrimer(num)) 
            Console.WriteLine(Format($"El numero {num} ES primer!"));
            else
                Console.WriteLine(Format($"El numero {num} NO ES primer!"));
            Thread.Sleep(1500);
            ContadorRetorn();

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
        static void Case8()
        {
            int num;
            Console.Clear();
            Console.WriteLine();
            Console.Write(Format("Quant nombres primers vols mostrar: "));
            num = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine();
            Console.Write(Format($"Els {num} primers son:  "));
            Console.WriteLine();
            NPrimersPrimers(num);
            Thread.Sleep(1500);
            ContadorRetorn();
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
                    Console.WriteLine();
                    Console.Write(Format(Convert.ToString(numero)));
                    Thread.Sleep(500);
                    primers++;



                }
                numero++;
            }

        }

        static void Case9()
        {
            for (int i = 3; i >= 1; i--)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine(Format($"Adeu, sortint del programa en: {i}"));
                Thread.Sleep(1000);

            }
            Console.Clear();
        }
       

       

        

        

        

        

       

       
    }

}
