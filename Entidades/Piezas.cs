using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Piezas
    {
        public Piezas(int idPieza, string nombre, int stock, double costo)
        {
            IdPieza = idPieza;
            Nombre = nombre;
            Stock = stock;
            Costo = costo;
        }

        public int IdPieza { get; set; }
        public string Nombre { get; set; }
        public int Stock { get; set; }
        public double Costo { get; set; }
    }
}
