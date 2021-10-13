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
    public class PermisosRepositorio:DbHelperSql, IPermisosRepositorio
    {
        private readonly string tabla = "Menus";
        public PermisosRepositorio(SqlConnection context, SqlTransaction transaction)
        {
            this._context = context;
            this._transaction = transaction;
        }

        public List<Permiso> GetLista()
        {
            try
            {
                List<Permiso> lista = new List<Permiso>();
                string cadenaComando = "SELECT PermisoId, MenuId, NombrePermiso,  RowVersion  " +
                                       "FROM Permisos ORDER BY MenuId, NombrePermiso";
                using (var comando = CreateCommand(cadenaComando))
                {
                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var menu = ConstruirPermiso(reader);
                            lista.Add(menu);
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

        private Permiso ConstruirPermiso(IDataReader reader)
        {
            return new Permiso()
            {
                PermisoId = reader.GetInt32(0),
                MenuId = reader.GetInt32(1),
                NombrePermiso = reader.GetString(2),
                RowVersion = (byte[])reader[3]
            };
        }


        public Permiso GetPermisoPorId(int id)
        {
            try
            {
                Permiso permiso = null;
                string cadenaComando = "SELECT PermisoId, MenuId, NombrePermiso,  RowVersion  " +
                                       "FROM Permisos WHERE PermisoId=@id";
                using (var comando =(SqlCommand) CreateCommand(cadenaComando))
                {
                    comando.Parameters.AddWithValue("@id", id);
                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            permiso = ConstruirPermiso(reader);
                            
                        }
                    }
                }

                return permiso;
            }
            catch (Exception ex)
            {
                throw DbExceptionManager.GettingException(tabla);
            }
        }

    }
}
