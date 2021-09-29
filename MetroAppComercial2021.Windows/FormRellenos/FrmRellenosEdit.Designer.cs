
namespace MetroAppComercial2021.Windows.FormRellenos
{
    partial class FrmRellenosEdit
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.CancelarIconButton = new FontAwesome.Sharp.IconButton();
            this.OKIconButton = new FontAwesome.Sharp.IconButton();
            this.RellenoMetroTextBox = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(35, 82);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(79, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Descripción:";
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
            this.CancelarIconButton.Location = new System.Drawing.Point(334, 152);
            this.CancelarIconButton.Name = "CancelarIconButton";
            this.CancelarIconButton.Size = new System.Drawing.Size(99, 60);
            this.CancelarIconButton.TabIndex = 5;
            this.CancelarIconButton.UseVisualStyleBackColor = true;
            this.CancelarIconButton.Click += new System.EventHandler(this.CancelarIconButton_Click);
            // 
            // OKIconButton
            // 
            this.OKIconButton.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.OKIconButton.IconColor = System.Drawing.Color.Blue;
            this.OKIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.OKIconButton.Location = new System.Drawing.Point(35, 152);
            this.OKIconButton.Name = "OKIconButton";
            this.OKIconButton.Size = new System.Drawing.Size(99, 60);
            this.OKIconButton.TabIndex = 6;
            this.OKIconButton.UseVisualStyleBackColor = true;
            this.OKIconButton.Click += new System.EventHandler(this.OKIconButton_Click);
            // 
            // RellenoMetroTextBox
            // 
            // 
            // 
            // 
            this.RellenoMetroTextBox.CustomButton.Image = null;
            this.RellenoMetroTextBox.CustomButton.Location = new System.Drawing.Point(289, 1);
            this.RellenoMetroTextBox.CustomButton.Name = "";
            this.RellenoMetroTextBox.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.RellenoMetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.RellenoMetroTextBox.CustomButton.TabIndex = 1;
            this.RellenoMetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.RellenoMetroTextBox.CustomButton.UseSelectable = true;
            this.RellenoMetroTextBox.CustomButton.Visible = false;
            this.RellenoMetroTextBox.DisplayIcon = true;
            this.RellenoMetroTextBox.Icon = global::MetroAppComercial2021.Windows.Properties.Resources.edit_image_20px;
            this.RellenoMetroTextBox.Lines = new string[0];
            this.RellenoMetroTextBox.Location = new System.Drawing.Point(120, 82);
            this.RellenoMetroTextBox.MaxLength = 50;
            this.RellenoMetroTextBox.Name = "RellenoMetroTextBox";
            this.RellenoMetroTextBox.PasswordChar = '\0';
            this.RellenoMetroTextBox.PromptText = "Ingrese la descripción";
            this.RellenoMetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.RellenoMetroTextBox.SelectedText = "";
            this.RellenoMetroTextBox.SelectionLength = 0;
            this.RellenoMetroTextBox.SelectionStart = 0;
            this.RellenoMetroTextBox.ShortcutsEnabled = true;
            this.RellenoMetroTextBox.Size = new System.Drawing.Size(313, 25);
            this.RellenoMetroTextBox.TabIndex = 4;
            this.RellenoMetroTextBox.UseSelectable = true;
            this.RellenoMetroTextBox.WaterMark = "Ingrese la descripción";
            this.RellenoMetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.RellenoMetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FrmRellenosEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 250);
            this.ControlBox = false;
            this.Controls.Add(this.CancelarIconButton);
            this.Controls.Add(this.OKIconButton);
            this.Controls.Add(this.RellenoMetroTextBox);
            this.Controls.Add(this.metroLabel1);
            this.Name = "FrmRellenosEdit";
            this.Text = "FrmRellenosEdit";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton CancelarIconButton;
        private FontAwesome.Sharp.IconButton OKIconButton;
        private MetroFramework.Controls.MetroTextBox RellenoMetroTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}