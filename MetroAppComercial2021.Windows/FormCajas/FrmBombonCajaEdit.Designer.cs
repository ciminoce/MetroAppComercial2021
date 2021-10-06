
namespace MetroAppComercial2021.Windows.FormCajas
{
    partial class FrmBombonCajaEdit
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
            this.UnidadesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CancelarIconButton = new FontAwesome.Sharp.IconButton();
            this.OKIconButton = new FontAwesome.Sharp.IconButton();
            this.BombonesMetroComboBox = new MetroFramework.Controls.MetroComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.UnidadesNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(43, 92);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(63, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Bombón:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(43, 154);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(66, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Unidades:";
            // 
            // UnidadesNumericUpDown
            // 
            this.UnidadesNumericUpDown.Location = new System.Drawing.Point(115, 154);
            this.UnidadesNumericUpDown.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.UnidadesNumericUpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.UnidadesNumericUpDown.Name = "UnidadesNumericUpDown";
            this.UnidadesNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.UnidadesNumericUpDown.TabIndex = 3;
            this.UnidadesNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // CancelarIconButton
            // 
            this.CancelarIconButton.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.CancelarIconButton.IconColor = System.Drawing.Color.Red;
            this.CancelarIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CancelarIconButton.Location = new System.Drawing.Point(401, 195);
            this.CancelarIconButton.Name = "CancelarIconButton";
            this.CancelarIconButton.Size = new System.Drawing.Size(99, 60);
            this.CancelarIconButton.TabIndex = 21;
            this.CancelarIconButton.UseVisualStyleBackColor = true;
            this.CancelarIconButton.Click += new System.EventHandler(this.CancelarIconButton_Click);
            // 
            // OKIconButton
            // 
            this.OKIconButton.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.OKIconButton.IconColor = System.Drawing.Color.Blue;
            this.OKIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.OKIconButton.Location = new System.Drawing.Point(102, 195);
            this.OKIconButton.Name = "OKIconButton";
            this.OKIconButton.Size = new System.Drawing.Size(99, 60);
            this.OKIconButton.TabIndex = 20;
            this.OKIconButton.UseVisualStyleBackColor = true;
            this.OKIconButton.Click += new System.EventHandler(this.OKIconButton_Click);
            // 
            // BombonesMetroComboBox
            // 
            this.BombonesMetroComboBox.FormattingEnabled = true;
            this.BombonesMetroComboBox.ItemHeight = 23;
            this.BombonesMetroComboBox.Location = new System.Drawing.Point(115, 89);
            this.BombonesMetroComboBox.Name = "BombonesMetroComboBox";
            this.BombonesMetroComboBox.Size = new System.Drawing.Size(385, 29);
            this.BombonesMetroComboBox.TabIndex = 22;
            this.BombonesMetroComboBox.UseSelectable = true;
            this.BombonesMetroComboBox.SelectedIndexChanged += new System.EventHandler(this.BombonesMetroComboBox_SelectedIndexChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmBombonCajaEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 269);
            this.ControlBox = false;
            this.Controls.Add(this.BombonesMetroComboBox);
            this.Controls.Add(this.CancelarIconButton);
            this.Controls.Add(this.OKIconButton);
            this.Controls.Add(this.UnidadesNumericUpDown);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.MaximumSize = new System.Drawing.Size(627, 269);
            this.MinimumSize = new System.Drawing.Size(627, 269);
            this.Name = "FrmBombonCajaEdit";
            this.Text = "FrmBombonCajaEdit";
            this.Load += new System.EventHandler(this.FrmBombonCajaEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UnidadesNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.NumericUpDown UnidadesNumericUpDown;
        private FontAwesome.Sharp.IconButton CancelarIconButton;
        private FontAwesome.Sharp.IconButton OKIconButton;
        private MetroFramework.Controls.MetroComboBox BombonesMetroComboBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}