namespace WindowsFormsApp1
{
    partial class FormIzmenaRezervacije
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
            this.dtpDatumOd = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDatumDo = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIzmenaCeneRezervacije = new System.Windows.Forms.TextBox();
            this.btnSacuvajRezervaciju = new System.Windows.Forms.Button();
            this.btnVratiSeSaRezervacije = new System.Windows.Forms.Button();
            this.cmbRezervacija = new System.Windows.Forms.ComboBox();
            this.cmbAuto = new System.Windows.Forms.ComboBox();
            this.cmbKupac = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Izaberi rezervaciju";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Auto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kupac";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 190);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Datum Od";
            // 
            // dtpDatumOd
            // 
            this.dtpDatumOd.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatumOd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatumOd.Location = new System.Drawing.Point(12, 218);
            this.dtpDatumOd.Name = "dtpDatumOd";
            this.dtpDatumOd.Size = new System.Drawing.Size(261, 22);
            this.dtpDatumOd.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 243);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Datum Do";
            // 
            // dtpDatumDo
            // 
            this.dtpDatumDo.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatumDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatumDo.Location = new System.Drawing.Point(12, 271);
            this.dtpDatumDo.Name = "dtpDatumDo";
            this.dtpDatumDo.Size = new System.Drawing.Size(261, 22);
            this.dtpDatumDo.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(348, 71);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Cena";
            // 
            // txtIzmenaCeneRezervacije
            // 
            this.txtIzmenaCeneRezervacije.Location = new System.Drawing.Point(353, 99);
            this.txtIzmenaCeneRezervacije.Name = "txtIzmenaCeneRezervacije";
            this.txtIzmenaCeneRezervacije.Size = new System.Drawing.Size(176, 29);
            this.txtIzmenaCeneRezervacije.TabIndex = 14;
            // 
            // btnSacuvajRezervaciju
            // 
            this.btnSacuvajRezervaciju.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvajRezervaciju.Location = new System.Drawing.Point(353, 202);
            this.btnSacuvajRezervaciju.Name = "btnSacuvajRezervaciju";
            this.btnSacuvajRezervaciju.Size = new System.Drawing.Size(218, 38);
            this.btnSacuvajRezervaciju.TabIndex = 15;
            this.btnSacuvajRezervaciju.Text = "Sacuvaj";
            this.btnSacuvajRezervaciju.UseVisualStyleBackColor = true;
            this.btnSacuvajRezervaciju.Click += new System.EventHandler(this.btnSacuvajRezervaciju_Click);
            // 
            // btnVratiSeSaRezervacije
            // 
            this.btnVratiSeSaRezervacije.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVratiSeSaRezervacije.Location = new System.Drawing.Point(353, 255);
            this.btnVratiSeSaRezervacije.Name = "btnVratiSeSaRezervacije";
            this.btnVratiSeSaRezervacije.Size = new System.Drawing.Size(218, 38);
            this.btnVratiSeSaRezervacije.TabIndex = 16;
            this.btnVratiSeSaRezervacije.Text = "Vrati se";
            this.btnVratiSeSaRezervacije.UseVisualStyleBackColor = true;
            this.btnVratiSeSaRezervacije.Click += new System.EventHandler(this.btnVratiSeSaRezervacije_Click);
            // 
            // cmbRezervacija
            // 
            this.cmbRezervacija.DropDownHeight = 144;
            this.cmbRezervacija.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRezervacija.FormattingEnabled = true;
            this.cmbRezervacija.IntegralHeight = false;
            this.cmbRezervacija.ItemHeight = 20;
            this.cmbRezervacija.Location = new System.Drawing.Point(20, 38);
            this.cmbRezervacija.Name = "cmbRezervacija";
            this.cmbRezervacija.Size = new System.Drawing.Size(398, 28);
            this.cmbRezervacija.TabIndex = 17;
            // 
            // cmbAuto
            // 
            this.cmbAuto.DropDownHeight = 144;
            this.cmbAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAuto.FormattingEnabled = true;
            this.cmbAuto.IntegralHeight = false;
            this.cmbAuto.ItemHeight = 20;
            this.cmbAuto.Location = new System.Drawing.Point(20, 99);
            this.cmbAuto.Name = "cmbAuto";
            this.cmbAuto.Size = new System.Drawing.Size(196, 28);
            this.cmbAuto.TabIndex = 18;
            // 
            // cmbKupac
            // 
            this.cmbKupac.DropDownHeight = 144;
            this.cmbKupac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKupac.FormattingEnabled = true;
            this.cmbKupac.IntegralHeight = false;
            this.cmbKupac.ItemHeight = 20;
            this.cmbKupac.Location = new System.Drawing.Point(20, 159);
            this.cmbKupac.Name = "cmbKupac";
            this.cmbKupac.Size = new System.Drawing.Size(196, 28);
            this.cmbKupac.TabIndex = 19;
            // 
            // FormIzmenaRezervacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 361);
            this.Controls.Add(this.cmbKupac);
            this.Controls.Add(this.cmbAuto);
            this.Controls.Add(this.cmbRezervacija);
            this.Controls.Add(this.btnVratiSeSaRezervacije);
            this.Controls.Add(this.btnSacuvajRezervaciju);
            this.Controls.Add(this.txtIzmenaCeneRezervacije);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpDatumDo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpDatumOd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormIzmenaRezervacije";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormIzmenaRezervacije";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDatumOd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDatumDo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIzmenaCeneRezervacije;
        private System.Windows.Forms.Button btnSacuvajRezervaciju;
        private System.Windows.Forms.Button btnVratiSeSaRezervacije;
        private System.Windows.Forms.ComboBox cmbRezervacija;
        private System.Windows.Forms.ComboBox cmbAuto;
        private System.Windows.Forms.ComboBox cmbKupac;
    }
}