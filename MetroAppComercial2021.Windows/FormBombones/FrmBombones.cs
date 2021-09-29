using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroAppComercial2021.Datos.Comun.UnitOfWork;
using MetroAppComercial2021.Datos.Sql.UnitOfWork;
using MetroAppComercial2021.Entidades.Entidades;
using MetroAppComercial2021.Servicios;
using MetroAppComercial2021.Servicios.Facades;
using MetroAppComercial2021.Windows.Excepciones;
using MetroAppComercial2021.Windows.FormClientes;
using MetroAppComercial2021.Windows.Helpers;
using MetroFramework.Controls;

namespace MetroAppComercial2021.Windows.FormBombones
{
    public partial class FrmBombones : MetroFramework.Forms.MetroForm
    {
        public FrmBombones()
        {
            InitializeComponent();
        }

        private void NuevoIconButton_Click(object sender, EventArgs e)
        {
            FrmBombonesEdit frm = new FrmBombonesEdit(_servicio) { Text = "Nuevo Bombón" };
            DialogResult dr = frm.ShowDialog(this);
            RecargarGrilla();
        }

        private void CerrarIconButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private IUnitOfWork _unitOfWork;
        private IBombonesServicios _servicio;
        private List<Bombon> lista;

        private int cantidadPorPagina = 15;//Cantidad de registros a mostrar por página
        private int cantidadDeRegistros;
        private int cantidadDePaginas;
        private int paginaActual = 1;

        private void FrmBombones_Load(object sender, EventArgs e)
        {
            _unitOfWork = new UnitOfWorkSql();
            _servicio = new BombonesServicios(_unitOfWork);
            RecargarGrilla();
        }

        private void RecargarGrilla()
        {
            try
            {
                //Obtengo la cantidad de registros de la tabla
                cantidadDeRegistros = _servicio.GetCantidad();
                /*
                 * Obtengo la cantidad de páginas que puedo tener
                 * usando una clase estática para los cálculos y
                 * poderla usar en todos los forms
                 */
                cantidadDePaginas = HelperCalculos.CalcularCantidadDePaginas(cantidadDeRegistros, cantidadPorPagina);
                /*
                 * Usando otra clase estática, creo los botones
                 * para la paginación de la tabla
                 */
                HelperForm.CrearBotonesPaginas(BotonesMetroPanel,cantidadDePaginas);
                /*
                 * Método para asignar a cada botón un manejador del evento clic
                 */
                AsignarEventHandler(this.BotonesMetroPanel);

                RegistrosMetroLabel.Text = cantidadDeRegistros.ToString();
                PaginasMetroLabel.Text = cantidadDePaginas.ToString();

                MostrarPaginado(cantidadPorPagina,paginaActual);
                //lista = _servicio.GetListaPaginada(cantidadPorPagina,paginaActual);
                                
                //MostrarDatosEnGrilla();
            }
            catch (Exception e)
            {
                HelperMessageBox.Message(this, e.Message, "Error", MessageType.Error);
            }
        }

        private void AsignarEventHandler(MetroPanel panel)
        {
            /*
             * Hago un ciclo para recorrer los controles
             * que tiene el panel donde se muestran los botones
             * si el control es un botón entonces le asigno el manejador del evento click
             * que en nuestro caso se llama Miclick.
             * 
             */
            foreach (var control in panel.Controls)
            {
                if (control is MetroButton)
                {
                    ((Button)control).Click += Miclick;
                }
            }

        }
        private void Miclick(object sender, EventArgs e)
        {
            //Obtengo el botón donde se efectuó el clic
            MetroButton b = (MetroButton)sender;
            //De la prop Text obtengo el número de página que se seleccionó (b.Text)
            //y luego lo asigno a la página actual previo convertirlo a entero
            paginaActual = int.Parse(b.Text);
            //Muestro paginado
            MostrarPaginado(cantidadPorPagina, paginaActual);
        }
        private void MostrarPaginado(int cantidadPorPagina, int paginaActual)
        {
            /*
             * Observar que se usa otro método para paginar
             * en este caso para no tener que propagarlo por todo el proyecto
             */
            lista = _servicio.GetListaPaginada(cantidadPorPagina, paginaActual);
            MostrarDatosEnGrilla();

        }

        private void MostrarDatosEnGrilla()
        {
            HelperGrid.LimpiarGrilla(DatosMetroGrid);
            foreach (var bombon in lista)
            {
                DataGridViewRow r = HelperGrid.ConstruirFila(DatosMetroGrid);
                HelperGrid.SetearFila(r, bombon);
                HelperGrid.AgregarFila(DatosMetroGrid, r);
            }
        }

        private void EditarIconButton_Click(object sender, EventArgs e)
        {
            {
                if (DatosMetroGrid.SelectedRows.Count == 0)
                {
                    return;
                }

                DataGridViewRow r = DatosMetroGrid.SelectedRows[0];
                var bombon = (Bombon)r.Tag;
                FrmBombonesEdit frm = new FrmBombonesEdit(_servicio) { Text = "Editar Bombon" };
                frm.SetBombon(bombon);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    return;
                }

                try
                {
                    bombon = frm.GetBombon();
                    int registrosGuardados = _servicio.Editar(bombon);
                    if (registrosGuardados == 0)
                    {
                        HelperMessageBox.Message(this, GuiMessageManager.NonExistingOrModifiedRecord(), "Mensaje",
                            MessageType.Warning);
                        RecargarGrilla();

                        return;
                    }

                    HelperMessageBox.Message(this, GuiMessageManager.RecordsUpdated(registrosGuardados), "Mensaje",
                        MessageType.Information);

                    HelperGrid.SetearFila(r, bombon);

                }
                catch (Exception exception)
                {
                    HelperMessageBox.Message(this, exception.Message, "Mensaje", MessageType.Error);
                }


            }
        }

        private void BorrarIconButton_Click(object sender, EventArgs e)
        {
            if (DatosMetroGrid.SelectedRows.Count == 0)
            {
                return;
            }

            DataGridViewRow r = DatosMetroGrid.SelectedRows[0];
            var b = (Bombon)r.Tag;
            DialogResult dr = HelperMessageBox.Message(this, GuiMessageManager.ConfirmDelete(), "Confirmar");

            if (dr == DialogResult.Yes)
            {
                try
                {

                    if (!_servicio.EstaRelacionado(b))
                    {
                        int registrosBorrados = _servicio.Borrar(b);
                        if (registrosBorrados == 0)
                        {
                            HelperMessageBox.Message(this, GuiMessageManager.NonExistingOrModifiedRecord(),
                                "Advertencia", MessageType.Warning);
                            RecargarGrilla();
                            return;

                        }

                        HelperMessageBox.Message(this, GuiMessageManager.RecordsDeleted(registrosBorrados), "Mensaje", MessageType.Information);

                        HelperGrid.QuitarFila(DatosMetroGrid, r);

                    }
                    else
                    {
                        HelperMessageBox.Message(this, GuiMessageManager.RelatedRecords(), "Error", MessageType.Error);
                    }

                }
                catch (Exception ex)
                {
                    HelperMessageBox.Message(this, ex.Message, "Error", MessageType.Error);
                }

            }

        }
    }
}
