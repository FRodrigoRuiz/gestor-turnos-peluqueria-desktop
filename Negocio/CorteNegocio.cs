using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dominio;
using AccesoDatos;

namespace Negocio
{
    public class CorteNegocio
    {
        CorteDatos corteDatos = new CorteDatos();

        public List<Corte> Lista()
        {
            try
            {
                return corteDatos.Lista();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
