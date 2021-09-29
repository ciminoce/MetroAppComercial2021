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
    public class NuecesRepositorio:DbHelperSql,INuecesRepositorio
    {
        private readonly string tabla = "TipoNueces";
        public NuecesRepositorio(SqlConnection context, SqlTransaction transaction)
        {
            this._context = context;
            this._transaction = transaction;
        }
        public List<TipoNuez> GetLista()
        {
            List<TipoNuez> lista = new List<TipoNuez>();
            try
            {
                string cadenaComando = "SELECT TipoNuezId, Descripcion, RowVersion FROM TipoNueces ORDER BY Descripcion";
                using (var comando = CreateCommand(cadenaComando))
                {
                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var chocolate = ConstruirNuez(reader);
                            lista.Add(chocolate);
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

        private TipoNuez ConstruirNuez(IDataReader reader)
        {
            return new TipoNuez()
            {
                TipoNuezId = reader.GetInt32(0),
                Descripcion = reader.GetString(1),
                RowVersion = (byte[])reader[2]
            };
        }

        public TipoNuez GetPorId(int id)
        {
            TipoNuez tipo = null;
            try
            {
                string cadenaComando =
                    "SELECT TipoNuezId, Descripcion, RowVersion FROM TipoNueces WHERE TipoNuezId=@id";
                using (var comando = (SqlCommand)CreateCommand(cadenaComando))
                {
                    comando.Parameters.AddWithValue("@id", id);
                    using (var reader = comando.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            tipo = ConstruirNuez(reader);
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

        public int Agregar(TipoNuez obj)
        {
            int registrosAfectados = 0;
            try
            {
                string cadenaComando = "INSERT INTO TipoNueces (Descripcion) VALUES(@desc)";
                using (var comando = (SqlCommand)CreateCommand(cadenaComando))
                {
                    comando.Parameters.AddWithValue("@desc", obj.Descripcion);
                    registrosAfectados = comando.ExecuteNonQuery();
                    if (registrosAfectados > 0)
                    {
                        string cadenaOutput = "SELECT @@IDENTITY";
                        using (var comandoOutput = CreateCommand(cadenaOutput))
                        {
                            obj.TipoNuezId = (int)(decimal)comandoOutput.ExecuteScalar();
                        }
                        cadenaComando = "SELECT RowVersion FROM TipoNueces WHERE TipoNuezId=@id";
                        using (var comandoRow = (SqlCommand)CreateCommand(cadenaComando))
                        {
                            comandoRow.Parameters.AddWithValue("@id", obj.TipoNuezId);
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

        public int Borrar(TipoNuez obj)
        {
            int registrosAfectados = 0;
            try
            {
                string cadenaComando = "DELETE FROM TipoNueces WHERE TipoNuezId=@id AND RowVersion=@ver";
                using (var comando = (SqlCommand)CreateCommand(cadenaComando))
                {
                    comando.Parameters.AddWithValue("@id", obj.TipoNuezId);
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

        public int Editar(TipoNuez obj)
        {
            int registrosAfectados = 0;
            try
            {
                string cadenaComando =
                    "UPDATE TipoNueces SET Descripcion=@desc WHERE TipoNuezId=@id AND RowVersion=@row";
                using (var comando = (SqlCommand)CreateCommand(cadenaComando))
                {
                    comando.Parameters.AddWithValue("@desc", obj.Descripcion);
                    comando.Parameters.AddWithValue("@id", obj.TipoNuezId);
                    comando.Parameters.AddWithValue("@row", obj.RowVersion);

                    registrosAfectados = comando.ExecuteNonQuery();
                    if (registrosAfectados > 0)
                    {
                        cadenaComando = "SELECT RowVersion FROM TipoNueces WHERE TipoNuezId=@id";
                        using (var comandoOutput = (SqlCommand)CreateCommand(cadenaComando))
                        {
                            comandoOutput.Parameters.AddWithValue("@id", obj.TipoNuezId);
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

        public bool Existe(TipoNuez obj)
        {
            try
            {
                int registrosAfectados = 0;
                if (obj.TipoNuezId == 0)
                {
                    //Es un alta
                    string cadenaComando = "SELECT COUNT(*) FROM TipoNueces WHERE Descripcion=@desc";
                    using (var comando = (SqlCommand)CreateCommand(cadenaComando))
                    {
                        comando.Parameters.AddWithValue("@desc", obj.Descripcion);
                        registrosAfectados = (int)comando.ExecuteScalar();
                    }
                }
                else
                {
                    //Es una edición
                    string cadenaComando =
                        "SELECT COUNT(*) FROM TipoNueces WHERE Descripcion=@desc AND TipoNuezId<>@id";
                    using (var comando = (SqlCommand)CreateCommand(cadenaComando))
                    {
                        comando.Parameters.AddWithValue("@desc", obj.Descripcion);
                        comando.Parameters.AddWithValue("@id", obj.TipoNuezId);
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

        public bool EstaRelacionado(TipoNuez obj)
        {
            try
            {
                int registrosAfectados = 0;
                string cadenaComando = "SELECT COUNT(*) FROM Bombones WHERE TipoNuezId=@id";
                using (var comando = (SqlCommand)CreateCommand(cadenaComando))
                {
                    comando.Parameters.AddWithValue("@id", obj.TipoNuezId);
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
