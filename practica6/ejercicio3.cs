using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica6
{
    class ejercicio3
    {
        //Marco René Esquivel Juárez
        //04-sep-2019
        public void ejer3()
        {
            int n, ex, r;
            bool isInt;
            do
            {
                Console.WriteLine("Ingrese el la base que desea elevar.");
                isInt = int.TryParse(Console.ReadLine(), out n);
            } while (isInt == false);
            do
            {
                Console.WriteLine("Ingrese el exponente que desea elevar.");
                isInt = int.TryParse(Console.ReadLine(), out ex);
            } while (isInt == false);
            r = exponente(n, ex);
            Console.WriteLine("resultado = {0}", r);
            Console.ReadKey();
        }

        static int exponente(int n, int ex)
        {
            
            if (ex == 0)
            {
                return 1;
            }
            else
            {
                return n * exponente(n, ex - 1); // llamada recursiva
            }
        }
    }
}
