using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DetallesMantenimiento
    {
        public DetallesMantenimiento(int idDetalle, int idPieza, int idMantenimiento, int cantidad, double costo)
        {
            IdDetalle = idDetalle;
            IdPieza = idPieza;
            IdMantenimiento = idMantenimiento;
            Cantidad = cantidad;
            Costo = costo;
        }

        public int IdDetalle { get; set; }
        public int IdPieza { get; set; }
        public int IdMantenimiento { get; set; }
        public int Cantidad { get; set; }
        public double Costo { get; set; }
    }
}
