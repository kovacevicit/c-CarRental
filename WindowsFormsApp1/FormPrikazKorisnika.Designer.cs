namespace WindowsFormsApp1
{
    partial class FormPrikazKorisnika
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnObrisiRezervaciju = new System.Windows.Forms.Button();
            this.btnNovaRezervacija = new System.Windows.Forms.Button();
            this.btnVratiSe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(183, 28);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Trenutne rezervacije";
            // 
            // btnObrisiRezervaciju
            // 
            this.btnObrisiRezervaciju.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiRezervaciju.Location = new System.Drawing.Point(203, 39);
            this.btnObrisiRezervaciju.Name = "btnObrisiRezervaciju";
            this.btnObrisiRezervaciju.Size = new System.Drawing.Size(125, 27);
            this.btnObrisiRezervaciju.TabIndex = 2;
            this.btnObrisiRezervaciju.Text = "Obrisi";
            this.btnObrisiRezervaciju.UseVisualStyleBackColor = true;
            this.btnObrisiRezervaciju.Click += new System.EventHandler(this.btnObrisiRezervaciju_Click);
            // 
            // btnNovaRezervacija
            // 
            this.btnNovaRezervacija.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovaRezervacija.Location = new System.Drawing.Point(93, 114);
            this.btnNovaRezervacija.Name = "btnNovaRezervacija";
            this.btnNovaRezervacija.Size = new System.Drawing.Size(169, 60);
            this.btnNovaRezervacija.TabIndex = 3;
            this.btnNovaRezervacija.Text = "Nova Rezervacija";
            this.btnNovaRezervacija.UseVisualStyleBackColor = true;
            this.btnNovaRezervacija.Click += new System.EventHandler(this.btnNovaRezervacija_Click_1);
            // 
            // btnVratiSe
            // 
            this.btnVratiSe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVratiSe.Location = new System.Drawing.Point(12, 259);
            this.btnVratiSe.Name = "btnVratiSe";
            this.btnVratiSe.Size = new System.Drawing.Size(169, 60);
            this.btnVratiSe.TabIndex = 4;
            this.btnVratiSe.Text = "Vrati se ";
            this.btnVratiSe.UseVisualStyleBackColor = true;
            this.btnVratiSe.Click += new System.EventHandler(this.btnVratiSe_Click);
            // 
            // FormPrikazKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 331);
            this.Controls.Add(this.btnVratiSe);
            this.Controls.Add(this.btnNovaRezervacija);
            this.Controls.Add(this.btnObrisiRezervaciju);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "FormPrikazKorisnika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPikazKorisnika";
            this.Load += new System.EventHandler(this.FormPrikazKorisnika_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnObrisiRezervaciju;
        private System.Windows.Forms.Button btnNovaRezervacija;
        private System.Windows.Forms.Button btnVratiSe;
    }
}