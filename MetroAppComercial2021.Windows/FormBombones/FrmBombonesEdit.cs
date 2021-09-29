using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroAppComercial2021.Entidades.Entidades;
using MetroAppComercial2021.Servicios.Facades;
using MetroAppComercial2021.Windows.Excepciones;
using MetroAppComercial2021.Windows.Helpers;

namespace MetroAppComercial2021.Windows.FormBombones
{
    public partial class FrmBombonesEdit : MetroFramework.Forms.MetroForm
    {
        public FrmBombonesEdit(IBombonesServicios servicio)
        {
            InitializeComponent();
            _servicio = servicio;
        }

        private IBombonesServicios _servicio;
        private Bombon bombon;
        private TipoChocolate tipoChocolate;
        private TipoRelleno tipoRelleno;
        private TipoNuez tipoNuez;
        private string _archivoImagen = null;

        private readonly string _imagenNoDisponible = Application.StartupPath + "\\SinImagenDisponible.jpg";
        private readonly string _archivoNoEncontrado = Application.StartupPath + "\\ArchivoNoEncontrado.jpg";


        private bool esEdicion = false;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            HelperCombo.CargarDatosComboChocolates(ref ChocolateMetroComboBox);
            HelperCombo.CargarDatosComboNueces(ref NuezMetroComboBox);
            HelperCombo.CargarDatosComboRellenos(ref RellenoMetroComboBox);

            if (bombon != null)
            {
                esEdicion = true;
                BombonMetroTextBox.Text = bombon.NombreProducto;
                DescripcionMetroTextBox.Text = bombon.Descripcion;
                CostoMetroTextBox.Text = bombon.PrecioCosto.ToString();
                PVtaMetroTextBox.Text = bombon.PrecioVenta.ToString();
                StockMetroTextBox.Text = bombon.CantidadEnExistencia.ToString();
                EnPedidoMetroTextBox.Text = bombon.CantidadEnPedido.ToString();
                ReposicionMetroTextBox.Text = bombon.NivelDeReposicion.ToString();
                tipoChocolate = bombon.TipoChocolate;
                tipoNuez=bombon.TipoNuez;
                tipoRelleno = bombon.TipoRelleno;
                ChocolateMetroComboBox.SelectedValue = bombon.ChocolateId;
                RellenoMetroComboBox.SelectedValue = bombon.RellenoId;
                NuezMetroComboBox.SelectedValue = bombon.NuezId;
                SuspendidoMetroCheckBox.Checked = bombon.Suspendido;
                //Veo si el bombon tiene alguna imagen asociada
                if (bombon.Imagen != string.Empty)
                {
                    
                    //Me aseguro que esa imagen exista
                    if (!File.Exists(bombon.Imagen))
                    {
                        //Si no existe, muestro la imagen de archivo no encontrado
                        ImagenPictureBox.Image = Image.FromFile(_archivoNoEncontrado);
                    }
                    else
                    {
                        //Caso contrario muestro la imagen
                        ImagenPictureBox.Image = Image.FromFile(bombon.Imagen);
                    }
                }
                else
                {
                    //Si no tiene imagen muestro Sin Imagen 
                    ImagenPictureBox.Image = Image.FromFile(_imagenNoDisponible);
                }

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
                if (bombon == null)
                {
                    bombon = new Bombon();
                }

                bombon.NombreProducto = BombonMetroTextBox.Text;
                bombon.Descripcion = DescripcionMetroTextBox.Text;
                bombon.PrecioVenta =decimal.Parse(PVtaMetroTextBox.Text);
                bombon.PrecioCosto = decimal.Parse(CostoMetroTextBox.Text);
                bombon.CantidadEnExistencia =int.Parse(StockMetroTextBox.Text);
                bombon.CantidadEnPedido = int.Parse(EnPedidoMetroTextBox.Text);
                bombon.NivelDeReposicion = int.Parse(ReposicionMetroTextBox.Text);
                bombon.Suspendido = SuspendidoMetroCheckBox.Checked;
                bombon.TipoChocolate = tipoChocolate;
                bombon.TipoNuez = tipoNuez;
                bombon.TipoRelleno = tipoRelleno;
                bombon.ChocolateId = tipoChocolate.TipoChocolateId;
                bombon.NuezId = tipoNuez.TipoNuezId;
                bombon.RellenoId = tipoRelleno.TipoRellenoId;
                bombon.Imagen = _archivoImagen;
                try
                {
                    if (!_servicio.Existe(bombon))
                    {
                        if (!esEdicion)
                        {
                            int registrosAfectados = _servicio.Agregar(bombon);
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
                                BombonMetroTextBox.Focus();

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
                        errorProvider1.SetError(BombonMetroTextBox, GuiMessageManager.ExistingRecord());
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
            BombonMetroTextBox.Clear();
            DescripcionMetroTextBox.Clear();
            CostoMetroTextBox.Clear();
            PVtaMetroTextBox.Clear();
            StockMetroTextBox.Clear();
            ReposicionMetroTextBox.Clear();
            EnPedidoMetroTextBox.Clear();
            ImagenPictureBox.Image = null;
            ChocolateMetroComboBox.SelectedIndex=0;
            RellenoMetroComboBox.SelectedIndex = 0;
            NuezMetroComboBox.SelectedIndex = 0;
            SuspendidoMetroCheckBox.Checked = false;
            _archivoImagen = string.Empty;
        }

        private bool ValidarDatos()
        {
            //Se deben validar los campos requeridos
            bool valido = true;
            errorProvider1.Clear();

            return valido;
        }

        public void SetBombon(Bombon bombon)
        {
            this.bombon = bombon;
        }

        public Bombon GetBombon()
        {
            return bombon;
        }

        private void RellenoMetroComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RellenoMetroComboBox.SelectedIndex != 0)
            {
                tipoRelleno = (TipoRelleno)RellenoMetroComboBox.SelectedItem;
            }
            else
            {
                tipoRelleno = null;
            }

        }

        private void NuezMetroComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NuezMetroComboBox.SelectedIndex != 0)
            {
                tipoNuez = (TipoNuez)NuezMetroComboBox.SelectedItem;
            }
            else
            {
                tipoNuez = null;
            }
        }

        private void ChocolateMetroComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (ChocolateMetroComboBox.SelectedIndex != 0)
            {
                tipoChocolate = (TipoChocolate)ChocolateMetroComboBox.SelectedItem;
            }
            else
            {
                tipoChocolate = null;
            }

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
