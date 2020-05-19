namespace ejercicio1.familias
{
    internal class Champañero : FabricaVasos
    {
        private string nombre;
        private double precio;

        public Champañero(string nombre, double precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }
    }
}