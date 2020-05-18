using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Statistika : Form
    {
        List<Rezervacija> listaRezervacija;
        string putanjaRez = "Rezervacije.bin";
        List<Automobil> listaAutomobila;
        string putanjaAuta = "Automobili.bin";
        Thread t;
        private static float br = 0;
        public Statistika()
        {
            InitializeComponent();
            t = new Thread(ucitaj);
            t.Start();
            
        }

        private void ucitaj()
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream(putanjaRez, FileMode.Open, FileAccess.Read);
            listaRezervacija = bf.Deserialize(fs) as List<Rezervacija>;
            fs.Close();

            BinaryFormatter bf1 = new BinaryFormatter();
            FileStream fs1 = new FileStream(putanjaAuta, FileMode.Open, FileAccess.Read);
            listaAutomobila = bf1.Deserialize(fs1) as List<Automobil>;
            fs1.Close();
        }
        int tmp = 0;
        int brojAutomobila = 0;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tmp = 0;
            brojAutomobila = listaAutomobila.Count;
            for(int i = 0; i < listaRezervacija.Count; i++)
            {

                if (int.Parse(listaRezervacija[i].DatumDo.Split('/').First()) == comboBox1.SelectedIndex + 1 || int.Parse(listaRezervacija[i].DatumOd.Split('/').First()) == comboBox1.SelectedIndex + 1)
                {
                    tmp = tmp + 1;
                }
            }
            //MessageBox.Show("Za mesec: " + comboBox1.Text + " rezervisano je: " + tmp + " automobila");
            label4.Text = tmp.ToString();
            label5.Text = brojAutomobila.ToString();
            br = (float)tmp * (float)(360/brojAutomobila);
            this.Paint += crtanje;
            this.Invalidate();

        }

        private void crtanje(object sender, PaintEventArgs e)
        {
            Rectangle r = new Rectangle(380, 120, 275, 275);
            e.Graphics.DrawEllipse(Pens.Black, r);
            e.Graphics.FillEllipse(Brushes.Blue, r);
            e.Graphics.FillPie(Brushes.Red, r, -90F, br);

            Rectangle k = new Rectangle(180, 390, 30, 30);
            e.Graphics.DrawRectangle(Pens.Blue, k);
            e.Graphics.FillRectangle(Brushes.Blue, k);

            Rectangle k1 = new Rectangle(300, 340, 30, 30);
            e.Graphics.DrawRectangle(Pens.Red, k1);
            e.Graphics.FillRectangle(Brushes.Red, k1);

        }


        private void Statistika_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Statistika_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAdmin fadmin = new FormAdmin();
            fadmin.Show();
            this.Hide();
        }
    }
}
