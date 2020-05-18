namespace WindowsFormsApp1
{
    partial class FormBrisiAutomobil
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
            this.btnBrisiAuto = new System.Windows.Forms.Button();
            this.btnVratiSeSaBrisanjaAuta = new System.Windows.Forms.Button();
            this.cmbUIDAuta = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Izaberite Auto za Brisanje";
            // 
            // btnBrisiAuto
            // 
            this.btnBrisiAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrisiAuto.Location = new System.Drawing.Point(42, 95);
            this.btnBrisiAuto.Name = "btnBrisiAuto";
            this.btnBrisiAuto.Size = new System.Drawing.Size(147, 41);
            this.btnBrisiAuto.TabIndex = 2;
            this.btnBrisiAuto.Text = "Obrisi";
            this.btnBrisiAuto.UseVisualStyleBackColor = true;
            this.btnBrisiAuto.Click += new System.EventHandler(this.btnBrisiAuto_Click);
            // 
            // btnVratiSeSaBrisanjaAuta
            // 
            this.btnVratiSeSaBrisanjaAuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVratiSeSaBrisanjaAuta.Location = new System.Drawing.Point(213, 95);
            this.btnVratiSeSaBrisanjaAuta.Name = "btnVratiSeSaBrisanjaAuta";
            this.btnVratiSeSaBrisanjaAuta.Size = new System.Drawing.Size(147, 41);
            this.btnVratiSeSaBrisanjaAuta.TabIndex = 3;
            this.btnVratiSeSaBrisanjaAuta.Text = "Vrati se";
            this.btnVratiSeSaBrisanjaAuta.UseVisualStyleBackColor = true;
            this.btnVratiSeSaBrisanjaAuta.Click += new System.EventHandler(this.btnVratiSeSaBrisanjaAuta_Click);
            // 
            // cmbUIDAuta
            // 
            this.cmbUIDAuta.DropDownHeight = 144;
            this.cmbUIDAuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUIDAuta.FormattingEnabled = true;
            this.cmbUIDAuta.IntegralHeight = false;
            this.cmbUIDAuta.ItemHeight = 24;
            this.cmbUIDAuta.Location = new System.Drawing.Point(85, 41);
            this.cmbUIDAuta.MaxDropDownItems = 6;
            this.cmbUIDAuta.Name = "cmbUIDAuta";
            this.cmbUIDAuta.Size = new System.Drawing.Size(237, 32);
            this.cmbUIDAuta.TabIndex = 4;
            // 
            // FormBrisiAutomobil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 192);
            this.Controls.Add(this.cmbUIDAuta);
            this.Controls.Add(this.btnVratiSeSaBrisanjaAuta);
            this.Controls.Add(this.btnBrisiAuto);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(434, 230);
            this.MinimumSize = new System.Drawing.Size(434, 230);
            this.Name = "FormBrisiAutomobil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBrisiAutomobil";
            this.Load += new System.EventHandler(this.FormBrisiAutomobil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrisiAuto;
        private System.Windows.Forms.Button btnVratiSeSaBrisanjaAuta;
        private System.Windows.Forms.ComboBox cmbUIDAuta;
    }
}