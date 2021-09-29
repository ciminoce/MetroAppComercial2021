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
    public class ClientesRepositorio:DbHelperSql,IClientesRepositorio
    {
        private readonly string tabla = "Clientes";

        public ClientesRepositorio(SqlConnection context, SqlTransaction transaction)
        {
            this._context=context;
            this._transaction = transaction;
        }
        public List<Cliente> GetLista()
        {
            try
            {
                List<Cliente> lista = new List<Cliente>();
                string cadenaComando = "SELECT ClienteId, Apellido, Nombres, Direccion," +
                                       " ProvinciaId, LocalidadId, CodPostal, TelefonoFijo," +
                                       " TelefonoMovil, Mail, RowVersion  " +
                                       "FROM Clientes ORDER BY Apellido, Nombres";
                using (var comando = CreateCommand(cadenaComando))
                {
                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var cliente = ConstruirCliente(reader);
                            lista.Add(cliente);
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

        private Cliente ConstruirCliente(IDataReader reader)
        {
            return new Cliente()
            {
                Id = reader.GetInt32(0),
                Apellido = reader.GetString(1),
                Nombres = reader.GetString(2),
                Direccion = reader.GetString(3),
                ProvinciaId = reader.GetInt32(4),
                LocalidadId = reader.GetInt32(5),
                CodPostal =reader[6]!=DBNull.Value?reader.GetString(6):string.Empty,
                TelefonoFijo =reader[7]!=DBNull.Value?reader.GetString(7):string.Empty,
                TelefonoMovil =reader[8]!=DBNull.Value?reader.GetString(8):string.Empty,
                Mail =reader[9]!=DBNull.Value?reader.GetString(9):string.Empty,
                RowVersion = (byte[]) reader[10]
            };
        }

        public Cliente GetPorId(int id)
        {
            throw new NotImplementedException();
        }

        public int Agregar(Cliente obj)
        {

            try
            {
                int registrosAfectados = 0;
                string cadenaComando = "INSERT INTO Clientes (Apellido, Nombres, Direccion, ProvinciaId," +
                                       " LocalidadId, CodPostal, TelefonoFijo, TelefonoMovil, Mail)" +
                                       " VALUES (@ape, @nom, @dir, @prov, @loc, @cod, @fijo, @mov, @mail)";
                using (var comando =(SqlCommand) CreateCommand(cadenaComando))
                {
                    comando.Parameters.AddWithValue("@ape", obj.Apellido);
                    comando.Parameters.AddWithValue("@nom", obj.Nombres);
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

                    registrosAfectados = comando.ExecuteNonQuery();
                    if (registrosAfectados > 0)
                    {
                        string cadenaOutput = "SELECT @@IDENTITY";
                        using (var comandoOutput = CreateCommand(cadenaOutput))
                        {
                            obj.Id = (int)(decimal)comandoOutput.ExecuteScalar();
                        }
                        cadenaComando = "SELECT RowVersion FROM Clientes WHERE ClienteId=@id";
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

        public int Borrar(Cliente obj)
        {
            int registrosAfectados = 0;
            try
            {
                string cadenaComando = "DELETE FROM Clientes WHERE ClienteId=@id AND RowVersion=@ver";
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

        public int Editar(Cliente obj)
        {
            int registrosAfectados = 0;
            try
            {
                string cadenaComando = "UPDATE Clientes SET Apellido=@ape, Nombres=@nom, Direccion=@dir," +
                                       " ProvinciaId=@prov, LocalidadId=@loc, CodPostal=@cod, TelefonoFijo=@fijo, " +
                                        "TelefonoMovil=@cel, Mail=@mail " +
                                       " WHERE ClienteId=@id AND RowVersion=@rov";
                using (var comando = (SqlCommand)CreateCommand(cadenaComando))
                {
                    comando.Parameters.AddWithValue("@ape", obj.Apellido);
                    comando.Parameters.AddWithValue("@nom", obj.Nombres);
                    comando.Parameters.AddWithValue("@dir", obj.Direccion);
                    comando.Parameters.AddWithValue("@prov", obj.ProvinciaId);
                    comando.Parameters.AddWithValue("@loc", obj.LocalidadId);
                    if (!string.IsNullOrEmpty(obj.CodPostal))
                    {
                        comando.Parameters.AddWithValue("@cod", obj.Id);
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
                        comando.Parameters.AddWithValue("@cel", obj.TelefonoMovil);
                    }
                    else
                    {
                        comando.Parameters.AddWithValue("@cel", DBNull.Value);

                    }
                    if (!string.IsNullOrEmpty(obj.Mail))
                    {
                        comando.Parameters.AddWithValue("@mail", obj.Mail);
                    }
                    else
                    {
                        comando.Parameters.AddWithValue("@mail", DBNull.Value);

                    }

                    comando.Parameters.AddWithValue("@id", obj.Id);
                    comando.Parameters.AddWithValue("@id", obj.RowVersion);


                    registrosAfectados = comando.ExecuteNonQuery();
                    if (registrosAfectados > 0)
                    {
                        cadenaComando = "SELECT RowVersion FROM Clientes WHERE ClienteId=@id";
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

        public bool Existe(Cliente cliente)
        {
            try
            {
                int registrosAfectados = 0;
                if (cliente.Id == 0)
                {
                    //Es un alta
                    string cadenaComando = "SELECT COUNT(*) FROM Clientes WHERE Apellido=@ape AND Nombres=@nom";
                    using (var comando = (SqlCommand)CreateCommand(cadenaComando))
                    {
                        comando.Parameters.AddWithValue("@ape", cliente.Apellido);
                        comando.Parameters.AddWithValue("@nom", cliente.Nombres);

                        registrosAfectados = (int)comando.ExecuteScalar();
                    }
                }
                else
                {
                    //Es una edición
                    string cadenaComando = "SELECT COUNT(*) FROM Clientes WHERE Apellido=@ape AND Nombres=@nom AND ClienteId<>@id";
                    using (var comando = (SqlCommand)CreateCommand(cadenaComando))
                    {
                        comando.Parameters.AddWithValue("@ape", cliente.Apellido);
                        comando.Parameters.AddWithValue("@nom", cliente.Nombres);
                        comando.Parameters.AddWithValue("@id", cliente.Id);
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

        public bool EstaRelacionado(Cliente cliente)
        {
            //Veremos luego si se relaciona con la tabla de ventas
            return false;
        }
    }
}
