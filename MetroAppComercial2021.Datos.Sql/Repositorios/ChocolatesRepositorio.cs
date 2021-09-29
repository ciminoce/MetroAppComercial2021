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
    public class ChocolatesRepositorio:DbHelperSql,IChocolatesRepositorio
    {
        private readonly string tabla = "TipoChocolates";
        public ChocolatesRepositorio(SqlConnection context, SqlTransaction transaction)
        {
            this._context = context;
            this._transaction = transaction;
        }
        public List<TipoChocolate> GetLista()
        {
            List<TipoChocolate> lista = new List<TipoChocolate>();
            try
            {
                string cadenaComando = "SELECT TipoChocolateId, Descripcion, RowVersion FROM TipoChocolates ORDER BY Descripcion";
                using (var comando=CreateCommand(cadenaComando))
                {
                    using (var reader=comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var chocolate = ConstruirChocolate(reader);
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

        private TipoChocolate ConstruirChocolate(IDataReader reader)
        {
            return new TipoChocolate()
            {
                TipoChocolateId = reader.GetInt32(0),
                Descripcion = reader.GetString(1),
                RowVersion = (byte[]) reader[2]
            };
        }

        public TipoChocolate GetPorId(int id)
        {
            TipoChocolate tipo = null;
            try
            {
                string cadenaComando =
                    "SELECT TipoChocolateId, Descripcion, RowVersion FROM TipoChocolates WHERE TipoChocolateId=@id";
                using (var comando=(SqlCommand)CreateCommand(cadenaComando))
                {
                    comando.Parameters.AddWithValue("@id", id);
                    using (var reader=comando.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            tipo = ConstruirChocolate(reader);
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

        public int Agregar(TipoChocolate obj)
        {
            int registrosAfectados = 0;
            try
            {
                string cadenaComando = "INSERT INTO TipoChocolates (Descripcion) VALUES(@desc)";
                using (var comando=(SqlCommand)CreateCommand(cadenaComando))
                {
                    comando.Parameters.AddWithValue("@desc", obj.Descripcion);
                    registrosAfectados = comando.ExecuteNonQuery();
                    if (registrosAfectados>0)
                    {
                        string cadenaOutput = "SELECT @@IDENTITY";
                        using (var comandoOutput=CreateCommand(cadenaOutput))
                        {
                            obj.TipoChocolateId = (int) (decimal) comandoOutput.ExecuteScalar();
                        }
                        cadenaComando = "SELECT RowVersion FROM TipoChocolates WHERE TipoChocolateId=@id";
                        using (var comandoRow = (SqlCommand)CreateCommand(cadenaComando))
                        {
                            comandoRow.Parameters.AddWithValue("@id", obj.TipoChocolateId);
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

        public int Borrar(TipoChocolate obj)
        {
            int registrosAfectados = 0;
            try
            {
                string cadenaComando = "DELETE FROM TipoChocolates WHERE TipoChocolateId=@id AND RowVersion=@ver";
                using (var comando=(SqlCommand)CreateCommand(cadenaComando))
                {
                    comando.Parameters.AddWithValue("@id", obj.TipoChocolateId);
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

        public int Editar(TipoChocolate obj)
        {
            int registrosAfectados = 0;
            try
            {
                string cadenaComando =
                    "UPDATE TipoChocolates SET Descripcion=@desc WHERE TipoChocolateId=@id AND RowVersion=@row";
                using (var comando=(SqlCommand)CreateCommand(cadenaComando))
                {
                    comando.Parameters.AddWithValue("@desc", obj.Descripcion);
                    comando.Parameters.AddWithValue("@id", obj.TipoChocolateId);
                    comando.Parameters.AddWithValue("@row", obj.RowVersion);

                    registrosAfectados = comando.ExecuteNonQuery();
                    if (registrosAfectados>0)
                    {
                        cadenaComando = "SELECT RowVersion FROM TipoChocolates WHERE TipoChocolateId=@id";
                        using (var comandoOutput=(SqlCommand)CreateCommand(cadenaComando))
                        {
                            comandoOutput.Parameters.AddWithValue("@id", obj.TipoChocolateId);
                            obj.RowVersion =(byte[]) comandoOutput.ExecuteScalar();
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

        public bool Existe(TipoChocolate obj)
        {
            try
            {
                int registrosAfectados = 0;
                if (obj.TipoChocolateId==0)
                { 
                    //Es un alta
                    string cadenaComando = "SELECT COUNT(*) FROM TipoChocolates WHERE Descripcion=@desc";
                    using (var comando=(SqlCommand)CreateCommand(cadenaComando))
                    {
                        comando.Parameters.AddWithValue("@desc", obj.Descripcion);
                        registrosAfectados = (int) comando.ExecuteScalar();
                    }
                }
                else
                {
                    //Es una edición
                    string cadenaComando =
                        "SELECT COUNT(*) FROM TipoChocolates WHERE Descripcion=@desc AND TipoChocolateId<>@id";
                    using (var comando=(SqlCommand)CreateCommand(cadenaComando))
                    {
                        comando.Parameters.AddWithValue("@desc", obj.Descripcion);
                        comando.Parameters.AddWithValue("@id", obj.TipoChocolateId);
                        registrosAfectados = (int) comando.ExecuteScalar();
                    }
                }

                return registrosAfectados > 0;
            }
            catch (Exception e)
            {
                throw DbExceptionManager.GettingException(tabla);
            }
        }

        public bool EstaRelacionado(TipoChocolate obj)
        {
            try
            {
                int registrosAfectados = 0;
                string cadenaComando = "SELECT COUNT(*) FROM Bombones WHERE TipoChocolateId=@id";
                using (var comando=(SqlCommand)CreateCommand(cadenaComando))
                {
                    comando.Parameters.AddWithValue("@id", obj.TipoChocolateId);
                    registrosAfectados = (int) comando.ExecuteScalar();
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
