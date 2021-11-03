using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroAppComercial2021.Entidades.Entidades;
using MetroAppComercial2021.Windows.Classes;
using MetroAppComercial2021.Windows.Helpers;

namespace MetroAppComercial2021.Windows.FormVentas
{
    public partial class FrmVentasEdit : MetroFramework.Forms.MetroForm
    {
        public FrmVentasEdit()
        {
            InitializeComponent();
        }

        private Venta venta;
        private Cliente cliente;
        private Caja caja;
        private Bombon bombon;
        private Producto producto;
        
        private void FrmVentasEdit_Load(object sender, EventArgs e)
        {
            HelperCombo.CargarDatosComboClientes(ref ClientesMetroComboBox);
            HelperCombo.CargarDatosComboBombones(ref BombonesMetroComboBox);
            HelperCombo.CargarDatosComboCajas(ref CajasMetroComboBox);
            CarritoDeVentas.GetInstancia().VaciarCarrito();
        }

        private void ClientesMetroComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ClientesMetroComboBox.SelectedIndex==0)
            {
                cliente = null;
                return;
            }

            cliente = (Cliente) ClientesMetroComboBox.SelectedItem;
            MostrarDatosDelCliente();

        }

        private void MostrarDatosDelCliente()
        {
            DireccionMetroTextBox.Text = cliente.Direccion;
            CodPostalMetroTextBox.Text = cliente.CodPostal;
            LocalidadMetroTextBox.Text = cliente.Localidad.NombreLocalidad;
            ProvinciaMetroTextBox.Text = cliente.Provincia.NombreProvincia;
        }

        private void CajasMetroComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CajasMetroComboBox.SelectedIndex>0)
            {
                bombon = null;
                BombonesMetroComboBox.SelectedIndex = 0;

                producto = (Caja) CajasMetroComboBox.SelectedItem;
                MostrarDatosDelProducto(producto);
                CantidadNumericUpDown.Enabled = true;
                CantidadNumericUpDown.Maximum = producto.CantidadEnExistencia - producto.CantidadEnPedido;
            }
        }

        private void MostrarDatosDelProducto(Producto producto)
        {
            PVtaMetroTextBox.Text = producto.PrecioVenta.ToString();
            StockMetroTextBox.Text = producto.CantidadEnExistencia.ToString();
            EnPedidoMetroTextBox.Text = producto.CantidadEnPedido.ToString();
        }

        private void BombonesMetroComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BombonesMetroComboBox.SelectedIndex>0)
            {
                caja = null;
                CajasMetroComboBox.SelectedIndex = 0;

                producto = (Bombon) BombonesMetroComboBox.SelectedItem;
                MostrarDatosDelProducto(producto);
                CantidadNumericUpDown.Enabled = true;
                CantidadNumericUpDown.Maximum = producto.CantidadEnExistencia - producto.CantidadEnPedido;

            }
        }

        private void CantidadNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

            if (CantidadNumericUpDown.Value>0)
            {
                TotalMetroTextBox.Text = (CantidadNumericUpDown.Value * producto.PrecioVenta).ToString();

            }
            else
            {
                TotalMetroTextBox.Clear();
            }

        }

        private void CancelarIconButton_Click(object sender, EventArgs e)
        {
            InicializarControles();
        }

        private void InicializarControles()
        {
            caja = null;
            bombon = null;
            producto = null;
            PVtaMetroTextBox.Clear();
            StockMetroTextBox.Clear();
            TotalMetroTextBox.Clear();
            CantidadNumericUpDown.Value = 0;
            CajasMetroComboBox.SelectedIndex = 0;
            BombonesMetroComboBox.SelectedIndex = 0;
            CajasMetroComboBox.Focus();
        }

        private void OKIconButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                var detalleVta = new DetalleVenta()
                {
                    ProductoId=producto.Id,
                    Producto = producto,
                    Precio = producto.PrecioVenta,
                    Cantidad = (int) CantidadNumericUpDown.Value,
                    TipoProducto = (producto is Caja) ? TipoProducto.Caja : TipoProducto.Bombon
                };
                if (CarritoDeVentas.GetInstancia().Existe(detalleVta))
                {
                    DialogResult drVenta = HelperMessageBox.Message(this,"Producto ya consta en la venta..." +
                                                           Environment.NewLine + " ¿Actualiza cantidad? ",
                        "Confirmar");
                    if (drVenta==DialogResult.No)
                    {
                        return;
                    }
                }
                CarritoDeVentas.GetInstancia().Agregar(detalleVta);
                MostrarDetallesDelPedido();
                ActualizarTotalVenta();
                MessageBox.Show("Articulo agregado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                InicializarControles();
                detalleVta = null;
            }
        }

        private void ActualizarTotalVenta()
        {
            TotalAPagarMetroTextBox.Text= CarritoDeVentas.GetInstancia().GetTotal().ToString();
        }

        private void MostrarDetallesDelPedido()
        {
            HelperGrid.LimpiarGrilla(DatosMetroGrid);
            foreach (var detalleVenta in CarritoDeVentas.GetInstancia().GetLista())
            {
                var r = HelperGrid.ConstruirFila(DatosMetroGrid);
                HelperGrid.SetearFila(r, detalleVenta);
                HelperGrid.AgregarFila(DatosMetroGrid,r);
            }
        }

        private bool ValidarDatos()
        {
            bool esValido = true;
            errorProvider1.Clear();
            if (CantidadNumericUpDown.Value==0)
            {
                esValido = false;
                errorProvider1.SetError(CantidadNumericUpDown,"Debe ingresar una cantidad");
            }
            return esValido;
        }

        private void GuardarVentaIconButton_Click(object sender, EventArgs e)
        {
            if (ValidarVenta())
            {
                venta = new Venta()
                {
                    ClienteId = cliente.Id,
                    Cliente=cliente,
                    FechaVenta = FechaMetroDateTime.Value.Date,
                    Total = CarritoDeVentas.GetInstancia().GetTotal(),
                    Regalo = RegaloMetroCheckBox.Checked,
                    DetalleVentas = CarritoDeVentas.GetInstancia().GetLista()
                };
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarVenta()
        {
            bool esValido = true;
            errorProvider1.Clear();
            if (ClientesMetroComboBox.SelectedIndex==0)
            {
                esValido = false;
                errorProvider1.SetError(ClientesMetroComboBox,"Debe seleccionar un cliente");
            }

            if (FechaMetroDateTime.Value.Date!=DateTime.Today.Date)
            {
                esValido = false;
                errorProvider1.SetError(FechaMetroDateTime,"Fecha distinta a la fecha del día");
            }

            if (CarritoDeVentas.GetInstancia().GetCantidad()==0)
            {
                esValido = false;
                errorProvider1.SetError(CajasMetroComboBox,"Debe ingresar al menos un item de Caja o Bombón");
            }

            return esValido;
        }

        public Venta GetVenta()
        {
            return venta;
        }
    }
}
