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
    public class ProveedoresRepositorio:DbHelperSql,IProveedoresRepositorio
    {
        private readonly string tabla = "Proveedores";

        public ProveedoresRepositorio(SqlConnection context, SqlTransaction transaction)
        {
            this._context = context;
            this._transaction = transaction;
        }
        public List<Proveedor> GetLista()
        {
            try
            {
                List<Proveedor> lista = new List<Proveedor>();
                string cadenaComando = "SELECT ProveedorId, NombreFantasia, ApellidoContacto, NombresContacto, Direccion," +
                                       " ProvinciaId, LocalidadId, CodPostal, TelefonoFijo," +
                                       " TelefonoMovil, Mail, RowVersion  " +
                                       "FROM Proveedores ORDER BY NombreFantasia";
                using (var comando = CreateCommand(cadenaComando))
                {
                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var proveedor = ConstruirProveedor(reader);
                            lista.Add(proveedor);
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

        private Proveedor ConstruirProveedor(IDataReader reader)
        {
            return new Proveedor()
            {
                Id = reader.GetInt32(0),
                NombreFantasia = reader.GetString(1),
                Apellido = reader.GetString(2),
                Nombres = reader.GetString(3),
                Direccion = reader.GetString(4),
                ProvinciaId = reader.GetInt32(5),
                LocalidadId = reader.GetInt32(6),
                CodPostal = reader[7] != DBNull.Value ? reader.GetString(7) : string.Empty,
                TelefonoFijo = reader[8] != DBNull.Value ? reader.GetString(8) : string.Empty,
                TelefonoMovil = reader[9] != DBNull.Value ? reader.GetString(9) : string.Empty,
                Mail = reader[10] != DBNull.Value ? reader.GetString(10) : string.Empty,
                RowVersion = (byte[])reader[11]
            };
        }

        public Proveedor GetPorId(int id)
        {
            throw new NotImplementedException();
        }

        public int Agregar(Proveedor obj)
        {

            try
            {
                int registrosAfectados = 0;
                string cadenaComando = "INSERT INTO Proveedores (NombreFantasia, ApellidoContacto, NombresContacto, Direccion, ProvinciaId," +
                                       " LocalidadId, CodPostal, TelefonoFijo, TelefonoMovil, Mail)" +
                                       " VALUES (@fta, @ape, @nom, @dir, @prov, @loc, @cod, @fijo, @mov, @mail)";
                using (var comando = (SqlCommand)CreateCommand(cadenaComando))
                {
                    comando.Parameters.AddWithValue("@fta", obj.NombreFantasia);
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
                        cadenaComando = "SELECT RowVersion FROM Proveedores WHERE ProveedorId=@id";
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

        public int Borrar(Proveedor obj)
        {
            throw new NotImplementedException();
        }

        public int Editar(Proveedor obj)
        {
            int registrosAfectados = 0;
            try
            {
                string cadenaComando = "UPDATE Proveedores SET NombreFantasia=@fta, ApellidoContacto=@ape, NombresContacto=@nom, Direccion=@dir," +
                                       " ProvinciaId=@prov, LocalidadId=@loc, CodPostal=@cod, TelefonoFijo=@fijo, " +
                                        "TelefonoMovil=@cel, Mail=@mail " +
                                       " WHERE ProveedorId=@id";
                using (var comando = (SqlCommand)CreateCommand(cadenaComando))
                {
                    comando.Parameters.AddWithValue("@fta", obj.NombreFantasia);

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

                    registrosAfectados = comando.ExecuteNonQuery();
                    if (registrosAfectados > 0)
                    {
                        cadenaComando = "SELECT RowVersion FROM Proveedores WHERE ProveedorId=@id";
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

        public bool Existe(Proveedor proveedor)
        {
            try
            {
                int registrosAfectados = 0;
                if (proveedor.Id == 0)
                {
                    //Es un alta
                    string cadenaComando = "SELECT COUNT(*) FROM Proveedores WHERE NombreFantasia=@fta";
                    using (var comando = (SqlCommand)CreateCommand(cadenaComando))
                    {
                        comando.Parameters.AddWithValue("@fta", proveedor.NombreFantasia);

                        registrosAfectados = (int)comando.ExecuteScalar();
                    }
                }
                else
                {
                    //Es una edición
                    string cadenaComando = "SELECT COUNT(*) FROM Proveedores WHERE NombreFantasia=@fta AND ProveedorId<>@id";
                    using (var comando = (SqlCommand)CreateCommand(cadenaComando))
                    {
                        comando.Parameters.AddWithValue("@fta", proveedor.NombreFantasia);
                        comando.Parameters.AddWithValue("@id", proveedor.Id);
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

        public bool EstaRelacionado(Proveedor proveedor)
        {
            throw new NotImplementedException();
        }
    }
}
