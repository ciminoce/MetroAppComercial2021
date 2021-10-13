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
    public class NoPermisosRepositorio:DbHelperSql, INoPermisosRepositorio
    {
        private readonly string tabla = "NoPermisosRoles";
        public NoPermisosRepositorio(SqlConnection context, SqlTransaction transaction)
        {
            this._context = context;
            this._transaction = transaction;
        }

        public List<NoPermisoRol> GetLista(int rolId)
        {
            try
            {
                List<NoPermisoRol> lista = new List<NoPermisoRol>();
                string cadenaComando = "SELECT PermisoRolId, RolId, PermisoId,  RowVersion  " +
                                       "FROM PermisosDenegadosPorRol WHERE RolId=@id";
                using (var comando = (SqlCommand)CreateCommand(cadenaComando))
                {
                    comando.Parameters.AddWithValue("@id", rolId);
                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            NoPermisoRol noPermisoRol = ConstruirNoPermisoRol(reader);
                            lista.Add(noPermisoRol);
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

        private NoPermisoRol ConstruirNoPermisoRol(SqlDataReader reader)
        {
            return new NoPermisoRol()
            {
                NoPermisoRolId = reader.GetInt32(0),
                RolId = reader.GetInt32(1),
                PermisoId = reader.GetInt32(2)
            };
        }
    }
}
