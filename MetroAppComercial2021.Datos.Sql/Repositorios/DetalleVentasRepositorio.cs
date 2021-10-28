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
    public class DetalleVentasRepositorio:DbHelperSql, IDetalleVentasRepositorio
    {
        private readonly string tabla = "DetalleVentas";
        private List<Bombon> lista;
        public DetalleVentasRepositorio(SqlConnection context, SqlTransaction transaction)
        {
            this._context = context;
            this._transaction = transaction;
        }

        public int Agregar(DetalleVenta detalleVta)
        {
            try
            {
                int registrosAfectados = 0;
                string cadenaComando = "INSERT INTO DetallesVentas (VentaId, ProductoId, TipoProductoId, Cantidad, Precio)" +
                                       " VALUES (@vta, @prod, @tipo, @cant, @pre)";
                using (var comando = (SqlCommand)CreateCommand(cadenaComando))
                {
                    comando.Parameters.AddWithValue("@vta", detalleVta.VentaId);
                    comando.Parameters.AddWithValue("@prod", detalleVta.ProductoId);
                    comando.Parameters.AddWithValue("@tipo", detalleVta.TipoProducto.GetHashCode());
                    comando.Parameters.AddWithValue("@cant", detalleVta.Cantidad);
                    comando.Parameters.AddWithValue("@pre", detalleVta.Precio);




                    registrosAfectados = comando.ExecuteNonQuery();
                    if (registrosAfectados > 0)
                    {
                        string cadenaOutput = "SELECT @@IDENTITY";
                        using (var comandoOutput = CreateCommand(cadenaOutput))
                        {
                            detalleVta.DetalleVentaId = (int)(decimal)comandoOutput.ExecuteScalar();
                        }
                        cadenaComando = "SELECT RowVersion FROM DetallesVentas WHERE DetalleVentaId=@id";
                        using (var comandoRow = (SqlCommand)CreateCommand(cadenaComando))
                        {
                            comandoRow.Parameters.AddWithValue("@id", detalleVta.DetalleVentaId);
                            detalleVta.RowVersion = (byte[])comandoRow.ExecuteScalar();
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
