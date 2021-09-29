
namespace MetroAppComercial2021.Windows.FormProvincias
{
    partial class FrmProvinciasEdit
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
            this.CancelarIconButton = new FontAwesome.Sharp.IconButton();
            this.OKIconButton = new FontAwesome.Sharp.IconButton();
            this.ProvinciaMetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelarIconButton
            // 
            this.CancelarIconButton.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.CancelarIconButton.IconColor = System.Drawing.Color.Red;
            this.CancelarIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CancelarIconButton.Location = new System.Drawing.Point(332, 141);
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
            this.OKIconButton.Location = new System.Drawing.Point(33, 141);
            this.OKIconButton.Name = "OKIconButton";
            this.OKIconButton.Size = new System.Drawing.Size(99, 60);
            this.OKIconButton.TabIndex = 14;
            this.OKIconButton.UseVisualStyleBackColor = true;
            this.OKIconButton.Click += new System.EventHandler(this.OKIconButton_Click);
            // 
            // ProvinciaMetroTextBox
            // 
            // 
            // 
            // 
            this.ProvinciaMetroTextBox.CustomButton.Image = null;
            this.ProvinciaMetroTextBox.CustomButton.Location = new System.Drawing.Point(289, 1);
            this.ProvinciaMetroTextBox.CustomButton.Name = "";
            this.ProvinciaMetroTextBox.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.ProvinciaMetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ProvinciaMetroTextBox.CustomButton.TabIndex = 1;
            this.ProvinciaMetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ProvinciaMetroTextBox.CustomButton.UseSelectable = true;
            this.ProvinciaMetroTextBox.CustomButton.Visible = false;
            this.ProvinciaMetroTextBox.DisplayIcon = true;
            this.ProvinciaMetroTextBox.Icon = global::MetroAppComercial2021.Windows.Properties.Resources.edit_image_20px;
            this.ProvinciaMetroTextBox.Lines = new string[0];
            this.ProvinciaMetroTextBox.Location = new System.Drawing.Point(118, 71);
            this.ProvinciaMetroTextBox.MaxLength = 50;
            this.ProvinciaMetroTextBox.Name = "ProvinciaMetroTextBox";
            this.ProvinciaMetroTextBox.PasswordChar = '\0';
            this.ProvinciaMetroTextBox.PromptText = "Ingrese el nombre";
            this.ProvinciaMetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ProvinciaMetroTextBox.SelectedText = "";
            this.ProvinciaMetroTextBox.SelectionLength = 0;
            this.ProvinciaMetroTextBox.SelectionStart = 0;
            this.ProvinciaMetroTextBox.ShortcutsEnabled = true;
            this.ProvinciaMetroTextBox.Size = new System.Drawing.Size(313, 25);
            this.ProvinciaMetroTextBox.TabIndex = 12;
            this.ProvinciaMetroTextBox.UseSelectable = true;
            this.ProvinciaMetroTextBox.WaterMark = "Ingrese el nombre";
            this.ProvinciaMetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ProvinciaMetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(33, 71);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(62, 19);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "Nombre:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmProvinciasEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 232);
            this.Controls.Add(this.CancelarIconButton);
            this.Controls.Add(this.OKIconButton);
            this.Controls.Add(this.ProvinciaMetroTextBox);
            this.Controls.Add(this.metroLabel1);
            this.Name = "FrmProvinciasEdit";
            this.Text = "FrmProvinciasEdit";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton CancelarIconButton;
        private FontAwesome.Sharp.IconButton OKIconButton;
        private MetroFramework.Controls.MetroTextBox ProvinciaMetroTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}