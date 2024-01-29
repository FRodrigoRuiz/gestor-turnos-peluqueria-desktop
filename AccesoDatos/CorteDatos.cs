using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dominio;
using System.Data;
using System.Data.SqlClient;

namespace AccesoDatos
{
    public class CorteDatos
    {
        public List<Corte> Lista()
        {
            List<Corte> lista = new List<Corte>();

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
            {
                SqlCommand cmd = new SqlCommand("Select * from fn_cortes()", oConexion);
                cmd.CommandType = CommandType.Text;
                try
                {
                    oConexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Corte
                            {
                                IdCorte = Convert.ToInt32(dr["IdCorte"].ToString()),
                                TipoCorte = dr["TipoCorte"].ToString()
                            });
                        }
                    }

                    return lista;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }


    }
}
