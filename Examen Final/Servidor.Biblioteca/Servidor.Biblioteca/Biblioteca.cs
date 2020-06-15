using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Servidor.Biblioteca
{
    class Biblioteca
        
    {

        String nombre;
        string direccion;
        double telefono;
        List<LibrosLir> ListaDeLibros;
        private static Biblioteca instance;

        public static Biblioteca getInstance()
        {
            if (instance==null)
            {
                instance = new Biblioteca();
            }
            return instance;
        }

        private Biblioteca()
        {
            this.nombre = "Univalle Biblioteca";
            this.direccion = "direccion Pasaje Guilermina Ruiz";
            this.telefono = 64 - 255233;
            ListaDeLibros = new List<LibrosLir>();
        }
        public void IngresarLibro(LibrosLir z)
        {
            ListaDeLibros.Add(z);
        }
        public void RestauraeLibro(LibrosLir b)
        {
            ListaDeLibros.Add(b);
        }
        public void MostrarLibro()
        {
            foreach (LibrosLir c in ListaDeLibros)
            {
                Console.WriteLine("{0} " , c);
            }
        }

    }
    
}
