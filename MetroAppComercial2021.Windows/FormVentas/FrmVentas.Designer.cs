
namespace MetroAppComercial2021.Windows.FormVentas
{
    partial class FrmVentas
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
            this.BotonesMetroPanel = new MetroFramework.Controls.MetroPanel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.PaginadorMetroPanel = new MetroFramework.Controls.MetroPanel();
            this.PaginasMetroLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.RegistrosMetroLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.PanelContenedorMetroPanel = new MetroFramework.Controls.MetroPanel();
            this.DatosMetroGrid = new MetroFramework.Controls.MetroGrid();
            this.colVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRegalo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LineaInferiorMetroPanel = new MetroFramework.Controls.MetroPanel();
            this.LinesSuperiorMetroPanel = new MetroFramework.Controls.MetroPanel();
            this.DetalleIconButton = new FontAwesome.Sharp.IconButton();
            this.ActualizarIconButton = new FontAwesome.Sharp.IconButton();
            this.ConsultaPorFechaIconButton = new FontAwesome.Sharp.IconButton();
            this.ConsultaPorClienteIconButton = new FontAwesome.Sharp.IconButton();
            this.ImprimirIconButton = new FontAwesome.Sharp.IconButton();
            this.EditarIconButton = new FontAwesome.Sharp.IconButton();
            this.CerrarIconButton = new FontAwesome.Sharp.IconButton();
            this.BorrarIconButton = new FontAwesome.Sharp.IconButton();
            this.NuevoIconButton = new FontAwesome.Sharp.IconButton();
            this.BotonesMetroPanel.SuspendLayout();
            this.PaginadorMetroPanel.SuspendLayout();
            this.PanelContenedorMetroPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatosMetroGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // BotonesMetroPanel
            // 
            this.BotonesMetroPanel.Controls.Add(this.metroButton1);
            this.BotonesMetroPanel.HorizontalScrollbarBarColor = true;
            this.BotonesMetroPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.BotonesMetroPanel.HorizontalScrollbarSize = 10;
            this.BotonesMetroPanel.Location = new System.Drawing.Point(199, 670);
            this.BotonesMetroPanel.Name = "BotonesMetroPanel";
            this.BotonesMetroPanel.Size = new System.Drawing.Size(926, 50);
            this.BotonesMetroPanel.TabIndex = 67;
            this.BotonesMetroPanel.VerticalScrollbarBarColor = true;
            this.BotonesMetroPanel.VerticalScrollbarHighlightOnWheel = false;
            this.BotonesMetroPanel.VerticalScrollbarSize = 10;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(19, 8);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(30, 30);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "metroButton1";
            this.metroButton1.UseSelectable = true;
            // 
            // PaginadorMetroPanel
            // 
            this.PaginadorMetroPanel.Controls.Add(this.PaginasMetroLabel);
            this.PaginadorMetroPanel.Controls.Add(this.metroLabel2);
            this.PaginadorMetroPanel.Controls.Add(this.RegistrosMetroLabel);
            this.PaginadorMetroPanel.Controls.Add(this.metroLabel1);
            this.PaginadorMetroPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PaginadorMetroPanel.HorizontalScrollbarBarColor = true;
            this.PaginadorMetroPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.PaginadorMetroPanel.HorizontalScrollbarSize = 10;
            this.PaginadorMetroPanel.Location = new System.Drawing.Point(20, 666);
            this.PaginadorMetroPanel.Name = "PaginadorMetroPanel";
            this.PaginadorMetroPanel.Size = new System.Drawing.Size(1117, 56);
            this.PaginadorMetroPanel.TabIndex = 77;
            this.PaginadorMetroPanel.VerticalScrollbarBarColor = true;
            this.PaginadorMetroPanel.VerticalScrollbarHighlightOnWheel = false;
            this.PaginadorMetroPanel.VerticalScrollbarSize = 10;
            // 
            // PaginasMetroLabel
            // 
            this.PaginasMetroLabel.AutoSize = true;
            this.PaginasMetroLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.PaginasMetroLabel.Location = new System.Drawing.Point(87, 30);
            this.PaginasMetroLabel.Name = "PaginasMetroLabel";
            this.PaginasMetroLabel.Size = new System.Drawing.Size(17, 19);
            this.PaginasMetroLabel.TabIndex = 2;
            this.PaginasMetroLabel.Text = "0";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(16, 30);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(56, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Páginas:";
            // 
            // RegistrosMetroLabel
            // 
            this.RegistrosMetroLabel.AutoSize = true;
            this.RegistrosMetroLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.RegistrosMetroLabel.Location = new System.Drawing.Point(87, 11);
            this.RegistrosMetroLabel.Name = "RegistrosMetroLabel";
            this.RegistrosMetroLabel.Size = new System.Drawing.Size(17, 19);
            this.RegistrosMetroLabel.TabIndex = 2;
            this.RegistrosMetroLabel.Text = "0";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(16, 11);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(65, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Registros:";
            // 
            // PanelContenedorMetroPanel
            // 
            this.PanelContenedorMetroPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelContenedorMetroPanel.Controls.Add(this.DatosMetroGrid);
            this.PanelContenedorMetroPanel.HorizontalScrollbarBarColor = true;
            this.PanelContenedorMetroPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelContenedorMetroPanel.HorizontalScrollbarSize = 10;
            this.PanelContenedorMetroPanel.Location = new System.Drawing.Point(21, 153);
            this.PanelContenedorMetroPanel.Name = "PanelContenedorMetroPanel";
            this.PanelContenedorMetroPanel.Size = new System.Drawing.Size(1114, 480);
            this.PanelContenedorMetroPanel.TabIndex = 76;
            this.PanelContenedorMetroPanel.VerticalScrollbarBarColor = true;
            this.PanelContenedorMetroPanel.VerticalScrollbarHighlightOnWheel = false;
            this.PanelContenedorMetroPanel.VerticalScrollbarSize = 10;
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
            this.colVenta,
            this.colCliente,
            this.colFecha,
            this.colRegalo,
            this.colTotal});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DatosMetroGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.DatosMetroGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatosMetroGrid.EnableHeadersVisualStyles = false;
            this.DatosMetroGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DatosMetroGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DatosMetroGrid.Location = new System.Drawing.Point(0, 0);
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
            this.DatosMetroGrid.Size = new System.Drawing.Size(1114, 480);
            this.DatosMetroGrid.TabIndex = 3;
            // 
            // colVenta
            // 
            this.colVenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colVenta.HeaderText = "Venta Nro.";
            this.colVenta.Name = "colVenta";
            this.colVenta.ReadOnly = true;
            this.colVenta.Width = 106;
            // 
            // colCliente
            // 
            this.colCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCliente.HeaderText = "Cliente";
            this.colCliente.Name = "colCliente";
            this.colCliente.ReadOnly = true;
            // 
            // colFecha
            // 
            this.colFecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colFecha.HeaderText = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.ReadOnly = true;
            this.colFecha.Width = 73;
            // 
            // colRegalo
            // 
            this.colRegalo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colRegalo.HeaderText = "Regalo";
            this.colRegalo.Name = "colRegalo";
            this.colRegalo.ReadOnly = true;
            this.colRegalo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colRegalo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colRegalo.Width = 81;
            // 
            // colTotal
            // 
            this.colTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colTotal.HeaderText = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            this.colTotal.Width = 65;
            // 
            // LineaInferiorMetroPanel
            // 
            this.LineaInferiorMetroPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LineaInferiorMetroPanel.HorizontalScrollbarBarColor = true;
            this.LineaInferiorMetroPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.LineaInferiorMetroPanel.HorizontalScrollbarSize = 10;
            this.LineaInferiorMetroPanel.Location = new System.Drawing.Point(22, 133);
            this.LineaInferiorMetroPanel.Name = "LineaInferiorMetroPanel";
            this.LineaInferiorMetroPanel.Size = new System.Drawing.Size(1111, 3);
            this.LineaInferiorMetroPanel.TabIndex = 69;
            this.LineaInferiorMetroPanel.VerticalScrollbarBarColor = true;
            this.LineaInferiorMetroPanel.VerticalScrollbarHighlightOnWheel = false;
            this.LineaInferiorMetroPanel.VerticalScrollbarSize = 10;
            // 
            // LinesSuperiorMetroPanel
            // 
            this.LinesSuperiorMetroPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LinesSuperiorMetroPanel.HorizontalScrollbarBarColor = true;
            this.LinesSuperiorMetroPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.LinesSuperiorMetroPanel.HorizontalScrollbarSize = 10;
            this.LinesSuperiorMetroPanel.Location = new System.Drawing.Point(22, 62);
            this.LinesSuperiorMetroPanel.Name = "LinesSuperiorMetroPanel";
            this.LinesSuperiorMetroPanel.Size = new System.Drawing.Size(1111, 3);
            this.LinesSuperiorMetroPanel.TabIndex = 68;
            this.LinesSuperiorMetroPanel.VerticalScrollbarBarColor = true;
            this.LinesSuperiorMetroPanel.VerticalScrollbarHighlightOnWheel = false;
            this.LinesSuperiorMetroPanel.VerticalScrollbarSize = 10;
            // 
            // DetalleIconButton
            // 
            this.DetalleIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DetalleIconButton.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.DetalleIconButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.DetalleIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DetalleIconButton.Location = new System.Drawing.Point(218, 77);
            this.DetalleIconButton.Name = "DetalleIconButton";
            this.DetalleIconButton.Size = new System.Drawing.Size(50, 50);
            this.DetalleIconButton.TabIndex = 73;
            this.DetalleIconButton.UseVisualStyleBackColor = true;
            this.DetalleIconButton.Click += new System.EventHandler(this.DetalleIconButton_Click);
            // 
            // ActualizarIconButton
            // 
            this.ActualizarIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ActualizarIconButton.IconChar = FontAwesome.Sharp.IconChar.Sync;
            this.ActualizarIconButton.IconColor = System.Drawing.Color.SlateGray;
            this.ActualizarIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ActualizarIconButton.Location = new System.Drawing.Point(415, 77);
            this.ActualizarIconButton.Name = "ActualizarIconButton";
            this.ActualizarIconButton.Size = new System.Drawing.Size(50, 50);
            this.ActualizarIconButton.TabIndex = 74;
            this.ActualizarIconButton.UseVisualStyleBackColor = true;
            this.ActualizarIconButton.Click += new System.EventHandler(this.ActualizarIconButton_Click);
            // 
            // ConsultaPorFechaIconButton
            // 
            this.ConsultaPorFechaIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsultaPorFechaIconButton.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.ConsultaPorFechaIconButton.IconColor = System.Drawing.Color.SlateGray;
            this.ConsultaPorFechaIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ConsultaPorFechaIconButton.Location = new System.Drawing.Point(359, 77);
            this.ConsultaPorFechaIconButton.Name = "ConsultaPorFechaIconButton";
            this.ConsultaPorFechaIconButton.Size = new System.Drawing.Size(50, 50);
            this.ConsultaPorFechaIconButton.TabIndex = 74;
            this.ConsultaPorFechaIconButton.UseVisualStyleBackColor = true;
            this.ConsultaPorFechaIconButton.Click += new System.EventHandler(this.ConsultaPorFechaIconButton_Click);
            // 
            // ConsultaPorClienteIconButton
            // 
            this.ConsultaPorClienteIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsultaPorClienteIconButton.IconChar = FontAwesome.Sharp.IconChar.User;
            this.ConsultaPorClienteIconButton.IconColor = System.Drawing.Color.SlateGray;
            this.ConsultaPorClienteIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ConsultaPorClienteIconButton.Location = new System.Drawing.Point(303, 77);
            this.ConsultaPorClienteIconButton.Name = "ConsultaPorClienteIconButton";
            this.ConsultaPorClienteIconButton.Size = new System.Drawing.Size(50, 50);
            this.ConsultaPorClienteIconButton.TabIndex = 74;
            this.ConsultaPorClienteIconButton.UseVisualStyleBackColor = true;
            this.ConsultaPorClienteIconButton.Click += new System.EventHandler(this.ConsultaPorClienteIconButton_Click);
            // 
            // ImprimirIconButton
            // 
            this.ImprimirIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImprimirIconButton.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.ImprimirIconButton.IconColor = System.Drawing.Color.Blue;
            this.ImprimirIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ImprimirIconButton.Location = new System.Drawing.Point(583, 77);
            this.ImprimirIconButton.Name = "ImprimirIconButton";
            this.ImprimirIconButton.Size = new System.Drawing.Size(50, 50);
            this.ImprimirIconButton.TabIndex = 74;
            this.ImprimirIconButton.UseVisualStyleBackColor = true;
            // 
            // EditarIconButton
            // 
            this.EditarIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditarIconButton.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.EditarIconButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.EditarIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EditarIconButton.Location = new System.Drawing.Point(134, 78);
            this.EditarIconButton.Name = "EditarIconButton";
            this.EditarIconButton.Size = new System.Drawing.Size(50, 50);
            this.EditarIconButton.TabIndex = 75;
            this.EditarIconButton.UseVisualStyleBackColor = true;
            // 
            // CerrarIconButton
            // 
            this.CerrarIconButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CerrarIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CerrarIconButton.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.CerrarIconButton.IconColor = System.Drawing.Color.Red;
            this.CerrarIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CerrarIconButton.IconSize = 30;
            this.CerrarIconButton.Location = new System.Drawing.Point(1088, 22);
            this.CerrarIconButton.Name = "CerrarIconButton";
            this.CerrarIconButton.Size = new System.Drawing.Size(45, 34);
            this.CerrarIconButton.TabIndex = 72;
            this.CerrarIconButton.UseVisualStyleBackColor = true;
            this.CerrarIconButton.Click += new System.EventHandler(this.CerrarIconButton_Click);
            // 
            // BorrarIconButton
            // 
            this.BorrarIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BorrarIconButton.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.BorrarIconButton.IconColor = System.Drawing.Color.Red;
            this.BorrarIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BorrarIconButton.Location = new System.Drawing.Point(78, 78);
            this.BorrarIconButton.Name = "BorrarIconButton";
            this.BorrarIconButton.Size = new System.Drawing.Size(50, 50);
            this.BorrarIconButton.TabIndex = 71;
            this.BorrarIconButton.UseVisualStyleBackColor = true;
            // 
            // NuevoIconButton
            // 
            this.NuevoIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NuevoIconButton.IconChar = FontAwesome.Sharp.IconChar.File;
            this.NuevoIconButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.NuevoIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.NuevoIconButton.Location = new System.Drawing.Point(22, 78);
            this.NuevoIconButton.Name = "NuevoIconButton";
            this.NuevoIconButton.Size = new System.Drawing.Size(50, 50);
            this.NuevoIconButton.TabIndex = 70;
            this.NuevoIconButton.UseVisualStyleBackColor = true;
            this.NuevoIconButton.Click += new System.EventHandler(this.NuevoIconButton_Click_1);
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 742);
            this.ControlBox = false;
            this.Controls.Add(this.BotonesMetroPanel);
            this.Controls.Add(this.PaginadorMetroPanel);
            this.Controls.Add(this.PanelContenedorMetroPanel);
            this.Controls.Add(this.DetalleIconButton);
            this.Controls.Add(this.ActualizarIconButton);
            this.Controls.Add(this.ConsultaPorFechaIconButton);
            this.Controls.Add(this.ConsultaPorClienteIconButton);
            this.Controls.Add(this.ImprimirIconButton);
            this.Controls.Add(this.EditarIconButton);
            this.Controls.Add(this.CerrarIconButton);
            this.Controls.Add(this.BorrarIconButton);
            this.Controls.Add(this.NuevoIconButton);
            this.Controls.Add(this.LineaInferiorMetroPanel);
            this.Controls.Add(this.LinesSuperiorMetroPanel);
            this.Name = "FrmVentas";
            this.Text = "FrmVentas";
            this.Load += new System.EventHandler(this.FrmVentas_Load);
            this.BotonesMetroPanel.ResumeLayout(false);
            this.PaginadorMetroPanel.ResumeLayout(false);
            this.PaginadorMetroPanel.PerformLayout();
            this.PanelContenedorMetroPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DatosMetroGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel BotonesMetroPanel;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroPanel PaginadorMetroPanel;
        private MetroFramework.Controls.MetroLabel PaginasMetroLabel;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel RegistrosMetroLabel;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel PanelContenedorMetroPanel;
        private MetroFramework.Controls.MetroGrid DatosMetroGrid;
        private FontAwesome.Sharp.IconButton DetalleIconButton;
        private FontAwesome.Sharp.IconButton ImprimirIconButton;
        private FontAwesome.Sharp.IconButton EditarIconButton;
        private FontAwesome.Sharp.IconButton CerrarIconButton;
        private FontAwesome.Sharp.IconButton BorrarIconButton;
        private FontAwesome.Sharp.IconButton NuevoIconButton;
        private MetroFramework.Controls.MetroPanel LineaInferiorMetroPanel;
        private MetroFramework.Controls.MetroPanel LinesSuperiorMetroPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colRegalo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private FontAwesome.Sharp.IconButton ConsultaPorClienteIconButton;
        private FontAwesome.Sharp.IconButton ConsultaPorFechaIconButton;
        private FontAwesome.Sharp.IconButton ActualizarIconButton;
    }
}