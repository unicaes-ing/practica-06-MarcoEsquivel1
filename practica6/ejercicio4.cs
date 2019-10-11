using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica6
{
    class ejercicio4
    {
        //Marco René Esquivel Juárez
        //04-sep-2019
        public void ejer4()
        {
            int n;
            bool isInt;
            do
            {
                Console.WriteLine("Ingrese un número");
                isInt = int.TryParse(Console.ReadLine(), out n);
            } while (isInt == false);

            DecimalaBinario(n);
            Console.WriteLine("\nPresione <Enter> para continuar...");
            Console.ReadKey();

        }
        static void DecimalaBinario(int n)
        {
            if (n < 2)
            {
                Console.Write(n);
            }
            else
            {
                DecimalaBinario(n / 2);
                Console.Write(n % 2);
            }
        }

    }
}
