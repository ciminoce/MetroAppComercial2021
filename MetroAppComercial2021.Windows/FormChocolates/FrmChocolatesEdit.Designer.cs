
namespace MetroAppComercial2021.Windows.FormChocolates
{
    partial class FrmChocolatesEdit
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
            this.ChocolateMetroTextBox = new MetroFramework.Controls.MetroTextBox();
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
            this.CancelarIconButton.Location = new System.Drawing.Point(332, 145);
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
            this.OKIconButton.Location = new System.Drawing.Point(33, 145);
            this.OKIconButton.Name = "OKIconButton";
            this.OKIconButton.Size = new System.Drawing.Size(99, 60);
            this.OKIconButton.TabIndex = 10;
            this.OKIconButton.UseVisualStyleBackColor = true;
            this.OKIconButton.Click += new System.EventHandler(this.OKIconButton_Click);
            // 
            // ChocolateMetroTextBox
            // 
            // 
            // 
            // 
            this.ChocolateMetroTextBox.CustomButton.Image = null;
            this.ChocolateMetroTextBox.CustomButton.Location = new System.Drawing.Point(289, 1);
            this.ChocolateMetroTextBox.CustomButton.Name = "";
            this.ChocolateMetroTextBox.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.ChocolateMetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ChocolateMetroTextBox.CustomButton.TabIndex = 1;
            this.ChocolateMetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ChocolateMetroTextBox.CustomButton.UseSelectable = true;
            this.ChocolateMetroTextBox.CustomButton.Visible = false;
            this.ChocolateMetroTextBox.DisplayIcon = true;
            this.ChocolateMetroTextBox.Icon = global::MetroAppComercial2021.Windows.Properties.Resources.edit_image_20px;
            this.ChocolateMetroTextBox.Lines = new string[0];
            this.ChocolateMetroTextBox.Location = new System.Drawing.Point(118, 75);
            this.ChocolateMetroTextBox.MaxLength = 50;
            this.ChocolateMetroTextBox.Name = "ChocolateMetroTextBox";
            this.ChocolateMetroTextBox.PasswordChar = '\0';
            this.ChocolateMetroTextBox.PromptText = "Ingrese la descripción";
            this.ChocolateMetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ChocolateMetroTextBox.SelectedText = "";
            this.ChocolateMetroTextBox.SelectionLength = 0;
            this.ChocolateMetroTextBox.SelectionStart = 0;
            this.ChocolateMetroTextBox.ShortcutsEnabled = true;
            this.ChocolateMetroTextBox.Size = new System.Drawing.Size(313, 25);
            this.ChocolateMetroTextBox.TabIndex = 8;
            this.ChocolateMetroTextBox.UseSelectable = true;
            this.ChocolateMetroTextBox.WaterMark = "Ingrese la descripción";
            this.ChocolateMetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ChocolateMetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(33, 75);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(79, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Descripción:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmChocolatesEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 250);
            this.Controls.Add(this.CancelarIconButton);
            this.Controls.Add(this.OKIconButton);
            this.Controls.Add(this.ChocolateMetroTextBox);
            this.Controls.Add(this.metroLabel1);
            this.Name = "FrmChocolatesEdit";
            this.Text = "FrmChocolatesEdit";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton CancelarIconButton;
        private FontAwesome.Sharp.IconButton OKIconButton;
        private MetroFramework.Controls.MetroTextBox ChocolateMetroTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}