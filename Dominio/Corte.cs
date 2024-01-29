using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Corte
    {
        public int IdCorte { get; set; }
        public string TipoCorte { get; set; }

        public override string ToString()
        {
            return TipoCorte;
        }
    }
}
