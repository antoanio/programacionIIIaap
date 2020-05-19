using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3.composite
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductoSimple CARNE = new ProductoSimple("CARNE DE RES",30);
            ProductoSimple PAPA = new ProductoSimple("PAPA IMILLA", 20);
            ProductoSimple LECHUGA = new ProductoSimple("LECHUDA BIEN LAVADA", 10);

            ProductoCompuesto combofamiliar = new ProductoCompuesto("combofamiliar");
            combofamiliar.insertarProducto(PAPA);
            combofamiliar.insertarProducto(CARNE);

            OrdenCompra compra1 = new OrdenCompra(1, "antonio arce");
            compra1.insertarProducto(combofamiliar);
            compra1.insertarProducto(CARNE);
            compra1.insertarProducto(PAPA);
            compra1.imprimirOrden();

            OrdenCompra compra2 = new OrdenCompra(2, "juanita del rio");
            compra2.insertarProducto(combofamiliar);
            compra2.insertarProducto(combofamiliar);
            compra2.insertarProducto(LECHUGA);
            compra2.insertarProducto(PAPA);
            compra2.imprimirOrden();

            OrdenCompra compra3 = new OrdenCompra(3, "luis teran");
            compra3.insertarProducto(combofamiliar);
            compra3.insertarProducto(combofamiliar);
            compra3.insertarProducto(combofamiliar);
            compra3.insertarProducto(PAPA);
            compra3.insertarProducto(CARNE);
            compra3.imprimirOrden();
            Console.ReadKey();


        }
    }
}
