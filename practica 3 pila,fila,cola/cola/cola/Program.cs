using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cola
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            rentista y;
            Cola1<rentista> p = new Cola1<rentista>();
            while (opcion != 4)
            {
                Console.Clear();
                Console.WriteLine("1. Insertar");
                Console.WriteLine("2. Eliminar");
                Console.WriteLine("3. Mostrar");
                Console.WriteLine("4. Salir");

                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Introduzca Nombre");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("Introduzca Apellido");
                        string apellido = Console.ReadLine();
                        Console.WriteLine("Introduzca Sexo");
                        string sexo = Console.ReadLine();
                        Console.WriteLine("Introduzca Edad");
                        int edad = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Introduzca Sector");
                        string sector = Console.ReadLine();
                        y = new rentista(nombre, apellido, sexo, edad, sector);
                        p.Insertar(y);
                        break;
                    case 2:
                        y = p.Eliminar();
                        Console.WriteLine("El elemento eliminado es:" + y);
                        Console.ReadKey();
                        break;
                    case 3:
                        p.mostrar();
                        Console.ReadKey();
                        break;
                }

            }
        }
    }
}

