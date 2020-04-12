using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cola
{
    class rentista
    {
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Sexo { get; set; }
        public int Edad { get; set; }
        public String Sector { get; set; }
        public rentista(String nombre, String apellido, String sexo, int edad, String sector)
        {
            Nombre = nombre;
            Apellido = apellido;
            Sexo =  sexo;
            Edad = edad;
            Sector = sector;
        }
        public override string ToString()
        {
            return  Nombre + " " + Apellido + " " + Sexo + " " + Edad.ToString() + " " + Sector + " ";
        }
    }
}
