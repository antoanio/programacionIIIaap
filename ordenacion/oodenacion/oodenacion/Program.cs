using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oodenacion
{
    class Program
    {
        static void Main(string[] args)
        {
            // crear un arreglo de int, double y char
            int[] intArray = { 1, 2, 3, 4, 5, 6 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7 };
            char[] charArray = { 'H', 'O', 'L', 'A' };
            Console.WriteLine("intArray contiene:");
            ordenar(intArray);
            MuestraArreglo(intArray);
            Console.WriteLine("doubleArray contiene:");
           ordenar(doubleArray);
            MuestraArreglo(doubleArray);
            Console.WriteLine("charArray contiene:");
           ordenar(charArray);
            MuestraArreglo(charArray);
            Console.ReadKey();
        }
        private static void ordenar<T>(T[] a)
            where T:IComparable<T>
        {
            for (int j = 0; j < a.Length; j++)
            {
                for (int i = 0; i < a.Length - 1 - j; i++)
                {
                    if (a[i].CompareTo(a[i + 1]) < 0)
                    {
                        T aux = a[i];
                        a[i] = a[i + 1];
                        a[i + 1] = aux;
                    }
                }
            }
            
                

        }
        private static void MuestraArreglo<T>(T[] arreglo)
        {
            foreach (T elemento in arreglo)
                Console.Write(elemento + " ");
            Console.WriteLine("\n");
        }
    }
}
