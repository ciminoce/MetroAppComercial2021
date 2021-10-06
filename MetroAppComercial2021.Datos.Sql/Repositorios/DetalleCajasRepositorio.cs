using System;
using System.Collections.Generic;
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
    public class DetalleCajasRepositorio:DbHelperSql, IDetalleCajasRepositorio
    {
        private readonly string tabla = "DetalleCajas";
        public DetalleCajasRepositorio(SqlConnection context, SqlTransaction transaction)
        {
            this._context = context;
            this._transaction = transaction;
        }

        public List<DetalleCaja> GetLista(int cajaId)
        {
            try
            {
                List<DetalleCaja> lista = new List<DetalleCaja>();
                string cadenaComando = "SELECT DetalleCajaId, CajaId, BombonId, Cantidad, RowVersion  " +
                                       "FROM DetallesCajas WHERE CajaId=@id ORDER BY DetalleCajaId";
                using (var comando =(SqlCommand) CreateCommand(cadenaComando))
                {
                    comando.Parameters.AddWithValue("@id", cajaId);
                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var detalle = ConstruirDetalle(reader);
                            lista.Add(detalle);
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

        public int Agregar(DetalleCaja detalleCaja)
        {
            try
            {
                int registrosAfectados = 0;
                string cadenaComando = "INSERT INTO DetallesCajas (CajaId, BombonId, Cantidad)" +
                                       " VALUES (@caja, @bom, @cant)";
                using (var comando = (SqlCommand)CreateCommand(cadenaComando))
                {
                    comando.Parameters.AddWithValue("@caja", detalleCaja.CajaId);
                    comando.Parameters.AddWithValue("@bom", detalleCaja.BombonId);
                    comando.Parameters.AddWithValue("@cant", detalleCaja.Cantidad);



                    registrosAfectados = comando.ExecuteNonQuery();
                    if (registrosAfectados > 0)
                    {
                        string cadenaOutput = "SELECT @@IDENTITY";
                        using (var comandoOutput = CreateCommand(cadenaOutput))
                        {
                            detalleCaja.DetalleCajaId = (int)(decimal)comandoOutput.ExecuteScalar();
                        }
                        cadenaComando = "SELECT RowVersion FROM DetallesCajas WHERE DetalleCajaId=@id";
                        using (var comandoRow = (SqlCommand)CreateCommand(cadenaComando))
                        {
                            comandoRow.Parameters.AddWithValue("@id", detalleCaja.DetalleCajaId);
                            detalleCaja.RowVersion = (byte[])comandoRow.ExecuteScalar();
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

        public int Borrar(DetalleCaja obj)
        {
            int registrosAfectados = 0;
            try
            {
                string cadenaComando = "DELETE FROM DetallesCajas WHERE DetalleCajaId=@id AND RowVersion=@ver";
                using (var comando = (SqlCommand)CreateCommand(cadenaComando))
                {
                    comando.Parameters.AddWithValue("@id", obj.DetalleCajaId);
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

        private DetalleCaja ConstruirDetalle(SqlDataReader reader)
        {
            return new DetalleCaja()
            {
                DetalleCajaId = reader.GetInt32(0),
                CajaId = reader.GetInt32(1),
                BombonId = reader.GetInt32(2),
                Cantidad = reader.GetInt32(3),
                RowVersion = (byte[]) reader[4]

            };
        }
    }
}
