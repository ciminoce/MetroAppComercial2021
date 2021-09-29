using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroAppComercial2021.Datos.Comun
{
    public interface IConexionBd
    {
        IDbConnection GetConexion();
    }
}
