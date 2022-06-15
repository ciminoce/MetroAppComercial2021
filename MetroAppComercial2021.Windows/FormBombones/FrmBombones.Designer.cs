
namespace MetroAppComercial2021.Windows.FormBombones
{
    partial class FrmBombones
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
            this.PanelContenedorMetroPanel = new MetroFramework.Controls.MetroPanel();
            this.DatosMetroGrid = new MetroFramework.Controls.MetroGrid();
            this.colBombon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioVta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSuspendido = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.LineaInferiorMetroPanel = new MetroFramework.Controls.MetroPanel();
            this.LinesSuperiorMetroPanel = new MetroFramework.Controls.MetroPanel();
            this.ImprimirIconButton = new FontAwesome.Sharp.IconButton();
            this.EditarIconButton = new FontAwesome.Sharp.IconButton();
            this.CerrarIconButton = new FontAwesome.Sharp.IconButton();
            this.BorrarIconButton = new FontAwesome.Sharp.IconButton();
            this.NuevoIconButton = new FontAwesome.Sharp.IconButton();
            this.PaginadorMetroPanel = new MetroFramework.Controls.MetroPanel();
            this.PaginasMetroLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.RegistrosMetroLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.BotonesMetroPanel = new MetroFramework.Controls.MetroPanel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.PanelContenedorMetroPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatosMetroGrid)).BeginInit();
            this.PaginadorMetroPanel.SuspendLayout();
            this.BotonesMetroPanel.SuspendLayout();
            this.SuspendLayout();
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
            this.PanelContenedorMetroPanel.Location = new System.Drawing.Point(21, 158);
            this.PanelContenedorMetroPanel.Name = "PanelContenedorMetroPanel";
            this.PanelContenedorMetroPanel.Size = new System.Drawing.Size(1114, 480);
            this.PanelContenedorMetroPanel.TabIndex = 55;
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
            this.colBombon,
            this.colStock,
            this.colPrecioVta,
            this.colSuspendido});
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
            // colBombon
            // 
            this.colBombon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colBombon.HeaderText = "Bombon";
            this.colBombon.Name = "colBombon";
            this.colBombon.ReadOnly = true;
            // 
            // colStock
            // 
            this.colStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colStock.HeaderText = "Stock";
            this.colStock.Name = "colStock";
            this.colStock.ReadOnly = true;
            this.colStock.Width = 70;
            // 
            // colPrecioVta
            // 
            this.colPrecioVta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colPrecioVta.HeaderText = "Precio Vta.";
            this.colPrecioVta.Name = "colPrecioVta";
            this.colPrecioVta.ReadOnly = true;
            this.colPrecioVta.Width = 97;
            // 
            // colSuspendido
            // 
            this.colSuspendido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colSuspendido.HeaderText = "Suspendido";
            this.colSuspendido.Name = "colSuspendido";
            this.colSuspendido.ReadOnly = true;
            this.colSuspendido.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSuspendido.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colSuspendido.Width = 115;
            // 
            // LineaInferiorMetroPanel
            // 
            this.LineaInferiorMetroPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LineaInferiorMetroPanel.HorizontalScrollbarBarColor = true;
            this.LineaInferiorMetroPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.LineaInferiorMetroPanel.HorizontalScrollbarSize = 10;
            this.LineaInferiorMetroPanel.Location = new System.Drawing.Point(22, 138);
            this.LineaInferiorMetroPanel.Name = "LineaInferiorMetroPanel";
            this.LineaInferiorMetroPanel.Size = new System.Drawing.Size(1111, 3);
            this.LineaInferiorMetroPanel.TabIndex = 49;
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
            this.LinesSuperiorMetroPanel.Location = new System.Drawing.Point(22, 67);
            this.LinesSuperiorMetroPanel.Name = "LinesSuperiorMetroPanel";
            this.LinesSuperiorMetroPanel.Size = new System.Drawing.Size(1111, 3);
            this.LinesSuperiorMetroPanel.TabIndex = 48;
            this.LinesSuperiorMetroPanel.VerticalScrollbarBarColor = true;
            this.LinesSuperiorMetroPanel.VerticalScrollbarHighlightOnWheel = false;
            this.LinesSuperiorMetroPanel.VerticalScrollbarSize = 10;
            // 
            // ImprimirIconButton
            // 
            this.ImprimirIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImprimirIconButton.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.ImprimirIconButton.IconColor = System.Drawing.Color.Blue;
            this.ImprimirIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ImprimirIconButton.Location = new System.Drawing.Point(218, 82);
            this.ImprimirIconButton.Name = "ImprimirIconButton";
            this.ImprimirIconButton.Size = new System.Drawing.Size(50, 50);
            this.ImprimirIconButton.TabIndex = 53;
            this.ImprimirIconButton.UseVisualStyleBackColor = true;
            this.ImprimirIconButton.Click += new System.EventHandler(this.ImprimirIconButton_Click);
            // 
            // EditarIconButton
            // 
            this.EditarIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditarIconButton.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.EditarIconButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.EditarIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EditarIconButton.Location = new System.Drawing.Point(134, 83);
            this.EditarIconButton.Name = "EditarIconButton";
            this.EditarIconButton.Size = new System.Drawing.Size(50, 50);
            this.EditarIconButton.TabIndex = 54;
            this.EditarIconButton.UseVisualStyleBackColor = true;
            this.EditarIconButton.Click += new System.EventHandler(this.EditarIconButton_Click);
            // 
            // CerrarIconButton
            // 
            this.CerrarIconButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CerrarIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CerrarIconButton.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.CerrarIconButton.IconColor = System.Drawing.Color.Red;
            this.CerrarIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CerrarIconButton.IconSize = 30;
            this.CerrarIconButton.Location = new System.Drawing.Point(1088, 27);
            this.CerrarIconButton.Name = "CerrarIconButton";
            this.CerrarIconButton.Size = new System.Drawing.Size(45, 34);
            this.CerrarIconButton.TabIndex = 52;
            this.CerrarIconButton.UseVisualStyleBackColor = true;
            this.CerrarIconButton.Click += new System.EventHandler(this.CerrarIconButton_Click);
            // 
            // BorrarIconButton
            // 
            this.BorrarIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BorrarIconButton.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.BorrarIconButton.IconColor = System.Drawing.Color.Red;
            this.BorrarIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BorrarIconButton.Location = new System.Drawing.Point(78, 83);
            this.BorrarIconButton.Name = "BorrarIconButton";
            this.BorrarIconButton.Size = new System.Drawing.Size(50, 50);
            this.BorrarIconButton.TabIndex = 51;
            this.BorrarIconButton.UseVisualStyleBackColor = true;
            this.BorrarIconButton.Click += new System.EventHandler(this.BorrarIconButton_Click);
            // 
            // NuevoIconButton
            // 
            this.NuevoIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NuevoIconButton.IconChar = FontAwesome.Sharp.IconChar.File;
            this.NuevoIconButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.NuevoIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.NuevoIconButton.Location = new System.Drawing.Point(22, 83);
            this.NuevoIconButton.Name = "NuevoIconButton";
            this.NuevoIconButton.Size = new System.Drawing.Size(50, 50);
            this.NuevoIconButton.TabIndex = 50;
            this.NuevoIconButton.UseVisualStyleBackColor = true;
            this.NuevoIconButton.Click += new System.EventHandler(this.NuevoIconButton_Click);
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
            this.PaginadorMetroPanel.TabIndex = 56;
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
            // BotonesMetroPanel
            // 
            this.BotonesMetroPanel.Controls.Add(this.metroButton1);
            this.BotonesMetroPanel.HorizontalScrollbarBarColor = true;
            this.BotonesMetroPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.BotonesMetroPanel.HorizontalScrollbarSize = 10;
            this.BotonesMetroPanel.Location = new System.Drawing.Point(199, 669);
            this.BotonesMetroPanel.Name = "BotonesMetroPanel";
            this.BotonesMetroPanel.Size = new System.Drawing.Size(926, 50);
            this.BotonesMetroPanel.TabIndex = 3;
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
            // FrmBombones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 742);
            this.ControlBox = false;
            this.Controls.Add(this.BotonesMetroPanel);
            this.Controls.Add(this.PaginadorMetroPanel);
            this.Controls.Add(this.PanelContenedorMetroPanel);
            this.Controls.Add(this.ImprimirIconButton);
            this.Controls.Add(this.EditarIconButton);
            this.Controls.Add(this.CerrarIconButton);
            this.Controls.Add(this.BorrarIconButton);
            this.Controls.Add(this.NuevoIconButton);
            this.Controls.Add(this.LineaInferiorMetroPanel);
            this.Controls.Add(this.LinesSuperiorMetroPanel);
            this.Name = "FrmBombones";
            this.Text = "Bombones";
            this.Load += new System.EventHandler(this.FrmBombones_Load);
            this.PanelContenedorMetroPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DatosMetroGrid)).EndInit();
            this.PaginadorMetroPanel.ResumeLayout(false);
            this.PaginadorMetroPanel.PerformLayout();
            this.BotonesMetroPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel PanelContenedorMetroPanel;
        private MetroFramework.Controls.MetroGrid DatosMetroGrid;
        private FontAwesome.Sharp.IconButton ImprimirIconButton;
        private FontAwesome.Sharp.IconButton EditarIconButton;
        private FontAwesome.Sharp.IconButton CerrarIconButton;
        private FontAwesome.Sharp.IconButton BorrarIconButton;
        private FontAwesome.Sharp.IconButton NuevoIconButton;
        private MetroFramework.Controls.MetroPanel LineaInferiorMetroPanel;
        private MetroFramework.Controls.MetroPanel LinesSuperiorMetroPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBombon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioVta;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSuspendido;
        private MetroFramework.Controls.MetroPanel PaginadorMetroPanel;
        private MetroFramework.Controls.MetroLabel PaginasMetroLabel;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel RegistrosMetroLabel;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel BotonesMetroPanel;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}