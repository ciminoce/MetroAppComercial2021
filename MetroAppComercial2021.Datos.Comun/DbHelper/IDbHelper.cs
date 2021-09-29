using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroAppComercial2021.Datos.Comun.DbHelper
{
    public interface IDbHelper
    {
        IDbCommand CreateCommand(string query);

    }
}
