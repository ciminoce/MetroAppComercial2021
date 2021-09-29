
namespace MetroAppComercial2021.Windows.FormNueces
{
    partial class FrmNuecesEdit
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
            this.NuezMetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
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
            this.CancelarIconButton.Location = new System.Drawing.Point(329, 140);
            this.CancelarIconButton.Name = "CancelarIconButton";
            this.CancelarIconButton.Size = new System.Drawing.Size(99, 60);
            this.CancelarIconButton.TabIndex = 9;
            this.CancelarIconButton.UseVisualStyleBackColor = true;
            this.CancelarIconButton.Click += new System.EventHandler(this.CancelarIconButton_Click);
            // 
            // OKIconButton
            // 
            this.OKIconButton.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.OKIconButton.IconColor = System.Drawing.Color.Blue;
            this.OKIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.OKIconButton.Location = new System.Drawing.Point(30, 140);
            this.OKIconButton.Name = "OKIconButton";
            this.OKIconButton.Size = new System.Drawing.Size(99, 60);
            this.OKIconButton.TabIndex = 10;
            this.OKIconButton.UseVisualStyleBackColor = true;
            this.OKIconButton.Click += new System.EventHandler(this.OKIconButton_Click);
            // 
            // NuezMetroTextBox
            // 
            // 
            // 
            // 
            this.NuezMetroTextBox.CustomButton.Image = null;
            this.NuezMetroTextBox.CustomButton.Location = new System.Drawing.Point(289, 1);
            this.NuezMetroTextBox.CustomButton.Name = "";
            this.NuezMetroTextBox.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.NuezMetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NuezMetroTextBox.CustomButton.TabIndex = 1;
            this.NuezMetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NuezMetroTextBox.CustomButton.UseSelectable = true;
            this.NuezMetroTextBox.CustomButton.Visible = false;
            this.NuezMetroTextBox.DisplayIcon = true;
            this.NuezMetroTextBox.Icon = global::MetroAppComercial2021.Windows.Properties.Resources.edit_image_20px;
            this.NuezMetroTextBox.Lines = new string[0];
            this.NuezMetroTextBox.Location = new System.Drawing.Point(115, 70);
            this.NuezMetroTextBox.MaxLength = 50;
            this.NuezMetroTextBox.Name = "NuezMetroTextBox";
            this.NuezMetroTextBox.PasswordChar = '\0';
            this.NuezMetroTextBox.PromptText = "Ingrese la descripción";
            this.NuezMetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NuezMetroTextBox.SelectedText = "";
            this.NuezMetroTextBox.SelectionLength = 0;
            this.NuezMetroTextBox.SelectionStart = 0;
            this.NuezMetroTextBox.ShortcutsEnabled = true;
            this.NuezMetroTextBox.Size = new System.Drawing.Size(313, 25);
            this.NuezMetroTextBox.TabIndex = 8;
            this.NuezMetroTextBox.UseSelectable = true;
            this.NuezMetroTextBox.WaterMark = "Ingrese la descripción";
            this.NuezMetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.NuezMetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(30, 70);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(79, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Descripción:";
            // 
            // FrmNuecesEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 232);
            this.ControlBox = false;
            this.Controls.Add(this.CancelarIconButton);
            this.Controls.Add(this.OKIconButton);
            this.Controls.Add(this.NuezMetroTextBox);
            this.Controls.Add(this.metroLabel1);
            this.Name = "FrmNuecesEdit";
            this.Text = "FrmNuecesEdit";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private FontAwesome.Sharp.IconButton CancelarIconButton;
        private FontAwesome.Sharp.IconButton OKIconButton;
        private MetroFramework.Controls.MetroTextBox NuezMetroTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}