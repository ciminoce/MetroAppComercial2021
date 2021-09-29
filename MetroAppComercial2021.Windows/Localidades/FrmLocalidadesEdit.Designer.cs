
namespace MetroAppComercial2021.Windows.Localidades
{
    partial class FrmLocalidadesEdit
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
            this.LocalidadMetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.ProvinciasMetroComboBox = new MetroFramework.Controls.MetroComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(36, 65);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(68, 19);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "Localidad:";
            // 
            // CancelarIconButton
            // 
            this.CancelarIconButton.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.CancelarIconButton.IconColor = System.Drawing.Color.Red;
            this.CancelarIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CancelarIconButton.Location = new System.Drawing.Point(335, 178);
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
            this.OKIconButton.Location = new System.Drawing.Point(36, 178);
            this.OKIconButton.Name = "OKIconButton";
            this.OKIconButton.Size = new System.Drawing.Size(99, 60);
            this.OKIconButton.TabIndex = 14;
            this.OKIconButton.UseVisualStyleBackColor = true;
            this.OKIconButton.Click += new System.EventHandler(this.OKIconButton_Click);
            // 
            // LocalidadMetroTextBox
            // 
            // 
            // 
            // 
            this.LocalidadMetroTextBox.CustomButton.Image = null;
            this.LocalidadMetroTextBox.CustomButton.Location = new System.Drawing.Point(289, 1);
            this.LocalidadMetroTextBox.CustomButton.Name = "";
            this.LocalidadMetroTextBox.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.LocalidadMetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.LocalidadMetroTextBox.CustomButton.TabIndex = 1;
            this.LocalidadMetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.LocalidadMetroTextBox.CustomButton.UseSelectable = true;
            this.LocalidadMetroTextBox.CustomButton.Visible = false;
            this.LocalidadMetroTextBox.DisplayIcon = true;
            this.LocalidadMetroTextBox.Icon = global::MetroAppComercial2021.Windows.Properties.Resources.edit_image_20px;
            this.LocalidadMetroTextBox.Lines = new string[0];
            this.LocalidadMetroTextBox.Location = new System.Drawing.Point(121, 65);
            this.LocalidadMetroTextBox.MaxLength = 50;
            this.LocalidadMetroTextBox.Name = "LocalidadMetroTextBox";
            this.LocalidadMetroTextBox.PasswordChar = '\0';
            this.LocalidadMetroTextBox.PromptText = "Ingrese la localidad";
            this.LocalidadMetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.LocalidadMetroTextBox.SelectedText = "";
            this.LocalidadMetroTextBox.SelectionLength = 0;
            this.LocalidadMetroTextBox.SelectionStart = 0;
            this.LocalidadMetroTextBox.ShortcutsEnabled = true;
            this.LocalidadMetroTextBox.Size = new System.Drawing.Size(313, 25);
            this.LocalidadMetroTextBox.TabIndex = 12;
            this.LocalidadMetroTextBox.UseSelectable = true;
            this.LocalidadMetroTextBox.WaterMark = "Ingrese la localidad";
            this.LocalidadMetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.LocalidadMetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(36, 116);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(65, 19);
            this.metroLabel2.TabIndex = 11;
            this.metroLabel2.Text = "Provincia:";
            // 
            // ProvinciasMetroComboBox
            // 
            this.ProvinciasMetroComboBox.FormattingEnabled = true;
            this.ProvinciasMetroComboBox.ItemHeight = 23;
            this.ProvinciasMetroComboBox.Location = new System.Drawing.Point(121, 113);
            this.ProvinciasMetroComboBox.Name = "ProvinciasMetroComboBox";
            this.ProvinciasMetroComboBox.Size = new System.Drawing.Size(313, 29);
            this.ProvinciasMetroComboBox.TabIndex = 15;
            this.ProvinciasMetroComboBox.UseSelectable = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmLocalidadesEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 261);
            this.Controls.Add(this.ProvinciasMetroComboBox);
            this.Controls.Add(this.CancelarIconButton);
            this.Controls.Add(this.OKIconButton);
            this.Controls.Add(this.LocalidadMetroTextBox);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "FrmLocalidadesEdit";
            this.Text = "FrmLocalidadesEdit";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton CancelarIconButton;
        private FontAwesome.Sharp.IconButton OKIconButton;
        private MetroFramework.Controls.MetroTextBox LocalidadMetroTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox ProvinciasMetroComboBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}