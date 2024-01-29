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
    public class TurnoDatos
    {
        public List<Turno> Lista()
        {
            List<Turno> lista = new List<Turno>();

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
            {
                SqlCommand cmd = new SqlCommand("Select * from fn_turnos()", oConexion);
                cmd.CommandType = CommandType.Text;
                try
                {
                    oConexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Turno
                            {
                                IdTurno = Convert.ToInt32(dr["IdTurno"].ToString()),
                                Fecha = Convert.ToDateTime(dr["Fecha"]),
                                NombreCliente = dr["NombreCliente"].ToString(),
                                Empleado = new Empleado
                                {
                                    IdEmpleado = Convert.ToInt32(dr["IdEmpleado"].ToString()),
                                    Nombre = dr["Nombre"].ToString()
                                },
                                Corte = new Corte
                                {
                                    IdCorte = Convert.ToInt32(dr["IdCorte"].ToString()),
                                    TipoCorte = dr["TipoCorte"].ToString()
                                }
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

        public Turno Obtener(int IdTurno)
        {
            Turno entidad = new Turno();

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
            {
                SqlCommand cmd = new SqlCommand("Select * from fn_turno(@idTurno)", oConexion);
                cmd.Parameters.AddWithValue("@idTurno", IdTurno);
                cmd.CommandType = CommandType.Text;
                try
                {
                    oConexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        
                        if(dr.Read())
                        {
                            entidad.IdTurno = Convert.ToInt32(dr["IdTurno"].ToString());
                            entidad.Fecha = Convert.ToDateTime(dr["Fecha"]);
                            entidad.Empleado = new Empleado
                            {
                                IdEmpleado = Convert.ToInt32(dr["IdEmpleado"].ToString()),
                                Nombre = dr["Nombre"].ToString()
                            };
                            entidad.Corte = new Corte
                            {
                                IdCorte = Convert.ToInt32(dr["IdCorte"].ToString()),
                                TipoCorte = dr["TipoCorte"].ToString()
                            };
                        }
                    }

                    return entidad;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool Crear(Turno entidad)
        {
            bool respuesta = false;

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
            {
                SqlCommand cmd = new SqlCommand("sp_CrearTurno", oConexion);
                cmd.Parameters.AddWithValue("@Fecha", entidad.Fecha);
                cmd.Parameters.AddWithValue("@NombreCliente", entidad.NombreCliente);
                cmd.Parameters.AddWithValue("@IdEmpleado", entidad.Empleado.IdEmpleado);
                cmd.Parameters.AddWithValue("@IdCorte", entidad.Corte.IdCorte);
                cmd.CommandType = CommandType.StoredProcedure;
                try
                {
                    oConexion.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    if (filasAfectadas > 0)
                        respuesta = true;

                    return respuesta;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool Editar(Turno entidad)
        {
            bool respuesta = false;

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
            {
                SqlCommand cmd = new SqlCommand("sp_EditarTurno", oConexion);
                cmd.Parameters.AddWithValue("@IdTurno", entidad.IdTurno);
                cmd.Parameters.AddWithValue("@Fecha", entidad.Fecha);
                cmd.Parameters.AddWithValue("@NombreCliente", entidad.NombreCliente);
                cmd.Parameters.AddWithValue("@IdEmpleado", entidad.Empleado.IdEmpleado);
                cmd.Parameters.AddWithValue("@IdCorte", entidad.Corte.IdCorte);
                cmd.CommandType = CommandType.StoredProcedure;
                try
                {
                    oConexion.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    if (filasAfectadas > 0)
                        respuesta = true;

                    return respuesta;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool Eliminar(int IdTurno)
        {
            bool respuesta = false;

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
            {
                SqlCommand cmd = new SqlCommand("sp_EliminarTurno", oConexion);
                cmd.Parameters.AddWithValue("@IdTurno", IdTurno);
                cmd.CommandType = CommandType.StoredProcedure;
                try
                {
                    oConexion.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    if (filasAfectadas > 0)
                        respuesta = true;

                    return respuesta;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
