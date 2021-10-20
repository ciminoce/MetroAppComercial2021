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
    public class VentasRepositorio:DbHelperSql, IVentasRepositorio
    {
        private readonly string tabla = "Ventas";
        public VentasRepositorio(SqlConnection context, SqlTransaction transaction)
        {
            this._context = context;
            this._transaction = transaction;
        }

        public List<Venta> GetListaPaginada(int registros, int paginaActual)
        {
            try
            {
                List<Venta> lista = new List<Venta>();
                string cadenaComando = "SELECT VentaId, ClienteId, FechaVenta, Regalo, Total, RowVersion  " +
                                       "FROM Ventas ORDER BY VentaId  OFFSET @ig ROWS FETCH NEXT @reg ROWS ONLY";
                using (var comando = (SqlCommand)CreateCommand(cadenaComando))
                {
                    var registrosIgnorados = registros * (paginaActual - 1);
                    comando.Parameters.AddWithValue("@ig", registrosIgnorados);
                    comando.Parameters.AddWithValue("@reg", registros);
                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var venta = ConstruirVenta(reader);
                            lista.Add(venta);
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

        private Venta ConstruirVenta(SqlDataReader reader)
        {
            return new Venta()
            {
                VentaId = reader.GetInt32(0),
                ClienteId = reader.GetInt32(1),
                FechaVenta = reader.GetDateTime(2),
                Regalo = reader.GetBoolean(3),
                Total = reader.GetDecimal(4),
                RowVersion = (byte[]) reader[5]
            };
        }

        public List<Venta> GetLista()
        {
            throw new NotImplementedException();
        }

        public List<Venta> GetLista(int clienteId, int registros, int paginaActual)
        {
            try
            {
                List<Venta> lista = new List<Venta>();
                string cadenaComando = "SELECT VentaId, ClienteId, FechaVenta, Regalo, Total, RowVersion  " +
                                       "FROM Ventas WHERE ClienteId=@id ORDER BY VentaId  OFFSET @ig ROWS FETCH NEXT @reg ROWS ONLY";
                using (var comando = (SqlCommand)CreateCommand(cadenaComando))
                {
                    var registrosIgnorados = registros * (paginaActual - 1);
                    comando.Parameters.AddWithValue("@id", clienteId);
                    comando.Parameters.AddWithValue("@ig", registrosIgnorados);
                    comando.Parameters.AddWithValue("@reg", registros);
                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var venta = ConstruirVenta(reader);
                            lista.Add(venta);
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


        public List<Venta> GetLista(DateTime fechaVenta, int registros, int paginaActual)
        {
            try
            {
                List<Venta> lista = new List<Venta>();
                string cadenaComando = "SELECT VentaId, ClienteId, FechaVenta, Regalo, Total, RowVersion  " +
                                       "FROM Ventas WHERE FechaVenta=@fecha ORDER BY VentaId  OFFSET @ig ROWS FETCH NEXT @reg ROWS ONLY";
                using (var comando = (SqlCommand)CreateCommand(cadenaComando))
                {
                    var registrosIgnorados = registros * (paginaActual - 1);
                    comando.Parameters.AddWithValue("@fecha", fechaVenta);
                    comando.Parameters.AddWithValue("@ig", registrosIgnorados);
                    comando.Parameters.AddWithValue("@reg", registros);
                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var venta = ConstruirVenta(reader);
                            lista.Add(venta);
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

        public Venta GetVentaPorId(int ventaId)
        {
            throw new NotImplementedException();
        }

        public void Agregar(Venta venta)
        {
            throw new NotImplementedException();
        }

        public int GetCantidad()
        {
            try
            {
                int registrosAfectados = 0;

                string cadenaComando = "SELECT COUNT(*) FROM Ventas";
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

        public int GetCantidad(int clienteId)
        {
            try
            {
                int registrosAfectados = 0;

                string cadenaComando = "SELECT COUNT(*) FROM Ventas WHERE ClienteId=@id";
                using (var comando = (SqlCommand)CreateCommand(cadenaComando))
                {
                    comando.Parameters.AddWithValue("@id", clienteId);
                    registrosAfectados = (int)comando.ExecuteScalar();
                }
                return registrosAfectados;
            }
            catch (Exception e)
            {
                throw DbExceptionManager.GettingException(tabla);
            }
        }

        public int GetCantidad(DateTime fechaBusqueda)
        {
            try
            {
                int registrosAfectados = 0;

                string cadenaComando = "SELECT COUNT(*) FROM Ventas WHERE FechaVenta=@fecha";
                using (var comando = (SqlCommand)CreateCommand(cadenaComando))
                {
                    comando.Parameters.AddWithValue("@fecha", fechaBusqueda);
                    registrosAfectados = (int)comando.ExecuteScalar();
                }
                return registrosAfectados;
            }
            catch (Exception e)
            {
                throw DbExceptionManager.GettingException(tabla);
            }
        }
    }
}
