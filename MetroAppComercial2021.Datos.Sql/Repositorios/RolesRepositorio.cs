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
    public class RolesRepositorio:DbHelperSql, IRolesRepositorio
    {
        private readonly string tabla = "Roles";

        public RolesRepositorio(SqlConnection context, SqlTransaction transaction)
        {
            this._context = context;
            this._transaction = transaction;
        }

        public List<Rol> GetLista()
        {
            List<Rol> lista = new List<Rol>();
            try
            {
                string cadenaComando =
                    "SELECT RolId, NombreRol, RowVersion FROM Roles";
                using (var comando = CreateCommand(cadenaComando))
                {
                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var rol = ConstruirRol(reader);
                            lista.Add(rol);
                        }
                    }
                }

                return lista;
            }
            catch (Exception e)
            {
                throw DbExceptionManager.GettingException(tabla);
            }
        }

        private Rol ConstruirRol(IDataReader reader)
        {
            return new Rol()
            {
                RolId = reader.GetInt32(0),
                NombreRol = reader.GetString(1),
                RowVersion = (byte[])reader[2]
            };
        }

        public Rol GetPorId(int id)
        {
            Rol tipo = null;
            try
            {
                string cadenaComando =
                    "SELECT RolId, NombreRol, RowVersion FROM Roles WHERE RolId=@id";
                using (var comando = (SqlCommand)CreateCommand(cadenaComando))
                {
                    comando.Parameters.AddWithValue("@id", id);
                    using (var reader = comando.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            tipo = ConstruirRol(reader);
                        }
                    }
                }

                return tipo;
            }
            catch (Exception e)
            {
                throw DbExceptionManager.GettingException(tabla);
            }
        }

        public int Agregar(Rol obj)
        {
            int registrosAfectados = 0;
            try
            {
                string cadenaComando = "INSERT INTO Roles (NombreRol) VALUES(@desc)";
                using (var comando = (SqlCommand)CreateCommand(cadenaComando))
                {
                    comando.Parameters.AddWithValue("@desc", obj.NombreRol);
                    registrosAfectados = comando.ExecuteNonQuery();
                    if (registrosAfectados > 0)
                    {
                        string cadenaOutput = "SELECT @@IDENTITY";
                        using (var comandoOutput = CreateCommand(cadenaOutput))
                        {
                            obj.RolId = (int)(decimal)comandoOutput.ExecuteScalar();
                        }

                        cadenaComando = "SELECT RowVersion FROM Roles WHERE RolId=@id";
                        using (var comandoRow = (SqlCommand)CreateCommand(cadenaComando))
                        {
                            comandoRow.Parameters.AddWithValue("@id", obj.RolId);
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

        public int Borrar(Rol obj)
        {
            int registrosAfectados = 0;
            try
            {
                string cadenaComando = "DELETE FROM Roles WHERE RolId=@id AND RowVersion=@ver";
                using (var comando = (SqlCommand)CreateCommand(cadenaComando))
                {
                    comando.Parameters.AddWithValue("@id", obj.RolId);
                    comando.Parameters.AddWithValue("@ver", obj.RowVersion);

                    registrosAfectados = comando.ExecuteNonQuery();
                }

                return registrosAfectados;
            }
            catch (Exception e)
            {
                throw DbExceptionManager.DeleteException(tabla);
            }
        }

        public int Editar(Rol obj)
        {
            int registrosAfectados = 0;
            try
            {
                string cadenaComando =
                    "UPDATE Roles SET NombreRol=@desc WHERE RolId=@id AND RowVersion=@row";
                using (var comando = (SqlCommand)CreateCommand(cadenaComando))
                {
                    comando.Parameters.AddWithValue("@desc", obj.NombreRol);
                    comando.Parameters.AddWithValue("@id", obj.RolId);
                    comando.Parameters.AddWithValue("@row", obj.RowVersion);

                    registrosAfectados = comando.ExecuteNonQuery();
                    if (registrosAfectados > 0)
                    {
                        cadenaComando = "SELECT RowVersion FROM Roles WHERE RolId=@id";
                        using (var comandoOutput = (SqlCommand)CreateCommand(cadenaComando))
                        {
                            comandoOutput.Parameters.AddWithValue("@id", obj.RolId);
                            obj.RowVersion = (byte[])comandoOutput.ExecuteScalar();
                        }
                    }

                }

                return registrosAfectados;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public bool Existe(Rol obj)
        {
            try
            {
                int registrosAfectados = 0;
                if (obj.RolId == 0)
                {
                    //Es un alta
                    string cadenaComando = "SELECT COUNT(*) FROM Roles WHERE NombreRol=@desc";
                    using (var comando = (SqlCommand)CreateCommand(cadenaComando))
                    {
                        comando.Parameters.AddWithValue("@desc", obj.NombreRol);
                        registrosAfectados = (int)comando.ExecuteScalar();
                    }
                }
                else
                {
                    //Es una edición
                    string cadenaComando =
                        "SELECT COUNT(*) FROM Roles WHERE NombreRol=@desc AND RolId<>@id";
                    using (var comando = (SqlCommand)CreateCommand(cadenaComando))
                    {
                        comando.Parameters.AddWithValue("@desc", obj.NombreRol);
                        comando.Parameters.AddWithValue("@id", obj.RolId);
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

        public bool EstaRelacionado(Rol obj)
        {
            try
            {
                int registrosAfectados = 0;
                string cadenaComando = "SELECT COUNT(*) FROM Localidades WHERE RolId=@id";
                using (var comando = (SqlCommand)CreateCommand(cadenaComando))
                {
                    comando.Parameters.AddWithValue("@id", obj.RolId);
                    registrosAfectados = (int)comando.ExecuteScalar();
                }

                return registrosAfectados > 0;
            }
            catch (Exception e)
            {
                throw DbExceptionManager.GettingException(tabla);
            }
        }

    }
}
