
namespace MetroAppComercial2021.Windows.FormCajas
{
    partial class FrmCajasEdit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SuspendidoMetroCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.DatosMetroTabPage = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.StockMetroTabPage = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.DetallesTabPage = new MetroFramework.Controls.MetroTabPage();
            this.DatosMetroGrid = new MetroFramework.Controls.MetroGrid();
            this.colBombon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.CancelarIconButton = new FontAwesome.Sharp.IconButton();
            this.OKIconButton = new FontAwesome.Sharp.IconButton();
            this.ImagenPictureBox = new System.Windows.Forms.PictureBox();
            this.SubirImagenIconButton = new FontAwesome.Sharp.IconButton();
            this.PVtaMetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.CostoMetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.ReposicionMetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.EnPedidoMetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.StockMetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.EditarIconButton = new FontAwesome.Sharp.IconButton();
            this.BorrarIconButton = new FontAwesome.Sharp.IconButton();
            this.AgregarIconButton = new FontAwesome.Sharp.IconButton();
            this.BombonMetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.DescripcionMetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroTabControl1.SuspendLayout();
            this.DatosMetroTabPage.SuspendLayout();
            this.StockMetroTabPage.SuspendLayout();
            this.DetallesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatosMetroGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SuspendidoMetroCheckBox
            // 
            this.SuspendidoMetroCheckBox.AutoSize = true;
            this.SuspendidoMetroCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SuspendidoMetroCheckBox.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.SuspendidoMetroCheckBox.Location = new System.Drawing.Point(22, 161);
            this.SuspendidoMetroCheckBox.Name = "SuspendidoMetroCheckBox";
            this.SuspendidoMetroCheckBox.Size = new System.Drawing.Size(96, 19);
            this.SuspendidoMetroCheckBox.TabIndex = 20;
            this.SuspendidoMetroCheckBox.Text = "Suspendido";
            this.SuspendidoMetroCheckBox.UseSelectable = true;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.DatosMetroTabPage);
            this.metroTabControl1.Controls.Add(this.StockMetroTabPage);
            this.metroTabControl1.Controls.Add(this.DetallesTabPage);
            this.metroTabControl1.Location = new System.Drawing.Point(92, 223);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(694, 325);
            this.metroTabControl1.TabIndex = 17;
            this.metroTabControl1.UseSelectable = true;
            // 
            // DatosMetroTabPage
            // 
            this.DatosMetroTabPage.Controls.Add(this.SuspendidoMetroCheckBox);
            this.DatosMetroTabPage.Controls.Add(this.ImagenPictureBox);
            this.DatosMetroTabPage.Controls.Add(this.SubirImagenIconButton);
            this.DatosMetroTabPage.Controls.Add(this.PVtaMetroTextBox);
            this.DatosMetroTabPage.Controls.Add(this.CostoMetroTextBox);
            this.DatosMetroTabPage.Controls.Add(this.metroLabel10);
            this.DatosMetroTabPage.Controls.Add(this.metroLabel4);
            this.DatosMetroTabPage.HorizontalScrollbarBarColor = true;
            this.DatosMetroTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.DatosMetroTabPage.HorizontalScrollbarSize = 10;
            this.DatosMetroTabPage.Location = new System.Drawing.Point(4, 38);
            this.DatosMetroTabPage.Name = "DatosMetroTabPage";
            this.DatosMetroTabPage.Size = new System.Drawing.Size(686, 283);
            this.DatosMetroTabPage.TabIndex = 0;
            this.DatosMetroTabPage.Text = "Datos";
            this.DatosMetroTabPage.VerticalScrollbarBarColor = true;
            this.DatosMetroTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.DatosMetroTabPage.VerticalScrollbarSize = 10;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(22, 66);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(72, 19);
            this.metroLabel10.TabIndex = 2;
            this.metroLabel10.Text = "Precio Vta:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(12, 32);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(87, 19);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "Precio Costo:";
            // 
            // StockMetroTabPage
            // 
            this.StockMetroTabPage.Controls.Add(this.metroLabel9);
            this.StockMetroTabPage.Controls.Add(this.metroLabel8);
            this.StockMetroTabPage.Controls.Add(this.metroLabel7);
            this.StockMetroTabPage.Controls.Add(this.ReposicionMetroTextBox);
            this.StockMetroTabPage.Controls.Add(this.EnPedidoMetroTextBox);
            this.StockMetroTabPage.Controls.Add(this.StockMetroTextBox);
            this.StockMetroTabPage.HorizontalScrollbarBarColor = true;
            this.StockMetroTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.StockMetroTabPage.HorizontalScrollbarSize = 10;
            this.StockMetroTabPage.Location = new System.Drawing.Point(4, 38);
            this.StockMetroTabPage.Name = "StockMetroTabPage";
            this.StockMetroTabPage.Size = new System.Drawing.Size(686, 283);
            this.StockMetroTabPage.TabIndex = 1;
            this.StockMetroTabPage.Text = "Stock";
            this.StockMetroTabPage.VerticalScrollbarBarColor = true;
            this.StockMetroTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.StockMetroTabPage.VerticalScrollbarSize = 10;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(22, 77);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(127, 19);
            this.metroLabel9.TabIndex = 2;
            this.metroLabel9.Text = "Nivel de Reposición:";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(17, 46);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(129, 19);
            this.metroLabel8.TabIndex = 2;
            this.metroLabel8.Text = "Unidades en Pedido:";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(3, 17);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(143, 19);
            this.metroLabel7.TabIndex = 2;
            this.metroLabel7.Text = "Unidades en Existencia:";
            // 
            // DetallesTabPage
            // 
            this.DetallesTabPage.Controls.Add(this.EditarIconButton);
            this.DetallesTabPage.Controls.Add(this.BorrarIconButton);
            this.DetallesTabPage.Controls.Add(this.AgregarIconButton);
            this.DetallesTabPage.Controls.Add(this.DatosMetroGrid);
            this.DetallesTabPage.HorizontalScrollbarBarColor = true;
            this.DetallesTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.DetallesTabPage.HorizontalScrollbarSize = 10;
            this.DetallesTabPage.Location = new System.Drawing.Point(4, 38);
            this.DetallesTabPage.Name = "DetallesTabPage";
            this.DetallesTabPage.Size = new System.Drawing.Size(686, 283);
            this.DetallesTabPage.TabIndex = 2;
            this.DetallesTabPage.Text = "Detalles";
            this.DetallesTabPage.VerticalScrollbarBarColor = true;
            this.DetallesTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.DetallesTabPage.VerticalScrollbarSize = 10;
            // 
            // DatosMetroGrid
            // 
            this.DatosMetroGrid.AllowUserToAddRows = false;
            this.DatosMetroGrid.AllowUserToDeleteRows = false;
            this.DatosMetroGrid.AllowUserToResizeColumns = false;
            this.DatosMetroGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DatosMetroGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DatosMetroGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DatosMetroGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DatosMetroGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DatosMetroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DatosMetroGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DatosMetroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosMetroGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBombon,
            this.colCantidad});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DatosMetroGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.DatosMetroGrid.EnableHeadersVisualStyles = false;
            this.DatosMetroGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DatosMetroGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DatosMetroGrid.Location = new System.Drawing.Point(8, 8);
            this.DatosMetroGrid.MultiSelect = false;
            this.DatosMetroGrid.Name = "DatosMetroGrid";
            this.DatosMetroGrid.ReadOnly = true;
            this.DatosMetroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DatosMetroGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DatosMetroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DatosMetroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DatosMetroGrid.Size = new System.Drawing.Size(584, 206);
            this.DatosMetroGrid.TabIndex = 4;
            // 
            // colBombon
            // 
            this.colBombon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colBombon.HeaderText = "Bombon";
            this.colBombon.Name = "colBombon";
            this.colBombon.ReadOnly = true;
            // 
            // colCantidad
            // 
            this.colCantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            this.colCantidad.Width = 95;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(92, 80);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(38, 19);
            this.metroLabel2.TabIndex = 14;
            this.metroLabel2.Text = "Caja:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(86, 113);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(79, 19);
            this.metroLabel1.TabIndex = 15;
            this.metroLabel1.Text = "Descripción:";
            // 
            // CancelarIconButton
            // 
            this.CancelarIconButton.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.CancelarIconButton.IconColor = System.Drawing.Color.Red;
            this.CancelarIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CancelarIconButton.Location = new System.Drawing.Point(559, 554);
            this.CancelarIconButton.Name = "CancelarIconButton";
            this.CancelarIconButton.Size = new System.Drawing.Size(99, 60);
            this.CancelarIconButton.TabIndex = 19;
            this.CancelarIconButton.UseVisualStyleBackColor = true;
            // 
            // OKIconButton
            // 
            this.OKIconButton.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.OKIconButton.IconColor = System.Drawing.Color.Blue;
            this.OKIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.OKIconButton.Location = new System.Drawing.Point(260, 554);
            this.OKIconButton.Name = "OKIconButton";
            this.OKIconButton.Size = new System.Drawing.Size(99, 60);
            this.OKIconButton.TabIndex = 18;
            this.OKIconButton.UseVisualStyleBackColor = true;
            // 
            // ImagenPictureBox
            // 
            this.ImagenPictureBox.Location = new System.Drawing.Point(505, 20);
            this.ImagenPictureBox.Name = "ImagenPictureBox";
            this.ImagenPictureBox.Size = new System.Drawing.Size(159, 143);
            this.ImagenPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagenPictureBox.TabIndex = 13;
            this.ImagenPictureBox.TabStop = false;
            // 
            // SubirImagenIconButton
            // 
            this.SubirImagenIconButton.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleUp;
            this.SubirImagenIconButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SubirImagenIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubirImagenIconButton.Location = new System.Drawing.Point(505, 171);
            this.SubirImagenIconButton.Name = "SubirImagenIconButton";
            this.SubirImagenIconButton.Size = new System.Drawing.Size(159, 54);
            this.SubirImagenIconButton.TabIndex = 10;
            this.SubirImagenIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SubirImagenIconButton.UseVisualStyleBackColor = true;
            // 
            // PVtaMetroTextBox
            // 
            // 
            // 
            // 
            this.PVtaMetroTextBox.CustomButton.Image = null;
            this.PVtaMetroTextBox.CustomButton.Location = new System.Drawing.Point(260, 1);
            this.PVtaMetroTextBox.CustomButton.Name = "";
            this.PVtaMetroTextBox.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.PVtaMetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PVtaMetroTextBox.CustomButton.TabIndex = 1;
            this.PVtaMetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PVtaMetroTextBox.CustomButton.UseSelectable = true;
            this.PVtaMetroTextBox.CustomButton.Visible = false;
            this.PVtaMetroTextBox.DisplayIcon = true;
            this.PVtaMetroTextBox.Icon = global::MetroAppComercial2021.Windows.Properties.Resources.low_price_20px;
            this.PVtaMetroTextBox.Lines = new string[0];
            this.PVtaMetroTextBox.Location = new System.Drawing.Point(100, 66);
            this.PVtaMetroTextBox.MaxLength = 5;
            this.PVtaMetroTextBox.Multiline = true;
            this.PVtaMetroTextBox.Name = "PVtaMetroTextBox";
            this.PVtaMetroTextBox.PasswordChar = '\0';
            this.PVtaMetroTextBox.PromptText = "Ingrese el precio vta";
            this.PVtaMetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PVtaMetroTextBox.SelectedText = "";
            this.PVtaMetroTextBox.SelectionLength = 0;
            this.PVtaMetroTextBox.SelectionStart = 0;
            this.PVtaMetroTextBox.ShortcutsEnabled = true;
            this.PVtaMetroTextBox.Size = new System.Drawing.Size(292, 33);
            this.PVtaMetroTextBox.TabIndex = 5;
            this.PVtaMetroTextBox.UseSelectable = true;
            this.PVtaMetroTextBox.WaterMark = "Ingrese el precio vta";
            this.PVtaMetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PVtaMetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // CostoMetroTextBox
            // 
            // 
            // 
            // 
            this.CostoMetroTextBox.CustomButton.Image = null;
            this.CostoMetroTextBox.CustomButton.Location = new System.Drawing.Point(260, 1);
            this.CostoMetroTextBox.CustomButton.Name = "";
            this.CostoMetroTextBox.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.CostoMetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CostoMetroTextBox.CustomButton.TabIndex = 1;
            this.CostoMetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CostoMetroTextBox.CustomButton.UseSelectable = true;
            this.CostoMetroTextBox.CustomButton.Visible = false;
            this.CostoMetroTextBox.DisplayIcon = true;
            this.CostoMetroTextBox.Icon = global::MetroAppComercial2021.Windows.Properties.Resources.low_price_pound_20px;
            this.CostoMetroTextBox.Lines = new string[0];
            this.CostoMetroTextBox.Location = new System.Drawing.Point(100, 27);
            this.CostoMetroTextBox.MaxLength = 5;
            this.CostoMetroTextBox.Multiline = true;
            this.CostoMetroTextBox.Name = "CostoMetroTextBox";
            this.CostoMetroTextBox.PasswordChar = '\0';
            this.CostoMetroTextBox.PromptText = "Ingrese el costo";
            this.CostoMetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CostoMetroTextBox.SelectedText = "";
            this.CostoMetroTextBox.SelectionLength = 0;
            this.CostoMetroTextBox.SelectionStart = 0;
            this.CostoMetroTextBox.ShortcutsEnabled = true;
            this.CostoMetroTextBox.Size = new System.Drawing.Size(292, 33);
            this.CostoMetroTextBox.TabIndex = 5;
            this.CostoMetroTextBox.UseSelectable = true;
            this.CostoMetroTextBox.WaterMark = "Ingrese el costo";
            this.CostoMetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CostoMetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ReposicionMetroTextBox
            // 
            // 
            // 
            // 
            this.ReposicionMetroTextBox.CustomButton.Image = null;
            this.ReposicionMetroTextBox.CustomButton.Location = new System.Drawing.Point(110, 1);
            this.ReposicionMetroTextBox.CustomButton.Name = "";
            this.ReposicionMetroTextBox.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.ReposicionMetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ReposicionMetroTextBox.CustomButton.TabIndex = 1;
            this.ReposicionMetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ReposicionMetroTextBox.CustomButton.UseSelectable = true;
            this.ReposicionMetroTextBox.CustomButton.Visible = false;
            this.ReposicionMetroTextBox.DisplayIcon = true;
            this.ReposicionMetroTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.ReposicionMetroTextBox.Icon = global::MetroAppComercial2021.Windows.Properties.Resources.level_up_20px;
            this.ReposicionMetroTextBox.Lines = new string[0];
            this.ReposicionMetroTextBox.Location = new System.Drawing.Point(152, 77);
            this.ReposicionMetroTextBox.MaxLength = 200;
            this.ReposicionMetroTextBox.Multiline = true;
            this.ReposicionMetroTextBox.Name = "ReposicionMetroTextBox";
            this.ReposicionMetroTextBox.PasswordChar = '\0';
            this.ReposicionMetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ReposicionMetroTextBox.SelectedText = "";
            this.ReposicionMetroTextBox.SelectionLength = 0;
            this.ReposicionMetroTextBox.SelectionStart = 0;
            this.ReposicionMetroTextBox.ShortcutsEnabled = true;
            this.ReposicionMetroTextBox.Size = new System.Drawing.Size(140, 31);
            this.ReposicionMetroTextBox.TabIndex = 3;
            this.ReposicionMetroTextBox.UseSelectable = true;
            this.ReposicionMetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ReposicionMetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // EnPedidoMetroTextBox
            // 
            // 
            // 
            // 
            this.EnPedidoMetroTextBox.CustomButton.Image = null;
            this.EnPedidoMetroTextBox.CustomButton.Location = new System.Drawing.Point(114, 1);
            this.EnPedidoMetroTextBox.CustomButton.Name = "";
            this.EnPedidoMetroTextBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.EnPedidoMetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.EnPedidoMetroTextBox.CustomButton.TabIndex = 1;
            this.EnPedidoMetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.EnPedidoMetroTextBox.CustomButton.UseSelectable = true;
            this.EnPedidoMetroTextBox.CustomButton.Visible = false;
            this.EnPedidoMetroTextBox.DisplayIcon = true;
            this.EnPedidoMetroTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.EnPedidoMetroTextBox.Icon = global::MetroAppComercial2021.Windows.Properties.Resources.sell_stock_20px;
            this.EnPedidoMetroTextBox.Lines = new string[0];
            this.EnPedidoMetroTextBox.Location = new System.Drawing.Point(152, 46);
            this.EnPedidoMetroTextBox.MaxLength = 20;
            this.EnPedidoMetroTextBox.Multiline = true;
            this.EnPedidoMetroTextBox.Name = "EnPedidoMetroTextBox";
            this.EnPedidoMetroTextBox.PasswordChar = '\0';
            this.EnPedidoMetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.EnPedidoMetroTextBox.SelectedText = "";
            this.EnPedidoMetroTextBox.SelectionLength = 0;
            this.EnPedidoMetroTextBox.SelectionStart = 0;
            this.EnPedidoMetroTextBox.ShortcutsEnabled = true;
            this.EnPedidoMetroTextBox.Size = new System.Drawing.Size(140, 27);
            this.EnPedidoMetroTextBox.TabIndex = 3;
            this.EnPedidoMetroTextBox.UseSelectable = true;
            this.EnPedidoMetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.EnPedidoMetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // StockMetroTextBox
            // 
            // 
            // 
            // 
            this.StockMetroTextBox.CustomButton.Image = null;
            this.StockMetroTextBox.CustomButton.Location = new System.Drawing.Point(114, 1);
            this.StockMetroTextBox.CustomButton.Name = "";
            this.StockMetroTextBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.StockMetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.StockMetroTextBox.CustomButton.TabIndex = 1;
            this.StockMetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.StockMetroTextBox.CustomButton.UseSelectable = true;
            this.StockMetroTextBox.CustomButton.Visible = false;
            this.StockMetroTextBox.DisplayIcon = true;
            this.StockMetroTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.StockMetroTextBox.Icon = global::MetroAppComercial2021.Windows.Properties.Resources.stock_20px;
            this.StockMetroTextBox.Lines = new string[0];
            this.StockMetroTextBox.Location = new System.Drawing.Point(152, 17);
            this.StockMetroTextBox.MaxLength = 20;
            this.StockMetroTextBox.Multiline = true;
            this.StockMetroTextBox.Name = "StockMetroTextBox";
            this.StockMetroTextBox.PasswordChar = '\0';
            this.StockMetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.StockMetroTextBox.SelectedText = "";
            this.StockMetroTextBox.SelectionLength = 0;
            this.StockMetroTextBox.SelectionStart = 0;
            this.StockMetroTextBox.ShortcutsEnabled = true;
            this.StockMetroTextBox.Size = new System.Drawing.Size(140, 27);
            this.StockMetroTextBox.TabIndex = 3;
            this.StockMetroTextBox.UseSelectable = true;
            this.StockMetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.StockMetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // EditarIconButton
            // 
            this.EditarIconButton.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.EditarIconButton.IconColor = System.Drawing.Color.Black;
            this.EditarIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EditarIconButton.Location = new System.Drawing.Point(611, 112);
            this.EditarIconButton.Name = "EditarIconButton";
            this.EditarIconButton.Size = new System.Drawing.Size(61, 46);
            this.EditarIconButton.TabIndex = 5;
            this.EditarIconButton.UseVisualStyleBackColor = true;
            // 
            // BorrarIconButton
            // 
            this.BorrarIconButton.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.BorrarIconButton.IconColor = System.Drawing.Color.Red;
            this.BorrarIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BorrarIconButton.Location = new System.Drawing.Point(611, 60);
            this.BorrarIconButton.Name = "BorrarIconButton";
            this.BorrarIconButton.Size = new System.Drawing.Size(61, 46);
            this.BorrarIconButton.TabIndex = 5;
            this.BorrarIconButton.UseVisualStyleBackColor = true;
            // 
            // AgregarIconButton
            // 
            this.AgregarIconButton.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.AgregarIconButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.AgregarIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AgregarIconButton.Location = new System.Drawing.Point(611, 8);
            this.AgregarIconButton.Name = "AgregarIconButton";
            this.AgregarIconButton.Size = new System.Drawing.Size(61, 46);
            this.AgregarIconButton.TabIndex = 5;
            this.AgregarIconButton.UseVisualStyleBackColor = true;
            // 
            // BombonMetroTextBox
            // 
            // 
            // 
            // 
            this.BombonMetroTextBox.CustomButton.Image = null;
            this.BombonMetroTextBox.CustomButton.Location = new System.Drawing.Point(469, 1);
            this.BombonMetroTextBox.CustomButton.Name = "";
            this.BombonMetroTextBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.BombonMetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.BombonMetroTextBox.CustomButton.TabIndex = 1;
            this.BombonMetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BombonMetroTextBox.CustomButton.UseSelectable = true;
            this.BombonMetroTextBox.CustomButton.Visible = false;
            this.BombonMetroTextBox.DisplayIcon = true;
            this.BombonMetroTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.BombonMetroTextBox.Icon = global::MetroAppComercial2021.Windows.Properties.Resources.edit_image_20px;
            this.BombonMetroTextBox.Lines = new string[0];
            this.BombonMetroTextBox.Location = new System.Drawing.Point(173, 80);
            this.BombonMetroTextBox.MaxLength = 50;
            this.BombonMetroTextBox.Multiline = true;
            this.BombonMetroTextBox.Name = "BombonMetroTextBox";
            this.BombonMetroTextBox.PasswordChar = '\0';
            this.BombonMetroTextBox.PromptText = "Ingrese el nombre de la caja";
            this.BombonMetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.BombonMetroTextBox.SelectedText = "";
            this.BombonMetroTextBox.SelectionLength = 0;
            this.BombonMetroTextBox.SelectionStart = 0;
            this.BombonMetroTextBox.ShortcutsEnabled = true;
            this.BombonMetroTextBox.Size = new System.Drawing.Size(495, 27);
            this.BombonMetroTextBox.TabIndex = 13;
            this.BombonMetroTextBox.UseSelectable = true;
            this.BombonMetroTextBox.WaterMark = "Ingrese el nombre de la caja";
            this.BombonMetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BombonMetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // DescripcionMetroTextBox
            // 
            // 
            // 
            // 
            this.DescripcionMetroTextBox.CustomButton.Image = null;
            this.DescripcionMetroTextBox.CustomButton.Location = new System.Drawing.Point(411, 1);
            this.DescripcionMetroTextBox.CustomButton.Name = "";
            this.DescripcionMetroTextBox.CustomButton.Size = new System.Drawing.Size(83, 83);
            this.DescripcionMetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.DescripcionMetroTextBox.CustomButton.TabIndex = 1;
            this.DescripcionMetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.DescripcionMetroTextBox.CustomButton.UseSelectable = true;
            this.DescripcionMetroTextBox.CustomButton.Visible = false;
            this.DescripcionMetroTextBox.DisplayIcon = true;
            this.DescripcionMetroTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.DescripcionMetroTextBox.Icon = global::MetroAppComercial2021.Windows.Properties.Resources.edit_image_20px;
            this.DescripcionMetroTextBox.Lines = new string[0];
            this.DescripcionMetroTextBox.Location = new System.Drawing.Point(173, 113);
            this.DescripcionMetroTextBox.MaxLength = 250;
            this.DescripcionMetroTextBox.Multiline = true;
            this.DescripcionMetroTextBox.Name = "DescripcionMetroTextBox";
            this.DescripcionMetroTextBox.PasswordChar = '\0';
            this.DescripcionMetroTextBox.PromptText = "Ingrese la descripción";
            this.DescripcionMetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DescripcionMetroTextBox.SelectedText = "";
            this.DescripcionMetroTextBox.SelectionLength = 0;
            this.DescripcionMetroTextBox.SelectionStart = 0;
            this.DescripcionMetroTextBox.ShortcutsEnabled = true;
            this.DescripcionMetroTextBox.Size = new System.Drawing.Size(495, 85);
            this.DescripcionMetroTextBox.TabIndex = 16;
            this.DescripcionMetroTextBox.UseSelectable = true;
            this.DescripcionMetroTextBox.WaterMark = "Ingrese la descripción";
            this.DescripcionMetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DescripcionMetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FrmCajasEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 653);
            this.ControlBox = false;
            this.Controls.Add(this.CancelarIconButton);
            this.Controls.Add(this.OKIconButton);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.BombonMetroTextBox);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.DescripcionMetroTextBox);
            this.Controls.Add(this.metroLabel1);
            this.Name = "FrmCajasEdit";
            this.Text = "FrmCajasEdit";
            this.metroTabControl1.ResumeLayout(false);
            this.DatosMetroTabPage.ResumeLayout(false);
            this.DatosMetroTabPage.PerformLayout();
            this.StockMetroTabPage.ResumeLayout(false);
            this.StockMetroTabPage.PerformLayout();
            this.DetallesTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DatosMetroGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroCheckBox SuspendidoMetroCheckBox;
        private FontAwesome.Sharp.IconButton CancelarIconButton;
        private FontAwesome.Sharp.IconButton OKIconButton;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage DatosMetroTabPage;
        private System.Windows.Forms.PictureBox ImagenPictureBox;
        private FontAwesome.Sharp.IconButton SubirImagenIconButton;
        private MetroFramework.Controls.MetroTextBox PVtaMetroTextBox;
        private MetroFramework.Controls.MetroTextBox CostoMetroTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTabPage StockMetroTabPage;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox ReposicionMetroTextBox;
        private MetroFramework.Controls.MetroTextBox EnPedidoMetroTextBox;
        private MetroFramework.Controls.MetroTextBox StockMetroTextBox;
        private MetroFramework.Controls.MetroTabPage DetallesTabPage;
        private MetroFramework.Controls.MetroTextBox BombonMetroTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox DescripcionMetroTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private FontAwesome.Sharp.IconButton EditarIconButton;
        private FontAwesome.Sharp.IconButton BorrarIconButton;
        private FontAwesome.Sharp.IconButton AgregarIconButton;
        private MetroFramework.Controls.MetroGrid DatosMetroGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBombon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
    }
}