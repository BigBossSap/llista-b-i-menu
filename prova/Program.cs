using System;

namespace Ex30
{
    class Program
    {
        static void Main(string[] args)
        {
            static string Menu()
            {
                const int screenWidth = Console.WindowWidth;

                // Crea la plantilla para el menú con marcadores de posición para insertar los números de opción
                string menuTemplate = "*********************************\n" +
                                     "{0}. Troba el numero més gran.\n" +
                                     "{1}. Troba el Maxim Comu Divisor de dos nombres.\n" +
                                     "{2}. Troba el Minim Comú Múltiple de dos nombres.\n" +
                                     "{3}. Calcula el factorial d'un nombre.\n" +
                                     "{4}. Calcula la combinatoria de dos nombres.\n" +
                                     "{5}. Calcula el Major Divisor de dos nombres.\n" +
                                     "{6}. Indica si el nombre es primer.\n" +
                                     "{7}. Mostra els N nombres primers.\n" +
                                     "{8}. Sortir.\n" +
                                     "*********************************\n";

                // Rellena cada marcador de posición con el número de opción correspondiente
                string menu = string.Format(menuTemplate, 1, 2, 3, 4, 5, 6, 7, 8, 9);

                // Añade espacios en blanco a la izquierda del texto hasta que alcance la anchura de la pantalla
                string paddedMenu = menu.PadLeft(screenWidth / 2 + menu.Length / 2);

                Console.WriteLine(paddedMenu);
                string num = Console.ReadLine();
                return num;
            }



        }
    }
}