namespace WindowsFormsApp1
{
    partial class FormIzmenaKupca
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbUIDKupca = new System.Windows.Forms.ComboBox();
            this.txtIzmenaIme = new System.Windows.Forms.TextBox();
            this.txtIzmenaPrezime = new System.Windows.Forms.TextBox();
            this.txtIzmenaJMBG = new System.Windows.Forms.TextBox();
            this.dtpDatumRodjenja = new System.Windows.Forms.DateTimePicker();
            this.txtIzmenaTelefona = new System.Windows.Forms.TextBox();
            this.btnSacuvajIzmeneKupca = new System.Windows.Forms.Button();
            this.btnVratiSeIzIzmeneKupca = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNovaSifra = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Izmena Kupca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Izaberi kupca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(419, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Prezime";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "JMBG";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Datum rodjenja";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 24);
            this.label7.TabIndex = 8;
            this.label7.Text = "Telefon";
            // 
            // cmbUIDKupca
            // 
            this.cmbUIDKupca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUIDKupca.FormattingEnabled = true;
            this.cmbUIDKupca.Location = new System.Drawing.Point(208, 57);
            this.cmbUIDKupca.Name = "cmbUIDKupca";
            this.cmbUIDKupca.Size = new System.Drawing.Size(182, 24);
            this.cmbUIDKupca.TabIndex = 9;
            this.cmbUIDKupca.SelectedIndexChanged += new System.EventHandler(this.cmbUIDKupca_SelectedIndexChanged);
            // 
            // txtIzmenaIme
            // 
            this.txtIzmenaIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIzmenaIme.Location = new System.Drawing.Point(208, 155);
            this.txtIzmenaIme.Name = "txtIzmenaIme";
            this.txtIzmenaIme.Size = new System.Drawing.Size(182, 22);
            this.txtIzmenaIme.TabIndex = 10;
            // 
            // txtIzmenaPrezime
            // 
            this.txtIzmenaPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIzmenaPrezime.Location = new System.Drawing.Point(516, 155);
            this.txtIzmenaPrezime.Name = "txtIzmenaPrezime";
            this.txtIzmenaPrezime.Size = new System.Drawing.Size(182, 22);
            this.txtIzmenaPrezime.TabIndex = 11;
            // 
            // txtIzmenaJMBG
            // 
            this.txtIzmenaJMBG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIzmenaJMBG.Location = new System.Drawing.Point(208, 206);
            this.txtIzmenaJMBG.Name = "txtIzmenaJMBG";
            this.txtIzmenaJMBG.Size = new System.Drawing.Size(182, 22);
            this.txtIzmenaJMBG.TabIndex = 12;
            // 
            // dtpDatumRodjenja
            // 
            this.dtpDatumRodjenja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatumRodjenja.Location = new System.Drawing.Point(208, 255);
            this.dtpDatumRodjenja.MaxDate = new System.DateTime(2001, 12, 31, 0, 0, 0, 0);
            this.dtpDatumRodjenja.MinDate = new System.DateTime(1950, 12, 31, 0, 0, 0, 0);
            this.dtpDatumRodjenja.Name = "dtpDatumRodjenja";
            this.dtpDatumRodjenja.Size = new System.Drawing.Size(259, 22);
            this.dtpDatumRodjenja.TabIndex = 13;
            this.dtpDatumRodjenja.Value = new System.DateTime(2001, 12, 31, 0, 0, 0, 0);
            // 
            // txtIzmenaTelefona
            // 
            this.txtIzmenaTelefona.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIzmenaTelefona.Location = new System.Drawing.Point(208, 305);
            this.txtIzmenaTelefona.Name = "txtIzmenaTelefona";
            this.txtIzmenaTelefona.Size = new System.Drawing.Size(182, 22);
            this.txtIzmenaTelefona.TabIndex = 14;
            // 
            // btnSacuvajIzmeneKupca
            // 
            this.btnSacuvajIzmeneKupca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvajIzmeneKupca.Location = new System.Drawing.Point(516, 302);
            this.btnSacuvajIzmeneKupca.Name = "btnSacuvajIzmeneKupca";
            this.btnSacuvajIzmeneKupca.Size = new System.Drawing.Size(186, 49);
            this.btnSacuvajIzmeneKupca.TabIndex = 15;
            this.btnSacuvajIzmeneKupca.Text = "Sacuvaj Izmene";
            this.btnSacuvajIzmeneKupca.UseVisualStyleBackColor = true;
            this.btnSacuvajIzmeneKupca.Click += new System.EventHandler(this.btnSacuvajIzmeneKupca_Click);
            // 
            // btnVratiSeIzIzmeneKupca
            // 
            this.btnVratiSeIzIzmeneKupca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVratiSeIzIzmeneKupca.Location = new System.Drawing.Point(516, 242);
            this.btnVratiSeIzIzmeneKupca.Name = "btnVratiSeIzIzmeneKupca";
            this.btnVratiSeIzIzmeneKupca.Size = new System.Drawing.Size(186, 49);
            this.btnVratiSeIzIzmeneKupca.TabIndex = 16;
            this.btnVratiSeIzIzmeneKupca.Text = "Vrati se";
            this.btnVratiSeIzIzmeneKupca.UseVisualStyleBackColor = true;
            this.btnVratiSeIzIzmeneKupca.Click += new System.EventHandler(this.btnVratiSeIzIzmeneKupca_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 24);
            this.label8.TabIndex = 17;
            this.label8.Text = "Sifra";
            // 
            // txtNovaSifra
            // 
            this.txtNovaSifra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNovaSifra.Location = new System.Drawing.Point(208, 109);
            this.txtNovaSifra.Name = "txtNovaSifra";
            this.txtNovaSifra.Size = new System.Drawing.Size(182, 22);
            this.txtNovaSifra.TabIndex = 18;
            // 
            // FormIzmenaKupca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 398);
            this.Controls.Add(this.txtNovaSifra);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnVratiSeIzIzmeneKupca);
            this.Controls.Add(this.btnSacuvajIzmeneKupca);
            this.Controls.Add(this.txtIzmenaTelefona);
            this.Controls.Add(this.dtpDatumRodjenja);
            this.Controls.Add(this.txtIzmenaJMBG);
            this.Controls.Add(this.txtIzmenaPrezime);
            this.Controls.Add(this.txtIzmenaIme);
            this.Controls.Add(this.cmbUIDKupca);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(730, 436);
            this.MinimumSize = new System.Drawing.Size(730, 436);
            this.Name = "FormIzmenaKupca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormIzmenaKupca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbUIDKupca;
        private System.Windows.Forms.TextBox txtIzmenaIme;
        private System.Windows.Forms.TextBox txtIzmenaPrezime;
        private System.Windows.Forms.TextBox txtIzmenaJMBG;
        private System.Windows.Forms.DateTimePicker dtpDatumRodjenja;
        private System.Windows.Forms.TextBox txtIzmenaTelefona;
        private System.Windows.Forms.Button btnSacuvajIzmeneKupca;
        private System.Windows.Forms.Button btnVratiSeIzIzmeneKupca;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNovaSifra;
    }
}