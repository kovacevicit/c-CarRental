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
    public partial class FormIzmenaKupca : Form
    {
        string putanjaKupci = "Kupci.bin";
        List<Kupac> listaKupaca;
        public FormIzmenaKupca()
        {
            InitializeComponent();
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream(putanjaKupci, FileMode.Open, FileAccess.Read);
            listaKupaca = bf.Deserialize(fs) as List<Kupac>;
            fs.Close();
            for (int i = 0; i < listaKupaca.Count; i++)
            {
                cmbUIDKupca.Items.Add(listaKupaca[i].UID + " " + listaKupaca[i].Ime + " " + listaKupaca[i].Prezime);
            }

            if (listaKupaca.Count > 0)
            {
                cmbUIDKupca.SelectedIndex = 0;
            }
        }

        private void btnVratiSeIzIzmeneKupca_Click(object sender, EventArgs e)
        {
            FormAdmin fadmin = new FormAdmin();
            fadmin.Show();
            this.Close();
        }

        private void cmbUIDKupca_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < listaKupaca.Count; i++) {
                if (cmbUIDKupca.Text.Split(' ').First().Equals(listaKupaca[i].UID.ToString())){
                    txtNovaSifra.Text = listaKupaca[i].Sifra;
                    txtIzmenaIme.Text = listaKupaca[i].Ime;
                    txtIzmenaJMBG.Text = listaKupaca[i].Jmbg;
                    txtIzmenaPrezime.Text = listaKupaca[i].Prezime;
                    txtIzmenaTelefona.Text = listaKupaca[i].Telefon;
                   dtpDatumRodjenja.Value = DateTime.Parse(listaKupaca[i].Datum);
                   //MessageBox.Show(listaKupaca[i].Datum);
                }
            }
        }

        private void btnSacuvajIzmeneKupca_Click(object sender, EventArgs e)
        {
            if (cmbUIDKupca.Text != "")
            {
                if (txtNovaSifra.Text.Length > 3 && txtNovaSifra.Text.Length<25)
                {
                    if(txtIzmenaIme.Text.All(char.IsLetter) && txtIzmenaPrezime.Text.All(char.IsLetter) && txtIzmenaIme.Text.Length>3 && txtIzmenaPrezime.Text.Length > 3)
                    {
                        if(txtIzmenaJMBG.Text.All(char.IsNumber) && txtIzmenaJMBG.Text.Length == 13)
                        {
                            if (txtIzmenaTelefona.Text.All(char.IsNumber)){

                                for (int i = 0; i < listaKupaca.Count; i++)
                                {
                                    if (cmbUIDKupca.Text.Split(' ').First().Equals(listaKupaca[i].UID.ToString()))
                                    {
                                        listaKupaca[i].Sifra = txtNovaSifra.Text;
                                        listaKupaca[i].Ime = txtIzmenaIme.Text;
                                        listaKupaca[i].Jmbg = txtIzmenaJMBG.Text;
                                        listaKupaca[i].Prezime = txtIzmenaPrezime.Text;
                                        listaKupaca[i].Telefon = txtIzmenaTelefona.Text;
                                        listaKupaca[i].Datum = dtpDatumRodjenja.Value.ToShortDateString();

                                        MessageBox.Show("Kupac ispesno azuriran");

                                        FileStream fs2 = new FileStream(putanjaKupci, FileMode.Open, FileAccess.Write);
                                        BinaryFormatter bf2 = new BinaryFormatter();
                                        bf2.Serialize(fs2, listaKupaca);
                                        fs2.Close();

                                    }
                                }


                            }
                            else
                            {
                                MessageBox.Show("Broj Telefona moze biti samo broj");
                            }
                        }
                        else
                        {
                            MessageBox.Show("JMBG mora biti samo broj i mora biti 13 karaktera duzine"); 
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ime i prezime moraju biti samo slova i biti duza od 3 karaktera");

                    }
                }
                else
                {
                    MessageBox.Show("Sifra mora biti duze od 3 a manja od 25 karaktera");
                }
            }
            else
            {
                MessageBox.Show("Morate izabrati kupca");
            }
        }
    }
}
