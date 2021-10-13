using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroAppComercial2021.Datos.Comun.Excepciones;
using MetroAppComercial2021.Datos.Comun.Repositorios;
using MetroAppComercial2021.Datos.Sql.DbHelper;
using MetroAppComercial2021.Entidades.Entidades;

namespace MetroAppComercial2021.Datos.Sql.Repositorios
{
    public class EmpleadosRepositorio:DbHelperSql,IEmpleadosRepositorio
    {
        private readonly string tabla = "Empleados";

        public EmpleadosRepositorio(SqlConnection context, SqlTransaction transaction)
        {
            this._context = context;
            this._transaction = transaction;
        }
        public List<Empleado> GetLista()
        {
            try
            {
                List<Empleado> lista = new List<Empleado>();
                string cadenaComando = "SELECT EmpleadoId, Apellido, Nombres, FechaNacimiento, FechaContratacion, Direccion," +
                                       " ProvinciaId, LocalidadId, CodPostal, TelefonoFijo," +
                                       " TelefonoMovil, Mail, Activo, RowVersion  " +
                                       "FROM Empleados WHERE Activo=1 ORDER BY Apellido, Nombres";
                using (var comando = CreateCommand(cadenaComando))
                {
                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var empleado = ConstruirEmpleado(reader);
                            lista.Add(empleado);
                        }
                    }
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw DbExceptionManager.GettingException(tabla);
            }
        }

        private Empleado ConstruirEmpleado(IDataReader reader)
        {
            return new Empleado()
            {
                Id = reader.GetInt32(0),
                Apellido = reader.GetString(1),
                Nombres = reader.GetString(2),
                FechaNacimiento = reader.GetDateTime(3),
                FechaContratacion = reader.GetDateTime(4),
                Direccion =reader[5]!=DBNull.Value?reader.GetString(5):string.Empty,
                ProvinciaId = reader.GetInt32(6),
                LocalidadId = reader.GetInt32(7),
                CodPostal = reader[8] != DBNull.Value ? reader.GetString(8) : string.Empty,
                TelefonoFijo = reader[9] != DBNull.Value ? reader.GetString(9) : string.Empty,
                TelefonoMovil = reader[10] != DBNull.Value ? reader.GetString(10) : string.Empty,
                Mail = reader[11] != DBNull.Value ? reader.GetString(11) : string.Empty,
                Activo = reader.GetBoolean(12),
                RowVersion = (byte[])reader[13]
            };
        }

        public Empleado GetPorId(int id)
        {
            try
            {
                Empleado empleado=null;
                string cadenaComando = "SELECT EmpleadoId, Apellido, Nombres, FechaNacimiento, FechaContratacion, Direccion," +
                                       " ProvinciaId, LocalidadId, CodPostal, TelefonoFijo," +
                                       " TelefonoMovil, Mail, Activo, RowVersion  " +
                                       "FROM Empleados WHERE EmpleadoId=@id";
                using (var comando = (SqlCommand)CreateCommand(cadenaComando))
                {
                    comando.Parameters.AddWithValue("@id", id);
                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            empleado = ConstruirEmpleado(reader);
                            
                        }
                    }
                }

