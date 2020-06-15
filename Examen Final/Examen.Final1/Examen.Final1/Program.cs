using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Final1
{
    class Program
    {
        static void Main(string[] args)
        {

            int n= 0;
           Biblioteca x = Biblioteca.getInstance();

            do
            {

                Console.WriteLine("1. Insertar libro :");
                Console.WriteLine("2. Eliminar Libro: ");
                Console.WriteLine("3. Mostar: ");
                Console.WriteLine(" ");
                Console.WriteLine("digite un valor 1-3");
                n = int.Parse(Console.ReadLine());
                Console.Write("");


                
                switch (n)
                {
                    case 1:
                        Console.WriteLine("1. titulo del libro");
                        string titulo = Console.ReadLine();
                        Console.WriteLine("1.autor");
                        string autor = Console.ReadLine();
                        Console.WriteLine("1. Editorial");
                        string editorial = Console.ReadLine();
                        Console.WriteLine("estado  Nuevo,Seminuevo,Viejo");
                        string estados = Console.ReadLine();
                        Estado estado;
                        Enum.TryParse(estados, out estado);



                        LibrosLir m = new LibrosLir(titulo, autor, editorial, Estado.nuevo);
                        x.IngresarLibro(m);

                        break;
                    case 2:

                        break;
                    case 3:
                        x.MostrarLibro();
                        break;
                }

            } while (n != 7);

        }
    }
}