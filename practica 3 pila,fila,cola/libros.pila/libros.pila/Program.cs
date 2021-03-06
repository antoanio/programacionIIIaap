﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libros.pila
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int opcion = 0;

                pila<libro> p = new pila<libro>();
                while (opcion != 4)
                {
                    Console.Clear();
                    Console.WriteLine("1. Insertar");
                    Console.WriteLine("2. Eliminar ");
                    Console.WriteLine("3. Mostrar");
                    Console.WriteLine("4. Salir");

                    opcion = int.Parse(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Introduzca nombre del libro:");
                            string nombredellibro = Console.ReadLine();
                            Console.WriteLine("Introduzca nombre del Autor:");
                            string autor = Console.ReadLine();
                            Console.WriteLine("Introduzca nombre de la Editorial");
                            string editorial = Console.ReadLine();
                            Console.WriteLine("Introduzca año de Publicacion");
                            int añodepubli = int.Parse(Console.ReadLine());

                            libro x = new libro(nombredellibro, autor, editorial, añodepubli);
                            p.Insertar(x);
                            break;
                        case 2:
                            libro y = p.Eliminar();
                            Console.WriteLine("El elemento eliminado es {0}", y.ToString());
                            Console.ReadKey();
                            break;
                        case 3:
                            p.Mostrar();
                            Console.ReadKey();
                            break;

                    }
                }
            }
        }
    }
    
}
