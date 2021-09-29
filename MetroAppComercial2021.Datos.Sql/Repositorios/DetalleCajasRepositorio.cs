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
