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
    public partial class FormIzmenaRezervacije : Form
    {
        List<Rezervacija> listaRezervacija;
        string putanjaRez = "Rezervacije.bin";
        string putanjaKupci = "Kupci.bin";
        List<Kupac> listaKupaca;
        List<Automobil> listaAutomobila;
        string putanjaAuta = "Automobili.bin";
        public FormIzmenaRezervacije()
        {
            InitializeComponent();
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream(putanjaRez, FileMode.Open, FileAccess.Read);
            listaRezervacija = bf.Deserialize(fs) as List<Rezervacija>;
            fs.Close();
            for (int i = 0; i < listaRezervacija.Count; i++)
            {
                cmbRezervacija.Items.Add("Sifra kupca: " + listaRezervacija[i].UIDKupac1 + " UID auta: " + listaRezervacija[i].UIDAuto1 + " " + listaRezervacija[i].DatumOd + " - " + listaRezervacija[i].DatumDo);


            }

            if (listaRezervacija.Count > 0)
            {
                cmbRezervacija.SelectedIndex = 0;
            }

            BinaryFormatter bf1 = new BinaryFormatter();
            FileStream fs1 = new FileStream(putanjaKupci, FileMode.Open, FileAccess.Read);
            listaKupaca = bf1.Deserialize(fs1) as List<Kupac>;
            fs1.Close();
            for (int i = 0; i < listaKupaca.Count; i++)
            {
                cmbKupac.Items.Add(listaKupaca[i].UID + " " + listaKupaca[i].Ime + " " + listaKupaca[i].Prezime);
            }

            BinaryFormatter bf2 = new BinaryFormatter();
            FileStream fs2 = new FileStream(putanjaAuta, FileMode.Open, FileAccess.Read);
            listaAutomobila = bf2.Deserialize(fs2) as List<Automobil>;
            fs2.Close();
            for (int i = 0; i < listaAutomobila.Count; i++)
            {
                cmbAuto.Items.Add(listaAutomobila[i].UID + " " + listaAutomobila[i].Marka + " " + listaAutomobila[i].Model);

            }

        }

        private void btnVratiSeSaRezervacije_Click(object sender, EventArgs e)
        {
            FormAdmin fadmin = new FormAdmin();
            fadmin.Show();
            this.Close();
        }

        private void btnSacuvajRezervaciju_Click(object sender, EventArgs e)
        {
            if (dtpDatumDo.Value >= dtpDatumOd.Value)
            {
                if (cmbRezervacija.Text != "")
                {
                    if (cmbAuto.Text != "")
                    {
                        if (cmbKupac.Text != "")
                        {
                            if (txtIzmenaCeneRezervacije.Text.All(char.IsNumber))
                            {
                                for(int i = 0; i < listaRezervacija.Count; i++)
                                {
                                    if (listaRezervacija[i].UIDKupac1.ToString().Equals(cmbRezervacija.Text.Split(' ').Skip(2).First()) &&
                                        listaRezervacija[i].UIDAuto1.ToString().Equals(cmbRezervacija.Text.Split(' ').Skip(5).First()) &&
                                        listaRezervacija[i].DatumOd.ToString().Equals(cmbRezervacija.Text.Split(' ').Skip(6).First()) &&
                                        listaRezervacija[i].DatumDo.ToString().Equals(cmbRezervacija.Text.Split(' ').Last()))
                                    {
                                        listaRezervacija[i].Cena = double.Parse(txtIzmenaCeneRezervacije.Text)*(dtpDatumDo.Value-dtpDatumOd.Value).TotalDays+1;
                                        listaRezervacija[i].UIDKupac1 = int.Parse(cmbKupac.Text.Split(' ').First());
                                        listaRezervacija[i].UIDAuto1 = int.Parse(cmbAuto.Text.Split(' ').First());
                                        listaRezervacija[i].DatumOd = dtpDatumOd.Value.ToShortDateString();
                                        listaRezervacija[i].DatumDo = dtpDatumDo.Value.ToShortDateString();
                                        FileStream fss = new FileStream(putanjaRez, FileMode.Open, FileAccess.Write);
                                        BinaryFormatter bff = new BinaryFormatter();
                                        bff.Serialize(fss, listaRezervacija);
                                        fss.Close();
                                        MessageBox.Show("Rezervacija izmenjena");
                                        cmbRezervacija.Items.Clear();
                                        for (int j = 0; j < listaRezervacija.Count; j++)
                                        {
                                            cmbRezervacija.Items.Add("Sifra kupca: " + listaRezervacija[j].UIDKupac1 + " UID auta: " + listaRezervacija[j].UIDAuto1 + " " + listaRezervacija[j].DatumOd + " - " + listaRezervacija[j].DatumDo);


                                        }

                                        if (listaRezervacija.Count > 0)
                                        {
                                            cmbRezervacija.SelectedIndex = 0;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Cene mora biti ceo broj");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Morate izabrati kupca");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Morate izabrati auto");
                    }
                }
                else
                {
                    MessageBox.Show("Morate izabrati rezervaciju za izmenu");
                }
            }
            else
            {
                MessageBox.Show("Datum Do mora biti veci ili jednak datumu Od");
            }
        }
    }
}
