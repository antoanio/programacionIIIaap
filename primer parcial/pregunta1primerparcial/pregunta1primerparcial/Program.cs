using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pregunta1primerparcial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Primer Mayor de {0}, {1} , {2} es: {3}",
                2, 3, 4, PrimerMayor(2, 3, 4));
            Console.WriteLine("Segundo Mayor de {0}, {1} , {2} es: {3}",
                2, 3, 4, SegundoMayor(2, 3, 4));
            Console.WriteLine("Primer Mayor de {0}, {1} , {2} es: {3}",
               3.1, 4.6, 2.3, PrimerMayor(3.1, 4.6, 2.3));
            Console.WriteLine("Segundo Mayor de {0}, {1} , {2} es: {3}",
               3.1, 4.6, 2.3, SegundoMayor(3.1, 4.6, 2.3));
            Console.WriteLine("Primer Mayor de {0}, {1} , {2} es: {3}",
               "juan", "pedro", "maria", PrimerMayor("juan", "pedro", "maria"));
            Console.WriteLine("Segundo Mayor de {0}, {1} , {2} es: {3}",
               "juan", "pedro", "maria", SegundoMayor("juan", "pedro", "maria"));
            Console.ReadKey();
        }
       

        private static T PrimerMayor<T>(T a, T b, T c)
            where T : IComparable<T>
        {
            T max = a;
            if (b.CompareTo(max) > 0)
                max = b; 
            if (c.CompareTo(max) > 0)
                max = c; 
            return max; 
        }
        private static T SegundoMayor<T>(T a, T b, T c)
           where T : IComparable<T>
        {
            T max = a; 
            if (b.CompareTo(max) > 1)
                max = b; 
            if (c.CompareTo(max) > 1)
                max = c;
            return max;
        }
    }
}