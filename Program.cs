using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 04";

            int A = 0, B, C;
            int cant = 0;
            int i = 2;

                //for (int i = 2; i <= 50000; i++)
                while(cant<4)
                {   
                    A = 0;
                    B = i / 2;

                    for (int j = 1; j <= B; j++)
                    {
                        C = i % j;
                        if (C == 0)
                        {
                            A = A + j;
                        }
                    }
                    if (A==i)
                    {
                        Console.WriteLine("El numero " + i + " es perfecto");
                        cant++;
                    }
                    i++;
                }
                Console.ReadKey();
         }
    }
}
