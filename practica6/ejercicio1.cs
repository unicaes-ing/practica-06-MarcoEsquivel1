using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica6
{
    class ejercicio1
    {
        //Marco René Esquivel Juárez
        //04-sep-2019
        public void ejer1()
        {
            bool isInt;
            int nTabla, op;
            do
            {
                Console.WriteLine("Ingrese el número de la tabla de multiplicar que desea mostrar");
                isInt = int.TryParse(Console.ReadLine(), out nTabla);
            } while (isInt == false || nTabla <= 0 || nTabla > 12);
            do
            {
                Console.WriteLine("¿Desea ingresar un color para la tabla?");
                Console.WriteLine("1. si \n2.no");
                isInt = int.TryParse(Console.ReadLine(), out op);
            } while (isInt == false || op != 1 && op != 2);
            if (op == 1)
            {
                do
                {
                    Console.WriteLine("Ingrese el color de la tabla");
                    Console.WriteLine("1 - Rojo \n2 - Verde\n3 - azul\n4 - amarillo");
                    isInt = int.TryParse(Console.ReadLine(), out op);
                } while (isInt == false || op < 1 || op > 4);
                tabla(nTabla, op);
            }
            else tabla(nTabla);
            Console.ReadKey();
        }

        static void tabla(int n)
        {
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", n, i + 1, n * (i + 1));
            }
        }
        static void tabla(int n, int c)
        {
            switch (c)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Se elijió el color rojo");
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Se elijió el color verde");
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Se elijió el color azul");
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Se elijió el color amarillo");
                    break;
            }
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", n, i + 1, n * (i + 1));
            }
        }
    }
}
