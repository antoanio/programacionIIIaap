using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2.singleton
{
    class Numeros
    {
        int numero;
        int factorial;
        int sumatoria;

        public Numeros(int numero, int factorial, int sumatoria)
        {
            this.numero = numero;
            this.factorial = factorial;
            this.sumatoria = sumatoria;
        }

        public override string ToString()
        {
            return "Numero de lista:" + numero + " Numero Factorial:" + factorial + " Numero Sumatoria:" + sumatoria;
        }
    }
}
