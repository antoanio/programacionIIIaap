using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda.ejercicio3
{
    class Program
    {
        delegate string Mdelegado(int nun, int resul);
        static void Main(string[] args)
        {
            {
                int nun = 0;
                string resul = null
               ;
                string cadena;
                Program ob = new Program();
                Console.Write("DIGITE NÚMERO : ");
                cadena = Console.ReadLine();
                nun = int.Parse(cadena);
                resul = ob.DIASEMANA(nun);
                Console.WriteLine();
                Console.WriteLine("RESULTADO ES: " + resul);
                Console.Write("Pulse una Tecla:");
                Console.ReadLine();

            }
             string DIASEMANA(int DIA)

            {
                string R = null
               ;
                switch (DIA)

                {
                    case 1:
                        R = "DOMINGO"
                       ;
                        break
                        ;
                    case 2:
                        R = "LUNES"
                       ;
                        break
                       ;
                    case 3:
                        R = "MARTES"
                       ;
                        break
                        ;
                    case 4:
                        R = "MIÉRCOLES"
                       ;
                        break
                        ;
                    case 5:
                        R = "JUEVES"
                       ;
                        break
                        ;
                    case 6:
                        R = "VIERNES"
                       ;
                        break
                        ;
                    case 7:
                        R = "SÁBADO"
                       ;
                        break
                        ;
                    default
               :
                        R = "FUERA DE RANGO"
                       ;
                        break
                       ;

                }
                return (R);

            }

        }

        private string DIASEMANA(int nun)
        {
            throw new NotImplementedException();
        }
    }

}
    

