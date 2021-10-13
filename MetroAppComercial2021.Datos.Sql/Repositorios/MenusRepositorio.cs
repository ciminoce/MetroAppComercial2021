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
    public class MenusRepositorio:DbHelperSql,IMenusRepositorio
    {

        private readonly string tabla = "Menus";
        public MenusRepositorio(SqlConnection context, SqlTransaction transaction)
        {
            this._context = context;
            this._transaction = transaction;
        }

        public List<Menu> GetLista()
        {
            try
            {
                List<Menu> lista = new List<Menu>();
                string cadenaComando = "SELECT MenuId, NombreMenu, RowVersion  " +
                                       "FROM Menus ORDER BY NombreMenu";
                using (var comando = CreateCommand(cadenaComando))
                {
                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var menu = ConstruirMenu(reader);
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

        private Menu ConstruirMenu(IDataReader reader)
        {
            return new Menu()
            {
                MenuId = reader.GetInt32(0),
                NombreMenu = reader.GetString(1)
            };
        }


        public Menu GetMenuPorId(int id)
        {
            try
            {
                Menu menu=null;
                string cadenaComando = "SELECT MenuId, NombreMenu, RowVersion  " +
                                       "FROM Menus WHERE MenuId=@id";
                using (var comando =(SqlCommand) CreateCommand(cadenaComando))
                {
                    comando.Parameters.AddWithValue("@id", id);
                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            menu = ConstruirMenu(reader);
                            
                        }
                    }
                }

                return menu;
            }
            catch (Exception ex)
            {
                throw DbExceptionManager.GettingException(tabla);
            }
        }

    }
}
