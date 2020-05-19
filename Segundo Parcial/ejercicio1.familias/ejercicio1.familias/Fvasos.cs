using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1.familias
{
    abstract class Fvasos
    {
        protected string wiskero;
        protected string champañero;
        protected string cervecero;
        double precio;

        public Fvasos(string wiskero, string champañero, string cervecero, double precio) : this(wiskero, champañero, cervecero)
        {
            this.precio = precio;
        }

        protected Fvasos(string wiskero, string champañero, string cervecero)
        {
            this.wiskero = wiskero;
            this.champañero = champañero;
            this.cervecero = cervecero;
        }
        public override string ToString()
        {
            return "Wiskero:" + wiskero + " Champañero:" + champañero + "Cervecero" + cervecero + " Precio:" + precio;
        }
        public string getWinkero()
        {
            return wiskero;
        }
        public void setWiskeroo(string nombre)
        {
            this.wiskero = nombre;
        }
        public string getChampañero()
        {
            return champañero;
        }
        public void setchampañero(string nombre)
        {
            this.champañero = nombre;
        }
        public string getCervecero()
        {
            return cervecero;
        }
        public void setcervecero(string nombre)
        {
            this.cervecero = nombre;
        }
        public double getPrecio()
        {
            return precio;
        }
        public void setPrecio(double precio)
        {
            this.precio = precio;
        }
    }
}
