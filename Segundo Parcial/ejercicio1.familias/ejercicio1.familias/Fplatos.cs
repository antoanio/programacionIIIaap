using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1.familias
{
    abstract class Fplatos
    {

        protected string planos;
        protected string soperos;
        protected string platillos;
        double precio;

        protected Fplatos(string planos, string soperos, string platillos, double precio)
        {
            this.planos = planos;
            this.soperos = soperos;
            this.platillos = platillos;
            this.precio = precio;
        }
        public override string ToString()
        {
            return "Platos:" + planos + " soperos:" + soperos + "Platillos" + platillos + " Precio:" + precio;
        }
        public string getPlanos()
        {
            return planos;
        }
        public void setPlanos(string nombre)
        {
            this.planos = nombre;
        }
        public string getSoperos()
        {
            return soperos;
        }
        public void setSoperos(string nombre)
        {
            this.soperos = nombre;
        }
        public string getPlatillos()
        {
            return platillos;
        }
        public void setPlatillos(string nombre)
        {
            this.platillos = nombre;
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
