namespace WindowsFormsApp1
{
    partial class FormNoviAuto
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
            this.txtUnesiMarku = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUnesiModel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbOdaberiGodiste = new System.Windows.Forms.ComboBox();
            this.cmbOdaberiKaroseriju = new System.Windows.Forms.ComboBox();
            this.cmbOdaberiKubikazu = new System.Windows.Forms.ComboBox();
            this.cmbOdaberiPogon = new System.Windows.Forms.ComboBox();
            this.cmbOdaberiMenjac = new System.Windows.Forms.ComboBox();
            this.cmbOdaberiBrojVrata = new System.Windows.Forms.ComboBox();
            this.cmbOdaberiGorivo = new System.Windows.Forms.ComboBox();
            this.btnPotvrdiNoviAuto = new System.Windows.Forms.Button();
            this.btnVratiSeIzNovogAuta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unesite Marku:";
            // 
            // txtUnesiMarku
            // 
            this.txtUnesiMarku.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnesiMarku.Location = new System.Drawing.Point(17, 40);
            this.txtUnesiMarku.Name = "txtUnesiMarku";
            this.txtUnesiMarku.Size = new System.Drawing.Size(174, 26);
            this.txtUnesiMarku.TabIndex = 1;
            this.txtUnesiMarku.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(215, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Unesite Model";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtUnesiModel
            // 
            this.txtUnesiModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnesiModel.Location = new System.Drawing.Point(219, 40);
            this.txtUnesiModel.Name = "txtUnesiModel";
            this.txtUnesiModel.Size = new System.Drawing.Size(174, 26);
            this.txtUnesiModel.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Odaberite godiste";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Odaberite kubikazu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Odaberite karoseriju";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(215, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Odaberite gorivo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(215, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 24);
            this.label7.TabIndex = 8;
            this.label7.Text = "Odaberite broj vrata";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 24);
            this.label9.TabIndex = 10;
            this.label9.Text = "Odaberite pogon";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(215, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 24);
            this.label10.TabIndex = 11;
            this.label10.Text = "Odaberite menjac";
            // 
            // cmbOdaberiGodiste
            // 
            this.cmbOdaberiGodiste.DropDownHeight = 100;
            this.cmbOdaberiGodiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOdaberiGodiste.FormattingEnabled = true;
            this.cmbOdaberiGodiste.IntegralHeight = false;
            this.cmbOdaberiGodiste.ItemHeight = 20;
            this.cmbOdaberiGodiste.Items.AddRange(new object[] {
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019"});
            this.cmbOdaberiGodiste.Location = new System.Drawing.Point(17, 93);
            this.cmbOdaberiGodiste.MaxDropDownItems = 5;
            this.cmbOdaberiGodiste.Name = "cmbOdaberiGodiste";
            this.cmbOdaberiGodiste.Size = new System.Drawing.Size(174, 28);
            this.cmbOdaberiGodiste.TabIndex = 12;
            // 
            // cmbOdaberiKaroseriju
            // 
            this.cmbOdaberiKaroseriju.DropDownHeight = 100;
            this.cmbOdaberiKaroseriju.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOdaberiKaroseriju.FormattingEnabled = true;
            this.cmbOdaberiKaroseriju.IntegralHeight = false;
            this.cmbOdaberiKaroseriju.Items.AddRange(new object[] {
            "Limuzina",
            "Hecbek",
            "Karavan",
            "Kupe",
            "Kabriolet/Roadster",
            "MiniVan",
            "Dzip",
            "Pickup"});
            this.cmbOdaberiKaroseriju.Location = new System.Drawing.Point(17, 151);
            this.cmbOdaberiKaroseriju.MaxDropDownItems = 5;
            this.cmbOdaberiKaroseriju.Name = "cmbOdaberiKaroseriju";
            this.cmbOdaberiKaroseriju.Size = new System.Drawing.Size(174, 28);
            this.cmbOdaberiKaroseriju.TabIndex = 13;
            // 
            // cmbOdaberiKubikazu
            // 
            this.cmbOdaberiKubikazu.DropDownHeight = 100;
            this.cmbOdaberiKubikazu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOdaberiKubikazu.FormattingEnabled = true;
            this.cmbOdaberiKubikazu.IntegralHeight = false;
            this.cmbOdaberiKubikazu.Items.AddRange(new object[] {
            "500 cm3",
            "1150 cm3",
            "1300 cm3",
            "1600 cm3",
            "1800 cm3",
            "2000 cm3",
            "2500 cm3",
            "3000 cm3",
            "3500 cm3",
            "4000 cm3"});
            this.cmbOdaberiKubikazu.Location = new System.Drawing.Point(16, 209);
            this.cmbOdaberiKubikazu.MaxDropDownItems = 5;
            this.cmbOdaberiKubikazu.Name = "cmbOdaberiKubikazu";
            this.cmbOdaberiKubikazu.Size = new System.Drawing.Size(175, 28);
            this.cmbOdaberiKubikazu.TabIndex = 14;
            // 
            // cmbOdaberiPogon
            // 
            this.cmbOdaberiPogon.DropDownHeight = 100;
            this.cmbOdaberiPogon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOdaberiPogon.FormattingEnabled = true;
            this.cmbOdaberiPogon.IntegralHeight = false;
            this.cmbOdaberiPogon.Items.AddRange(new object[] {
            "Prednji",
            "Zadnji",
            "4x4",
            "4X4 Reduktor"});
            this.cmbOdaberiPogon.Location = new System.Drawing.Point(16, 267);
            this.cmbOdaberiPogon.MaxDropDownItems = 5;
            this.cmbOdaberiPogon.Name = "cmbOdaberiPogon";
            this.cmbOdaberiPogon.Size = new System.Drawing.Size(175, 28);
            this.cmbOdaberiPogon.TabIndex = 15;
            // 
            // cmbOdaberiMenjac
            // 
            this.cmbOdaberiMenjac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOdaberiMenjac.FormattingEnabled = true;
            this.cmbOdaberiMenjac.Items.AddRange(new object[] {
            "Manuelni 4",
            "Manuelni 5",
            "Manuelni 6",
            "Poluautomatski",
            "Automatski"});
            this.cmbOdaberiMenjac.Location = new System.Drawing.Point(219, 96);
            this.cmbOdaberiMenjac.Name = "cmbOdaberiMenjac";
            this.cmbOdaberiMenjac.Size = new System.Drawing.Size(175, 28);
            this.cmbOdaberiMenjac.TabIndex = 16;
            // 
            // cmbOdaberiBrojVrata
            // 
            this.cmbOdaberiBrojVrata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOdaberiBrojVrata.FormattingEnabled = true;
            this.cmbOdaberiBrojVrata.Items.AddRange(new object[] {
            "2/3",
            "4/5"});
            this.cmbOdaberiBrojVrata.Location = new System.Drawing.Point(219, 154);
            this.cmbOdaberiBrojVrata.Name = "cmbOdaberiBrojVrata";
            this.cmbOdaberiBrojVrata.Size = new System.Drawing.Size(175, 28);
            this.cmbOdaberiBrojVrata.TabIndex = 17;
            // 
            // cmbOdaberiGorivo
            // 
            this.cmbOdaberiGorivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOdaberiGorivo.FormattingEnabled = true;
            this.cmbOdaberiGorivo.Items.AddRange(new object[] {
            "Benzin",
            "Dizel",
            "Benzin+Gas",
            "Metan CNG",
            "Elektricni Pogon",
            "Hibridni Pogon"});
            this.cmbOdaberiGorivo.Location = new System.Drawing.Point(219, 212);
            this.cmbOdaberiGorivo.Name = "cmbOdaberiGorivo";
            this.cmbOdaberiGorivo.Size = new System.Drawing.Size(175, 28);
            this.cmbOdaberiGorivo.TabIndex = 18;
            // 
            // btnPotvrdiNoviAuto
            // 
            this.btnPotvrdiNoviAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPotvrdiNoviAuto.Location = new System.Drawing.Point(461, 40);
            this.btnPotvrdiNoviAuto.Name = "btnPotvrdiNoviAuto";
            this.btnPotvrdiNoviAuto.Size = new System.Drawing.Size(136, 53);
            this.btnPotvrdiNoviAuto.TabIndex = 19;
            this.btnPotvrdiNoviAuto.Text = "Potvrdi";
            this.btnPotvrdiNoviAuto.UseVisualStyleBackColor = true;
            this.btnPotvrdiNoviAuto.Click += new System.EventHandler(this.btnPotvrdiNoviAuto_Click);
            // 
            // btnVratiSeIzNovogAuta
            // 
            this.btnVratiSeIzNovogAuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVratiSeIzNovogAuta.Location = new System.Drawing.Point(461, 124);
            this.btnVratiSeIzNovogAuta.Name = "btnVratiSeIzNovogAuta";
            this.btnVratiSeIzNovogAuta.Size = new System.Drawing.Size(136, 53);
            this.btnVratiSeIzNovogAuta.TabIndex = 20;
            this.btnVratiSeIzNovogAuta.Text = "Vrati se";
            this.btnVratiSeIzNovogAuta.UseVisualStyleBackColor = true;
            this.btnVratiSeIzNovogAuta.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormNoviAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 328);
            this.Controls.Add(this.btnVratiSeIzNovogAuta);
            this.Controls.Add(this.btnPotvrdiNoviAuto);
            this.Controls.Add(this.cmbOdaberiGorivo);
            this.Controls.Add(this.cmbOdaberiBrojVrata);
            this.Controls.Add(this.cmbOdaberiMenjac);
            this.Controls.Add(this.cmbOdaberiPogon);
            this.Controls.Add(this.cmbOdaberiKubikazu);
            this.Controls.Add(this.cmbOdaberiKaroseriju);
            this.Controls.Add(this.cmbOdaberiGodiste);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUnesiModel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUnesiMarku);
            this.Controls.Add(this.label1);
            this.Name = "FormNoviAuto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNoviAuto";
            this.Load += new System.EventHandler(this.FormNoviAuto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUnesiMarku;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUnesiModel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbOdaberiGodiste;
        private System.Windows.Forms.ComboBox cmbOdaberiKaroseriju;
        private System.Windows.Forms.ComboBox cmbOdaberiKubikazu;
        private System.Windows.Forms.ComboBox cmbOdaberiPogon;
        private System.Windows.Forms.ComboBox cmbOdaberiMenjac;
        private System.Windows.Forms.ComboBox cmbOdaberiBrojVrata;
        private System.Windows.Forms.ComboBox cmbOdaberiGorivo;
        private System.Windows.Forms.Button btnPotvrdiNoviAuto;
        private System.Windows.Forms.Button btnVratiSeIzNovogAuta;
    }
}