                return empleado;
            }
            catch (Exception ex)
            {
                throw DbExceptionManager.GettingException(tabla);
            }
        }

        public int Agregar(Empleado obj)
        {

            try
            {
                int registrosAfectados = 0;
                string cadenaComando = "INSERT INTO Empleados (Apellido, Nombres, FechaNacimiento, FechaContratacion, Direccion, ProvinciaId," +
                                       " LocalidadId, CodPostal, TelefonoFijo, TelefonoMovil, Mail, Activo)" +
                                       " VALUES (@ape, @nom, @fecnac, @feccont @dir, @prov, @loc, @cod, @fijo, @mov, @mail, @act)";
                using (var comando = (SqlCommand)CreateCommand(cadenaComando))
                {
                    comando.Parameters.AddWithValue("@ape", obj.Apellido);
                    comando.Parameters.AddWithValue("@nom", obj.Nombres);
                    comando.Parameters.AddWithValue("@fecnac", obj.FechaNacimiento);
                    comando.Parameters.AddWithValue("@feccont", obj.FechaContratacion);

                    comando.Parameters.AddWithValue("@dir", obj.Direccion);
                    comando.Parameters.AddWithValue("@prov", obj.ProvinciaId);
                    comando.Parameters.AddWithValue("@loc", obj.LocalidadId);
                    if (!string.IsNullOrEmpty(obj.CodPostal))
                    {
                        comando.Parameters.AddWithValue("@cod", obj.CodPostal);
                    }
                    else
                    {
                        comando.Parameters.AddWithValue("@cod", DBNull.Value);
                    }
                    if (!string.IsNullOrEmpty(obj.TelefonoFijo))
                    {
                        comando.Parameters.AddWithValue("@fijo", obj.TelefonoFijo);
                    }
                    else
                    {
                        comando.Parameters.AddWithValue("@fijo", DBNull.Value);
                    }
                    if (!string.IsNullOrEmpty(obj.TelefonoMovil))
                    {
                        comando.Parameters.AddWithValue("@mov", obj.TelefonoMovil);
                    }
                    else
                    {
                        comando.Parameters.AddWithValue("@mov", DBNull.Value);
                    }
                    if (!string.IsNullOrEmpty(obj.Mail))
                    {
                        comando.Parameters.AddWithValue("@mail", obj.Mail);
                    }
                    else
                    {
                        comando.Parameters.AddWithValue("@mail", DBNull.Value);
                    }

                    comando.Parameters.AddWithValue("@act", obj.Activo);
                    registrosAfectados = comando.ExecuteNonQuery();
                    if (registrosAfectados > 0)
                    {
                        string cadenaOutput = "SELECT @@IDENTITY";
                        using (var comandoOutput = CreateCommand(cadenaOutput))
                        {
                            obj.Id = (int)(decimal)comandoOutput.ExecuteScalar();
                        }
                        cadenaComando = "SELECT RowVersion FROM Empleados WHERE EmpleadoId=@id";
                        using (var comandoRow = (SqlCommand)CreateCommand(cadenaComando))
                        {
                            comandoRow.Parameters.AddWithValue("@id", obj.Id);
                            obj.RowVersion = (byte[])comandoRow.ExecuteScalar();
                        }

                    }
                }

                return registrosAfectados;
            }
            catch (Exception ex)
            {
                throw DbExceptionManager.InsertException(tabla);
            }
        }

        public int Borrar(Empleado obj)
        {
            int registrosAfectados = 0;
            try
            {
                string cadenaComando = "DELETE FROM Empleados WHERE EmpleadoId=@id AND RowVersion=@ver";
                using (var comando = (SqlCommand)CreateCommand(cadenaComando))
                {
                    comando.Parameters.AddWithValue("@id", obj.Id);
                    comando.Parameters.AddWithValue("@ver", obj.RowVersion);

                    registrosAfectados = comando.ExecuteNonQuery();
                }

                return registrosAfectados;
            }
            catch (Exception e)
            {
                throw DbExceptionManager.InsertException(tabla);
            }

        }

        public int Editar(Empleado obj)
        {
            int registrosAfectados = 0;
            try
            {
                string cadenaComando = "UPDATE Empleados SET Apellido=@ape, Nombres=@nom, FechaNacimiento=@fecnact, FechaContratacion=@feccont,  Direccion=@dir," +
                                       " ProvinciaId=@prov, LocalidadId=@loc, CodPostal=@cod, TelefonoFijo=@fijo, " +
                                        "TelefonoMovil=@cel, Mail=@mail, Activo=@act " +
                                       " WHERE EmpleadoId=@id AND RowVersion=@rov";
                using (var comando = (SqlCommand)CreateCommand(cadenaComando))
                {
                    comando.Parameters.AddWithValue("@ape", obj.Apellido);
                    comando.Parameters.AddWithValue("@nom", obj.Nombres);
                    comando.Parameters.AddWithValue("@fecnac", obj.FechaNacimiento);
                    comando.Parameters.AddWithValue("@feccont", obj.FechaContratacion);

                    comando.Parameters.AddWithValue("@dir", obj.Direccion);
                    comando.Parameters.AddWithValue("@prov", obj.ProvinciaId);
                    comando.Parameters.AddWithValue("@loc", obj.LocalidadId);
                    if (!string.IsNullOrEmpty(obj.CodPostal))
                    {
                        comando.Parameters.AddWithValue("@cod", obj.CodPostal);
                    }
                    else
                    {
                        comando.Parameters.AddWithValue("@cod", DBNull.Value);
                    }
                    if (!string.IsNullOrEmpty(obj.TelefonoFijo))
                    {
                        comando.Parameters.AddWithValue("@fijo", obj.TelefonoFijo);
                    }
                    else
                    {
                        comando.Parameters.AddWithValue("@fijo", DBNull.Value);
                    }
                    if (!string.IsNullOrEmpty(obj.TelefonoMovil))
                    {
                        comando.Parameters.AddWithValue("@mov", obj.TelefonoMovil);
                    }
                    else
                    {
                        comando.Parameters.AddWithValue("@mov", DBNull.Value);
                    }
                    if (!string.IsNullOrEmpty(obj.Mail))
                    {
                        comando.Parameters.AddWithValue("@mail", obj.Mail);
                    }
                    else
                    {
                        comando.Parameters.AddWithValue("@mail", DBNull.Value);
                    }

                    comando.Parameters.AddWithValue("@act", obj.Activo);

                    comando.Parameters.AddWithValue("@id", obj.Id);
                    comando.Parameters.AddWithValue("@id", obj.RowVersion);


                    registrosAfectados = comando.ExecuteNonQuery();
                    if (registrosAfectados > 0)
                    {
                        cadenaComando = "SELECT RowVersion FROM Empleados WHERE EmpleadoId=@id";
                        using (var comandoRow = (SqlCommand)CreateCommand(cadenaComando))
                        {
                            comandoRow.Parameters.AddWithValue("@id", obj.Id);
                            obj.RowVersion = (byte[])comandoRow.ExecuteScalar();
                        }

                    }
                }

                return registrosAfectados;
            }
            catch (Exception e)
            {
                throw DbExceptionManager.InsertException(tabla);
            }
        }

        public bool Existe(Empleado empleado)
        {
            try
            {
                int registrosAfectados = 0;
                if (empleado.Id == 0)
                {
                    //Es un alta
                    string cadenaComando = "SELECT COUNT(*) FROM Empleados WHERE Apellido=@ape AND Nombres=@nom";
                    using (var comando = (SqlCommand)CreateCommand(cadenaComando))
                    {
                        comando.Parameters.AddWithValue("@ape", empleado.Apellido);
                        comando.Parameters.AddWithValue("@nom", empleado.Nombres);

                        registrosAfectados = (int)comando.ExecuteScalar();
                    }
                }
                else
                {
                    //Es una edición
                    string cadenaComando = "SELECT COUNT(*) FROM Empleados WHERE Apellido=@ape AND Nombres=@nom AND EmpleadoId<>@id";
                    using (var comando = (SqlCommand)CreateCommand(cadenaComando))
                    {
                        comando.Parameters.AddWithValue("@ape", empleado.Apellido);
                        comando.Parameters.AddWithValue("@nom", empleado.Nombres);
                        comando.Parameters.AddWithValue("@id", empleado.Id);
                        registrosAfectados = (int)comando.ExecuteScalar();
                    }
                }

                return registrosAfectados > 0;
            }
            catch (Exception e)
            {
                throw DbExceptionManager.GettingException(tabla);
            }
        }

        public bool EstaRelacionado(Empleado empleado)
        {
            //Veremos luego si se relaciona con la tabla de ventas
            return false;
        }
    }
}
