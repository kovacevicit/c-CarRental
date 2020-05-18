namespace WindowsFormsApp1
{
    partial class FormRegistracijaKorisnika
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
            this.txtNoviKupacPassword = new System.Windows.Forms.TextBox();
            this.txtNoviKupacUser = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnVratiSeSaRegistracije = new System.Windows.Forms.Button();
            this.btnRegistrujKorisnika = new System.Windows.Forms.Button();
            this.dtpNoviKupacRodjenje = new System.Windows.Forms.DateTimePicker();
            this.txtNoviKupacTelefon = new System.Windows.Forms.TextBox();
            this.txtNoviKupacJMBG = new System.Windows.Forms.TextBox();
            this.txtNoviKupacPrezime = new System.Windows.Forms.TextBox();
            this.txtNoviKupacIme = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNoviKupacPassword
            // 
            this.txtNoviKupacPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoviKupacPassword.Location = new System.Drawing.Point(232, 90);
            this.txtNoviKupacPassword.Name = "txtNoviKupacPassword";
            this.txtNoviKupacPassword.PasswordChar = '*';
            this.txtNoviKupacPassword.Size = new System.Drawing.Size(196, 26);
            this.txtNoviKupacPassword.TabIndex = 31;
            // 
            // txtNoviKupacUser
            // 
            this.txtNoviKupacUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoviKupacUser.Location = new System.Drawing.Point(10, 90);
            this.txtNoviKupacUser.Name = "txtNoviKupacUser";
            this.txtNoviKupacUser.Size = new System.Drawing.Size(196, 26);
            this.txtNoviKupacUser.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(228, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 24);
            this.label7.TabIndex = 29;
            this.label7.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 24);
            this.label6.TabIndex = 28;
            this.label6.Text = "Username";
            // 
            // btnVratiSeSaRegistracije
            // 
            this.btnVratiSeSaRegistracije.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVratiSeSaRegistracije.Location = new System.Drawing.Point(266, 282);
            this.btnVratiSeSaRegistracije.Name = "btnVratiSeSaRegistracije";
            this.btnVratiSeSaRegistracije.Size = new System.Drawing.Size(214, 42);
            this.btnVratiSeSaRegistracije.TabIndex = 27;
            this.btnVratiSeSaRegistracije.Text = "Vrati se";
            this.btnVratiSeSaRegistracije.UseVisualStyleBackColor = true;
            this.btnVratiSeSaRegistracije.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRegistrujKorisnika
            // 
            this.btnRegistrujKorisnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrujKorisnika.Location = new System.Drawing.Point(266, 217);
            this.btnRegistrujKorisnika.Name = "btnRegistrujKorisnika";
            this.btnRegistrujKorisnika.Size = new System.Drawing.Size(214, 42);
            this.btnRegistrujKorisnika.TabIndex = 26;
            this.btnRegistrujKorisnika.Text = "Registruj se";
            this.btnRegistrujKorisnika.UseVisualStyleBackColor = true;
            this.btnRegistrujKorisnika.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpNoviKupacRodjenje
            // 
            this.dtpNoviKupacRodjenje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNoviKupacRodjenje.Location = new System.Drawing.Point(232, 159);
            this.dtpNoviKupacRodjenje.MaxDate = new System.DateTime(2001, 12, 31, 0, 0, 0, 0);
            this.dtpNoviKupacRodjenje.MinDate = new System.DateTime(1949, 12, 31, 0, 0, 0, 0);
            this.dtpNoviKupacRodjenje.Name = "dtpNoviKupacRodjenje";
            this.dtpNoviKupacRodjenje.Size = new System.Drawing.Size(280, 26);
            this.dtpNoviKupacRodjenje.TabIndex = 25;
            this.dtpNoviKupacRodjenje.Value = new System.DateTime(1999, 12, 31, 0, 0, 0, 0);
            // 
            // txtNoviKupacTelefon
            // 
            this.txtNoviKupacTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoviKupacTelefon.Location = new System.Drawing.Point(10, 217);
            this.txtNoviKupacTelefon.Name = "txtNoviKupacTelefon";
            this.txtNoviKupacTelefon.Size = new System.Drawing.Size(196, 26);
            this.txtNoviKupacTelefon.TabIndex = 24;
            // 
            // txtNoviKupacJMBG
            // 
            this.txtNoviKupacJMBG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoviKupacJMBG.Location = new System.Drawing.Point(10, 161);
            this.txtNoviKupacJMBG.Name = "txtNoviKupacJMBG";
            this.txtNoviKupacJMBG.Size = new System.Drawing.Size(196, 26);
            this.txtNoviKupacJMBG.TabIndex = 23;
            // 
            // txtNoviKupacPrezime
            // 
            this.txtNoviKupacPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoviKupacPrezime.Location = new System.Drawing.Point(232, 34);
            this.txtNoviKupacPrezime.Name = "txtNoviKupacPrezime";
            this.txtNoviKupacPrezime.Size = new System.Drawing.Size(202, 26);
            this.txtNoviKupacPrezime.TabIndex = 22;
            // 
            // txtNoviKupacIme
            // 
            this.txtNoviKupacIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoviKupacIme.Location = new System.Drawing.Point(10, 34);
            this.txtNoviKupacIme.Name = "txtNoviKupacIme";
            this.txtNoviKupacIme.Size = new System.Drawing.Size(196, 26);
            this.txtNoviKupacIme.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 24);
            this.label5.TabIndex = 20;
            this.label5.Text = "Telefon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(228, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 24);
            this.label4.TabIndex = 19;
            this.label4.Text = "Datum Rodjenja";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "JMBG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(228, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Prezime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ime";
            // 
            // FormRegistracijaKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 360);
            this.Controls.Add(this.txtNoviKupacPassword);
            this.Controls.Add(this.txtNoviKupacUser);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnVratiSeSaRegistracije);
            this.Controls.Add(this.btnRegistrujKorisnika);
            this.Controls.Add(this.dtpNoviKupacRodjenje);
            this.Controls.Add(this.txtNoviKupacTelefon);
            this.Controls.Add(this.txtNoviKupacJMBG);
            this.Controls.Add(this.txtNoviKupacPrezime);
            this.Controls.Add(this.txtNoviKupacIme);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormRegistracijaKorisnika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRegistracijaKorisnika";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormRegistracijaKorisnika_FormClosing);
            this.Load += new System.EventHandler(this.FormRegistracijaKorisnika_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNoviKupacPassword;
        private System.Windows.Forms.TextBox txtNoviKupacUser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnVratiSeSaRegistracije;
        private System.Windows.Forms.Button btnRegistrujKorisnika;
        private System.Windows.Forms.DateTimePicker dtpNoviKupacRodjenje;
        private System.Windows.Forms.TextBox txtNoviKupacTelefon;
        private System.Windows.Forms.TextBox txtNoviKupacJMBG;
        private System.Windows.Forms.TextBox txtNoviKupacPrezime;
        private System.Windows.Forms.TextBox txtNoviKupacIme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}