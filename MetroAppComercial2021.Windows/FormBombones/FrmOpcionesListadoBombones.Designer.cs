
namespace MetroAppComercial2021.Windows.FormBombones
{
    partial class FrmOpcionesListadoBombones
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
            this.ListarMetroButton = new MetroFramework.Controls.MetroButton();
            this.AgrupadoMetroCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MenorMetroRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.MayorMetroRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.AlfaMetroRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListarMetroButton
            // 
            this.ListarMetroButton.Location = new System.Drawing.Point(100, 289);
            this.ListarMetroButton.Name = "ListarMetroButton";
            this.ListarMetroButton.Size = new System.Drawing.Size(84, 59);
            this.ListarMetroButton.TabIndex = 5;
            this.ListarMetroButton.Text = "Listar";
            this.ListarMetroButton.UseSelectable = true;
            this.ListarMetroButton.Click += new System.EventHandler(this.ListarMetroButton_Click);
            // 
            // AgrupadoMetroCheckBox
            // 
            this.AgrupadoMetroCheckBox.AutoSize = true;
            this.AgrupadoMetroCheckBox.Location = new System.Drawing.Point(40, 202);
            this.AgrupadoMetroCheckBox.Name = "AgrupadoMetroCheckBox";
            this.AgrupadoMetroCheckBox.Size = new System.Drawing.Size(180, 15);
            this.AgrupadoMetroCheckBox.TabIndex = 4;
            this.AgrupadoMetroCheckBox.Text = "Agrupado por Tipo Chocolate";
            this.AgrupadoMetroCheckBox.UseSelectable = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MenorMetroRadioButton);
            this.groupBox1.Controls.Add(this.MayorMetroRadioButton);
            this.groupBox1.Controls.Add(this.AlfaMetroRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(40, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Orden del Listado ";
            // 
            // MenorMetroRadioButton
            // 
            this.MenorMetroRadioButton.AutoSize = true;
            this.MenorMetroRadioButton.Location = new System.Drawing.Point(17, 62);
            this.MenorMetroRadioButton.Name = "MenorMetroRadioButton";
            this.MenorMetroRadioButton.Size = new System.Drawing.Size(140, 15);
            this.MenorMetroRadioButton.TabIndex = 0;
            this.MenorMetroRadioButton.Text = "Menor a mayor precio";
            this.MenorMetroRadioButton.UseSelectable = true;
            // 
            // MayorMetroRadioButton
            // 
            this.MayorMetroRadioButton.AutoSize = true;
            this.MayorMetroRadioButton.Location = new System.Drawing.Point(17, 41);
            this.MayorMetroRadioButton.Name = "MayorMetroRadioButton";
            this.MayorMetroRadioButton.Size = new System.Drawing.Size(140, 15);
            this.MayorMetroRadioButton.TabIndex = 0;
            this.MayorMetroRadioButton.Text = "Mayor a menor precio";
            this.MayorMetroRadioButton.UseSelectable = true;
            // 
            // AlfaMetroRadioButton
            // 
            this.AlfaMetroRadioButton.AutoSize = true;
            this.AlfaMetroRadioButton.Checked = true;
            this.AlfaMetroRadioButton.Location = new System.Drawing.Point(17, 20);
            this.AlfaMetroRadioButton.Name = "AlfaMetroRadioButton";
            this.AlfaMetroRadioButton.Size = new System.Drawing.Size(77, 15);
            this.AlfaMetroRadioButton.TabIndex = 0;
            this.AlfaMetroRadioButton.TabStop = true;
            this.AlfaMetroRadioButton.Text = "Alfabético";
            this.AlfaMetroRadioButton.UseSelectable = true;
            // 
            // FrmOpcionesListadoBombones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 385);
            this.Controls.Add(this.ListarMetroButton);
            this.Controls.Add(this.AgrupadoMetroCheckBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmOpcionesListadoBombones";
            this.Text = "Opciones Listado Bombones";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton ListarMetroButton;
        private MetroFramework.Controls.MetroCheckBox AgrupadoMetroCheckBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroRadioButton MenorMetroRadioButton;
        private MetroFramework.Controls.MetroRadioButton MayorMetroRadioButton;
        private MetroFramework.Controls.MetroRadioButton AlfaMetroRadioButton;
    }
}