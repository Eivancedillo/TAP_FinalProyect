using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Maquinas
    {
        public Maquinas(int idMaquina, string nombre, string descripcion)
        {
            IdMaquina = idMaquina;
            Nombre = nombre;
            Descripcion = descripcion;
        }

        public int IdMaquina { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }
}
