using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2.singleton
{
    class Operacion
    {
        private static Operacion instance;
        List<Numeros> listanumeros;

        private Operacion()
        {
            listanumeros = new List<Numeros>();
        }
        public static Operacion getInstance()
        {
            if (instance == null)
            {
                instance = new Operacion();
                return instance;
            }
            else
                return instance;

        }
        public void ingresarValor(int n)
        {
            int Sumatoria = 0;
            for (int i = 0; i <= n; i++)
            {
                Sumatoria += i;
            }

            int Fact = 1;
            for (int i = 1; i <= n; i++)
            {
                Fact = Fact * i;
            }
            listanumeros.Add(new Numeros(n, Fact, Sumatoria));
        }
        public void Mostrar()
        {
            foreach (Numeros o in listanumeros)
            {
                Console.WriteLine(o);
            }



        }
    }
}
