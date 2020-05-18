namespace WindowsFormsApp1
{
    partial class FormIzmenaAuta
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
            this.cmbAutoUID = new System.Windows.Forms.ComboBox();
            this.cmbIzmenaGodiste = new System.Windows.Forms.ComboBox();
            this.cmbIzmenaKubikaze = new System.Windows.Forms.ComboBox();
            this.cmbIzmenaPogona = new System.Windows.Forms.ComboBox();
            this.cmbIzmenaMenjaca = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbIzmenaKaroserije = new System.Windows.Forms.ComboBox();
            this.cmbIzmenaGoriva = new System.Windows.Forms.ComboBox();
            this.cmbIzmenaVrata = new System.Windows.Forms.ComboBox();
            this.btnSacuvajIzmeneAutomobila = new System.Windows.Forms.Button();
            this.btnIzIzmeneUKonzolu = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Izmena Automobila";
            // 
            // cmbAutoUID
            // 
            this.cmbAutoUID.DropDownHeight = 144;
            this.cmbAutoUID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAutoUID.FormattingEnabled = true;
            this.cmbAutoUID.IntegralHeight = false;
            this.cmbAutoUID.ItemHeight = 20;
            this.cmbAutoUID.Location = new System.Drawing.Point(170, 56);
            this.cmbAutoUID.Name = "cmbAutoUID";
            this.cmbAutoUID.Size = new System.Drawing.Size(184, 28);
            this.cmbAutoUID.TabIndex = 1;
            this.cmbAutoUID.SelectedIndexChanged += new System.EventHandler(this.cmbAutoUID_SelectedIndexChanged);
            // 
            // cmbIzmenaGodiste
            // 
            this.cmbIzmenaGodiste.DropDownHeight = 144;
            this.cmbIzmenaGodiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIzmenaGodiste.FormattingEnabled = true;
            this.cmbIzmenaGodiste.IntegralHeight = false;
            this.cmbIzmenaGodiste.ItemHeight = 20;
            this.cmbIzmenaGodiste.Items.AddRange(new object[] {
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
            this.cmbIzmenaGodiste.Location = new System.Drawing.Point(170, 162);
            this.cmbIzmenaGodiste.Name = "cmbIzmenaGodiste";
            this.cmbIzmenaGodiste.Size = new System.Drawing.Size(184, 28);
            this.cmbIzmenaGodiste.TabIndex = 9;
            // 
            // cmbIzmenaKubikaze
            // 
            this.cmbIzmenaKubikaze.DropDownHeight = 144;
            this.cmbIzmenaKubikaze.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIzmenaKubikaze.FormattingEnabled = true;
            this.cmbIzmenaKubikaze.IntegralHeight = false;
            this.cmbIzmenaKubikaze.ItemHeight = 20;
            this.cmbIzmenaKubikaze.Items.AddRange(new object[] {
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
            this.cmbIzmenaKubikaze.Location = new System.Drawing.Point(170, 208);
            this.cmbIzmenaKubikaze.Name = "cmbIzmenaKubikaze";
            this.cmbIzmenaKubikaze.Size = new System.Drawing.Size(184, 28);
            this.cmbIzmenaKubikaze.TabIndex = 10;
            // 
            // cmbIzmenaPogona
            // 
            this.cmbIzmenaPogona.DropDownHeight = 144;
            this.cmbIzmenaPogona.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIzmenaPogona.FormattingEnabled = true;
            this.cmbIzmenaPogona.IntegralHeight = false;
            this.cmbIzmenaPogona.ItemHeight = 20;
            this.cmbIzmenaPogona.Items.AddRange(new object[] {
            "Prednji",
            "Zadnji",
            "4x4",
            "4x4 reductor"});
            this.cmbIzmenaPogona.Location = new System.Drawing.Point(170, 258);
            this.cmbIzmenaPogona.Name = "cmbIzmenaPogona";
            this.cmbIzmenaPogona.Size = new System.Drawing.Size(184, 28);
            this.cmbIzmenaPogona.TabIndex = 11;
            // 
            // cmbIzmenaMenjaca
            // 
            this.cmbIzmenaMenjaca.DropDownHeight = 144;
            this.cmbIzmenaMenjaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIzmenaMenjaca.FormattingEnabled = true;
            this.cmbIzmenaMenjaca.IntegralHeight = false;
            this.cmbIzmenaMenjaca.ItemHeight = 20;
            this.cmbIzmenaMenjaca.Items.AddRange(new object[] {
            "Manuelni 4",
            "Manuelni 5",
            "Manuelni 6",
            "Poluautomatski",
            "Automatski"});
            this.cmbIzmenaMenjaca.Location = new System.Drawing.Point(170, 304);
            this.cmbIzmenaMenjaca.Name = "cmbIzmenaMenjaca";
            this.cmbIzmenaMenjaca.Size = new System.Drawing.Size(184, 28);
            this.cmbIzmenaMenjaca.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 24);
            this.label7.TabIndex = 8;
            this.label7.Text = "Vrsta menjaca";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Pogon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Kubikaza";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Godiste";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Marka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "UIDAuta";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(391, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 24);
            this.label8.TabIndex = 13;
            this.label8.Text = "Karoserija";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(391, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 24);
            this.label9.TabIndex = 14;
            this.label9.Text = "Gorivo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(391, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 24);
            this.label10.TabIndex = 15;
            this.label10.Text = "BrVrata";
            // 
            // cmbIzmenaKaroserije
            // 
            this.cmbIzmenaKaroserije.DropDownHeight = 144;
            this.cmbIzmenaKaroserije.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIzmenaKaroserije.FormattingEnabled = true;
            this.cmbIzmenaKaroserije.IntegralHeight = false;
            this.cmbIzmenaKaroserije.ItemHeight = 20;
            this.cmbIzmenaKaroserije.Items.AddRange(new object[] {
            "Limuzina",
            "Hecbek",
            "Karavan",
            "Kupe",
            "Kabriolet/Roadster",
            "MiniVan",
            "Dzip",
            "Pickup"});
            this.cmbIzmenaKaroserije.Location = new System.Drawing.Point(490, 56);
            this.cmbIzmenaKaroserije.Name = "cmbIzmenaKaroserije";
            this.cmbIzmenaKaroserije.Size = new System.Drawing.Size(184, 28);
            this.cmbIzmenaKaroserije.TabIndex = 16;
            // 
            // cmbIzmenaGoriva
            // 
            this.cmbIzmenaGoriva.DropDownHeight = 144;
            this.cmbIzmenaGoriva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIzmenaGoriva.FormattingEnabled = true;
            this.cmbIzmenaGoriva.IntegralHeight = false;
            this.cmbIzmenaGoriva.ItemHeight = 20;
            this.cmbIzmenaGoriva.Items.AddRange(new object[] {
            "Benzin",
            "Dizel",
            "Benzin+Gas",
            "Metan CNG",
            "Elektricni pogon",
            "Hibridni pogon"});
            this.cmbIzmenaGoriva.Location = new System.Drawing.Point(490, 116);
            this.cmbIzmenaGoriva.Name = "cmbIzmenaGoriva";
            this.cmbIzmenaGoriva.Size = new System.Drawing.Size(184, 28);
            this.cmbIzmenaGoriva.TabIndex = 17;
            // 
            // cmbIzmenaVrata
            // 
            this.cmbIzmenaVrata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIzmenaVrata.FormattingEnabled = true;
            this.cmbIzmenaVrata.Items.AddRange(new object[] {
            "2/3",
            "4/5"});
            this.cmbIzmenaVrata.Location = new System.Drawing.Point(490, 166);
            this.cmbIzmenaVrata.Name = "cmbIzmenaVrata";
            this.cmbIzmenaVrata.Size = new System.Drawing.Size(184, 28);
            this.cmbIzmenaVrata.TabIndex = 18;
            // 
            // btnSacuvajIzmeneAutomobila
            // 
            this.btnSacuvajIzmeneAutomobila.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSacuvajIzmeneAutomobila.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvajIzmeneAutomobila.Location = new System.Drawing.Point(395, 212);
            this.btnSacuvajIzmeneAutomobila.Name = "btnSacuvajIzmeneAutomobila";
            this.btnSacuvajIzmeneAutomobila.Size = new System.Drawing.Size(279, 54);
            this.btnSacuvajIzmeneAutomobila.TabIndex = 19;
            this.btnSacuvajIzmeneAutomobila.Text = "Sacuvaj izmene";
            this.btnSacuvajIzmeneAutomobila.UseVisualStyleBackColor = false;
            this.btnSacuvajIzmeneAutomobila.Click += new System.EventHandler(this.btnSacuvajIzmeneAutomobila_Click);
            // 
            // btnIzIzmeneUKonzolu
            // 
            this.btnIzIzmeneUKonzolu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnIzIzmeneUKonzolu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzIzmeneUKonzolu.Location = new System.Drawing.Point(395, 278);
            this.btnIzIzmeneUKonzolu.Name = "btnIzIzmeneUKonzolu";
            this.btnIzIzmeneUKonzolu.Size = new System.Drawing.Size(279, 54);
            this.btnIzIzmeneUKonzolu.TabIndex = 20;
            this.btnIzIzmeneUKonzolu.Text = "Vrati se";
            this.btnIzIzmeneUKonzolu.UseVisualStyleBackColor = false;
            this.btnIzIzmeneUKonzolu.Click += new System.EventHandler(this.btnIzIzmeneUKonzolu_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(170, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 26);
            this.textBox1.TabIndex = 21;
            // 
            // FormIzmenaAuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 398);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnIzIzmeneUKonzolu);
            this.Controls.Add(this.btnSacuvajIzmeneAutomobila);
            this.Controls.Add(this.cmbIzmenaVrata);
            this.Controls.Add(this.cmbIzmenaGoriva);
            this.Controls.Add(this.cmbIzmenaKaroserije);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbIzmenaMenjaca);
            this.Controls.Add(this.cmbIzmenaPogona);
            this.Controls.Add(this.cmbIzmenaKubikaze);
            this.Controls.Add(this.cmbIzmenaGodiste);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbAutoUID);
            this.Controls.Add(this.label1);
            this.Name = "FormIzmenaAuta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormIzmenaAuta";
            this.Load += new System.EventHandler(this.FormIzmenaAuta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAutoUID;
        private System.Windows.Forms.ComboBox cmbIzmenaGodiste;
        private System.Windows.Forms.ComboBox cmbIzmenaKubikaze;
        private System.Windows.Forms.ComboBox cmbIzmenaPogona;
        private System.Windows.Forms.ComboBox cmbIzmenaMenjaca;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbIzmenaKaroserije;
        private System.Windows.Forms.ComboBox cmbIzmenaGoriva;
        private System.Windows.Forms.ComboBox cmbIzmenaVrata;
        private System.Windows.Forms.Button btnSacuvajIzmeneAutomobila;
        private System.Windows.Forms.Button btnIzIzmeneUKonzolu;
        private System.Windows.Forms.TextBox textBox1;
    }
}