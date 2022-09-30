using System;

namespace SolveTestSourcecol
{
    public class Test
    {
        static void Main()
        {

            Console.WriteLine("Seleccionar opción a ejecutar");
            Console.WriteLine("1. Cortar cadena de texto");
            Console.WriteLine("2. Validar valor en serie Fibonacci");
            Console.WriteLine("3. Ordenar array");

            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    {
                        processCutTextString();
                        break;
                    }
                case 2:
                    {
                        processValidateFibonacciSerie();
                        break;
                    }
                case 3:
                    {
                        processOrderArray();
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
         *  Ejecutar recorte de cadena de texto
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

        /**
         * Cortar cadena de texto según longitud máxima de carácteres
         */
        public static string cutTextString(string text, int maxLength) => text.Substring(0, maxLength > text.Length ? text.Length : maxLength) + (text.Length > maxLength ? "..." : "");

        /**
         * Ejecutar validación de valor en serie Fibonacci
         */
        public static void processValidateFibonacciSerie()
        {
            Console.WriteLine("Inicia segundo punto");
            Console.WriteLine("Escribir un valor de la serie de Fibonacci");
            int valueFibonacci = int.Parse(Console.ReadLine());

            Console.WriteLine("Resultado ---> " + validateFibonacciSerie(valueFibonacci));
        }

        /** 
         *  Validar si el valor enviado existe en la serie Fibonacci
         */
        public static string validateFibonacciSerie(int valueFibonacci)
        {
            // Mensaje de respuesta a retornar
            string messageResponse = "";

            int value1 = 0;
            int value2 = 1;

            Console.WriteLine("Serie");

            for (int i = 0; i < valueFibonacci; i++)
            {
                int valueTemp = value1;

                value1 = value2;

                value2 = valueTemp + value1;

                Console.Write(value1 + " ");

                // Si el valor de la secuencia ya supero el valor enviado es porque no coincide
                if (value1 > valueFibonacci)
                {
                    messageResponse = $"El valor {valueFibonacci} no coincide con la serie de Fibonacci";
                    break;
                }
                else if (value1 == valueFibonacci)
                {
                    messageResponse = $"El valor {valueFibonacci} coincide con la serie de Fibonacci";
                    break;
                }

            }

            return messageResponse;
        }

        /**
         * Ejecutar metodo para odernar array
         */
        public static void processOrderArray()
        {
            Console.WriteLine("Inicia tercer punto");
            Console.WriteLine("Elegir opción en la que se va a ordenar, si se pone una opción no valida por defecto se usará la primera");
            Console.WriteLine("1 -> Mayor a menor");
            Console.WriteLine("2 -> Menor a mayor");
            int optionOrder = int.Parse(Console.ReadLine());

            Console.WriteLine("Elegir cantidad de elementos del array");
            int countItems = int.Parse(Console.ReadLine());

            int[] arrayNumbers = new int[countItems];

            for(int i = 0; i < countItems; i++)
            {
                Console.WriteLine($"Valor del array número {i+1}");
                int value = int.Parse(Console.ReadLine());
                arrayNumbers[i] = value;
            }

            //Console.WriteLine("Resultado ---> " + orderArray(arrayNumbers,));
            Test test = new Test();
            int[] orderedArray = test.orderArray(arrayNumbers, optionOrder);
            int countPair = 0;

            foreach(int value in orderedArray)
            {
                if (value % 2 == 0)
                {
                    countPair++;
                }
            }

            Console.WriteLine("El array ["+ string.Join(", ", orderedArray)+$"] tiene {countPair} números pares");

        }

        public int[] orderArray(int[] arrayNumbers, int order)
        {

            Array.Sort<int>(arrayNumbers, new Comparison<int>((a, b) =>
            {
                if (order == 2)
                {
                    return a.CompareTo(b);
                }
                else
                {
                    return b.CompareTo(a);
                }
            }));

            return arrayNumbers;
        }
    }
}