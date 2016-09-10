using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaTienda
{
    public class Videojuego
    {
        public int Stock { get; set; }
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public int Precio { get; set; }
        public int edadRequerida { get; set; }
        public int cantidadDeseada { get; set; }

        public Videojuego()
        {
            this.Init();
        }

        private void Init()
        {
            Stock = 0;
            Codigo = 0;
            Nombre = string.Empty;
            Precio = 0;
            edadRequerida = 0;
            cantidadDeseada = 0;
        }

        public int Vender(int Cantidad)
        {
            Stock = Stock - Cantidad;
            return Stock;
        }

        public Boolean enStock(int Cantidad)
        {
            if (Stock > Cantidad)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Suplementar(int Cantidad)
        {
            Stock = Stock + Cantidad;
        }
    }
}
