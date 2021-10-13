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
    public class UsuariosRepositorio:DbHelperSql, IUsuariosRepositorio
    {
        private readonly string tabla = "Usuarios";
        public UsuariosRepositorio(SqlConnection context, SqlTransaction transaction)
        {
            this._context = context;
            this._transaction = transaction;
        }

        public Usuario GetUsuario(int empleadoId, string password)
        {
            Usuario usuario = null;
            try
            {
                string cadenaComando =
                    "SELECT UsuarioId, EmpleadoId, RolId, Password, RowVersion FROM Usuarios WHERE EmpleadoId=@id AND Password=@pass";
                using (var comando = (SqlCommand)CreateCommand(cadenaComando))
                {
                    comando.Parameters.AddWithValue("@id", empleadoId);
                    comando.Parameters.AddWithValue("@pass", password);

                    using (var reader = comando.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            usuario = ConstruirUsuario(reader);
                        }
                    }
                }
                return usuario;
            }
            catch (Exception e)
            {
                throw DbExceptionManager.GettingException(tabla);
            }

        }

        public List<Usuario> GetLista()
        {
            try
            {
                List<Usuario> lista = new List<Usuario>();
                string cadenaComando = "SELECT UsuarioId, EmpleadoId, RolId, Password, RowVersion  " +
                                       "FROM Usuarios";
                using (var comando = CreateCommand(cadenaComando))
                {
                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var usuario = ConstruirUsuario(reader);
                            lista.Add(usuario);
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

        public bool Existe(Usuario usuario)
        {
            try
            {
                int registrosAfectados = 0;
                if (usuario.UsuarioId == 0)
                {
                    //Es un alta
                    string cadenaComando = "SELECT COUNT(*) FROM Usuarios WHERE EmpleadoId=@emp";
                    using (var comando = (SqlCommand)CreateCommand(cadenaComando))
                    {
                        comando.Parameters.AddWithValue("@nom", usuario.EmpleadoId);

                        registrosAfectados = (int)comando.ExecuteScalar();
                    }
                }
                else
                {
                    //Es una edición
                    string cadenaComando =
                        "SELECT COUNT(*) FROM Usuarios WHERE EmpleadoId=@emp AND UsuarioId<>@id";
                    using (var comando = (SqlCommand)CreateCommand(cadenaComando))
                    {
                        comando.Parameters.AddWithValue("@nom", usuario.EmpleadoId);
                        comando.Parameters.AddWithValue("@id", usuario.UsuarioId);
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

        public int Agregar(Usuario usuario)
        {
            int registrosAfectados = 0;
            try
            {
                string cadenaComando = "INSERT INTO Usuarios (EmpleadoId, RolId, Password) VALUES(@emp, @rol, @pass)";
                using (var comando = (SqlCommand)CreateCommand(cadenaComando))
                {
                    comando.Parameters.AddWithValue("@emp", usuario.EmpleadoId);
                    comando.Parameters.AddWithValue("@rol",usuario.RolId);
                    comando.Parameters.AddWithValue("@pass","1234");

                    registrosAfectados = comando.ExecuteNonQuery();
                    if (registrosAfectados > 0)
                    {
                        string cadenaOutput = "SELECT @@IDENTITY";
                        using (var comandoOutput = CreateCommand(cadenaOutput))
                        {
                            usuario.UsuarioId = (int)(decimal)comandoOutput.ExecuteScalar();
                        }
                        cadenaComando = "SELECT RowVersion FROM Usuarios WHERE UsuarioId=@id";
                        using (var comandoRow = (SqlCommand)CreateCommand(cadenaComando))
                        {
                            comandoRow.Parameters.AddWithValue("@id", usuario.UsuarioId);
                            usuario.RowVersion = (byte[])comandoRow.ExecuteScalar();
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

        public int Editar(Usuario usuario)
        {
            int registrosAfectados = 0;
            try
            {
                string cadenaComando =
                    "UPDATE Usuarios SET EmpleadoId=@emp, RolId=@rol WHERE UsuarioId=@id AND RowVersion=@row";
                using (var comando = (SqlCommand)CreateCommand(cadenaComando))
                {
                    comando.Parameters.AddWithValue("@emp", usuario.EmpleadoId);
                    comando.Parameters.AddWithValue("@rol", usuario.RolId);
                    comando.Parameters.AddWithValue("@row", usuario.RowVersion);

                    registrosAfectados = comando.ExecuteNonQuery();
                    if (registrosAfectados > 0)
                    {
                        cadenaComando = "SELECT RowVersion FROM Usuarios WHERE UsuarioId=@id";
                        using (var comandoOutput = (SqlCommand)CreateCommand(cadenaComando))
                        {
                            comandoOutput.Parameters.AddWithValue("@id", usuario.UsuarioId);
                            usuario.RowVersion = (byte[])comandoOutput.ExecuteScalar();
                        }
                    }

                }

                return registrosAfectados;
            }
            catch (Exception e)
            {
                throw DbExceptionManager.UpdateException(tabla);
            }
        }

        public int Borrar(Usuario usuario)
        {
            int registrosAfectados = 0;
            try
            {
                string cadenaComando = "DELETE FROM Usuarios WHERE UsuarioId=@id AND RowVersion=@ver";
                using (var comando = (SqlCommand)CreateCommand(cadenaComando))
                {
                    comando.Parameters.AddWithValue("@id", usuario.UsuarioId);
                    comando.Parameters.AddWithValue("@ver", usuario.RowVersion);

                    registrosAfectados = comando.ExecuteNonQuery();
                }

                return registrosAfectados;
            }
            catch (Exception e)
            {
                throw DbExceptionManager.DeleteException(tabla);
            }
        }

        private Usuario ConstruirUsuario(IDataReader reader)
        {
            return new Usuario()
            {
                UsuarioId = reader.GetInt32(0),
                EmpleadoId = reader.GetInt32(1),
                RolId = reader.GetInt32(2),
                Password = reader.GetString(3)
            };
        }
    }
}
