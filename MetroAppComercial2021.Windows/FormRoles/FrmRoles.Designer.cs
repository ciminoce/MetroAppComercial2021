
namespace MetroAppComercial2021.Windows.FormRoles
{
    partial class FrmRoles
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelContenedorMetroPanel = new MetroFramework.Controls.MetroPanel();
            this.DatosMetroGrid = new MetroFramework.Controls.MetroGrid();
            this.colRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LineaInferiorMetroPanel = new MetroFramework.Controls.MetroPanel();
            this.LinesSuperiorMetroPanel = new MetroFramework.Controls.MetroPanel();
            this.DetalleIconButton = new FontAwesome.Sharp.IconButton();
            this.ImprimirIconButton = new FontAwesome.Sharp.IconButton();
            this.EditarIconButton = new FontAwesome.Sharp.IconButton();
            this.CerrarIconButton = new FontAwesome.Sharp.IconButton();
            this.BorrarIconButton = new FontAwesome.Sharp.IconButton();
            this.NuevoIconButton = new FontAwesome.Sharp.IconButton();
            this.PanelContenedorMetroPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatosMetroGrid)).BeginInit();
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
            this.PanelContenedorMetroPanel.Location = new System.Drawing.Point(18, 153);
            this.PanelContenedorMetroPanel.Name = "PanelContenedorMetroPanel";
            this.PanelContenedorMetroPanel.Size = new System.Drawing.Size(433, 479);
            this.PanelContenedorMetroPanel.TabIndex = 31;
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
            this.colRol});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DatosMetroGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.DatosMetroGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatosMetroGrid.EnableHeadersVisualStyles = false;
            this.DatosMetroGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DatosMetroGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DatosMetroGrid.Location = new System.Drawing.Point(0, 0);
            this.DatosMetroGrid.MultiSelect = false;
            this.DatosMetroGrid.Name = "DatosMetroGrid";
            this.DatosMetroGrid.ReadOnly = true;
            this.DatosMetroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DatosMetroGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DatosMetroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DatosMetroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DatosMetroGrid.Size = new System.Drawing.Size(433, 479);
            this.DatosMetroGrid.TabIndex = 2;
            // 
            // colRol
            // 
            this.colRol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colRol.DefaultCellStyle = dataGridViewCellStyle3;
            this.colRol.HeaderText = "Rol";
            this.colRol.Name = "colRol";
            this.colRol.ReadOnly = true;
            // 
            // LineaInferiorMetroPanel
            // 
            this.LineaInferiorMetroPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LineaInferiorMetroPanel.HorizontalScrollbarBarColor = true;
            this.LineaInferiorMetroPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.LineaInferiorMetroPanel.HorizontalScrollbarSize = 10;
            this.LineaInferiorMetroPanel.Location = new System.Drawing.Point(19, 133);
            this.LineaInferiorMetroPanel.Name = "LineaInferiorMetroPanel";
            this.LineaInferiorMetroPanel.Size = new System.Drawing.Size(432, 2);
            this.LineaInferiorMetroPanel.TabIndex = 25;
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
            this.LinesSuperiorMetroPanel.Location = new System.Drawing.Point(19, 70);
            this.LinesSuperiorMetroPanel.Name = "LinesSuperiorMetroPanel";
            this.LinesSuperiorMetroPanel.Size = new System.Drawing.Size(433, 2);
            this.LinesSuperiorMetroPanel.TabIndex = 24;
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
            this.DetalleIconButton.Location = new System.Drawing.Point(208, 77);
            this.DetalleIconButton.Name = "DetalleIconButton";
            this.DetalleIconButton.Size = new System.Drawing.Size(50, 50);
            this.DetalleIconButton.TabIndex = 64;
            this.DetalleIconButton.UseVisualStyleBackColor = true;
            // 
            // ImprimirIconButton
            // 
            this.ImprimirIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImprimirIconButton.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.ImprimirIconButton.IconColor = System.Drawing.Color.Blue;
            this.ImprimirIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ImprimirIconButton.Location = new System.Drawing.Point(288, 78);
            this.ImprimirIconButton.Name = "ImprimirIconButton";
            this.ImprimirIconButton.Size = new System.Drawing.Size(50, 50);
            this.ImprimirIconButton.TabIndex = 29;
            this.ImprimirIconButton.UseVisualStyleBackColor = true;
            // 
            // EditarIconButton
            // 
            this.EditarIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditarIconButton.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.EditarIconButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.EditarIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EditarIconButton.Location = new System.Drawing.Point(131, 78);
            this.EditarIconButton.Name = "EditarIconButton";
            this.EditarIconButton.Size = new System.Drawing.Size(50, 50);
            this.EditarIconButton.TabIndex = 30;
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
            this.CerrarIconButton.Location = new System.Drawing.Point(408, 19);
            this.CerrarIconButton.Name = "CerrarIconButton";
            this.CerrarIconButton.Size = new System.Drawing.Size(45, 34);
            this.CerrarIconButton.TabIndex = 28;
            this.CerrarIconButton.UseVisualStyleBackColor = true;
            this.CerrarIconButton.Click += new System.EventHandler(this.CerrarIconButton_Click);
            // 
            // BorrarIconButton
            // 
            this.BorrarIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BorrarIconButton.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.BorrarIconButton.IconColor = System.Drawing.Color.Red;
            this.BorrarIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BorrarIconButton.Location = new System.Drawing.Point(75, 78);
            this.BorrarIconButton.Name = "BorrarIconButton";
            this.BorrarIconButton.Size = new System.Drawing.Size(50, 50);
            this.BorrarIconButton.TabIndex = 27;
            this.BorrarIconButton.UseVisualStyleBackColor = true;
            // 
            // NuevoIconButton
            // 
            this.NuevoIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NuevoIconButton.IconChar = FontAwesome.Sharp.IconChar.File;
            this.NuevoIconButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.NuevoIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.NuevoIconButton.Location = new System.Drawing.Point(19, 78);
            this.NuevoIconButton.Name = "NuevoIconButton";
            this.NuevoIconButton.Size = new System.Drawing.Size(50, 50);
            this.NuevoIconButton.TabIndex = 26;
            this.NuevoIconButton.UseVisualStyleBackColor = true;
            // 
            // FrmRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 650);
            this.ControlBox = false;
            this.Controls.Add(this.DetalleIconButton);
            this.Controls.Add(this.PanelContenedorMetroPanel);
            this.Controls.Add(this.ImprimirIconButton);
            this.Controls.Add(this.EditarIconButton);
            this.Controls.Add(this.CerrarIconButton);
            this.Controls.Add(this.BorrarIconButton);
            this.Controls.Add(this.NuevoIconButton);
            this.Controls.Add(this.LineaInferiorMetroPanel);
            this.Controls.Add(this.LinesSuperiorMetroPanel);
            this.Name = "FrmRoles";
            this.Text = "FrmRoles";
            this.Load += new System.EventHandler(this.FrmRoles_Load);
            this.PanelContenedorMetroPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DatosMetroGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel PanelContenedorMetroPanel;
        private MetroFramework.Controls.MetroGrid DatosMetroGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRol;
        private FontAwesome.Sharp.IconButton ImprimirIconButton;
        private FontAwesome.Sharp.IconButton EditarIconButton;
        private FontAwesome.Sharp.IconButton CerrarIconButton;
        private FontAwesome.Sharp.IconButton BorrarIconButton;
        private FontAwesome.Sharp.IconButton NuevoIconButton;
        private MetroFramework.Controls.MetroPanel LineaInferiorMetroPanel;
        private MetroFramework.Controls.MetroPanel LinesSuperiorMetroPanel;
        private FontAwesome.Sharp.IconButton DetalleIconButton;
    }
}