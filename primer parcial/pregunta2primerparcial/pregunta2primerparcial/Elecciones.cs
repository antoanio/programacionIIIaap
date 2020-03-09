using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pregunta2primerparcial
{
    class Elecciones
    {
        public Elecciones(int mesa, string eleccion, string ciudad, int mAS, int cC, int jUNTOS, int cRECER)
        {
            Mesa = mesa;
            Eleccion = eleccion;
            Ciudad = ciudad;
            MAS = mAS;
            CC = cC;
            JUNTOS = jUNTOS;
            CRECER = cRECER;
        }

        public int Mesa { get; set; }
        public String Eleccion { get; set; }
        public String Ciudad { get; set; }
        public int  MAS { get; set; }
        public int CC { get; set; }

        public int JUNTOS { get; set; }
        public int CRECER { get; set; }
    }
}
