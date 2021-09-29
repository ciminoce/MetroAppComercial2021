using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroAppComercial2021.Datos.Comun.Excepciones
{
    public static class DbExceptionManager
    {
        public static Exception GettingException(string tabla)
        {
            return new Exception($"Error al intentar leer de la tabla {tabla}");
        }

        public static Exception InsertException(string tabla)
        {
            return new Exception($"Error al intentar agregar un registro en la tabla:{tabla}");
        }

        public static Exception DeleteException(string tabla)
        {
            return new Exception($"Error al intentar borrar un registro de la tabla: {tabla}");
        }

        public static Exception UpdateException(string tabla)
        {
            return new Exception($"Error al intentar modificar un registro de la tabla: {tabla}");
        }
    }
}
