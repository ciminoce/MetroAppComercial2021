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
    public class LocalidadesRepositorio:DbHelperSql, ILocalidadesRepositorio
    {
        private readonly string tabla = "Localidades";
        public LocalidadesRepositorio(SqlConnection context, SqlTransaction transaction)
        {
            this._context = context;
            this._transaction = transaction;
        }
        public List<Localidad> GetLista()
        {
            List<Localidad> lista = new List<Localidad>();
            try
            {
                string cadenaComando = "SELECT LocalidadId, NombreLocalidad, ProvinciaId, RowVersion FROM Localidades ORDER BY NombreLocalidad";
                using (var comando = CreateCommand(cadenaComando))
                {
                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var localidad = ConstruirLocalidad(reader);
                            lista.Add(localidad);
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

        private Localidad ConstruirLocalidad(IDataReader reader)
        {
            return new Localidad()
            {
                LocalidadId = reader.GetInt32(0),
                NombreLocalidad = reader.GetString(1),
                ProvinciaId = reader.GetInt32(2),
                RowVersion = (byte[])reader[3]
            };
        }

        public Localidad GetPorId(int id)
        {
            Localidad tipo = null;
            try
            {
                string cadenaComando =
                    "SELECT LocalidadId, NombreLocalidad, ProvinciaId, RowVersion FROM Localidades WHERE LocalidadId=@id";
                using (var comando = (SqlCommand)CreateCommand(cadenaComando))
                {
                    comando.Parameters.AddWithValue("@id", id);
                    using (var reader = comando.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            tipo = ConstruirLocalidad(reader);
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

        public int Agregar(Localidad obj)
        {
            int registrosAfectados = 0;
            try
            {
                string cadenaComando = "INSERT INTO Localidades (NombreLocalidad, ProvinciaId) VALUES(@nom, @prov)";
                using (var comando = (SqlCommand)CreateCommand(cadenaComando))
                {
                    comando.Parameters.AddWithValue("@nom", obj.NombreLocalidad);
                    comando.Parameters.AddWithValue("@prov", obj.ProvinciaId);
                    registrosAfectados = comando.ExecuteNonQuery();
                    if (registrosAfectados > 0)
                    {
                        string cadenaOutput = "SELECT @@IDENTITY";
                        using (var comandoOutput = CreateCommand(cadenaOutput))
                        {
                            obj.LocalidadId = (int)(decimal)comandoOutput.ExecuteScalar();
                        }
                        cadenaComando = "SELECT RowVersion FROM Localidades WHERE LocalidadId=@id";
                        using (var comandoRow = (SqlCommand)CreateCommand(cadenaComando))
                        {
                            comandoRow.Parameters.AddWithValue("@id", obj.LocalidadId);
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

        public int Borrar(Localidad obj)
        {
            int registrosAfectados = 0;
            try
            {
                string cadenaComando = "DELETE FROM Localidades WHERE LocalidadId=@id AND RowVersion=@ver";
                using (var comando = (SqlCommand)CreateCommand(cadenaComando))
                {
                    comando.Parameters.AddWithValue("@id", obj.LocalidadId);
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

        public int Editar(Localidad obj)
        {
            int registrosAfectados = 0;
            try
            {
                string cadenaComando =
                    "UPDATE Localidades SET NombreLocalidad=@nom, ProvinciaId=@prov WHERE LocalidadId=@id AND RowVersion=@row";
                using (var comando = (SqlCommand)CreateCommand(cadenaComando))
                {
                    comando.Parameters.AddWithValue("@nom", obj.NombreLocalidad);
                    comando.Parameters.AddWithValue("@prov", obj.ProvinciaId);
                    comando.Parameters.AddWithValue("@id", obj.LocalidadId);
                    comando.Parameters.AddWithValue("@row", obj.RowVersion);

                    registrosAfectados = comando.ExecuteNonQuery();
                    if (registrosAfectados > 0)
                    {
                        cadenaComando = "SELECT RowVersion FROM Localidades WHERE LocalidadId=@id";
                        using (var comandoOutput = (SqlCommand)CreateCommand(cadenaComando))
                        {
                            comandoOutput.Parameters.AddWithValue("@id", obj.LocalidadId);
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

        public bool Existe(Localidad obj)
        {
            try
            {
                int registrosAfectados = 0;
                if (obj.LocalidadId == 0)
                {
                    //Es un alta
                    string cadenaComando = "SELECT COUNT(*) FROM Localidades WHERE NombreLocalidad=@nom AND ProvinciaId=@prov";
                    using (var comando = (SqlCommand)CreateCommand(cadenaComando))
                    {
                        comando.Parameters.AddWithValue("@nom", obj.NombreLocalidad);
                        comando.Parameters.AddWithValue("@prov", obj.ProvinciaId);

                        registrosAfectados = (int)comando.ExecuteScalar();
                    }
                }
                else
                {
                    //Es una edición
                    string cadenaComando =
                        "SELECT COUNT(*) FROM Localidades WHERE NombreLocalidad=@nom AND ProvinciaId=@prov AND LocalidadId<>@id";
                    using (var comando = (SqlCommand)CreateCommand(cadenaComando))
                    {
                        comando.Parameters.AddWithValue("@nom", obj.NombreLocalidad);
                        comando.Parameters.AddWithValue("@prov", obj.ProvinciaId);
                        comando.Parameters.AddWithValue("@id", obj.LocalidadId);
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

        public bool EstaRelacionado(Localidad obj)
        {
            try
            {
                int registrosAfectados = 0;
                string cadenaComando = "SELECT COUNT(*) FROM Clientes WHERE LocalidadId=@id";
                using (var comando = (SqlCommand)CreateCommand(cadenaComando))
                {
                    comando.Parameters.AddWithValue("@id", obj.LocalidadId);
                    registrosAfectados = (int)comando.ExecuteScalar();
                }

                return registrosAfectados > 0;
            }
            catch (Exception e)
            {
                throw DbExceptionManager.GettingException(tabla);
            }
        }

        public List<Localidad> GetLista(int provinciaId)
        {
            List<Localidad> lista = new List<Localidad>();
            try
            {
                string cadenaComando = "SELECT LocalidadId, NombreLocalidad, ProvinciaId, RowVersion " +
                                       "FROM Localidades WHERE provinciaId=@id ORDER BY NombreLocalidad";
                using (var comando =(SqlCommand) CreateCommand(cadenaComando))
                {
                    comando.Parameters.AddWithValue("@id", provinciaId);
                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var localidad = ConstruirLocalidad(reader);
                            lista.Add(localidad);
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
    }
}
