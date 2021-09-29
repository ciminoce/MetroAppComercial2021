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
    public class ProvinciasRepositorio:DbHelperSql, IProvinciasRepositorio
    {
        private readonly string tabla = "Provincias";
        public ProvinciasRepositorio(SqlConnection context, SqlTransaction transaction)
        {
            this._context = context;
            this._transaction = transaction;
        }
        public List<Provincia> GetLista()
        {
            List<Provincia> lista = new List<Provincia>();
            try
            {
                string cadenaComando = "SELECT ProvinciaId, NombreProvincia, RowVersion FROM Provincias ORDER BY NombreProvincia";
                using (var comando = CreateCommand(cadenaComando))
                {
                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var provincia = ConstruirProvincia(reader);
                            lista.Add(provincia);
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

        private Provincia ConstruirProvincia(IDataReader reader)
        {
            return new Provincia()
            {
                ProvinciaId = reader.GetInt32(0),
                NombreProvincia = reader.GetString(1),
                RowVersion = (byte[])reader[2]
            };
        }

        public Provincia GetPorId(int id)
        {
            Provincia tipo = null;
            try
            {
                string cadenaComando =
                    "SELECT ProvinciaId, NombreProvincia, RowVersion FROM Provincias WHERE ProvinciaId=@id";
                using (var comando = (SqlCommand)CreateCommand(cadenaComando))
                {
                    comando.Parameters.AddWithValue("@id", id);
                    using (var reader = comando.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            tipo = ConstruirProvincia(reader);
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

        public int Agregar(Provincia obj)
        {
            int registrosAfectados = 0;
            try
            {
                string cadenaComando = "INSERT INTO Provincias (NombreProvincia) VALUES(@desc)";
                using (var comando = (SqlCommand)CreateCommand(cadenaComando))
                {
                    comando.Parameters.AddWithValue("@desc", obj.NombreProvincia);
                    registrosAfectados = comando.ExecuteNonQuery();
                    if (registrosAfectados > 0)
                    {
                        string cadenaOutput = "SELECT @@IDENTITY";
                        using (var comandoOutput = CreateCommand(cadenaOutput))
                        {
                            obj.ProvinciaId = (int)(decimal)comandoOutput.ExecuteScalar();
                        }
                        cadenaComando = "SELECT RowVersion FROM Provincias WHERE ProvinciaId=@id";
                        using (var comandoRow = (SqlCommand)CreateCommand(cadenaComando))
                        {
                            comandoRow.Parameters.AddWithValue("@id", obj.ProvinciaId);
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

        public int Borrar(Provincia obj)
        {
            int registrosAfectados = 0;
            try
            {
                string cadenaComando = "DELETE FROM Provincias WHERE ProvinciaId=@id AND RowVersion=@ver";
                using (var comando = (SqlCommand)CreateCommand(cadenaComando))
                {
                    comando.Parameters.AddWithValue("@id", obj.ProvinciaId);
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

        public int Editar(Provincia obj)
        {
            int registrosAfectados = 0;
            try
            {
                string cadenaComando =
                    "UPDATE Provincias SET NombreProvincia=@desc WHERE ProvinciaId=@id AND RowVersion=@row";
                using (var comando = (SqlCommand)CreateCommand(cadenaComando))
                {
                    comando.Parameters.AddWithValue("@desc", obj.NombreProvincia);
                    comando.Parameters.AddWithValue("@id", obj.ProvinciaId);
                    comando.Parameters.AddWithValue("@row", obj.RowVersion);

                    registrosAfectados = comando.ExecuteNonQuery();
                    if (registrosAfectados > 0)
                    {
                        cadenaComando = "SELECT RowVersion FROM Provincias WHERE ProvinciaId=@id";
                        using (var comandoOutput = (SqlCommand)CreateCommand(cadenaComando))
                        {
                            comandoOutput.Parameters.AddWithValue("@id", obj.ProvinciaId);
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

        public bool Existe(Provincia obj)
        {
            try
            {
                int registrosAfectados = 0;
                if (obj.ProvinciaId == 0)
                {
                    //Es un alta
                    string cadenaComando = "SELECT COUNT(*) FROM Provincias WHERE NombreProvincia=@desc";
                    using (var comando = (SqlCommand)CreateCommand(cadenaComando))
                    {
                        comando.Parameters.AddWithValue("@desc", obj.NombreProvincia);
                        registrosAfectados = (int)comando.ExecuteScalar();
                    }
                }
                else
                {
                    //Es una edición
                    string cadenaComando =
                        "SELECT COUNT(*) FROM Provincias WHERE NombreProvincia=@desc AND ProvinciaId<>@id";
                    using (var comando = (SqlCommand)CreateCommand(cadenaComando))
                    {
                        comando.Parameters.AddWithValue("@desc", obj.NombreProvincia);
                        comando.Parameters.AddWithValue("@id", obj.ProvinciaId);
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

        public bool EstaRelacionado(Provincia obj)
        {
            try
            {
                int registrosAfectados = 0;
                string cadenaComando = "SELECT COUNT(*) FROM Localidades WHERE ProvinciaId=@id";
                using (var comando = (SqlCommand)CreateCommand(cadenaComando))
                {
                    comando.Parameters.AddWithValue("@id", obj.ProvinciaId);
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
