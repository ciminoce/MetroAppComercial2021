
namespace MetroAppComercial2021.Windows.FormCajas
{
    partial class FrmDetalleCajas
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
            this.CerrarIconButton = new FontAwesome.Sharp.IconButton();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.SuspendidoMetroCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.ReposicionMetroLabel = new MetroFramework.Controls.MetroLabel();
            this.EnPedidoMetroLabel = new MetroFramework.Controls.MetroLabel();
            this.PVentaMetroLabel = new MetroFramework.Controls.MetroLabel();
            this.CostoMetroLabel = new MetroFramework.Controls.MetroLabel();
            this.ExistenciaMetroLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.DatosMetroGrid = new MetroFramework.Controls.MetroGrid();
            this.colBombon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.ImagenPictureBox = new System.Windows.Forms.PictureBox();
            this.CajaMetroLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.DescripcionMetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel3.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatosMetroGrid)).BeginInit();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CerrarIconButton
            // 
            this.CerrarIconButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CerrarIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CerrarIconButton.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.CerrarIconButton.IconColor = System.Drawing.Color.Red;
            this.CerrarIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CerrarIconButton.IconSize = 30;
            this.CerrarIconButton.Location = new System.Drawing.Point(760, 20);
            this.CerrarIconButton.Name = "CerrarIconButton";
            this.CerrarIconButton.Size = new System.Drawing.Size(45, 34);
            this.CerrarIconButton.TabIndex = 67;
            this.CerrarIconButton.UseVisualStyleBackColor = true;
            this.CerrarIconButton.Click += new System.EventHandler(this.CerrarIconButton_Click);
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.SuspendidoMetroCheckBox);
            this.metroPanel3.Controls.Add(this.metroLabel10);
            this.metroPanel3.Controls.Add(this.metroLabel4);
            this.metroPanel3.Controls.Add(this.metroLabel9);
            this.metroPanel3.Controls.Add(this.metroLabel8);
            this.metroPanel3.Controls.Add(this.ReposicionMetroLabel);
            this.metroPanel3.Controls.Add(this.EnPedidoMetroLabel);
            this.metroPanel3.Controls.Add(this.PVentaMetroLabel);
            this.metroPanel3.Controls.Add(this.CostoMetroLabel);
            this.metroPanel3.Controls.Add(this.ExistenciaMetroLabel);
            this.metroPanel3.Controls.Add(this.metroLabel7);
            this.metroPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(20, 512);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(785, 157);
            this.metroPanel3.TabIndex = 66;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            this.metroPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel3_Paint);
            // 
            // SuspendidoMetroCheckBox
            // 
            this.SuspendidoMetroCheckBox.AutoSize = true;
            this.SuspendidoMetroCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SuspendidoMetroCheckBox.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.SuspendidoMetroCheckBox.Location = new System.Drawing.Point(359, 104);
            this.SuspendidoMetroCheckBox.Name = "SuspendidoMetroCheckBox";
            this.SuspendidoMetroCheckBox.Size = new System.Drawing.Size(96, 19);
            this.SuspendidoMetroCheckBox.TabIndex = 25;
            this.SuspendidoMetroCheckBox.Text = "Suspendido";
            this.SuspendidoMetroCheckBox.UseSelectable = true;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(362, 61);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(72, 19);
            this.metroLabel10.TabIndex = 21;
            this.metroLabel10.Text = "Precio Vta:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(359, 32);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(87, 19);
            this.metroLabel4.TabIndex = 22;
            this.metroLabel4.Text = "Precio Costo:";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(39, 92);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(127, 19);
            this.metroLabel9.TabIndex = 4;
            this.metroLabel9.Text = "Nivel de Reposición:";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(34, 61);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(129, 19);
            this.metroLabel8.TabIndex = 5;
            this.metroLabel8.Text = "Unidades en Pedido:";
            // 
            // ReposicionMetroLabel
            // 
            this.ReposicionMetroLabel.AutoSize = true;
            this.ReposicionMetroLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.ReposicionMetroLabel.Location = new System.Drawing.Point(166, 92);
            this.ReposicionMetroLabel.Name = "ReposicionMetroLabel";
            this.ReposicionMetroLabel.Size = new System.Drawing.Size(17, 19);
            this.ReposicionMetroLabel.TabIndex = 6;
            this.ReposicionMetroLabel.Text = "0";
            // 
            // EnPedidoMetroLabel
            // 
            this.EnPedidoMetroLabel.AutoSize = true;
            this.EnPedidoMetroLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.EnPedidoMetroLabel.Location = new System.Drawing.Point(166, 61);
            this.EnPedidoMetroLabel.Name = "EnPedidoMetroLabel";
            this.EnPedidoMetroLabel.Size = new System.Drawing.Size(17, 19);
            this.EnPedidoMetroLabel.TabIndex = 6;
            this.EnPedidoMetroLabel.Text = "0";
            // 
            // PVentaMetroLabel
            // 
            this.PVentaMetroLabel.AutoSize = true;
            this.PVentaMetroLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.PVentaMetroLabel.Location = new System.Drawing.Point(456, 61);
            this.PVentaMetroLabel.Name = "PVentaMetroLabel";
            this.PVentaMetroLabel.Size = new System.Drawing.Size(17, 19);
            this.PVentaMetroLabel.TabIndex = 6;
            this.PVentaMetroLabel.Text = "0";
            // 
            // CostoMetroLabel
            // 
            this.CostoMetroLabel.AutoSize = true;
            this.CostoMetroLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.CostoMetroLabel.Location = new System.Drawing.Point(456, 32);
            this.CostoMetroLabel.Name = "CostoMetroLabel";
            this.CostoMetroLabel.Size = new System.Drawing.Size(17, 19);
            this.CostoMetroLabel.TabIndex = 6;
            this.CostoMetroLabel.Text = "0";
            // 
            // ExistenciaMetroLabel
            // 
            this.ExistenciaMetroLabel.AutoSize = true;
            this.ExistenciaMetroLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.ExistenciaMetroLabel.Location = new System.Drawing.Point(168, 32);
            this.ExistenciaMetroLabel.Name = "ExistenciaMetroLabel";
            this.ExistenciaMetroLabel.Size = new System.Drawing.Size(17, 19);
            this.ExistenciaMetroLabel.TabIndex = 6;
            this.ExistenciaMetroLabel.Text = "0";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(20, 32);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(143, 19);
            this.metroLabel7.TabIndex = 6;
            this.metroLabel7.Text = "Unidades en Existencia:";
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.DatosMetroGrid);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(20, 206);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(785, 300);
            this.metroPanel2.TabIndex = 65;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            this.metroPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel2_Paint);
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
            this.DatosMetroGrid.Size = new System.Drawing.Size(785, 300);
            this.DatosMetroGrid.TabIndex = 5;
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
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metroPanel1.Controls.Add(this.ImagenPictureBox);
            this.metroPanel1.Controls.Add(this.CajaMetroLabel);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.DescripcionMetroTextBox);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel1.ForeColor = System.Drawing.Color.White;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(785, 140);
            this.metroPanel1.TabIndex = 64;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            this.metroPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint);
            // 
            // ImagenPictureBox
            // 
            this.ImagenPictureBox.Location = new System.Drawing.Point(629, 3);
            this.ImagenPictureBox.Name = "ImagenPictureBox";
            this.ImagenPictureBox.Size = new System.Drawing.Size(140, 128);
            this.ImagenPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagenPictureBox.TabIndex = 21;
            this.ImagenPictureBox.TabStop = false;
            // 
            // CajaMetroLabel
            // 
            this.CajaMetroLabel.AutoSize = true;
            this.CajaMetroLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.CajaMetroLabel.Location = new System.Drawing.Point(107, 9);
            this.CajaMetroLabel.Name = "CajaMetroLabel";
            this.CajaMetroLabel.Size = new System.Drawing.Size(38, 19);
            this.CajaMetroLabel.TabIndex = 18;
            this.CajaMetroLabel.Text = "Caja";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(26, 9);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(38, 19);
            this.metroLabel2.TabIndex = 18;
            this.metroLabel2.Text = "Caja:";
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
            this.DescripcionMetroTextBox.Enabled = false;
            this.DescripcionMetroTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.DescripcionMetroTextBox.Icon = global::MetroAppComercial2021.Windows.Properties.Resources.edit_image_20px;
            this.DescripcionMetroTextBox.Lines = new string[0];
            this.DescripcionMetroTextBox.Location = new System.Drawing.Point(107, 42);
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
            this.DescripcionMetroTextBox.TabIndex = 20;
            this.DescripcionMetroTextBox.UseSelectable = true;
            this.DescripcionMetroTextBox.WaterMark = "Ingrese la descripción";
            this.DescripcionMetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DescripcionMetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(20, 42);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(79, 19);
            this.metroLabel1.TabIndex = 19;
            this.metroLabel1.Text = "Descripción:";
            // 
            // FrmDetalleCajas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 689);
            this.ControlBox = false;
            this.Controls.Add(this.CerrarIconButton);
            this.Controls.Add(this.metroPanel3);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Name = "FrmDetalleCajas";
            this.Text = "Detalles de la caja:";
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DatosMetroGrid)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton CerrarIconButton;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroCheckBox SuspendidoMetroCheckBox;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel ReposicionMetroLabel;
        private MetroFramework.Controls.MetroLabel EnPedidoMetroLabel;
        private MetroFramework.Controls.MetroLabel PVentaMetroLabel;
        private MetroFramework.Controls.MetroLabel CostoMetroLabel;
        private MetroFramework.Controls.MetroLabel ExistenciaMetroLabel;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroGrid DatosMetroGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBombon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.PictureBox ImagenPictureBox;
        private MetroFramework.Controls.MetroLabel CajaMetroLabel;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox DescripcionMetroTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}