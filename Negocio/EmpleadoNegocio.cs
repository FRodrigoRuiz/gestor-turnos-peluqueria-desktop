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

        public Empleado Obtener(int idEmpleado)
        {
            try
            {
                return empleadoDatos.Obtener(idEmpleado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Crear(Empleado entidad)
        {
            try
            {
                if (entidad.Nombre == "")
                    throw new OperationCanceledException("El nombre no puede estar vacio");

                return empleadoDatos.Crear(entidad);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Editar(Empleado entidad)
        {
            try
            {
                var encontrado = empleadoDatos.Obtener(entidad.IdEmpleado);

                if (encontrado.IdEmpleado == 0)
                    throw new OperationCanceledException("No existe el empleado solicitado");

                return empleadoDatos.Editar(entidad);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Eliminar(int idEmpleado)
        {
            try
            {
                var encontrado = empleadoDatos.Obtener(idEmpleado);

                if (encontrado.IdEmpleado == 0)
                    throw new OperationCanceledException("No existe el empleado solicitado");

                return empleadoDatos.Eliminar(idEmpleado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
