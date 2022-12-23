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






            int width = 80; // ancho de la consola
            string text = "Hola mundo"; // texto a centrar

            // calcula el número de espacios en blanco necesarios para centrar el texto
            int spaces = (width - text.Length) / 2;

            // muestra el texto centrado
            Console.WriteLine(new string(' ', spaces) + text + new string(' ', spaces));



        }
    }
}