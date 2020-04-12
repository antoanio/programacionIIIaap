using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enfermos.con.covid19
{
    class nodo
    {
        public enfermos info;
        public nodo Siguiente;
        public nodo Anterior;

        public nodo(enfermos valor)
        {
            info = valor;
            Siguiente = null;
        }
    }
    class ListaDoble
    {
        public nodo Actual;
        public void Insertar(enfermos valor)
        {
            nodo nuevo = new nodo(valor);
            if (Actual == null)
            {
                Actual = nuevo;
            }
            else
            {
                nodo aux = Actual;
                nodo anterior = null;
                while (aux != null && valor.Apellido.CompareTo(aux.info.Apellido) > 0)
                {
                    anterior = aux;
                    aux = aux.Siguiente;
                }
                if (anterior == null)
                {
                    Actual = nuevo;
                    nuevo.Siguiente = aux;
                    aux.Anterior = nuevo;
                }
                else
                {
                    anterior.Siguiente = nuevo;
                    nuevo.Siguiente = aux;
                    nuevo.Anterior = anterior;
                }

            }
        }
        public void EliminarApellido(string apellido)
        {
            if (Actual != null)
            {
                nodo aux = Actual;
                nodo ant = null;
                while (aux.Siguiente != null && aux.info.Apellido != apellido)
                {
                    ant = aux;
                    aux = aux.Siguiente;
                }
                if (aux.info.Apellido == apellido)
                {
                    if (ant == null)
                        Actual = aux.Siguiente;
                    else
                        ant.Siguiente = aux.Siguiente;
                }
                else
                    Console.WriteLine("No se encontro el valor");

            }
        }
        public void Mostrar()
        {
            Console.WriteLine("Elementos de la lista:");
            if (Actual != null)
            {
                nodo aux = Actual;
                while (aux != null)
                {
                    Console.WriteLine("{0}     ", aux.info);
                    aux = aux.Siguiente;

                }
            }
        }
    }
}

