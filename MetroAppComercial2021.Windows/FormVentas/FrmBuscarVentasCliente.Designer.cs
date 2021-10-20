
namespace MetroAppComercial2021.Windows.FormVentas
{
    partial class FrmBuscarVentasCliente
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.CancelarIconButton = new FontAwesome.Sharp.IconButton();
            this.OKIconButton = new FontAwesome.Sharp.IconButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.ClientesMetroComboBox = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // CancelarIconButton
            // 
            this.CancelarIconButton.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.CancelarIconButton.IconColor = System.Drawing.Color.Red;
            this.CancelarIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CancelarIconButton.Location = new System.Drawing.Point(368, 239);
            this.CancelarIconButton.Name = "CancelarIconButton";
            this.CancelarIconButton.Size = new System.Drawing.Size(99, 60);
            this.CancelarIconButton.TabIndex = 13;
            this.CancelarIconButton.UseVisualStyleBackColor = true;
            this.CancelarIconButton.Click += new System.EventHandler(this.CancelarIconButton_Click);
            // 
            // OKIconButton
            // 
            this.OKIconButton.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.OKIconButton.IconColor = System.Drawing.Color.Blue;
            this.OKIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.OKIconButton.Location = new System.Drawing.Point(69, 239);
            this.OKIconButton.Name = "OKIconButton";
            this.OKIconButton.Size = new System.Drawing.Size(99, 60);
            this.OKIconButton.TabIndex = 12;
            this.OKIconButton.UseVisualStyleBackColor = true;
            this.OKIconButton.Click += new System.EventHandler(this.OKIconButton_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(47, 108);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(52, 19);
            this.metroLabel1.TabIndex = 14;
            this.metroLabel1.Text = "Cliente:";
            // 
            // ClientesMetroComboBox
            // 
            this.ClientesMetroComboBox.FormattingEnabled = true;
            this.ClientesMetroComboBox.ItemHeight = 23;
            this.ClientesMetroComboBox.Location = new System.Drawing.Point(106, 105);
            this.ClientesMetroComboBox.Name = "ClientesMetroComboBox";
            this.ClientesMetroComboBox.Size = new System.Drawing.Size(361, 29);
            this.ClientesMetroComboBox.TabIndex = 15;
            this.ClientesMetroComboBox.UseSelectable = true;
            this.ClientesMetroComboBox.SelectedIndexChanged += new System.EventHandler(this.ClientesMetroComboBox_SelectedIndexChanged);
            // 
            // FrmBuscarVentasCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 337);
            this.ControlBox = false;
            this.Controls.Add(this.ClientesMetroComboBox);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.CancelarIconButton);
            this.Controls.Add(this.OKIconButton);
            this.Name = "FrmBuscarVentasCliente";
            this.Text = "FrmBuscarVentasCliente";
            this.Load += new System.EventHandler(this.FrmBuscarVentasCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MetroFramework.Controls.MetroComboBox ClientesMetroComboBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private FontAwesome.Sharp.IconButton CancelarIconButton;
        private FontAwesome.Sharp.IconButton OKIconButton;
    }
}