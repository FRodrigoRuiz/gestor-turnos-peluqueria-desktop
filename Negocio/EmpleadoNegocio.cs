using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dominio;
using AccesoDatos;

namespace Negocio
{
    public class EmpleadoNegocio
    {
        EmpleadoDatos empleadoDatos = new EmpleadoDatos();

        public List<Empleado> Lista()
        {
            try
            {
                return empleadoDatos.Lista();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
