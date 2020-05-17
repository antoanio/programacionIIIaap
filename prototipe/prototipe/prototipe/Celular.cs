using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototipe
{
    class Celular
    {
        Marca marca;
        string Modelo;
        TamañodePantalla tamaniopantalla;
        Color color;
        int memoria;
        Procesador procesador;

        public Celular(Marca marca, string modelo, TamañodePantalla tamaniopantalla, Color color, int memoria, Procesador procesador)
        {
            this.marca = marca;
            Modelo = modelo;
            this.tamaniopantalla = tamaniopantalla;
            this.color = color;
            this.memoria = memoria;
            this.procesador = procesador;
        }
        public override string ToString()
        {
            return " Marca:" + marca + " Modelo:" + Modelo + " Tamaño de Pantalla:" + tamaniopantalla + " Color:" + color + " Memoria:" + memoria + " Procesador:" + procesador;
        }
        public object Clone()
        {
            return MemberwiseClone();
        }
    }
    enum Marca
    {
        Samsung, Huawei, LG, Sonny
    }
    enum Color
    {
        Negro, Rojo, Celeste, Blanco, Azul
    }
}
