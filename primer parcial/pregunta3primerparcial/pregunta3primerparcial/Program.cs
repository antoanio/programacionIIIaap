using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pregunta3primerparcial
{
    class Program
    {
        public class Operaciones 
        {
            public delegate void Delegado(); 
            public event Delegado CuandoEvento;  
            public int Multiplicar(int x, int y, int z)
            {
                int iMultiplicar = x * y * z;
                int iSuma = iMultiplicar / 2;
                if ((iSuma % 3 == 0) && (CuandoEvento != null)) 
                { CuandoEvento(); }
                return iMultiplicar;
            }
        }
        class ProgramaEvento
        {
            static void Main()
            {
                Console.WriteLine("Introduzca el primer numero");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Introduzca el segundo numero");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Introduzca tercer numero");
                int c = int.Parse(Console.ReadLine());

                Operaciones o = new Operaciones();
                o.CuandoEvento += RecibeEvento;

                int res = o.Multiplicar(a,b, c);
                Console.WriteLine("La Multiplicacion  es = {0}", res);

                Console.ReadKey();
            }
            static void RecibeEvento()
            {
                Console.WriteLine("Multiplo de 3");
            }
        }


    }

}

