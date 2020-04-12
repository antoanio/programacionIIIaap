using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libros.pila
{
    class libro
    {
        public libro(string nombredellibro, string autor, string editorial, int añodepubli)
        {
            Nombredelibro = nombredellibro;
            Autor = autor;
            Editorial = editorial;
            Añodepublicacion = añodepubli;
        }

        public string Nombredelibro { get; set; }
        public string Autor { get; set; }
        public string Editorial { get; set; }
        public int Añodepublicacion { get; set; }
        public override string ToString()
        {
            return (Nombredelibro + " " + Autor + " " + Editorial + " " + Añodepublicacion + " ");
        }
    }
}
