using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototipe
{
    class Program
    {
        static void Main(string[] args)
        {

            Celular cel = new Celular(Marca.Huawei, "Y92019",new TamañodePantalla(15, 8), Color.Blanco, 64, new Procesador("Intel", 10, 1));
            Celular cel2 = (Celular)cel.Clone();
            Celular cel3 = (Celular)cel.Clone();
            Celular cel4 = (Celular)cel.Clone();
            Celular cel5 = (Celular)cel.Clone();
            Console.WriteLine(cel + "\n" + cel2 + "\n" + cel3 + "\n" + cel4, "\n" + cel5 + "\n");
            Console.ReadKey();
        }
    }
}
