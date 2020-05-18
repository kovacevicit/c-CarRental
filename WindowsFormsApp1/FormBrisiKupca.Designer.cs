namespace WindowsFormsApp1
{
    partial class FormBrisiKupca
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
            this.btnVratiSeSaBrisanjaKupca = new System.Windows.Forms.Button();
            this.btnBrisiKupca = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbKupac = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnVratiSeSaBrisanjaKupca
            // 
            this.btnVratiSeSaBrisanjaKupca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVratiSeSaBrisanjaKupca.Location = new System.Drawing.Point(217, 95);
            this.btnVratiSeSaBrisanjaKupca.Name = "btnVratiSeSaBrisanjaKupca";
            this.btnVratiSeSaBrisanjaKupca.Size = new System.Drawing.Size(147, 41);
            this.btnVratiSeSaBrisanjaKupca.TabIndex = 7;
            this.btnVratiSeSaBrisanjaKupca.Text = "Vrati se";
            this.btnVratiSeSaBrisanjaKupca.UseVisualStyleBackColor = true;
            this.btnVratiSeSaBrisanjaKupca.Click += new System.EventHandler(this.btnVratiSeSaBrisanjaKupca_Click);
            // 
            // btnBrisiKupca
            // 
            this.btnBrisiKupca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrisiKupca.Location = new System.Drawing.Point(46, 95);
            this.btnBrisiKupca.Name = "btnBrisiKupca";
            this.btnBrisiKupca.Size = new System.Drawing.Size(147, 41);
            this.btnBrisiKupca.TabIndex = 6;
            this.btnBrisiKupca.Text = "Obrisi";
            this.btnBrisiKupca.UseVisualStyleBackColor = true;
            this.btnBrisiKupca.Click += new System.EventHandler(this.btnBrisiKupca_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Izaberite kupca";
            // 
            // cmbKupac
            // 
            this.cmbKupac.DropDownHeight = 144;
            this.cmbKupac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKupac.FormattingEnabled = true;
            this.cmbKupac.IntegralHeight = false;
            this.cmbKupac.ItemHeight = 20;
            this.cmbKupac.Location = new System.Drawing.Point(46, 50);
            this.cmbKupac.Name = "cmbKupac";
            this.cmbKupac.Size = new System.Drawing.Size(275, 28);
            this.cmbKupac.TabIndex = 8;
            // 
            // FormBrisiKupca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 192);
            this.Controls.Add(this.cmbKupac);
            this.Controls.Add(this.btnVratiSeSaBrisanjaKupca);
            this.Controls.Add(this.btnBrisiKupca);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(434, 230);
            this.MinimumSize = new System.Drawing.Size(434, 230);
            this.Name = "FormBrisiKupca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBrisiKupca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVratiSeSaBrisanjaKupca;
        private System.Windows.Forms.Button btnBrisiKupca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbKupac;
    }
}