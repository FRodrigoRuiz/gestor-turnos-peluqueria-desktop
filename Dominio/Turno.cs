using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Turno
    {
        public int IdTurno { get; set; }
        public DateTime Fecha { get; set; }
        public string NombreCliente { get; set; }
        public Corte Corte { get; set; }
        public Empleado Empleado { get; set; }
    }
}
