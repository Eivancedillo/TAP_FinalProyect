using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mecanicos
    {
        public Mecanicos(int idMecanico, string nombre, string apellidos)
        {
            IdMecanico = idMecanico;
            Nombre = nombre;
            Apellidos = apellidos;
        }

        public int IdMecanico { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
    }
}
