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
    public class CajasRepositorio:DbHelperSql,ICajasRepositorio
    {
        private readonly string tabla = "Cajas";
        public CajasRepositorio(SqlConnection context, SqlTransaction transaction)
        {
            this._context = context;
            this._transaction = transaction;
        }

        public List<Caja> GetLista()
        {
            try
            {
                List<Caja> lista = new List<Caja>();
                string cadenaComando = "SELECT CajaId, NombreCaja, Descripcion," +
                                       " PrecioCosto, PrecioVenta, CantidadEnExistencia, CantidadEnPedido," +
                                       " NivelDeReposicion, Suspendido, Imagen, RowVersion  " +
                                       "FROM Cajas ORDER BY NombreCaja";
                using (var comando = CreateCommand(cadenaComando))
                {
                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var Caja = ConstruirCaja(reader);
                            lista.Add(Caja);
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

        private Caja ConstruirCaja(IDataReader reader)
        {
            return new Caja()
            {
                Id = reader.GetInt32(0),
                NombreProducto = reader.GetString(1),
                Descripcion = reader[2] != DBNull.Value ? reader.GetString(2) : string.Empty,
                PrecioCosto = reader.GetDecimal(3),
                PrecioVenta = reader.GetDecimal(4),
                CantidadEnExistencia = reader.GetInt32(5),
                CantidadEnPedido = reader.GetInt32(6),
                NivelDeReposicion = reader.GetInt32(7),
                Suspendido = reader.GetBoolean(8),
                Imagen =reader.GetString(9),
                RowVersion = (byte[])reader[10]

            };
        }

        public Caja GetPorId(int id)
        {
            try
            {
                Caja caja = null;
                string cadenaComando = "SELECT CajaId, NombreCaja, Descripcion," +
                                       " PrecioCosto, PrecioVenta, CantidadEnExistencia, CantidadEnPedido," +
                                       " NivelDeReposicion, Suspendido, Imagen, RowVersion  " +
                                       "FROM Cajas WHERE CajaId=@id";
                using (var comando = (SqlCommand)CreateCommand(cadenaComando))
                {
                    comando.Parameters.AddWithValue("@id", id);
                    using (var reader = comando.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            caja = ConstruirCaja(reader);
                        }
                    }
                }

                return caja;
            }
            catch (Exception ex)
            {
                throw DbExceptionManager.GettingException(tabla);
            }

        }

        public int Agregar(Caja obj)
        {
            try
            {
                int registrosAfectados = 0;
                string cadenaComando = "INSERT INTO Cajas (NombreCaja, Descripcion, PrecioCosto, PrecioVenta, " +
                                       "  CantidadEnExistencia, CantidadEnPedido, NivelDeReposicion, Suspendido, Imagen)" +
                                       " VALUES (@nom, @desc, @pcosto, @pvta, @stock, @ped, @niv, @sus, @ima)";
                using (var comando = (SqlCommand)CreateCommand(cadenaComando))
                {
                    comando.Parameters.AddWithValue("@nom", obj.NombreProducto);
                    if (!string.IsNullOrEmpty(obj.Descripcion))
                    {
                        comando.Parameters.AddWithValue("@desc", obj.Descripcion);
                    }
                    else
                    {
                        comando.Parameters.AddWithValue("@desc", DBNull.Value);
                    }

                    comando.Parameters.AddWithValue("@pcosto", obj.PrecioCosto);
                    comando.Parameters.AddWithValue("@pvta", obj.PrecioVenta);
                    comando.Parameters.AddWithValue("@stock", obj.CantidadEnExistencia);
                    comando.Parameters.AddWithValue("@ped", obj.CantidadEnPedido);
                    comando.Parameters.AddWithValue("@niv", obj.NivelDeReposicion);
                    comando.Parameters.AddWithValue("@sus", obj.Suspendido);
                    if (!string.IsNullOrEmpty(obj.Imagen))
                    {
                        comando.Parameters.AddWithValue("@ima", obj.Imagen);
                    }
                    else
                    {
                        comando.Parameters.AddWithValue("@ima", string.Empty);
                    }



                    registrosAfectados = comando.ExecuteNonQuery();
                    if (registrosAfectados > 0)
                    {
                        string cadenaOutput = "SELECT @@IDENTITY";
                        using (var comandoOutput = CreateCommand(cadenaOutput))
                        {
                            obj.Id = (int)(decimal)comandoOutput.ExecuteScalar();
                        }
                        cadenaComando = "SELECT RowVersion FROM Cajas WHERE CajaId=@id";
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

        public int Borrar(Caja obj)
        {
            int registrosAfectados = 0;
            try
            {
                string cadenaComando = "DELETE FROM Cajas WHERE CajaId=@id AND RowVersion=@ver";
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

        public int Editar(Caja obj)
        {
            try
            {
                int registrosAfectados = 0;
                string cadenaComando = "UPDATE Cajas SET NombreCaja=@nom, Descripcion=@desc, PrecioCosto=@pcosto, "+
                        "PrecioVenta=@pvta,  CantidadEnExistencia=@stock, CantidadEnPedido=@ped, NivelDeReposicion=@niv, Suspendido=@sus, Imagen=@ima" +
                                       " WHERE CajaId=@id AND RowVersion=@rov";
                using (var comando = (SqlCommand)CreateCommand(cadenaComando))
                {
                    comando.Parameters.AddWithValue("@nom", obj.NombreProducto);
                    if (!string.IsNullOrEmpty(obj.Descripcion))
                    {
                        comando.Parameters.AddWithValue("@desc", obj.Descripcion);
                    }
                    else
                    {
                        comando.Parameters.AddWithValue("@desc", DBNull.Value);
                    }

                    comando.Parameters.AddWithValue("@pcosto", obj.PrecioCosto);
                    comando.Parameters.AddWithValue("@pvta", obj.PrecioVenta);
                    comando.Parameters.AddWithValue("@stock", obj.CantidadEnExistencia);
                    comando.Parameters.AddWithValue("@ped", obj.CantidadEnPedido);
                    comando.Parameters.AddWithValue("@niv", obj.NivelDeReposicion);
                    comando.Parameters.AddWithValue("@sus", obj.Suspendido);
                    if (!string.IsNullOrEmpty(obj.Imagen))
                    {
                        comando.Parameters.AddWithValue("@ima", obj.Imagen);
                    }
                    else
                    {
                        comando.Parameters.AddWithValue("@ima", string.Empty);
                    }
                    comando.Parameters.AddWithValue("@id", obj.Id);
                    comando.Parameters.AddWithValue("@rov", obj.RowVersion);

                    registrosAfectados = comando.ExecuteNonQuery();
                    if (registrosAfectados > 0)
                    {
                        cadenaComando = "SELECT RowVersion FROM Cajas WHERE CajaiD=@id";
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

        public bool Existe(Caja caja)
        {
            try
            {
                int registrosAfectados = 0;
                if (caja.Id == 0)
                {
                    //Es un alta
                    string cadenaComando = "SELECT COUNT(*) FROM Cajas WHERE NombreCaja=@nom";
                    using (var comando = (SqlCommand)CreateCommand(cadenaComando))
                    {
                        comando.Parameters.AddWithValue("@nom", caja.NombreProducto);

                        registrosAfectados = (int)comando.ExecuteScalar();
                    }
                }
                else
                {
                    //Es una edición
                    string cadenaComando = "SELECT COUNT(*) FROM Cajas WHERE NombreCaja=@nom AND CajaId<>@id";
                    using (var comando = (SqlCommand)CreateCommand(cadenaComando))
                    {
                        comando.Parameters.AddWithValue("@nom", caja.NombreProducto);
                        comando.Parameters.AddWithValue("@id", caja.Id);
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

        public bool EstaRelacionado(Caja bombon)
        {
            return false;
        }

        public int GetCantidad()
        {
            try
            {
                int registrosAfectados = 0;

                string cadenaComando = "SELECT COUNT(*) FROM Cajas";
                using (var comando = (SqlCommand)CreateCommand(cadenaComando))
                {

                    registrosAfectados = (int)comando.ExecuteScalar();
                }
                return registrosAfectados;
            }
            catch (Exception e)
            {
                throw DbExceptionManager.GettingException(tabla);
            }
        }

        public List<Caja> GetListaPaginada(int registros, int paginaActual)
        {
            try
            {
                List<Caja> lista = new List<Caja>();
                string cadenaComando = "SELECT CajaId, NombreCaja, Descripcion," +
                                       " PrecioCosto, PrecioVenta, CantidadEnExistencia, CantidadEnPedido," +
                                       " NivelDeReposicion, Suspendido, Imagen, RowVersion  " +
                                       "FROM Cajas ORDER BY NombreCaja OFFSET @ig ROWS FETCH NEXT @reg ROWS ONLY";
                using (var comando = (SqlCommand)CreateCommand(cadenaComando))
                {
                    var registrosIgnorados = registros * (paginaActual - 1);
                    comando.Parameters.AddWithValue("@ig", registrosIgnorados);
                    comando.Parameters.AddWithValue("@reg", registros);
                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var Caja = ConstruirCaja(reader);
                            lista.Add(Caja);
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

        public int ActualizarStock(Producto producto, int cantidad)
        {
            try
            {
                int registrosAfectados = 0;
                string cadenaComando = "UPDATE Cajas SET CantidadEnExistencia=CantidadEnExistencia-@cantidad" +
                                       " WHERE CajaId=@id AND RowVersion=@rov";
                using (var comando = (SqlCommand)CreateCommand(cadenaComando))
                {
                    comando.Parameters.AddWithValue("@cantidad", cantidad);
                    comando.Parameters.AddWithValue("@id", producto.Id);
                    comando.Parameters.AddWithValue("@rov", producto.RowVersion);

                    registrosAfectados = comando.ExecuteNonQuery();
                    if (registrosAfectados > 0)
                    {
                        cadenaComando = "SELECT RowVersion FROM Cajas WHERE CajaId=@id";
                        using (var comandoRow = (SqlCommand)CreateCommand(cadenaComando))
                        {
                            comandoRow.Parameters.AddWithValue("@id", producto.Id);
                            producto.RowVersion = (byte[])comandoRow.ExecuteScalar();
                        }
                    }
                }

                return registrosAfectados;
            }
            catch (Exception ex)
            {
                throw DbExceptionManager.UpdateException(tabla);
            }
        }
    }
}
