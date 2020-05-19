using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1.familias
{
    class FabricaVasos
    {
        public FabricaVasos getVasos(string Tipo, string nombre, double precio)
        {
            switch (Tipo)
            {
                case "Wiskero":
                    return new wiskero(nombre, precio);
                case "Champañero":
                    return new Champañero(nombre, precio);
                case "Cervecero":
                    return new Cervecero(nombre, precio);
                default:
                    return null;
            }
        }

    }
}
