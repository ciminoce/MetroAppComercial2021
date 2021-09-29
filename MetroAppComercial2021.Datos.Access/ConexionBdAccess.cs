using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroAppComercial2021.Datos.Comun;

namespace MetroAppComercial2021.Datos.Access
{
    public class ConexionBdAccess:IConexionBd
    {
        private readonly string cadenaDeConexion;
        private OleDbConnection cn;

        public static ConexionBdAccess instancia;
        //Patrón Singleton
        public static ConexionBdAccess GetInstancia()
        {
            if (instancia == null)
            {
                instancia = new ConexionBdAccess();
            }

            return instancia;
        }
        private ConexionBdAccess()
        {
            this.cadenaDeConexion = ConfigurationManager.ConnectionStrings["MiConexionAccess"].ToString();
        }

        public IDbConnection GetConexion()
        {
            try
            {
                cn = new OleDbConnection(cadenaDeConexion);
                return cn;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
