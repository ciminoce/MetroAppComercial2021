using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Controls;

namespace MetroAppComercial2021.Windows.Helpers
{
    public class HelperForm
    {
        /*
         * Método estático para crear los botones de paginación
         */
        public static void CrearBotonesPaginas(MetroPanel panel, int paginas)
        {
            //Limpio el panel
            panel.Controls.Clear();
            //Ciclo para crear los botones
            for (int i = 0; i < paginas; i++)
            {
                MetroButton b = new MetroButton()
                {
                    Text = (i + 1).ToString(), //Texto que se muestra en el botón
                    Location = new Point(19 + (35 * i), 8),//Posición del botón
                    Size = new Size(30, 30)//Tamaño del botón

                };
                panel.Controls.Add(b);//Agregro el botón a la colección de controles del panel
            }

        }

    }
}
