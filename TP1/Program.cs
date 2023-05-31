using System;
using System.Collections;

namespace TP1 // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Part1();

            Part2();

            //Part3();

            Part4();

            //test();


        }

        static void Part1()
        {
            float[] floatArray = new float[]
            {
                1.0f,
                2.0f,
                3.0f
            };

            string elements = string.Join(", ", floatArray);

            Console.WriteLine(elements);
        }

        static void Part2()
        {
            int[] intArray = new int[5]
            {
              0,
              7,
              9,
              14,
              27
            };

            string elements = string.Join(", ", intArray);

            Console.WriteLine(elements);
        }

        static void Part3()
        {
            int[] tableau = new int[5];

            for (int i = 0; i < tableau.Length; i++)
            {
                Console.WriteLine("Saisir le valeur {0}: ", i);
                tableau[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Les valeurs sont: ");


            // une maniere

            string elements = string.Join(", ", tableau);

            Console.WriteLine(elements);


            // autre maniere
            Console.WriteLine("Les valeurs sont: ");

            foreach (int test in tableau)
            {
                Console.WriteLine(test);
            }
        }

        static void Part4()
        {
            int[,] tableauMulti = new int[3, 5];

            for (int i = 0;i < 3;i++)
            {
                for (int j = 0;j < 5;j++)
                {
                    Console.WriteLine("saisir le valeur {0} {1}: ", i, j);
                    tableauMulti[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("le tableau: ");

            for (int i = 0;i < 3 ; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine(tableauMulti[i, j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}