using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enfermos.con.covid19
{
    class enfermos
    {
        public enfermos(string nombre, string apellido, int edad, string sexo, string estado)
        {
            Nombre = nombre;           
            Apellido = apellido;            
            Edad = edad;
            Sexo = sexo;
            Estado = estado;

        }

        public string Nombre { get; }       
        public string Apellido { get; }      
        public int Edad { get; }
        public string Sexo { get; }
        public string Estado { get; }
        public override string ToString()
        {
            return Nombre + "  " + Apellido + "  " + Edad.ToString() + "  " + Sexo + "  " + Estado;
        }
    }
}
