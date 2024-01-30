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

        public Corte Obtener(int idCorte)
        {
            try
            {
                return corteDatos.Obtener(idCorte);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Crear(Corte entidad)
        {
            try
            {
                if (entidad.TipoCorte == "")
                    throw new OperationCanceledException("La nombre del corte no puede estar vacio");

                return corteDatos.Crear(entidad);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Editar(Corte entidad)
        {
            try
            {
                var encontrado = corteDatos.Obtener(entidad.IdCorte);

                if (encontrado.IdCorte == 0)
                    throw new OperationCanceledException("No existe el corte solicitado");

                return corteDatos.Editar(entidad);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Eliminar(int idCorte)
        {
            try
            {
                var encontrado = corteDatos.Obtener(idCorte);

                if (encontrado.IdCorte == 0)
                    throw new OperationCanceledException("No existe el corte solicitado");

                return corteDatos.Eliminar(idCorte);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
