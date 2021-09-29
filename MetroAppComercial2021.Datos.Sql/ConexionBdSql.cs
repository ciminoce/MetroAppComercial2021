using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroAppComercial2021.Datos.Comun;

namespace MetroAppComercial2021.Datos.Sql
{
    public class ConexionBdSql:IConexionBd
    {
        private readonly string cadenaDeConexion;
        private SqlConnection cn;

        public static ConexionBdSql instancia;
        //Patrón Singleton
        public static ConexionBdSql GetInstancia()
        {
            if (instancia == null)
            {
                instancia = new ConexionBdSql();
            }
            return instancia;
        }
        private ConexionBdSql()
        {
            this.cadenaDeConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ToString();
        }

        public IDbConnection GetConexion()
        {
            try
            {
                cn = new SqlConnection(cadenaDeConexion);
            }
            catch (Exception ex)
            {
                cn = null;
            }
            return cn;
        }
    }
}
