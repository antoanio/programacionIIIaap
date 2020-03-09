using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pregunta2primerparcial
{
    class Program
    {
        static void Main(string[] args)
        {
            Elecciones[] listas = new Elecciones[8];
            InsertarTodos(listas);
            int opcion = 0;
            while (opcion != 13)
            {
                Console.Clear();
                Console.WriteLine("1.- Insertar Alumno");
                Console.WriteLine("2.- Mostrar Alumnos");
                Console.WriteLine("3.- Mostrar Alumnas");
                Console.WriteLine("4.- Mostrar Alumnos ordenados alfabeticamente por nombre");
                Console.WriteLine("5.- Mostrar Alumnos mayores de 20");
            }

        }
        static void Insertar(Elecciones[] listas)
        {

            Console.Write("Introduzca el nro de alumno: ");
            int nroalumno = int.Parse(Console.ReadLine()) - 1;
            Console.Write("Introduzca el Nombre: ");
            String Nombre = Console.ReadLine();
            Console.Write("Introduzca el Primer Apellido: ");
            String PrimerApellido = Console.ReadLine();
            Console.Write("Introduzca el Segundo Apellido: ");
            String SegundoApellido = Console.ReadLine();
            Console.Write("Introduzca el Carnet de Identidad: ");
            String CI = Console.ReadLine();
            Console.Write("Introduzca el Sexo: (M/F) ");
            String Sexo = Console.ReadLine();

            Console.Write("Introduzca la Edad: ");
            int Edad = int.Parse(Console.ReadLine());


             Elecciones a = new Elecciones(mesa, PrimerApellido, SegundoApellido, CI, Sexo, Edad);
            listas[nroalumno] = a;

        }
        static void InsertarTodos(Elecciones[] listas)
        {
            listaalumnos[0] = new Alumno("Antonio", "Arce", "Pacheco", "10390566", "M", 21);
            listaalumnos[7] = new Alumno("Manuel", "Quispe", "Calcina", "8565058", "M", 20);
        }


    }
}
