using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda.ejercicio2
{
    class Program
    {
        delegate string Mdelegado(int n, int m);
        static void Main(string[] args)
        {
            Mdelegado multi = (int n, int m) =>
            {
                string aux;
                if (n % m == 0)
                    aux = "El Multiplo";
                else
                    aux = "No es un Multiplo";
                return aux;
            };

            Console.WriteLine(multi(4, 2));
            Console.ReadKey();
        }
    }
}
