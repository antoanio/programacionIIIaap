using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Final1
{
    class LibrosLir
    {
        string Titulo;
        string Autor;
        string Editorial;
        Estado EstadoDeLibro;

        public LibrosLir(string titulo, string autor, string editorial, Estado estadoDeLibro)
        {
            Titulo = titulo;
            Autor = autor;
            Editorial = editorial;
            EstadoDeLibro = estadoDeLibro;
        }
        public string getTitulo()
        {
            return Titulo;
        }
        public void setTitulo(string Titulo)
        {
            this.Titulo = Titulo;
        }
        public string getAutor()
        {
            return Autor;
        }
        public void setAutor(string Autor)
        {
            this.Autor = Autor;
        }
        public string getEditorial()
        {
            return Editorial;
        }
        public void setEditorialo(string Editorial)
        {
            this.Editorial = Editorial;
        }
        public override string ToString()
        {
            return ("Titulo:  " + Titulo  + "Autor:  " + Autor  + "Editorial:  " + Editorial  );
        }
    }
    enum Estado
    {
        nuevo,seminuevo,viejo
    }
}
