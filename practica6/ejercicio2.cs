using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica6
{
    class ejercicio2
    {
        //Marco René Esquivel Juárez
        //04-sep-2019
        public void ejer2()
        {
            int ancho, alto, x, y, op;
            string caracter;
            bool isInt;
            do
            {
                Console.WriteLine("Ingrese el ancho de la figura");
                isInt = int.TryParse(Console.ReadLine(), out ancho);
            } while (isInt == false || ancho < 0);

            do
            {
                Console.WriteLine("Ingrese el alto de la figura");
                isInt = int.TryParse(Console.ReadLine(), out alto);
            } while (isInt == false || alto < 0);
            //---------------------------------------------------------------------------------------------
            do
            {
                Console.WriteLine("¿Desea ingresar coordenadas para mostrar el dibujo? 1- Si 2- No");
                isInt = int.TryParse(Console.ReadLine(), out op);
            } while (isInt == false || op < 1 || op > 2);

            if (op == 1)
            {
                do
                {
                    Console.WriteLine("Ingrese la coordenada en x");
                    isInt = int.TryParse(Console.ReadLine(), out x);
                } while (isInt == false || x < 0);
                do
                {
                    Console.WriteLine("Ingrese la coordenada en y");
                    isInt = int.TryParse(Console.ReadLine(), out y);
                } while (isInt == false || y < 0);
                do
                {
                    Console.WriteLine("Ingrese el caracter de la figura");
                    caracter = Console.ReadLine();
                } while (caracter.Length != 1);
                figura(ancho, alto, caracter, x, y);
            }

            do
            {
                Console.WriteLine("¿Desea ingresar un caracter diferente? 1- Si 2- No");
                isInt = int.TryParse(Console.ReadLine(), out op);
            } while (isInt == false || op < 1 || op > 2);

            if (op == 1)
            {
                do
                {
                    Console.WriteLine("Ingrese el caracter de la figura");
                    caracter = Console.ReadLine();
                } while (caracter.Length != 1);
                figura(ancho, alto, caracter);
            }
            else figura(ancho, alto);
        }

        static void figura(int an, int al)
        {
            Console.Clear();
            for (int i = 0; i < al; i++)
            {
                for (int j = 0; j < an; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        static void figura(int an, int al, string ca)
        {
            Console.Clear();
            for (int i = 0; i < al; i++)
            {
                for (int j = 0; j < an; j++)
                {
                    Console.Write("{0}", ca);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        static void figura(int an, int al, string ca, int x, int y)
        {
            Console.Clear();
            for (int i = 0; i < al; i++)
            {
                Console.SetCursorPosition(x, y);
                for (int j = 0; j < an; j++)
                {
                    Console.Write("{0}", ca);
                }
                Console.WriteLine();
                y++;
            }
            Console.ReadKey();
        }
    }
}
