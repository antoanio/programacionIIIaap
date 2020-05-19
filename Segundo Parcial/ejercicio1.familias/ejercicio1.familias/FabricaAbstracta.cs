using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1.familias
{
    interface FabricaAbstracta
    {
        Fvasos getMamiferos(string Tipo, string nombre, double precio);
        Fplatos getAves(string Tipo, string nombre, double precio);
       
    }
    

}
