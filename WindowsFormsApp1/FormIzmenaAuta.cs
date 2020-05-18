using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormIzmenaAuta : Form
    {
        List<Automobil> listaAutomobila;
        string putanjaAuta = "Automobili.bin";
        public FormIzmenaAuta()
        {
            InitializeComponent();
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream(putanjaAuta, FileMode.Open, FileAccess.Read);
            listaAutomobila = bf.Deserialize(fs) as List<Automobil>;
            fs.Close();
            for (int i = 0; i < listaAutomobila.Count; i++)
            {
                cmbAutoUID.Items.Add(listaAutomobila[i].UID + " " + listaAutomobila[i].Marka + " " + listaAutomobila[i].Model);

            }
            cmbAutoUID.SelectedIndex = 0;
        }

        private void btnIzIzmeneUKonzolu_Click(object sender, EventArgs e)
        {
            FormAdmin fadmin = new FormAdmin();
            fadmin.Show();
            this.Close();
        }

        private void FormIzmenaAuta_Load(object sender, EventArgs e)
        {

        }

        private void cmbAutoUID_SelectedIndexChanged(object sender, EventArgs e)
        {
            for(int i = 0; i < listaAutomobila.Count; i++)
            {
                if (cmbAutoUID.Text.Split(' ').First().Equals(listaAutomobila[i].UID.ToString()))
                {
                    textBox1.Text = listaAutomobila[i].Marka;
                    cmbIzmenaGodiste.Text = listaAutomobila[i].Godiste.ToString();
                    cmbIzmenaGoriva.Text = listaAutomobila[i].Gorivo;
                    cmbIzmenaKaroserije.Text = listaAutomobila[i].Karoserija;
                    cmbIzmenaKubikaze.Text = listaAutomobila[i].Kubikaza;
                    cmbIzmenaMenjaca.Text = listaAutomobila[i].Menjac;
                    cmbIzmenaPogona.Text = listaAutomobila[i].Pogon;
                    cmbIzmenaVrata.Text = listaAutomobila[i].BrojVrata;

                }
            }
        }

        private void btnSacuvajIzmeneAutomobila_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listaAutomobila.Count; i++)
            {
                if (cmbAutoUID.Text.Split(' ').First().Equals(listaAutomobila[i].UID.ToString()))
                {
                    listaAutomobila[i].Marka = textBox1.Text;
                    listaAutomobila[i].Godiste = int.Parse(cmbIzmenaGodiste.Text);
                    listaAutomobila[i].Gorivo = cmbIzmenaGoriva.Text;
                    listaAutomobila[i].Karoserija = cmbIzmenaKaroserije.Text;
                    listaAutomobila[i].Kubikaza = cmbIzmenaKubikaze.Text;
                    listaAutomobila[i].Menjac = cmbIzmenaMenjaca.Text;
                    listaAutomobila[i].Pogon = cmbIzmenaPogona.Text;
                    listaAutomobila[i].BrojVrata = cmbIzmenaVrata.Text;

                    FileStream fs2 = new FileStream(putanjaAuta, FileMode.Open, FileAccess.Write);
                    BinaryFormatter bf2 = new BinaryFormatter();
                    bf2.Serialize(fs2, listaAutomobila);
                    fs2.Close();
                    MessageBox.Show("Auto uspesno azuriran");

                }
                else
                {
                    
                }
            }
        }
    }
}
