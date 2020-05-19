namespace ejercicio1.familias
{
    internal class Cervecero : FabricaVasos
    {
        private string nombre;
        private double precio;

        public Cervecero(string nombre, double precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }
    }
}