using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsApp1
{
   
    
    public partial class FormNoviAuto : Form
    {
        string putanjaAuta = "Automobili.bin";
        List<Automobil> listaAutomobila;
        int pomocna = 100;

        public FormNoviAuto()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormNoviAuto_Load(object sender, EventArgs e)
        {
           // BinaryFormatter bf = new BinaryFormatter();
            //FileStream fs = new FileStream(putanjaAuta, FileMode.Open, FileAccess.Read);
            //listaAutomobila = bf.Deserialize(fs) as List<Automobil>;
           // fs.Close();
            //MessageBox.Show(listaAutomobila[1].UID.ToString());
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //Nista
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtUnesiMarku.Text != "" || txtUnesiModel.Text != "" || cmbOdaberiBrojVrata.Text != "" || cmbOdaberiGodiste.Text != "" || cmbOdaberiGorivo.Text != ""
                || cmbOdaberiKaroseriju.Text != "" || cmbOdaberiKubikazu.Text!="" || cmbOdaberiPogon.Text != "" || cmbOdaberiMenjac.Text!="")
            {
                if(MessageBox.Show("Da li ste sigurni da zelite da izadjete", "Upozorenje", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                     FormAdmin fadmin = new FormAdmin();
                     fadmin.Show();
                     this.Close();
                } else
                {
                   // Jos uvek nista
                }
            } else
            {
                FormAdmin fadmin = new FormAdmin();
                fadmin.Show();
                this.Close();
            }
           
        }

        private void btnPotvrdiNoviAuto_Click(object sender, EventArgs e)
        {
            if (File.Exists(putanjaAuta))
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = new FileStream(putanjaAuta, FileMode.Open, FileAccess.Read);
                listaAutomobila = bf.Deserialize(fs) as List<Automobil>;
                fs.Close();
                int poslednji = listaAutomobila.Count;          //Moze i jednostavnije
                int sif = listaAutomobila[poslednji - 1].UID + 1;     //U konstruktor(listaAutomobila[poslednji-1].UID+1)
                //MessageBox.Show(sif.ToString());
                if (txtUnesiMarku.Text != "" && txtUnesiModel.Text != "" && cmbOdaberiBrojVrata.SelectedIndex > -1 && cmbOdaberiGodiste.SelectedIndex > -1 &&
                    cmbOdaberiGorivo.SelectedIndex > -1 && cmbOdaberiKaroseriju.SelectedIndex > -1 && cmbOdaberiKubikazu.SelectedIndex > -1 &&
                    cmbOdaberiMenjac.SelectedIndex > -1 && cmbOdaberiPogon.SelectedIndex > -1) { 
                listaAutomobila.Add(new Automobil(txtUnesiMarku.Text, txtUnesiModel.Text, int.Parse(cmbOdaberiGodiste.Text), cmbOdaberiKaroseriju.Text, cmbOdaberiKubikazu.Text, cmbOdaberiPogon.Text, cmbOdaberiMenjac.Text, cmbOdaberiBrojVrata.Text, cmbOdaberiGorivo.Text,sif ));
                FileStream fs2 = new FileStream(putanjaAuta, FileMode.Open, FileAccess.Write);
                BinaryFormatter bf2 = new BinaryFormatter();
                bf2.Serialize(fs2, listaAutomobila);
                fs2.Close();
                MessageBox.Show("Auto uspesno napravljen");
                txtUnesiMarku.Clear();
                txtUnesiModel.Clear();
               
                   
                }
                else
                {
                    MessageBox.Show("Niste uneli sve podatke");
                }
            }
            else
            {
                listaAutomobila = new List<Automobil>();
                listaAutomobila.Add(new Automobil(txtUnesiMarku.Text, txtUnesiModel.Text, int.Parse(cmbOdaberiGodiste.Text), cmbOdaberiKaroseriju.Text, cmbOdaberiKubikazu.Text, cmbOdaberiPogon.Text, cmbOdaberiMenjac.Text, cmbOdaberiBrojVrata.Text, cmbOdaberiGorivo.Text, pomocna));
                FileStream fs = new FileStream(putanjaAuta, FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, listaAutomobila);
                fs.Close();
                MessageBox.Show("Auto uspesno napravljen");
            }
        }
    }
}
