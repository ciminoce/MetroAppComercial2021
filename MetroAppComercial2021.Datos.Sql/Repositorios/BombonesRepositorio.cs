using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MetroAppComercial2021.Datos.Comun.Excepciones;
using MetroAppComercial2021.Datos.Comun.Repositorios;
using MetroAppComercial2021.Datos.Sql.DbHelper;
using MetroAppComercial2021.Entidades.Entidades;

namespace MetroAppComercial2021.Datos.Sql.Repositorios
{
    public class BombonesRepositorio:DbHelperSql,IBombonesRepositorio
    {
        private readonly string tabla = "Bombones";
        private List<Bombon> lista;
        public BombonesRepositorio(SqlConnection context, SqlTransaction transaction)
        {
            this._context = context;
            this._transaction = transaction;
        }

        public List<Bombon> GetLista()
        {
            try
            {
                List<Bombon> lista = new List<Bombon>();
                string cadenaComando = "SELECT BombonId, NombreBombon, TipoChocolateId, TipoNuezId, TipoRellenoId, Descripcion," +
                                       " PrecioCosto, PrecioVenta, CantidadEnExistencia, CantidadEnPedido," +
                                       " NivelDeReposicion, Suspendido, Imagen, RowVersion  " +
                                       "FROM Bombones WHERE Suspendido=0 ORDER BY NombreBombon";
                using (var comando = CreateCommand(cadenaComando))
                {
                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var Bombon = ConstruirBombon(reader);
                            lista.Add(Bombon);
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

        private Bombon ConstruirBombon(IDataReader reader)
        {
            return new Bombon()
            {
                Id = reader.GetInt32(0),
                NombreProducto = reader.GetString(1),
                ChocolateId = reader.GetInt32(2),
                NuezId = reader.GetInt32(3),
                RellenoId = reader.GetInt32(4),
                Descripcion = reader[5] != DBNull.Value ? reader.GetString(5) : string.Empty,
                PrecioCosto = reader.GetDecimal(6),
                PrecioVenta = reader.GetDecimal(7),
                CantidadEnExistencia = reader.GetInt32(8),
                CantidadEnPedido = reader.GetInt32(9),
                NivelDeReposicion = reader.GetInt32(10),
                Suspendido = reader.GetBoolean(11),
                Imagen = reader.GetString(12),
                RowVersion = (byte[]) reader[13]

            };
        }

        public Bombon GetPorId(int id)
        {
            try
            {
                Bombon bombon = null;
                string cadenaComando = "SELECT BombonId, NombreBombon, TipoChocolateId, TipoNuezId, TipoRellenoId, Descripcion," +
                                       " PrecioCosto, PrecioVenta, CantidadEnExistencia, CantidadEnPedido," +
                                       " NivelDeReposicion, Suspendido, Imagen, RowVersion  " +
                                       "FROM Bombones WHERE BombonId=@id";
                using (var comando =(SqlCommand) CreateCommand(cadenaComando))
                {
                    comando.Parameters.AddWithValue("@id", id);
                    using (var reader = comando.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            bombon = ConstruirBombon(reader);
                        }
                    }
                }

                return bombon;
            }
            catch (Exception ex)
            {
                throw DbExceptionManager.GettingException(tabla);
            }

        }

        public int Agregar(Bombon obj)
        {
            try
            {
                int registrosAfectados = 0;
                string cadenaComando = "INSERT INTO Bombones (NombreBombon, TipoChocolateId, TipoNuezId, TipoRellenoId, " +
                                       " Descripcion, PrecioCosto, PrecioVenta,  CantidadEnExistencia, CantidadEnPedido, NivelDeReposicion, Suspendido, Imagen)" +
                                       " VALUES (@nom, @choc, @nuez, @rel, @desc, @pcosto, @pvta, @stock, @ped, @niv, @sus, @ima)";
                using (var comando = (SqlCommand)CreateCommand(cadenaComando))
                {
                    comando.Parameters.AddWithValue("@nom", obj.NombreProducto);
                    comando.Parameters.AddWithValue("@choc", obj.ChocolateId);
                    comando.Parameters.AddWithValue("@nuez", obj.NuezId);
                    comando.Parameters.AddWithValue("@rel", obj.RellenoId);
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
                        cadenaComando = "SELECT RowVersion FROM Bombones WHERE BombonId=@id";
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

        public int Borrar(Bombon obj)
        {
            int registrosAfectados = 0;
            try
            {
                string cadenaComando = "DELETE FROM Bombones WHERE BombonId=@id AND RowVersion=@ver";
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

        public int Editar(Bombon obj)
        {
            try
            {
                int registrosAfectados = 0;
                string cadenaComando = "UPDATE Bombones SET NombreBombon=@nom, TipoChocolateId=@choc, TipoNuezId=@nuez, TipoRellenoId=@rel, " +
                                       " Descripcion=@desc, PrecioCosto=@pcosto, PrecioVenta=@pvta,  CantidadEnExistencia=@stock, CantidadEnPedido=@ped, NivelDeReposicion=@niv, Suspendido=@sus, Imagen=@ima" +
                                       " WHERE BombonId=@id AND RowVersion=@rov";
                using (var comando = (SqlCommand)CreateCommand(cadenaComando))
                {
                    comando.Parameters.AddWithValue("@nom", obj.NombreProducto);
                    comando.Parameters.AddWithValue("@choc", obj.ChocolateId);
                    comando.Parameters.AddWithValue("@nuez", obj.NuezId);
                    comando.Parameters.AddWithValue("@rel", obj.RellenoId);
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
                        cadenaComando = "SELECT RowVersion FROM Bombones WHERE BombonId=@id";
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

        public bool Existe(Bombon bombon)
        {
            try
            {
                int registrosAfectados = 0;
                if (bombon.Id == 0)
                {
                    //Es un alta
                    string cadenaComando = "SELECT COUNT(*) FROM Bombones WHERE NombreBombon=@nom";
                    using (var comando = (SqlCommand)CreateCommand(cadenaComando))
                    {
                        comando.Parameters.AddWithValue("@nom", bombon.NombreProducto);

                        registrosAfectados = (int)comando.ExecuteScalar();
                    }
                }
                else
                {
                    //Es una edición
                    string cadenaComando = "SELECT COUNT(*) FROM Bombones WHERE NombreBombon=@nom AND BombonId<>@id";
                    using (var comando = (SqlCommand)CreateCommand(cadenaComando))
                    {
                        comando.Parameters.AddWithValue("@nom", bombon.NombreProducto);
                        comando.Parameters.AddWithValue("@id", bombon.Id);
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

        public bool EstaRelacionado(Bombon bombon)
        {
            return false;
        }

        public int GetCantidad()
        {
            try
            {
                int registrosAfectados = 0;
               
                string cadenaComando = "SELECT COUNT(*) FROM Bombones";
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

        public List<Bombon> GetListaPaginada(int registros, int paginaActual)
        {
            try
            {
                List<Bombon> lista = new List<Bombon>();
                string cadenaComando = "SELECT BombonId, NombreBombon, TipoChocolateId, TipoNuezId, TipoRellenoId, Descripcion," +
                                       " PrecioCosto, PrecioVenta, CantidadEnExistencia, CantidadEnPedido," +
                                       " NivelDeReposicion, Suspendido, Imagen, RowVersion  " +
                                       "FROM Bombones ORDER BY NombreBombon OFFSET @ig ROWS FETCH NEXT @reg ROWS ONLY";
                using (var comando =(SqlCommand) CreateCommand(cadenaComando))
                {
                    var registrosIgnorados = registros * (paginaActual - 1);
                    comando.Parameters.AddWithValue("@ig", registrosIgnorados);
                    comando.Parameters.AddWithValue("@reg", registros);
                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var Bombon = ConstruirBombon(reader);
                            lista.Add(Bombon);
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
                string cadenaComando = "UPDATE Bombones SET CantidadEnExistencia=CantidadEnExistencia-@cantidad" +
                                       " WHERE BombonId=@id AND RowVersion=@rov";
                using (var comando = (SqlCommand)CreateCommand(cadenaComando))
                {
                    comando.Parameters.AddWithValue("@cantidad", cantidad);
                    comando.Parameters.AddWithValue("@id",producto.Id);
                    comando.Parameters.AddWithValue("@rov", producto.RowVersion);

                    registrosAfectados = comando.ExecuteNonQuery();
                    if (registrosAfectados > 0)
                    {
                        cadenaComando = "SELECT RowVersion FROM Bombones WHERE BombonId=@id";
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
                throw DbExceptionManager.InsertException(tabla);
            }
        }
    }
}
