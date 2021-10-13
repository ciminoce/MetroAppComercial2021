
namespace MetroAppComercial2021.Windows.FormClientes
{
    partial class FrmClientesEdit
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
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.LocalidadMetroComboBox = new MetroFramework.Controls.MetroComboBox();
            this.ProvinciasMetroComboBox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.CancelarIconButton = new FontAwesome.Sharp.IconButton();
            this.OKIconButton = new FontAwesome.Sharp.IconButton();
            this.CodPostalMetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.DireccionMetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.MailMetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.MovilMetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.FijoMetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.ApellidoMetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.NombresMetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(46, 96);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(67, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Nombres:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(52, 63);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(61, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Apellido:";
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(38, 179);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(604, 228);
            this.metroTabControl1.TabIndex = 2;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.LocalidadMetroComboBox);
            this.metroTabPage1.Controls.Add(this.ProvinciasMetroComboBox);
            this.metroTabPage1.Controls.Add(this.metroLabel6);
            this.metroTabPage1.Controls.Add(this.CodPostalMetroTextBox);
            this.metroTabPage1.Controls.Add(this.metroLabel5);
            this.metroTabPage1.Controls.Add(this.metroLabel4);
            this.metroTabPage1.Controls.Add(this.DireccionMetroTextBox);
            this.metroTabPage1.Controls.Add(this.metroLabel3);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(596, 186);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Domicilio";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // LocalidadMetroComboBox
            // 
            this.LocalidadMetroComboBox.FormattingEnabled = true;
            this.LocalidadMetroComboBox.ItemHeight = 23;
            this.LocalidadMetroComboBox.Location = new System.Drawing.Point(103, 138);
            this.LocalidadMetroComboBox.Name = "LocalidadMetroComboBox";
            this.LocalidadMetroComboBox.Size = new System.Drawing.Size(383, 29);
            this.LocalidadMetroComboBox.TabIndex = 4;
            this.LocalidadMetroComboBox.UseSelectable = true;
            this.LocalidadMetroComboBox.SelectedIndexChanged += new System.EventHandler(this.LocalidadMetroComboBox_SelectedIndexChanged);
            // 
            // ProvinciasMetroComboBox
            // 
            this.ProvinciasMetroComboBox.FormattingEnabled = true;
            this.ProvinciasMetroComboBox.ItemHeight = 23;
            this.ProvinciasMetroComboBox.Location = new System.Drawing.Point(103, 103);
            this.ProvinciasMetroComboBox.Name = "ProvinciasMetroComboBox";
            this.ProvinciasMetroComboBox.Size = new System.Drawing.Size(383, 29);
            this.ProvinciasMetroComboBox.TabIndex = 3;
            this.ProvinciasMetroComboBox.UseSelectable = true;
            this.ProvinciasMetroComboBox.SelectedIndexChanged += new System.EventHandler(this.ProvinciasMetroComboBox_SelectedIndexChanged);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(17, 141);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(68, 19);
            this.metroLabel6.TabIndex = 2;
            this.metroLabel6.Text = "Localidad:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(20, 106);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(65, 19);
            this.metroLabel5.TabIndex = 2;
            this.metroLabel5.Text = "Provincia:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(7, 64);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(78, 19);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "Cód. Postal:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(19, 25);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(66, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Dirección:";
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroLabel9);
            this.metroTabPage2.Controls.Add(this.metroLabel8);
            this.metroTabPage2.Controls.Add(this.metroLabel7);
            this.metroTabPage2.Controls.Add(this.MailMetroTextBox);
            this.metroTabPage2.Controls.Add(this.MovilMetroTextBox);
            this.metroTabPage2.Controls.Add(this.FijoMetroTextBox);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(596, 186);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Contacto";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(52, 77);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(37, 19);
            this.metroLabel9.TabIndex = 2;
            this.metroLabel9.Text = "Mail:";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(0, 46);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(89, 19);
            this.metroLabel8.TabIndex = 2;
            this.metroLabel8.Text = "Teléfon Móvil:";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(3, 17);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(86, 19);
            this.metroLabel7.TabIndex = 2;
            this.metroLabel7.Text = "Teléfono Fijo:";
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
            this.CancelarIconButton.Location = new System.Drawing.Point(446, 413);
            this.CancelarIconButton.Name = "CancelarIconButton";
            this.CancelarIconButton.Size = new System.Drawing.Size(99, 60);
            this.CancelarIconButton.TabIndex = 4;
            this.CancelarIconButton.UseVisualStyleBackColor = true;
            this.CancelarIconButton.Click += new System.EventHandler(this.CancelarIconButton_Click);
            // 
            // OKIconButton
            // 
            this.OKIconButton.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.OKIconButton.IconColor = System.Drawing.Color.Blue;
            this.OKIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.OKIconButton.Location = new System.Drawing.Point(147, 413);
            this.OKIconButton.Name = "OKIconButton";
            this.OKIconButton.Size = new System.Drawing.Size(99, 60);
            this.OKIconButton.TabIndex = 3;
            this.OKIconButton.UseVisualStyleBackColor = true;
            this.OKIconButton.Click += new System.EventHandler(this.OKIconButton_Click);
            // 
            // CodPostalMetroTextBox
            // 
            // 
            // 
            // 
            this.CodPostalMetroTextBox.CustomButton.Image = null;
            this.CodPostalMetroTextBox.CustomButton.Location = new System.Drawing.Point(119, 2);
            this.CodPostalMetroTextBox.CustomButton.Name = "";
            this.CodPostalMetroTextBox.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.CodPostalMetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CodPostalMetroTextBox.CustomButton.TabIndex = 1;
            this.CodPostalMetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CodPostalMetroTextBox.CustomButton.UseSelectable = true;
            this.CodPostalMetroTextBox.CustomButton.Visible = false;
            this.CodPostalMetroTextBox.DisplayIcon = true;
            this.CodPostalMetroTextBox.Icon = global::MetroAppComercial2021.Windows.Properties.Resources.secured_letter_20px;
            this.CodPostalMetroTextBox.Lines = new string[0];
            this.CodPostalMetroTextBox.Location = new System.Drawing.Point(105, 64);
            this.CodPostalMetroTextBox.MaxLength = 10;
            this.CodPostalMetroTextBox.Multiline = true;
            this.CodPostalMetroTextBox.Name = "CodPostalMetroTextBox";
            this.CodPostalMetroTextBox.PasswordChar = '\0';
            this.CodPostalMetroTextBox.PromptText = "Ingrese el cód. postal";
            this.CodPostalMetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CodPostalMetroTextBox.SelectedText = "";
            this.CodPostalMetroTextBox.SelectionLength = 0;
            this.CodPostalMetroTextBox.SelectionStart = 0;
            this.CodPostalMetroTextBox.ShortcutsEnabled = true;
            this.CodPostalMetroTextBox.Size = new System.Drawing.Size(149, 32);
            this.CodPostalMetroTextBox.TabIndex = 2;
            this.CodPostalMetroTextBox.UseSelectable = true;
            this.CodPostalMetroTextBox.WaterMark = "Ingrese el cód. postal";
            this.CodPostalMetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CodPostalMetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // DireccionMetroTextBox
            // 
            // 
            // 
            // 
            this.DireccionMetroTextBox.CustomButton.Image = null;
            this.DireccionMetroTextBox.CustomButton.Location = new System.Drawing.Point(458, 2);
            this.DireccionMetroTextBox.CustomButton.Name = "";
            this.DireccionMetroTextBox.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.DireccionMetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.DireccionMetroTextBox.CustomButton.TabIndex = 1;
            this.DireccionMetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.DireccionMetroTextBox.CustomButton.UseSelectable = true;
            this.DireccionMetroTextBox.CustomButton.Visible = false;
            this.DireccionMetroTextBox.DisplayIcon = true;
            this.DireccionMetroTextBox.Icon = global::MetroAppComercial2021.Windows.Properties.Resources.marker_20px;
            this.DireccionMetroTextBox.Lines = new string[0];
            this.DireccionMetroTextBox.Location = new System.Drawing.Point(105, 25);
            this.DireccionMetroTextBox.MaxLength = 100;
            this.DireccionMetroTextBox.Multiline = true;
            this.DireccionMetroTextBox.Name = "DireccionMetroTextBox";
            this.DireccionMetroTextBox.PasswordChar = '\0';
            this.DireccionMetroTextBox.PromptText = "Ingrese la dirección";
            this.DireccionMetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DireccionMetroTextBox.SelectedText = "";
            this.DireccionMetroTextBox.SelectionLength = 0;
            this.DireccionMetroTextBox.SelectionStart = 0;
            this.DireccionMetroTextBox.ShortcutsEnabled = true;
            this.DireccionMetroTextBox.Size = new System.Drawing.Size(488, 32);
            this.DireccionMetroTextBox.TabIndex = 1;
            this.DireccionMetroTextBox.UseSelectable = true;
            this.DireccionMetroTextBox.WaterMark = "Ingrese la dirección";
            this.DireccionMetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DireccionMetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // MailMetroTextBox
            // 
            // 
            // 
            // 
            this.MailMetroTextBox.CustomButton.Image = null;
            this.MailMetroTextBox.CustomButton.Location = new System.Drawing.Point(436, 1);
            this.MailMetroTextBox.CustomButton.Name = "";
            this.MailMetroTextBox.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.MailMetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MailMetroTextBox.CustomButton.TabIndex = 1;
            this.MailMetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MailMetroTextBox.CustomButton.UseSelectable = true;
            this.MailMetroTextBox.CustomButton.Visible = false;
            this.MailMetroTextBox.DisplayIcon = true;
            this.MailMetroTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.MailMetroTextBox.Icon = global::MetroAppComercial2021.Windows.Properties.Resources.email_20px;
            this.MailMetroTextBox.Lines = new string[0];
            this.MailMetroTextBox.Location = new System.Drawing.Point(105, 77);
            this.MailMetroTextBox.MaxLength = 200;
            this.MailMetroTextBox.Multiline = true;
            this.MailMetroTextBox.Name = "MailMetroTextBox";
            this.MailMetroTextBox.PasswordChar = '\0';
            this.MailMetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MailMetroTextBox.SelectedText = "";
            this.MailMetroTextBox.SelectionLength = 0;
            this.MailMetroTextBox.SelectionStart = 0;
            this.MailMetroTextBox.ShortcutsEnabled = true;
            this.MailMetroTextBox.Size = new System.Drawing.Size(466, 31);
            this.MailMetroTextBox.TabIndex = 3;
            this.MailMetroTextBox.UseSelectable = true;
            this.MailMetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MailMetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // MovilMetroTextBox
            // 
            // 
            // 
            // 
            this.MovilMetroTextBox.CustomButton.Image = null;
            this.MovilMetroTextBox.CustomButton.Location = new System.Drawing.Point(161, 1);
            this.MovilMetroTextBox.CustomButton.Name = "";
            this.MovilMetroTextBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.MovilMetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MovilMetroTextBox.CustomButton.TabIndex = 1;
            this.MovilMetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MovilMetroTextBox.CustomButton.UseSelectable = true;
            this.MovilMetroTextBox.CustomButton.Visible = false;
            this.MovilMetroTextBox.DisplayIcon = true;
            this.MovilMetroTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.MovilMetroTextBox.Icon = global::MetroAppComercial2021.Windows.Properties.Resources.blackberry_20px;
            this.MovilMetroTextBox.Lines = new string[0];
            this.MovilMetroTextBox.Location = new System.Drawing.Point(105, 46);
            this.MovilMetroTextBox.MaxLength = 20;
            this.MovilMetroTextBox.Multiline = true;
            this.MovilMetroTextBox.Name = "MovilMetroTextBox";
            this.MovilMetroTextBox.PasswordChar = '\0';
            this.MovilMetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MovilMetroTextBox.SelectedText = "";
            this.MovilMetroTextBox.SelectionLength = 0;
            this.MovilMetroTextBox.SelectionStart = 0;
            this.MovilMetroTextBox.ShortcutsEnabled = true;
            this.MovilMetroTextBox.Size = new System.Drawing.Size(187, 27);
            this.MovilMetroTextBox.TabIndex = 3;
            this.MovilMetroTextBox.UseSelectable = true;
            this.MovilMetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MovilMetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FijoMetroTextBox
            // 
            // 
            // 
            // 
            this.FijoMetroTextBox.CustomButton.Image = null;
            this.FijoMetroTextBox.CustomButton.Location = new System.Drawing.Point(161, 1);
            this.FijoMetroTextBox.CustomButton.Name = "";
            this.FijoMetroTextBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.FijoMetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.FijoMetroTextBox.CustomButton.TabIndex = 1;
            this.FijoMetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.FijoMetroTextBox.CustomButton.UseSelectable = true;
            this.FijoMetroTextBox.CustomButton.Visible = false;
            this.FijoMetroTextBox.DisplayIcon = true;
            this.FijoMetroTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.FijoMetroTextBox.Icon = global::MetroAppComercial2021.Windows.Properties.Resources.phone_20px;
            this.FijoMetroTextBox.Lines = new string[0];
            this.FijoMetroTextBox.Location = new System.Drawing.Point(105, 17);
            this.FijoMetroTextBox.MaxLength = 20;
            this.FijoMetroTextBox.Multiline = true;
            this.FijoMetroTextBox.Name = "FijoMetroTextBox";
            this.FijoMetroTextBox.PasswordChar = '\0';
            this.FijoMetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.FijoMetroTextBox.SelectedText = "";
            this.FijoMetroTextBox.SelectionLength = 0;
            this.FijoMetroTextBox.SelectionStart = 0;
            this.FijoMetroTextBox.ShortcutsEnabled = true;
            this.FijoMetroTextBox.Size = new System.Drawing.Size(187, 27);
            this.FijoMetroTextBox.TabIndex = 3;
            this.FijoMetroTextBox.UseSelectable = true;
            this.FijoMetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.FijoMetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ApellidoMetroTextBox
            // 
            // 
            // 
            // 
            this.ApellidoMetroTextBox.CustomButton.Image = null;
            this.ApellidoMetroTextBox.CustomButton.Location = new System.Drawing.Point(469, 1);
            this.ApellidoMetroTextBox.CustomButton.Name = "";
            this.ApellidoMetroTextBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.ApellidoMetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ApellidoMetroTextBox.CustomButton.TabIndex = 1;
            this.ApellidoMetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ApellidoMetroTextBox.CustomButton.UseSelectable = true;
            this.ApellidoMetroTextBox.CustomButton.Visible = false;
            this.ApellidoMetroTextBox.DisplayIcon = true;
            this.ApellidoMetroTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.ApellidoMetroTextBox.Icon = global::MetroAppComercial2021.Windows.Properties.Resources.edit_image_20px;
            this.ApellidoMetroTextBox.Lines = new string[0];
            this.ApellidoMetroTextBox.Location = new System.Drawing.Point(133, 63);
            this.ApellidoMetroTextBox.MaxLength = 50;
            this.ApellidoMetroTextBox.Multiline = true;
            this.ApellidoMetroTextBox.Name = "ApellidoMetroTextBox";
            this.ApellidoMetroTextBox.PasswordChar = '\0';
            this.ApellidoMetroTextBox.PromptText = "Ingrese el apellido";
            this.ApellidoMetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ApellidoMetroTextBox.SelectedText = "";
            this.ApellidoMetroTextBox.SelectionLength = 0;
            this.ApellidoMetroTextBox.SelectionStart = 0;
            this.ApellidoMetroTextBox.ShortcutsEnabled = true;
            this.ApellidoMetroTextBox.Size = new System.Drawing.Size(495, 27);
            this.ApellidoMetroTextBox.TabIndex = 0;
            this.ApellidoMetroTextBox.UseSelectable = true;
            this.ApellidoMetroTextBox.WaterMark = "Ingrese el apellido";
            this.ApellidoMetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ApellidoMetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // NombresMetroTextBox
            // 
            // 
            // 
            // 
            this.NombresMetroTextBox.CustomButton.Image = null;
            this.NombresMetroTextBox.CustomButton.Location = new System.Drawing.Point(469, 1);
            this.NombresMetroTextBox.CustomButton.Name = "";
            this.NombresMetroTextBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.NombresMetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NombresMetroTextBox.CustomButton.TabIndex = 1;
            this.NombresMetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NombresMetroTextBox.CustomButton.UseSelectable = true;
            this.NombresMetroTextBox.CustomButton.Visible = false;
            this.NombresMetroTextBox.DisplayIcon = true;
            this.NombresMetroTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.NombresMetroTextBox.Icon = global::MetroAppComercial2021.Windows.Properties.Resources.edit_image_20px;
            this.NombresMetroTextBox.Lines = new string[0];
            this.NombresMetroTextBox.Location = new System.Drawing.Point(133, 96);
            this.NombresMetroTextBox.MaxLength = 50;
            this.NombresMetroTextBox.Multiline = true;
            this.NombresMetroTextBox.Name = "NombresMetroTextBox";
            this.NombresMetroTextBox.PasswordChar = '\0';
            this.NombresMetroTextBox.PromptText = "Ingrese los nombres";
            this.NombresMetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NombresMetroTextBox.SelectedText = "";
            this.NombresMetroTextBox.SelectionLength = 0;
            this.NombresMetroTextBox.SelectionStart = 0;
            this.NombresMetroTextBox.ShortcutsEnabled = true;
            this.NombresMetroTextBox.Size = new System.Drawing.Size(495, 27);
            this.NombresMetroTextBox.TabIndex = 1;
            this.NombresMetroTextBox.UseSelectable = true;
            this.NombresMetroTextBox.WaterMark = "Ingrese los nombres";
            this.NombresMetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.NombresMetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FrmClientesEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 503);
            this.ControlBox = false;
            this.Controls.Add(this.CancelarIconButton);
            this.Controls.Add(this.OKIconButton);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.ApellidoMetroTextBox);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.NombresMetroTextBox);
            this.Controls.Add(this.metroLabel1);
            this.MaximumSize = new System.Drawing.Size(685, 503);
            this.MinimumSize = new System.Drawing.Size(685, 503);
            this.Name = "FrmClientesEdit";
            this.Text = "FrmClientesEdit";
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox NombresMetroTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox ApellidoMetroTextBox;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroComboBox LocalidadMetroComboBox;
        private MetroFramework.Controls.MetroComboBox ProvinciasMetroComboBox;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox CodPostalMetroTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox DireccionMetroTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTextBox MailMetroTextBox;
        private MetroFramework.Controls.MetroTextBox MovilMetroTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox FijoMetroTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private FontAwesome.Sharp.IconButton CancelarIconButton;
        private FontAwesome.Sharp.IconButton OKIconButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}