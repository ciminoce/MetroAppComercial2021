
namespace MetroAppComercial2021.Windows.FrmTareas
{
    partial class FrmLogin
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.ClaveMetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.CancelarIconButton = new FontAwesome.Sharp.IconButton();
            this.OKIconButton = new FontAwesome.Sharp.IconButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.EmpleadosMetroComboBox = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MetroAppComercial2021.Windows.Properties.Resources.Ingreso;
            this.pictureBox1.Location = new System.Drawing.Point(335, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 134);
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(9, 91);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(56, 19);
            this.metroLabel1.TabIndex = 41;
            this.metroLabel1.Text = "Usuario:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(9, 132);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(44, 19);
            this.metroLabel2.TabIndex = 41;
            this.metroLabel2.Text = "Clave:";
            // 
            // ClaveMetroTextBox
            // 
            // 
            // 
            // 
            this.ClaveMetroTextBox.CustomButton.Image = null;
            this.ClaveMetroTextBox.CustomButton.Location = new System.Drawing.Point(236, 1);
            this.ClaveMetroTextBox.CustomButton.Name = "";
            this.ClaveMetroTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ClaveMetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ClaveMetroTextBox.CustomButton.TabIndex = 1;
            this.ClaveMetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ClaveMetroTextBox.CustomButton.UseSelectable = true;
            this.ClaveMetroTextBox.CustomButton.Visible = false;
            this.ClaveMetroTextBox.Lines = new string[0];
            this.ClaveMetroTextBox.Location = new System.Drawing.Point(71, 132);
            this.ClaveMetroTextBox.MaxLength = 32767;
            this.ClaveMetroTextBox.Name = "ClaveMetroTextBox";
            this.ClaveMetroTextBox.PasswordChar = '*';
            this.ClaveMetroTextBox.PromptText = "Clave";
            this.ClaveMetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ClaveMetroTextBox.SelectedText = "";
            this.ClaveMetroTextBox.SelectionLength = 0;
            this.ClaveMetroTextBox.SelectionStart = 0;
            this.ClaveMetroTextBox.ShortcutsEnabled = true;
            this.ClaveMetroTextBox.Size = new System.Drawing.Size(258, 23);
            this.ClaveMetroTextBox.TabIndex = 42;
            this.ClaveMetroTextBox.UseSelectable = true;
            this.ClaveMetroTextBox.WaterMark = "Clave";
            this.ClaveMetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ClaveMetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // CancelarIconButton
            // 
            this.CancelarIconButton.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.CancelarIconButton.IconColor = System.Drawing.Color.Red;
            this.CancelarIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CancelarIconButton.Location = new System.Drawing.Point(230, 162);
            this.CancelarIconButton.Name = "CancelarIconButton";
            this.CancelarIconButton.Size = new System.Drawing.Size(99, 60);
            this.CancelarIconButton.TabIndex = 44;
            this.CancelarIconButton.UseVisualStyleBackColor = true;
            this.CancelarIconButton.Click += new System.EventHandler(this.CancelarIconButton_Click);
            // 
            // OKIconButton
            // 
            this.OKIconButton.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.OKIconButton.IconColor = System.Drawing.Color.Blue;
            this.OKIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.OKIconButton.Location = new System.Drawing.Point(9, 162);
            this.OKIconButton.Name = "OKIconButton";
            this.OKIconButton.Size = new System.Drawing.Size(99, 60);
            this.OKIconButton.TabIndex = 43;
            this.OKIconButton.UseVisualStyleBackColor = true;
            this.OKIconButton.Click += new System.EventHandler(this.OKIconButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // EmpleadosMetroComboBox
            // 
            this.EmpleadosMetroComboBox.FormattingEnabled = true;
            this.EmpleadosMetroComboBox.ItemHeight = 23;
            this.EmpleadosMetroComboBox.Location = new System.Drawing.Point(71, 88);
            this.EmpleadosMetroComboBox.Name = "EmpleadosMetroComboBox";
            this.EmpleadosMetroComboBox.Size = new System.Drawing.Size(258, 29);
            this.EmpleadosMetroComboBox.TabIndex = 45;
            this.EmpleadosMetroComboBox.UseSelectable = true;
            this.EmpleadosMetroComboBox.SelectedIndexChanged += new System.EventHandler(this.EmpleadosMetroComboBox_SelectedIndexChanged);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 277);
            this.Controls.Add(this.EmpleadosMetroComboBox);
            this.Controls.Add(this.CancelarIconButton);
            this.Controls.Add(this.OKIconButton);
            this.Controls.Add(this.ClaveMetroTextBox);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(489, 277);
            this.MinimumSize = new System.Drawing.Size(489, 277);
            this.Name = "FrmLogin";
            this.Text = "Ingreso al Sistema";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox ClaveMetroTextBox;
        private FontAwesome.Sharp.IconButton CancelarIconButton;
        private FontAwesome.Sharp.IconButton OKIconButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MetroFramework.Controls.MetroComboBox EmpleadosMetroComboBox;
    }
}