using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroAppComercial2021.Datos.Comun.UnitOfWork;

namespace MetroAppComercial2021.Datos.Sql.UnitOfWork
{
    public class UnitOfWorkAdapterSql:IUnitOfWorkAdapter
    {
        private SqlConnection _context { get; set; }
        private SqlTransaction _transaction { get; set; }

        public UnitOfWorkAdapterSql()
        {
            _context = (SqlConnection)ConexionBdSql.GetInstancia().GetConexion();
            _context.Open();
            _transaction = _context.BeginTransaction();
            repositorios = new UnitOfWorkRepositoriosSql(_context, _transaction);
        }
        public void Dispose()
        {
            if (_transaction != null)
            {
                _transaction.Dispose();
            }

            if (_context != null)
            {
                _context.Close();
                _context.Dispose();
            }

            repositorios = null;
        }


        public IUnitOfWorkRepositorios repositorios { get; set; }

        public void SaveChanges()
        {
            _transaction.Commit();//confirma los cambios
        }
    }
}
