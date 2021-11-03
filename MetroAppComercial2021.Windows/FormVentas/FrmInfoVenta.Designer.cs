
namespace MetroAppComercial2021.Windows.FormVentas
{
    partial class FrmInfoVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.DatosMetroGrid = new MetroFramework.Controls.MetroGrid();
            this.colProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegaloMetroCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.CerrarIconButton = new FontAwesome.Sharp.IconButton();
            this.TotalAPagarMetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.LocalidadMetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.ProvinciaMetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.CodPostalMetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.ClienteMetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.DireccionMetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.FechaMetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatosMetroGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(852, 607);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(89, 19);
            this.metroLabel13.TabIndex = 95;
            this.metroLabel13.Text = "Total a Pagar:";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.DatosMetroGrid);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(24, 230);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1056, 363);
            this.metroPanel1.TabIndex = 94;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // DatosMetroGrid
            // 
            this.DatosMetroGrid.AllowUserToAddRows = false;
            this.DatosMetroGrid.AllowUserToDeleteRows = false;
            this.DatosMetroGrid.AllowUserToResizeRows = false;
            this.DatosMetroGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DatosMetroGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DatosMetroGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DatosMetroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DatosMetroGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DatosMetroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosMetroGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProducto,
            this.colTipo,
            this.colPrecioUnitario,
            this.colCantidad,
            this.colPrecioTotal});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DatosMetroGrid.DefaultCellStyle = dataGridViewCellStyle8;
            this.DatosMetroGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatosMetroGrid.EnableHeadersVisualStyles = false;
            this.DatosMetroGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DatosMetroGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DatosMetroGrid.Location = new System.Drawing.Point(0, 0);
            this.DatosMetroGrid.Name = "DatosMetroGrid";
            this.DatosMetroGrid.ReadOnly = true;
            this.DatosMetroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DatosMetroGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DatosMetroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DatosMetroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DatosMetroGrid.Size = new System.Drawing.Size(1056, 363);
            this.DatosMetroGrid.TabIndex = 3;
            // 
            // colProducto
            // 
            this.colProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colProducto.HeaderText = "Producto";
            this.colProducto.Name = "colProducto";
            this.colProducto.ReadOnly = true;
            // 
            // colTipo
            // 
            this.colTipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTipo.HeaderText = "Tipo Prod.";
            this.colTipo.Name = "colTipo";
            this.colTipo.ReadOnly = true;
            // 
            // colPrecioUnitario
            // 
            this.colPrecioUnitario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colPrecioUnitario.HeaderText = "P. Unit";
            this.colPrecioUnitario.Name = "colPrecioUnitario";
            this.colPrecioUnitario.ReadOnly = true;
            this.colPrecioUnitario.Width = 78;
            // 
            // colCantidad
            // 
            this.colCantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colCantidad.HeaderText = "Cant.";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            this.colCantidad.Width = 68;
            // 
            // colPrecioTotal
            // 
            this.colPrecioTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colPrecioTotal.HeaderText = "P. Total";
            this.colPrecioTotal.Name = "colPrecioTotal";
            this.colPrecioTotal.ReadOnly = true;
            this.colPrecioTotal.Width = 81;
            // 
            // RegaloMetroCheckBox
            // 
            this.RegaloMetroCheckBox.AutoSize = true;
            this.RegaloMetroCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RegaloMetroCheckBox.Enabled = false;
            this.RegaloMetroCheckBox.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.RegaloMetroCheckBox.Location = new System.Drawing.Point(977, 135);
            this.RegaloMetroCheckBox.Name = "RegaloMetroCheckBox";
            this.RegaloMetroCheckBox.Size = new System.Drawing.Size(89, 19);
            this.RegaloMetroCheckBox.TabIndex = 93;
            this.RegaloMetroCheckBox.Text = "Es Regalo?";
            this.RegaloMetroCheckBox.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(924, 77);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(43, 19);
            this.metroLabel2.TabIndex = 92;
            this.metroLabel2.Text = "Fecha";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.LocalidadMetroTextBox);
            this.groupBox1.Controls.Add(this.ProvinciaMetroTextBox);
            this.groupBox1.Controls.Add(this.CodPostalMetroTextBox);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.ClienteMetroTextBox);
            this.groupBox1.Controls.Add(this.DireccionMetroTextBox);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(884, 164);
            this.groupBox1.TabIndex = 91;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Datos del Cliente ";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(36, 120);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(68, 19);
            this.metroLabel6.TabIndex = 6;
            this.metroLabel6.Text = "Localidad:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(494, 120);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(65, 19);
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.Text = "Provincia:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(623, 77);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(78, 19);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "Cód. Postal:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(38, 77);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(66, 19);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "Dirección:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(52, 31);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(52, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Cliente:";
            // 
            // CerrarIconButton
            // 
            this.CerrarIconButton.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.CerrarIconButton.IconColor = System.Drawing.Color.Black;
            this.CerrarIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CerrarIconButton.Location = new System.Drawing.Point(483, 643);
            this.CerrarIconButton.Name = "CerrarIconButton";
            this.CerrarIconButton.Size = new System.Drawing.Size(99, 63);
            this.CerrarIconButton.TabIndex = 97;
            this.CerrarIconButton.UseVisualStyleBackColor = true;
            this.CerrarIconButton.Click += new System.EventHandler(this.CerrarIconButton_Click);
            // 
            // TotalAPagarMetroTextBox
            // 
            // 
            // 
            // 
            this.TotalAPagarMetroTextBox.CustomButton.Image = null;
            this.TotalAPagarMetroTextBox.CustomButton.Location = new System.Drawing.Point(96, 1);
            this.TotalAPagarMetroTextBox.CustomButton.Name = "";
            this.TotalAPagarMetroTextBox.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.TotalAPagarMetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TotalAPagarMetroTextBox.CustomButton.TabIndex = 1;
            this.TotalAPagarMetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TotalAPagarMetroTextBox.CustomButton.UseSelectable = true;
            this.TotalAPagarMetroTextBox.CustomButton.Visible = false;
            this.TotalAPagarMetroTextBox.DisplayIcon = true;
            this.TotalAPagarMetroTextBox.Enabled = false;
            this.TotalAPagarMetroTextBox.Icon = global::MetroAppComercial2021.Windows.Properties.Resources.low_price_20px;
            this.TotalAPagarMetroTextBox.Lines = new string[0];
            this.TotalAPagarMetroTextBox.Location = new System.Drawing.Point(947, 607);
            this.TotalAPagarMetroTextBox.MaxLength = 5;
            this.TotalAPagarMetroTextBox.Multiline = true;
            this.TotalAPagarMetroTextBox.Name = "TotalAPagarMetroTextBox";
            this.TotalAPagarMetroTextBox.PasswordChar = '\0';
            this.TotalAPagarMetroTextBox.PromptText = "Total a Pagar";
            this.TotalAPagarMetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TotalAPagarMetroTextBox.SelectedText = "";
            this.TotalAPagarMetroTextBox.SelectionLength = 0;
            this.TotalAPagarMetroTextBox.SelectionStart = 0;
            this.TotalAPagarMetroTextBox.ShortcutsEnabled = true;
            this.TotalAPagarMetroTextBox.Size = new System.Drawing.Size(128, 33);
            this.TotalAPagarMetroTextBox.TabIndex = 96;
            this.TotalAPagarMetroTextBox.UseSelectable = true;
            this.TotalAPagarMetroTextBox.WaterMark = "Total a Pagar";
            this.TotalAPagarMetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TotalAPagarMetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // LocalidadMetroTextBox
            // 
            // 
            // 
            // 
            this.LocalidadMetroTextBox.CustomButton.Image = null;
            this.LocalidadMetroTextBox.CustomButton.Location = new System.Drawing.Point(261, 2);
            this.LocalidadMetroTextBox.CustomButton.Name = "";
            this.LocalidadMetroTextBox.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.LocalidadMetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.LocalidadMetroTextBox.CustomButton.TabIndex = 1;
            this.LocalidadMetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.LocalidadMetroTextBox.CustomButton.UseSelectable = true;
            this.LocalidadMetroTextBox.CustomButton.Visible = false;
            this.LocalidadMetroTextBox.DisplayIcon = true;
            this.LocalidadMetroTextBox.Enabled = false;
            this.LocalidadMetroTextBox.Icon = global::MetroAppComercial2021.Windows.Properties.Resources.marker_20px;
            this.LocalidadMetroTextBox.Lines = new string[0];
            this.LocalidadMetroTextBox.Location = new System.Drawing.Point(124, 120);
            this.LocalidadMetroTextBox.MaxLength = 10;
            this.LocalidadMetroTextBox.Multiline = true;
            this.LocalidadMetroTextBox.Name = "LocalidadMetroTextBox";
            this.LocalidadMetroTextBox.PasswordChar = '\0';
            this.LocalidadMetroTextBox.PromptText = "Localidad";
            this.LocalidadMetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.LocalidadMetroTextBox.SelectedText = "";
            this.LocalidadMetroTextBox.SelectionLength = 0;
            this.LocalidadMetroTextBox.SelectionStart = 0;
            this.LocalidadMetroTextBox.ShortcutsEnabled = true;
            this.LocalidadMetroTextBox.Size = new System.Drawing.Size(291, 32);
            this.LocalidadMetroTextBox.TabIndex = 7;
            this.LocalidadMetroTextBox.UseSelectable = true;
            this.LocalidadMetroTextBox.WaterMark = "Localidad";
            this.LocalidadMetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.LocalidadMetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ProvinciaMetroTextBox
            // 
            // 
            // 
            // 
            this.ProvinciaMetroTextBox.CustomButton.Image = null;
            this.ProvinciaMetroTextBox.CustomButton.Location = new System.Drawing.Point(261, 2);
            this.ProvinciaMetroTextBox.CustomButton.Name = "";
            this.ProvinciaMetroTextBox.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.ProvinciaMetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ProvinciaMetroTextBox.CustomButton.TabIndex = 1;
            this.ProvinciaMetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ProvinciaMetroTextBox.CustomButton.UseSelectable = true;
            this.ProvinciaMetroTextBox.CustomButton.Visible = false;
            this.ProvinciaMetroTextBox.DisplayIcon = true;
            this.ProvinciaMetroTextBox.Enabled = false;
            this.ProvinciaMetroTextBox.Icon = global::MetroAppComercial2021.Windows.Properties.Resources.marker_20px;
            this.ProvinciaMetroTextBox.Lines = new string[0];
            this.ProvinciaMetroTextBox.Location = new System.Drawing.Point(579, 120);
            this.ProvinciaMetroTextBox.MaxLength = 10;
            this.ProvinciaMetroTextBox.Multiline = true;
            this.ProvinciaMetroTextBox.Name = "ProvinciaMetroTextBox";
            this.ProvinciaMetroTextBox.PasswordChar = '\0';
            this.ProvinciaMetroTextBox.PromptText = "Provincia";
            this.ProvinciaMetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ProvinciaMetroTextBox.SelectedText = "";
            this.ProvinciaMetroTextBox.SelectionLength = 0;
            this.ProvinciaMetroTextBox.SelectionStart = 0;
            this.ProvinciaMetroTextBox.ShortcutsEnabled = true;
            this.ProvinciaMetroTextBox.Size = new System.Drawing.Size(291, 32);
            this.ProvinciaMetroTextBox.TabIndex = 7;
            this.ProvinciaMetroTextBox.UseSelectable = true;
            this.ProvinciaMetroTextBox.WaterMark = "Provincia";
            this.ProvinciaMetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ProvinciaMetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // CodPostalMetroTextBox
            // 
            // 
            // 
            // 
            this.CodPostalMetroTextBox.CustomButton.Image = null;
            this.CodPostalMetroTextBox.CustomButton.Location = new System.Drawing.Point(119, 2);
            this.CodPostalMetroTextBox.CustomButton.Name = "";
            this.CodPostalMetroTextBox.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.CodPostalMetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CodPostalMetroTextBox.CustomButton.TabIndex = 1;
            this.CodPostalMetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CodPostalMetroTextBox.CustomButton.UseSelectable = true;
            this.CodPostalMetroTextBox.CustomButton.Visible = false;
            this.CodPostalMetroTextBox.DisplayIcon = true;
            this.CodPostalMetroTextBox.Enabled = false;
            this.CodPostalMetroTextBox.Icon = global::MetroAppComercial2021.Windows.Properties.Resources.secured_letter_20px;
            this.CodPostalMetroTextBox.Lines = new string[0];
            this.CodPostalMetroTextBox.Location = new System.Drawing.Point(721, 77);
            this.CodPostalMetroTextBox.MaxLength = 10;
            this.CodPostalMetroTextBox.Multiline = true;
            this.CodPostalMetroTextBox.Name = "CodPostalMetroTextBox";
            this.CodPostalMetroTextBox.PasswordChar = '\0';
            this.CodPostalMetroTextBox.PromptText = "Cód. postal";
            this.CodPostalMetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CodPostalMetroTextBox.SelectedText = "";
            this.CodPostalMetroTextBox.SelectionLength = 0;
            this.CodPostalMetroTextBox.SelectionStart = 0;
            this.CodPostalMetroTextBox.ShortcutsEnabled = true;
            this.CodPostalMetroTextBox.Size = new System.Drawing.Size(149, 32);
            this.CodPostalMetroTextBox.TabIndex = 7;
            this.CodPostalMetroTextBox.UseSelectable = true;
            this.CodPostalMetroTextBox.WaterMark = "Cód. postal";
            this.CodPostalMetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CodPostalMetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ClienteMetroTextBox
            // 
            // 
            // 
            // 
            this.ClienteMetroTextBox.CustomButton.Image = null;
            this.ClienteMetroTextBox.CustomButton.Location = new System.Drawing.Point(458, 2);
            this.ClienteMetroTextBox.CustomButton.Name = "";
            this.ClienteMetroTextBox.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.ClienteMetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ClienteMetroTextBox.CustomButton.TabIndex = 1;
            this.ClienteMetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ClienteMetroTextBox.CustomButton.UseSelectable = true;
            this.ClienteMetroTextBox.CustomButton.Visible = false;
            this.ClienteMetroTextBox.DisplayIcon = true;
            this.ClienteMetroTextBox.Enabled = false;
            this.ClienteMetroTextBox.Icon = global::MetroAppComercial2021.Windows.Properties.Resources.marker_20px;
            this.ClienteMetroTextBox.Lines = new string[0];
            this.ClienteMetroTextBox.Location = new System.Drawing.Point(124, 31);
            this.ClienteMetroTextBox.MaxLength = 100;
            this.ClienteMetroTextBox.Multiline = true;
            this.ClienteMetroTextBox.Name = "ClienteMetroTextBox";
            this.ClienteMetroTextBox.PasswordChar = '\0';
            this.ClienteMetroTextBox.PromptText = "Dirección";
            this.ClienteMetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ClienteMetroTextBox.SelectedText = "";
            this.ClienteMetroTextBox.SelectionLength = 0;
            this.ClienteMetroTextBox.SelectionStart = 0;
            this.ClienteMetroTextBox.ShortcutsEnabled = true;
            this.ClienteMetroTextBox.Size = new System.Drawing.Size(488, 32);
            this.ClienteMetroTextBox.TabIndex = 5;
            this.ClienteMetroTextBox.UseSelectable = true;
            this.ClienteMetroTextBox.WaterMark = "Dirección";
            this.ClienteMetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ClienteMetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // DireccionMetroTextBox
            // 
            // 
            // 
            // 
            this.DireccionMetroTextBox.CustomButton.Image = null;
            this.DireccionMetroTextBox.CustomButton.Location = new System.Drawing.Point(458, 2);
            this.DireccionMetroTextBox.CustomButton.Name = "";
            this.DireccionMetroTextBox.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.DireccionMetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.DireccionMetroTextBox.CustomButton.TabIndex = 1;
            this.DireccionMetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.DireccionMetroTextBox.CustomButton.UseSelectable = true;
            this.DireccionMetroTextBox.CustomButton.Visible = false;
            this.DireccionMetroTextBox.DisplayIcon = true;
            this.DireccionMetroTextBox.Enabled = false;
            this.DireccionMetroTextBox.Icon = global::MetroAppComercial2021.Windows.Properties.Resources.marker_20px;
            this.DireccionMetroTextBox.Lines = new string[0];
            this.DireccionMetroTextBox.Location = new System.Drawing.Point(124, 77);
            this.DireccionMetroTextBox.MaxLength = 100;
            this.DireccionMetroTextBox.Multiline = true;
            this.DireccionMetroTextBox.Name = "DireccionMetroTextBox";
            this.DireccionMetroTextBox.PasswordChar = '\0';
            this.DireccionMetroTextBox.PromptText = "Dirección";
            this.DireccionMetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DireccionMetroTextBox.SelectedText = "";
            this.DireccionMetroTextBox.SelectionLength = 0;
            this.DireccionMetroTextBox.SelectionStart = 0;
            this.DireccionMetroTextBox.ShortcutsEnabled = true;
            this.DireccionMetroTextBox.Size = new System.Drawing.Size(488, 32);
            this.DireccionMetroTextBox.TabIndex = 5;
            this.DireccionMetroTextBox.UseSelectable = true;
            this.DireccionMetroTextBox.WaterMark = "Dirección";
            this.DireccionMetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DireccionMetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FechaMetroTextBox
            // 
            // 
            // 
            // 
            this.FechaMetroTextBox.CustomButton.Image = null;
            this.FechaMetroTextBox.CustomButton.Location = new System.Drawing.Point(77, 2);
            this.FechaMetroTextBox.CustomButton.Name = "";
            this.FechaMetroTextBox.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.FechaMetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.FechaMetroTextBox.CustomButton.TabIndex = 1;
            this.FechaMetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.FechaMetroTextBox.CustomButton.UseSelectable = true;
            this.FechaMetroTextBox.CustomButton.Visible = false;
            this.FechaMetroTextBox.DisplayIcon = true;
            this.FechaMetroTextBox.Enabled = false;
            this.FechaMetroTextBox.Icon = global::MetroAppComercial2021.Windows.Properties.Resources.secured_letter_20px;
            this.FechaMetroTextBox.Lines = new string[0];
            this.FechaMetroTextBox.Location = new System.Drawing.Point(973, 72);
            this.FechaMetroTextBox.MaxLength = 10;
            this.FechaMetroTextBox.Multiline = true;
            this.FechaMetroTextBox.Name = "FechaMetroTextBox";
            this.FechaMetroTextBox.PasswordChar = '\0';
            this.FechaMetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.FechaMetroTextBox.SelectedText = "";
            this.FechaMetroTextBox.SelectionLength = 0;
            this.FechaMetroTextBox.SelectionStart = 0;
            this.FechaMetroTextBox.ShortcutsEnabled = true;
            this.FechaMetroTextBox.Size = new System.Drawing.Size(107, 32);
            this.FechaMetroTextBox.TabIndex = 90;
            this.FechaMetroTextBox.UseSelectable = true;
            this.FechaMetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.FechaMetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FrmInfoVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 738);
            this.ControlBox = false;
            this.Controls.Add(this.CerrarIconButton);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.TotalAPagarMetroTextBox);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.RegaloMetroCheckBox);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.FechaMetroTextBox);
            this.Name = "FrmInfoVenta";
            this.Text = "Detalle de la Venta Nro:";
            this.Load += new System.EventHandler(this.FrmInfoVenta_Load);
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DatosMetroGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton CerrarIconButton;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroTextBox TotalAPagarMetroTextBox;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroGrid DatosMetroGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioTotal;
        private MetroFramework.Controls.MetroCheckBox RegaloMetroCheckBox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox LocalidadMetroTextBox;
        private MetroFramework.Controls.MetroTextBox ProvinciaMetroTextBox;
        private MetroFramework.Controls.MetroTextBox CodPostalMetroTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox ClienteMetroTextBox;
        private MetroFramework.Controls.MetroTextBox DireccionMetroTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox FechaMetroTextBox;
    }
}