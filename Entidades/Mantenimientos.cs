using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mantenimientos
    {
        public Mantenimientos(int idMantenimiento, int fkIdMaquina, int fkIdMecanico, string fecha, string descipcion, string estado = "Pendiente")
        {
            IdMantenimiento = idMantenimiento;
            FkIdMaquina = fkIdMaquina;
            FkIdMecanico = fkIdMecanico;
            Fecha = fecha;
            Descipcion = descipcion;
            Estado = estado;
        }

        public int IdMantenimiento { get; set; }
        public int FkIdMaquina { get; set; }
        public int FkIdMecanico { get; set; }
        public string Fecha { get; set; }
        public string Descipcion { get; set; }
        public string Estado { get; set; }
    }
}
