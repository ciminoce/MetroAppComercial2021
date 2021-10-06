using MetroAppComercial2021.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroAppComercial2021.Servicios.Facades;
using MetroAppComercial2021.Windows.Classes;
using MetroAppComercial2021.Windows.Excepciones;
using MetroAppComercial2021.Windows.Helpers;

namespace MetroAppComercial2021.Windows.FormCajas
{
    public partial class FrmCajasEdit : MetroFramework.Forms.MetroForm
    {
        public FrmCajasEdit(ICajasServicios servicio)
        {
            InitializeComponent();
            _servicio = servicio;
        }

        private string _archivoImagen = null;

        private readonly string _imagenNoDisponible = Application.StartupPath + "\\SinImagenDisponible.jpg";
        private readonly string _archivoNoEncontrado = Application.StartupPath + "\\ArchivoNoEncontrado.jpg";


        private readonly ICajasServicios _servicio;
        private Caja caja;
        private bool esEdicion = false;
        public void SetCaja(Caja caja)
        {
            this.caja = caja;
        }

        public Caja GetCaja()
        {
            return caja;
        }

        private void AgregarIconButton_Click(object sender, EventArgs e)
        {
            FrmBombonCajaEdit frm = new FrmBombonCajaEdit() {Text = "Agregar Bombón a la Caja"};
            DialogResult dr = frm.ShowDialog(this);
            if (dr==DialogResult.OK)
            {
                var detalle = frm.GetDetalleCaja();
                //Tengo que ver si ya no existe un bombon como el que viene en el detalle
                if (CarritoDeDetalles.GetInstancia().Existe(detalle))
                {
                    DialogResult drDetalle = MessageBox.Show("Bombón existente... ¿Desea actualizar la cantidad?",
                        "Confirmar",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (drDetalle==DialogResult.No)
                    {
                        return;//Rechazo el bombón por estar repetido
                    }
                    //Actualizo la cantidad de bombones en la caja del tipo que me pasan
                    CarritoDeDetalles.GetInstancia().Actualizar(detalle);

                }
                else
                {
                    //Si el bombon no existe... lo agrego
                    CarritoDeDetalles.GetInstancia().Agregar(detalle);
                }

                MostrarDatosEnGrilla();
                ActualizarPrecios();
            }
        }

        private void ActualizarPrecios()
        {
            CostoMetroTextBox.Text = CarritoDeDetalles.GetInstancia().GetPrecioCosto().ToString();
            PVtaMetroTextBox.Text = CarritoDeDetalles.GetInstancia().GetPrecioVenta().ToString();
        }

        private void MostrarDatosEnGrilla()
        {
            HelperGrid.LimpiarGrilla(DatosMetroGrid);
            foreach (var detalleCaja in CarritoDeDetalles.GetInstancia().GetLista())
            {
                var r = HelperGrid.ConstruirFila(DatosMetroGrid);
                HelperGrid.SetearFila(r,detalleCaja);
                HelperGrid.AgregarFila(DatosMetroGrid,r);
            }
        }

        private void CancelarIconButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void OKIconButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (caja == null)
                {
                    caja = new Caja();

                }

                caja.NombreProducto = CajaMetroTextBox.Text;
                caja.Descripcion = DescripcionMetroTextBox.Text;
                caja.CantidadEnExistencia = int.Parse(StockMetroTextBox.Text);
                caja.CantidadEnPedido = int.Parse(EnPedidoMetroTextBox.Text);
                caja.Imagen = _archivoImagen;
                caja.NivelDeReposicion = int.Parse(ReposicionMetroTextBox.Text);
                caja.PrecioCosto = decimal.Parse(CostoMetroTextBox.Text);
                caja.PrecioVenta = decimal.Parse(PVtaMetroTextBox.Text);
                caja.Suspendido = SuspendidoMetroCheckBox.Checked;
                caja.DetalleCajas = CarritoDeDetalles.GetInstancia().GetLista();


                try
                {
                    if (!_servicio.Existe(caja))
                    {
                        if (!esEdicion)
                        {
                            int registrosAfectados = _servicio.Agregar(caja);
                            if (registrosAfectados == 0)
                            {
                                HelperMessageBox.Message(this, GuiMessageManager.NonRecordsAdded(), "Advertencia",
                                    MessageType.Warning);
                                return;
                            }

                            HelperMessageBox.Message(this, GuiMessageManager.RecordsAdded(registrosAfectados), "Mensaje",
                                MessageType.Information);

                            DialogResult dr =
                                HelperMessageBox.Message(this, "¿Desea agregar otro registro?", "Pregunta");
                            if (dr == DialogResult.Yes)
                            {

                                InicializarControles();
                                CajaMetroTextBox.Focus();
                            }
                            else
                            {
                                DialogResult = DialogResult.OK;
                            }
                        }
                        else
                        {
                            DialogResult = DialogResult.OK;
                        }
                    }
                    else
                    {
                        errorProvider1.SetError(CajaMetroTextBox, GuiMessageManager.ExistingRecord());
                        return;
                    }
                }
                catch (Exception ex)
                {
                    HelperMessageBox.Message(this, ex.Message, "Error", MessageType.Error);
                }
            }

        }

        private void InicializarControles()
        {
            CajaMetroTextBox.Clear();
            DescripcionMetroTextBox.Clear();
            StockMetroTextBox.Clear();
            EnPedidoMetroTextBox.Clear();
            ReposicionMetroTextBox.Clear();
            CostoMetroTextBox.Clear();
            PVtaMetroTextBox.Clear();
            HelperGrid.LimpiarGrilla(DatosMetroGrid);

        }

        private bool ValidarDatos()
        {
            //Ver que validamos
            return true;
        }

        private void SubirImagenIconButton_Click(object sender, EventArgs e)
        {
            //Abro un filedialog para buscar un archivo de imagen
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            //Seteo que no se pueda elegir más de uno a la vez
            openFileDialog1.Multiselect = false;
            //Pongo los filtros 
            openFileDialog1.Filter = " Imagenes(*.BMP;*.JPG;*.GIF;*.PGN)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            //Por defecto busco bitmaps
            openFileDialog1.FilterIndex = 1;

            //Abro el cuadro de diálogo
            DialogResult dr = openFileDialog1.ShowDialog(this);
            //Si el dialogo termina OK
            if (dr == DialogResult.OK)
            {
                //Tomo el nombre del archivo de imagen con su ruta
                //archivoNombreConRuta = openFileDialog1.FileName;
                ImagenPictureBox.Image = Image.FromFile(openFileDialog1.FileName);
                _archivoImagen = openFileDialog1.FileName;//Tomo la ruta y el nombre del archivo
            }

        }
    }
}
