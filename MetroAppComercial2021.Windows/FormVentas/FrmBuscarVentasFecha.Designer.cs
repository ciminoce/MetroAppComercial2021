
namespace MetroAppComercial2021.Windows.FormVentas
{
    partial class FrmBuscarVentasFecha
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
            this.components = new System.ComponentModel.Container();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.CancelarIconButton = new FontAwesome.Sharp.IconButton();
            this.OKIconButton = new FontAwesome.Sharp.IconButton();
            this.FechaMetroDateTime = new MetroFramework.Controls.MetroDateTime();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(48, 99);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(46, 19);
            this.metroLabel1.TabIndex = 16;
            this.metroLabel1.Text = "Fecha:";
            // 
            // CancelarIconButton
            // 
            this.CancelarIconButton.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.CancelarIconButton.IconColor = System.Drawing.Color.Red;
            this.CancelarIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CancelarIconButton.Location = new System.Drawing.Point(223, 161);
            this.CancelarIconButton.Name = "CancelarIconButton";
            this.CancelarIconButton.Size = new System.Drawing.Size(99, 60);
            this.CancelarIconButton.TabIndex = 15;
            this.CancelarIconButton.UseVisualStyleBackColor = true;
            this.CancelarIconButton.Click += new System.EventHandler(this.CancelarIconButton_Click);
            // 
            // OKIconButton
            // 
            this.OKIconButton.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.OKIconButton.IconColor = System.Drawing.Color.Blue;
            this.OKIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.OKIconButton.Location = new System.Drawing.Point(48, 161);
            this.OKIconButton.Name = "OKIconButton";
            this.OKIconButton.Size = new System.Drawing.Size(99, 60);
            this.OKIconButton.TabIndex = 14;
            this.OKIconButton.UseVisualStyleBackColor = true;
            this.OKIconButton.Click += new System.EventHandler(this.OKIconButton_Click);
            // 
            // FechaMetroDateTime
            // 
            this.FechaMetroDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaMetroDateTime.Location = new System.Drawing.Point(126, 99);
            this.FechaMetroDateTime.MinimumSize = new System.Drawing.Size(0, 29);
            this.FechaMetroDateTime.Name = "FechaMetroDateTime";
            this.FechaMetroDateTime.Size = new System.Drawing.Size(118, 29);
            this.FechaMetroDateTime.TabIndex = 17;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmBuscarVentasFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 258);
            this.ControlBox = false;
            this.Controls.Add(this.FechaMetroDateTime);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.CancelarIconButton);
            this.Controls.Add(this.OKIconButton);
            this.Name = "FrmBuscarVentasFecha";
            this.Text = "FrmBuscarVentasFecha";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton CancelarIconButton;
        private FontAwesome.Sharp.IconButton OKIconButton;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime FechaMetroDateTime;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}