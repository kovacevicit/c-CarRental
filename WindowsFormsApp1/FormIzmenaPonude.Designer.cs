namespace WindowsFormsApp1
{
    partial class FormIzmenaPonude
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
            this.cmbUIDAutaIzmena = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNovaCenaPonuda = new System.Windows.Forms.TextBox();
            this.dtpDatumOdIzmenaPonuda = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDatumDoIzmenaPonuda = new System.Windows.Forms.DateTimePicker();
            this.btnSacuvajNovuPonudu = new System.Windows.Forms.Button();
            this.btnVratiSeIzIzmenePonude = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbUIDAutaIzmena
            // 
            this.cmbUIDAutaIzmena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUIDAutaIzmena.FormattingEnabled = true;
            this.cmbUIDAutaIzmena.Location = new System.Drawing.Point(17, 57);
            this.cmbUIDAutaIzmena.Name = "cmbUIDAutaIzmena";
            this.cmbUIDAutaIzmena.Size = new System.Drawing.Size(368, 28);
            this.cmbUIDAutaIzmena.TabIndex = 0;
            this.cmbUIDAutaIzmena.SelectedIndexChanged += new System.EventHandler(this.cmbUIDAutaIzmena_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Izaberi ponudu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cena po danu";
            // 
            // txtNovaCenaPonuda
            // 
            this.txtNovaCenaPonuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNovaCenaPonuda.Location = new System.Drawing.Point(12, 124);
            this.txtNovaCenaPonuda.Name = "txtNovaCenaPonuda";
            this.txtNovaCenaPonuda.Size = new System.Drawing.Size(168, 26);
            this.txtNovaCenaPonuda.TabIndex = 5;
            this.txtNovaCenaPonuda.TextChanged += new System.EventHandler(this.txtNovaCenaPonuda_TextChanged);
            // 
            // dtpDatumOdIzmenaPonuda
            // 
            this.dtpDatumOdIzmenaPonuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatumOdIzmenaPonuda.Location = new System.Drawing.Point(253, 124);
            this.dtpDatumOdIzmenaPonuda.Name = "dtpDatumOdIzmenaPonuda";
            this.dtpDatumOdIzmenaPonuda.Size = new System.Drawing.Size(291, 26);
            this.dtpDatumOdIzmenaPonuda.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(248, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Datum od";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(248, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Datum do";
            // 
            // dtpDatumDoIzmenaPonuda
            // 
            this.dtpDatumDoIzmenaPonuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatumDoIzmenaPonuda.Location = new System.Drawing.Point(253, 186);
            this.dtpDatumDoIzmenaPonuda.Name = "dtpDatumDoIzmenaPonuda";
            this.dtpDatumDoIzmenaPonuda.Size = new System.Drawing.Size(291, 26);
            this.dtpDatumDoIzmenaPonuda.TabIndex = 9;
            // 
            // btnSacuvajNovuPonudu
            // 
            this.btnSacuvajNovuPonudu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvajNovuPonudu.Location = new System.Drawing.Point(25, 174);
            this.btnSacuvajNovuPonudu.Name = "btnSacuvajNovuPonudu";
            this.btnSacuvajNovuPonudu.Size = new System.Drawing.Size(141, 38);
            this.btnSacuvajNovuPonudu.TabIndex = 10;
            this.btnSacuvajNovuPonudu.Text = "Sacuvaj";
            this.btnSacuvajNovuPonudu.UseVisualStyleBackColor = true;
            this.btnSacuvajNovuPonudu.Click += new System.EventHandler(this.btnSacuvajNovuPonudu_Click);
            // 
            // btnVratiSeIzIzmenePonude
            // 
            this.btnVratiSeIzIzmenePonude.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVratiSeIzIzmenePonude.Location = new System.Drawing.Point(25, 228);
            this.btnVratiSeIzIzmenePonude.Name = "btnVratiSeIzIzmenePonude";
            this.btnVratiSeIzIzmenePonude.Size = new System.Drawing.Size(141, 38);
            this.btnVratiSeIzIzmenePonude.TabIndex = 11;
            this.btnVratiSeIzIzmenePonude.Text = "Vrati se";
            this.btnVratiSeIzIzmenePonude.UseVisualStyleBackColor = true;
            this.btnVratiSeIzIzmenePonude.Click += new System.EventHandler(this.btnVratiSeIzIzmenePonude_Click);
            // 
            // FormIzmenaPonude
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 332);
            this.Controls.Add(this.btnVratiSeIzIzmenePonude);
            this.Controls.Add(this.btnSacuvajNovuPonudu);
            this.Controls.Add(this.dtpDatumDoIzmenaPonuda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpDatumOdIzmenaPonuda);
            this.Controls.Add(this.txtNovaCenaPonuda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbUIDAutaIzmena);
            this.Name = "FormIzmenaPonude";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormIzmenaPonude";
            this.Load += new System.EventHandler(this.FormIzmenaPonude_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbUIDAutaIzmena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNovaCenaPonuda;
        private System.Windows.Forms.DateTimePicker dtpDatumOdIzmenaPonuda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDatumDoIzmenaPonuda;
        private System.Windows.Forms.Button btnSacuvajNovuPonudu;
        private System.Windows.Forms.Button btnVratiSeIzIzmenePonude;
    }
}