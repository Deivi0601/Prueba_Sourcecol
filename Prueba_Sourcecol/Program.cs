using System;

namespace SolveTestSourcecol
{
    public class Test
    {
        static void Main()
        {

            Console.WriteLine("Seleccionar opción a ejecutar");
            Console.WriteLine("1. Cortar cadena de texto");

            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    {
                        processCutTextString();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("La opción seleccionada no es valida");
                        break;
                    }
            }

        }

        /** 
         *  Escribir cadena de texto y longitud máxima de carácteres a mostrar
        */
        public static void processCutTextString()
        {
            Console.WriteLine("Inicia primer punto");

            Console.WriteLine("Escribir texto");
            string text = Console.ReadLine();
            Console.WriteLine("Escribir longitud aáxima");
            int maxLength = int.Parse(Console.ReadLine());

            Console.WriteLine("Resultado ---> " + cutTextString(text, maxLength));
            
        }

        static string cutTextString(string text, int maxLength) => text.Substring(0, maxLength > text.Length ? text.Length : maxLength) + (text.Length > maxLength ? "..." : "");

    }
}