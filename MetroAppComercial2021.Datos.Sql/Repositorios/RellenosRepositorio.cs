using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroAppComercial2021.Datos.Comun.DbHelper;
using MetroAppComercial2021.Datos.Comun.Excepciones;
using MetroAppComercial2021.Datos.Comun.Repositorios;
using MetroAppComercial2021.Datos.Sql.DbHelper;
using MetroAppComercial2021.Entidades.Entidades;

namespace MetroAppComercial2021.Datos.Sql.Repositorios
{
    public class RellenosRepositorio:DbHelperSql,IRellenosRepositorio
    {
        private string tabla = "Rellenos";
        public RellenosRepositorio(SqlConnection context, SqlTransaction transaction)
        {
            this._context = context;
            this._transaction = transaction;
        }

        public bool EstaRelacionado(TipoRelleno tipoRelleno)
        {
            int registrosEncontrados = 0;
            try
            {
                string cadenaComando = "SELECT COUNT(*) FROM Bombones WHERE TipoRellenoId=@id";
                using (var comando = (SqlCommand)CreateCommand(cadenaComando))
                {
                    comando.Parameters.AddWithValue("@id", tipoRelleno.TipoRellenoId);
                    registrosEncontrados = (int)comando.ExecuteScalar();
                }
                return registrosEncontrados > 0;
            }
            catch (Exception e)
            {
                throw DbExceptionManager.GettingException(tabla);
            }

        }
        public bool Existe(TipoRelleno tipoRelleno)
        {
            int registrosEncontrados = 0;
            try
            {

                if (tipoRelleno.TipoRellenoId == 0)
                {
                    string cadenaComando = "SELECT COUNT(*) FROM TipoRellenos WHERE Descripcion=@desc";
                    using (var comando = (SqlCommand)CreateCommand(cadenaComando))
                    {
                        comando.Parameters.AddWithValue("@desc", tipoRelleno.Descripcion);
                        registrosEncontrados = (int)comando.ExecuteScalar();
                    }

                }
                else
                {
                    string cadenaComando = "SELECT COUNT(*) FROM TipoRellenos WHERE Descripcion=@desc AND TipoRellenoId<>@id";
                    using (var comando = (SqlCommand)CreateCommand(cadenaComando))
                    {
                        comando.Parameters.AddWithValue("@desc", tipoRelleno.Descripcion);
                        comando.Parameters.AddWithValue("@id", tipoRelleno.TipoRellenoId);

                        registrosEncontrados = (int)comando.ExecuteScalar();
                    }

                }


                return registrosEncontrados > 0;
            }
            catch (Exception e)
            {
                throw DbExceptionManager.GettingException(tabla);
            }
        }
        public List<TipoRelleno> GetLista()
        {
            List<TipoRelleno> lista = new List<TipoRelleno>();
            try
            {
                string cadenaComando = "SELECT TipoRellenoId, Descripcion, RowVersion FROM TipoRellenos ORDER BY Descripcion";
                using (var comando = CreateCommand(cadenaComando))
                {
                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var tipo = ConstruirTipo(reader);
                            lista.Add(tipo);
                        }
                    }
                }

                return lista;

            }
            catch (Exception ex)
            {
                //throw new Exception("Error al intentar leer los datos de la tabla de Rellenos o al establecer la conexión");
                throw DbExceptionManager.GettingException(tabla);
            }


        }

        public TipoRelleno GetPorId(int id)
        {
            TipoRelleno tipo = null;
            try
            {
                string cadenaComando = "SELECT TipoRellenoId, Descripcion, RowVersion FROM TipoRellenos WHERE TipoRellenoId=@id";
                using (var comando = (SqlCommand)CreateCommand(cadenaComando))
                {
                    comando.Parameters.AddWithValue("@id", id);
                    using (var reader = comando.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            tipo = ConstruirTipo(reader);
                        }
                    }

                }
                return tipo;

            }
            catch (Exception ex)
            {
                //throw new Exception("Error al intentar leer los datos de la tabla de Rellenos o al establecer la conexión");
                throw DbExceptionManager.GettingException(tabla);
            }
        }


        private TipoRelleno ConstruirTipo(IDataReader reader)
        {
            return new TipoRelleno()
            {
                TipoRellenoId = reader.GetInt32(0),
                Descripcion = reader.GetString(1),
                RowVersion = (byte[])reader[2]
            };
        }

        public int Agregar(TipoRelleno tipoRelleno)
        {
            int registrosAfectados = 0;
            try
            {

                string cadenaComando = "INSERT INTO TipoRellenos (Descripcion) VALUES (@desc)";
                using (var comando = (SqlCommand)CreateCommand(cadenaComando))
                {
                    comando.Parameters.AddWithValue("@desc", tipoRelleno.Descripcion);

                    registrosAfectados = comando.ExecuteNonQuery();
                    if (registrosAfectados > 0)
                    {
                        cadenaComando = "SELECT @@IDENTITY";
                        using (var comandoOutput = (SqlCommand)CreateCommand(cadenaComando))
                        {
                            tipoRelleno.TipoRellenoId = (int)(decimal)comandoOutput.ExecuteScalar();

                        }
                        cadenaComando = "SELECT RowVersion FROM TipoRellenos WHERE TipoRellenoId=@id";
                        using (var comandoRow = (SqlCommand)CreateCommand(cadenaComando))
                        {
                            comandoRow.Parameters.AddWithValue("@id", tipoRelleno.TipoRellenoId);
                            tipoRelleno.RowVersion = (byte[])comandoRow.ExecuteScalar();
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

        public int Borrar(TipoRelleno tipoRelleno)
        {
            int registrosAfectados = 0;
            try
            {

                string cadenaComando = "DELETE FROM TipoRellenos WHERE TipoRellenoId=@id AND RowVersion=@ver";
                using (var comando = (SqlCommand)CreateCommand(cadenaComando))
                {
                    comando.Parameters.AddWithValue("@id", tipoRelleno.TipoRellenoId);
                    comando.Parameters.AddWithValue("@ver", tipoRelleno.RowVersion);
                    registrosAfectados = comando.ExecuteNonQuery();
                }

                return registrosAfectados;

            }
            catch (Exception e)
            {
                throw DbExceptionManager.DeleteException(tabla);
            }

        }

        public int Editar(TipoRelleno tipoRelleno)
        {
            int registrosAfectados = 0;
            try
            {
                string cadenaComando = "UPDATE TipoRellenos SET Descripcion=@desc WHERE TipoRellenoId=@id AND RowVersion=@ver";
                using (var comando = (SqlCommand)CreateCommand(cadenaComando))
                {
                    comando.Parameters.AddWithValue("@desc", tipoRelleno.Descripcion);
                    comando.Parameters.AddWithValue("@id", tipoRelleno.TipoRellenoId);
                    comando.Parameters.AddWithValue("@ver", tipoRelleno.RowVersion);

                    registrosAfectados = comando.ExecuteNonQuery();

                }

                if (registrosAfectados > 0)
                {
                    cadenaComando = "SELECT RowVersion FROM TipoRellenos WHERE TipoRellenoId=@id";
                    using (var comandoRow = (SqlCommand)CreateCommand(cadenaComando))
                    {
                        comandoRow.Parameters.AddWithValue("@id", tipoRelleno.TipoRellenoId);
                        tipoRelleno.RowVersion = (byte[])comandoRow.ExecuteScalar();
                    }

                }
                return registrosAfectados;
            }
            catch (Exception e)
            {
                throw DbExceptionManager.UpdateException(tabla);

            }
        }


    }
}
