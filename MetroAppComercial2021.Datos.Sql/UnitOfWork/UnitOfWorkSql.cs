using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroAppComercial2021.Datos.Comun.UnitOfWork;

namespace MetroAppComercial2021.Datos.Sql.UnitOfWork
{
    public class UnitOfWorkSql:IUnitOfWork
    {
        public IUnitOfWorkAdapter Create()
        {
            return new UnitOfWorkAdapterSql();
        }
    }
}
