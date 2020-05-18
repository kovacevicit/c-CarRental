namespace WindowsFormsApp1
{
    partial class FormBrisanjeRezervacije
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbUIDKupcaBrisanjeRezervacija = new System.Windows.Forms.ComboBox();
            this.btnObrisiRezervaciju = new System.Windows.Forms.Button();
            this.btnVratiSeSaBrisanjaRezervacije = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Izaberite rezervaciju";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbUIDKupcaBrisanjeRezervacija
            // 
            this.cmbUIDKupcaBrisanjeRezervacija.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUIDKupcaBrisanjeRezervacija.FormattingEnabled = true;
            this.cmbUIDKupcaBrisanjeRezervacija.Location = new System.Drawing.Point(9, 54);
            this.cmbUIDKupcaBrisanjeRezervacija.Name = "cmbUIDKupcaBrisanjeRezervacija";
            this.cmbUIDKupcaBrisanjeRezervacija.Size = new System.Drawing.Size(503, 28);
            this.cmbUIDKupcaBrisanjeRezervacija.TabIndex = 1;
            // 
            // btnObrisiRezervaciju
            // 
            this.btnObrisiRezervaciju.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiRezervaciju.Location = new System.Drawing.Point(13, 116);
            this.btnObrisiRezervaciju.Name = "btnObrisiRezervaciju";
            this.btnObrisiRezervaciju.Size = new System.Drawing.Size(155, 46);
            this.btnObrisiRezervaciju.TabIndex = 4;
            this.btnObrisiRezervaciju.Text = "Obrisi";
            this.btnObrisiRezervaciju.UseVisualStyleBackColor = true;
            // 
            // btnVratiSeSaBrisanjaRezervacije
            // 
            this.btnVratiSeSaBrisanjaRezervacije.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVratiSeSaBrisanjaRezervacije.Location = new System.Drawing.Point(12, 180);
            this.btnVratiSeSaBrisanjaRezervacije.Name = "btnVratiSeSaBrisanjaRezervacije";
            this.btnVratiSeSaBrisanjaRezervacije.Size = new System.Drawing.Size(164, 46);
            this.btnVratiSeSaBrisanjaRezervacije.TabIndex = 5;
            this.btnVratiSeSaBrisanjaRezervacije.Text = "Vrati se ";
            this.btnVratiSeSaBrisanjaRezervacije.UseVisualStyleBackColor = true;
            this.btnVratiSeSaBrisanjaRezervacije.Click += new System.EventHandler(this.btnVratiSeSaBrisanjaRezervacije_Click);
            // 
            // FormBrisanjeRezervacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 316);
            this.Controls.Add(this.btnVratiSeSaBrisanjaRezervacije);
            this.Controls.Add(this.btnObrisiRezervaciju);
            this.Controls.Add(this.cmbUIDKupcaBrisanjeRezervacija);
            this.Controls.Add(this.label1);
            this.Name = "FormBrisanjeRezervacije";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBrisanjeRezervacije";
            this.Load += new System.EventHandler(this.FormBrisanjeRezervacije_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbUIDKupcaBrisanjeRezervacija;
        private System.Windows.Forms.Button btnObrisiRezervaciju;
        private System.Windows.Forms.Button btnVratiSeSaBrisanjaRezervacije;
    }
}