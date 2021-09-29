using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroAppComercial2021.Windows.Helpers
{
    public class HelperCalculos
    {
        //Método estático para calcular la cantidad de páginas 
        public static int CalcularCantidadDePaginas(int totalRegistros, int porPagina)
        {
            /*
             * Si la cantidad de registros es inferior a la cantidad
             * que se desea mostrar en cada página
             * se asigna 1 página
             */
            
            if (totalRegistros < porPagina)
            {
                return 1;
            }
            /*
             * Si la cantidad es mayor a la permitida en cada página,
             * se efectúa la división, si el resto es mayor a 0
             * entonces al cociente se le suma 1
             * caso contrario se devuelve el cociente
             */
            if (totalRegistros % porPagina > 0)
            {
                return totalRegistros / porPagina + 1;
            }
            else
            {
                return totalRegistros / porPagina;
            }
        }

    }
}
