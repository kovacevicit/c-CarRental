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
    public partial class FormNovaRezervacija : Form
    {
        string putanjaKupci = "Kupci.bin";
        List<Kupac> listaKupaca;
        List<Automobil> listaAutomobila;
        string putanjaAuta = "Automobili.bin";
        List<Rezervacija> listaRezervacija;
        string putanjaRez = "Rezervacije.bin";
        public FormNovaRezervacija()
        {
            InitializeComponent();
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream(putanjaKupci, FileMode.Open, FileAccess.Read);
            listaKupaca = bf.Deserialize(fs) as List<Kupac>;
            fs.Close();
            for (int i = 0; i < listaKupaca.Count; i++)
            {
                cmbKupac.Items.Add(listaKupaca[i].UID + " " + listaKupaca[i].Ime + " " + listaKupaca[i].Prezime);
            }

            if (listaKupaca.Count > 0)
            {
                cmbKupac.SelectedIndex = 0;
            }
            BinaryFormatter bf1 = new BinaryFormatter();
            FileStream fs1 = new FileStream(putanjaAuta, FileMode.Open, FileAccess.Read);
            listaAutomobila = bf.Deserialize(fs1) as List<Automobil>;
            fs1.Close();
            for (int i = 0; i < listaAutomobila.Count; i++)
            {
                cmbAuto.Items.Add(listaAutomobila[i].UID + " " + listaAutomobila[i].Marka + " " + listaAutomobila[i].Model);

            }
        }

        private void btnVratiSe_Click(object sender, EventArgs e)
        {
            FormAdmin fadmin = new FormAdmin();
            fadmin.Show();
            this.Close();

        }

        private void btnRez_Click(object sender, EventArgs e)
        {
            if (cmbAuto.Text != "" && cmbKupac.Text != "")
            {
                if (txtCena.Text != "" && txtCena.Text.All(char.IsNumber))
                {
                    BinaryFormatter bf2 = new BinaryFormatter();
                    FileStream fs2 = new FileStream(putanjaRez, FileMode.Open, FileAccess.Read);
                    listaRezervacija = bf2.Deserialize(fs2) as List<Rezervacija>;
                    fs2.Close();

                    listaRezervacija.Add(new Rezervacija(int.Parse(cmbAuto.Text.Split(' ').First()),int.Parse(cmbKupac.Text.Split(' ').First()),dateTimePicker1.Value.ToShortDateString(),dateTimePicker2.Value.ToShortDateString(), double.Parse((((dateTimePicker2.Value - dateTimePicker1.Value).TotalDays + 1) * int.Parse(txtCena.Text)).ToString())));
                    FileStream fss = new FileStream(putanjaRez, FileMode.Open, FileAccess.Write);
                    BinaryFormatter bff = new BinaryFormatter();
                    bff.Serialize(fss, listaRezervacija);
                    fss.Close();
                    MessageBox.Show("Rezervacija uspesna");
                }
                else
                {
                    MessageBox.Show("Morate upisati cenu kao ceo broj");
                }

            }
            else
            {
                MessageBox.Show("Morate izabrati auto i kupca");
            }
        }
    }
}
