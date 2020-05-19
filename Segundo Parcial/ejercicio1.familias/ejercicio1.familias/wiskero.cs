namespace ejercicio1.familias
{
    internal class wiskero : FabricaVasos
    {
        private string nombre;
        private double precio;

        public wiskero(string nombre, double precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }
    }
}