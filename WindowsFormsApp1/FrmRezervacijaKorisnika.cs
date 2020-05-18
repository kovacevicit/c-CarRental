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
    public partial class FrmRezervacijaKorisnika : Form
    {
        private Kupac kupac;
        List<Automobil> listaAutomobila;
        string putanjaAuta = "Automobili.bin";
        List<Ponuda> listaPonuda;
        string putanjaPonude = "Ponuda.bin";
        List<Rezervacija> listaRezervacija;
        string putanjaRez = "Rezervacije.bin";
        bool tmp = false;
        public FrmRezervacijaKorisnika(Kupac k)
        {
            InitializeComponent();
            kupac = k;

            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream(putanjaAuta, FileMode.Open, FileAccess.Read);
            listaAutomobila = bf.Deserialize(fs) as List<Automobil>;
            fs.Close();
           

            BinaryFormatter bf1 = new BinaryFormatter();
            FileStream fs1 = new FileStream(putanjaPonude, FileMode.Open, FileAccess.Read);
            listaPonuda = bf1.Deserialize(fs1) as List<Ponuda>;
            fs1.Close();

            for (int i = 0; i < listaAutomobila.Count; i++)
            {
                tmp = false;
                for(int j = 0; j < cmbMarka.Items.Count; j++)
                {
                    if (cmbMarka.Items[j].Equals(listaAutomobila[i].Marka))
                    {
                        tmp = true;
                    }
                }
                if (tmp==false) {
                    cmbMarka.Items.Add(listaAutomobila[i].Marka);
                }
            }

           // MessageBox.Show(listaPonuda[0].Cena.ToString());

        }

       

        private void FrmRezervacijaKorisnika_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(kupac.Ime);
        }

        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbModel.Items.Clear();
            for (int i = 0; i < listaAutomobila.Count; i++) {
                tmp = false;
                if (listaAutomobila[i].Marka.Equals(cmbMarka.Text))
                {
                    for (int j = 0; j < cmbModel.Items.Count; j++)
                    {
                        if (cmbModel.Items[j].Equals(listaAutomobila[i].Model))
                        {
                            tmp = true;
                        }
                    }
                    if (tmp == false)
                    {
                        cmbModel.Items.Add(listaAutomobila[i].Model);
                    }
                  
                }
            }
            cmbModel.SelectedIndex = 0;
        }

        private void cmbGorivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbGodiste.Items.Clear();
            for (int i = 0; i < listaAutomobila.Count; i++)
            {
                tmp = false;

                if (listaAutomobila[i].Marka.Equals(cmbMarka.Text) && listaAutomobila[i].Model.Equals(cmbModel.Text) && listaAutomobila[i].Gorivo.Equals(cmbGorivo.Text))

                {
                    for (int j = 0; j < cmbGodiste.Items.Count; j++)
                    {
                        if (cmbGodiste.Items[j].Equals(listaAutomobila[i].Godiste))
                        {
                            tmp = true;
                        }
                    }
                    if (tmp == false)
                    {
                        cmbGodiste.Items.Add(listaAutomobila[i].Godiste);
                    }

                }
            }
            cmbGodiste.SelectedIndex = 0;
        }

        private void cmbModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbGorivo.Items.Clear();
            for (int i = 0; i < listaAutomobila.Count; i++)
            {
                tmp = false;
                
                if (listaAutomobila[i].Marka.Equals(cmbMarka.Text) && listaAutomobila[i].Model.Equals(cmbModel.Text))
                {
                    for (int j = 0; j < cmbGorivo.Items.Count; j++)
                    {
                        if (cmbGorivo.Items[j].Equals(listaAutomobila[i].Gorivo))
                        {
                            tmp = true;
                        }
                    }
                    if (tmp == false)
                    {
                        cmbGorivo.Items.Add(listaAutomobila[i].Gorivo);
                    }

                }
            }
            cmbGorivo.SelectedIndex = 0;
        }

        private void cmbGodiste_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbKubikaza.Items.Clear();
            cmbKaroserija.Items.Clear();
            cmbBrVrata.Items.Clear();
            cmbPogon.Items.Clear();
            cmbMenjac.Items.Clear();
                
            for (int i = 0; i < listaAutomobila.Count; i++)
            {
                tmp = false;

                if (listaAutomobila[i].Marka.Equals(cmbMarka.Text) && listaAutomobila[i].Godiste.Equals(cmbGodiste.SelectedItem)
                    && listaAutomobila[i].Model.Equals(cmbModel.Text) && listaAutomobila[i].Gorivo.Equals(cmbGorivo.Text))

                {
                    for (int j = 0; j < cmbKubikaza.Items.Count; j++)
                    {
                        if (cmbKubikaza.Items[j].Equals(listaAutomobila[i].Kubikaza))
                        {
                            tmp = true;
                        }
                    }
                    if (tmp == false)
                    {
                        cmbKubikaza.Items.Add(listaAutomobila[i].Kubikaza);
                    }

                }
            }
            cmbKubikaza.SelectedIndex = 0;


            for (int i = 0; i < listaAutomobila.Count; i++)
            {
                tmp = false;

                if (listaAutomobila[i].Marka.Equals(cmbMarka.Text) && listaAutomobila[i].Godiste.Equals(cmbGodiste.SelectedItem)
                    && listaAutomobila[i].Model.Equals(cmbModel.Text) && listaAutomobila[i].Gorivo.Equals(cmbGorivo.Text))

                {
                    for (int j = 0; j < cmbKaroserija.Items.Count; j++)
                    {
                        if (cmbKaroserija.Items[j].Equals(listaAutomobila[i].Karoserija))
                        {
                            tmp = true;
                        }
                    }
                    if (tmp == false)
                    {
                        cmbKaroserija.Items.Add(listaAutomobila[i].Karoserija);
                    }

                }
            }
            cmbKaroserija.SelectedIndex = 0;


            for (int i = 0; i < listaAutomobila.Count; i++)
            {
                tmp = false;

                if (listaAutomobila[i].Marka.Equals(cmbMarka.Text) && listaAutomobila[i].Godiste.Equals(cmbGodiste.SelectedItem)
                    && listaAutomobila[i].Model.Equals(cmbModel.Text) && listaAutomobila[i].Gorivo.Equals(cmbGorivo.Text))

                {
                    for (int j = 0; j < cmbBrVrata.Items.Count; j++)
                    {
                        if (cmbBrVrata.Items[j].Equals(listaAutomobila[i].BrojVrata))
                        {
                            tmp = true;
                        }
                    }
                    if (tmp == false)
                    {
                        cmbBrVrata.Items.Add(listaAutomobila[i].BrojVrata);
                    }

                }
            }
            cmbBrVrata.SelectedIndex = 0;

            for (int i = 0; i < listaAutomobila.Count; i++)
            {
                tmp = false;

                if (listaAutomobila[i].Marka.Equals(cmbMarka.Text) && listaAutomobila[i].Godiste.Equals(cmbGodiste.SelectedItem)
                    && listaAutomobila[i].Model.Equals(cmbModel.Text) && listaAutomobila[i].Gorivo.Equals(cmbGorivo.Text))

                {
                    for (int j = 0; j < cmbPogon.Items.Count; j++)
                    {
                        if (cmbPogon.Items[j].Equals(listaAutomobila[i].Pogon))
                        {
                            tmp = true;
                        }
                    }
                    if (tmp == false)
                    {
                        cmbPogon.Items.Add(listaAutomobila[i].Pogon);
                    }

                }
            }
            cmbPogon.SelectedIndex = 0;

            for (int i = 0; i < listaAutomobila.Count; i++)
            {
                tmp = false;

                if (listaAutomobila[i].Marka.Equals(cmbMarka.Text) && listaAutomobila[i].Godiste.Equals(cmbGodiste.SelectedItem)
                    && listaAutomobila[i].Model.Equals(cmbModel.Text) && listaAutomobila[i].Gorivo.Equals(cmbGorivo.Text))

                {
                    for (int j = 0; j < cmbMenjac.Items.Count; j++)
                    {
                        if (cmbMenjac.Items[j].Equals(listaAutomobila[i].Menjac))
                        {
                            tmp = true;
                        }
                    }
                    if (tmp == false)
                    {
                        cmbMenjac.Items.Add(listaAutomobila[i].Menjac);
                    }

                }
            }
            cmbMenjac.SelectedIndex = 0;
        }

        int tmpUID = 0;
        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (cmbMarka.SelectedIndex != -1 && cmbModel.SelectedIndex != -1 && cmbKaroserija.SelectedIndex != -1
                && cmbGodiste.SelectedIndex != -1 && cmbGorivo.SelectedIndex != -1 && cmbKubikaza.SelectedIndex != -1
                && cmbMenjac.SelectedIndex != -1 && cmbPogon.SelectedIndex != -1 && cmbBrVrata.SelectedIndex != -1)
            {
                for (int i = 0; i < listaAutomobila.Count; i++) {
                    if (cmbMarka.Text.Equals(listaAutomobila[i].Marka) && cmbModel.Text.Equals(listaAutomobila[i].Model) && cmbGodiste.SelectedItem.Equals(listaAutomobila[i].Godiste) &&
                      cmbGorivo.SelectedItem.Equals(listaAutomobila[i].Gorivo) && cmbKubikaza.SelectedItem.Equals(listaAutomobila[i].Kubikaza) &&
                      cmbKubikaza.SelectedItem.Equals(listaAutomobila[i].Kubikaza) && cmbPogon.SelectedItem.Equals(listaAutomobila[i].Pogon) &&
                      cmbBrVrata.SelectedItem.Equals(listaAutomobila[i].BrojVrata) && cmbMenjac.SelectedItem.Equals(listaAutomobila[i].Menjac)) {
                        tmpUID = listaAutomobila[i].UID;    
                    }
                }

                for(int i = 0; i < listaPonuda.Count; i++)
                {
                    if (listaPonuda[i].UID == tmpUID)
                    {
                        
                        listBox1.Items.Add(listaPonuda[i].DatumOd + " - " + listaPonuda[i].DatumDo + " Cena: " + listaPonuda[i].Cena +" din po danu");



                    }
                }

            }
            else
            {
                MessageBox.Show("Niste izabrali sve stavke");
            }

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < listaPonuda.Count; i++) {
                if (dateTimePicker1.Value >= DateTime.Parse(listaPonuda[i].DatumOd) && dateTimePicker2.Value <= DateTime.Parse(listaPonuda[i].DatumDo)) {
                    lblCena.Text = (((dateTimePicker2.Value - dateTimePicker1.Value).TotalDays+1) * listaPonuda[i].Cena).ToString();
                }
                else
                {
                  //  lblCena.Text = "0";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.Parse(lblCena.Text) > 0)
            {
                if (File.Exists(putanjaRez))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    FileStream fs = new FileStream(putanjaRez, FileMode.Open, FileAccess.Read);
                    listaRezervacija = bf.Deserialize(fs) as List<Rezervacija>;
                    fs.Close();
                    listaRezervacija.Add(new Rezervacija(tmpUID, kupac.UID, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), double.Parse(lblCena.Text))) ;
                    FileStream fss = new FileStream(putanjaRez, FileMode.Open, FileAccess.Write);
                    BinaryFormatter bff = new BinaryFormatter();
                    bff.Serialize(fss, listaRezervacija);
                    fss.Close();
                    MessageBox.Show("Rezervacija uspesna");
                    for(int i = 0; i < listaPonuda.Count; i++)
                    {
                        if (listaPonuda[i].UID == tmpUID) {
                            if(dateTimePicker1.Value>=DateTime.Parse(listaPonuda[i].DatumOd) && dateTimePicker2.Value <= DateTime.Parse(listaPonuda[i].DatumDo))
                            {
                                listaPonuda.RemoveAt(i);

                                FileStream fs5 = new FileStream(putanjaPonude, FileMode.Open, FileAccess.Write);
                                BinaryFormatter bf5 = new BinaryFormatter();
                                bf5.Serialize(fs5, listaPonuda);
                                fs5.Close();

                            }
                        }
                    }
                    FormPrikazKorisnika frmPrikaz = new FormPrikazKorisnika(kupac);
                    frmPrikaz.Show();
                    this.Close();
                }
                else
                {
                    listaRezervacija = new List<Rezervacija>();
                    listaRezervacija.Add(new Rezervacija(tmpUID, kupac.UID, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), double.Parse(lblCena.Text)));
                    FileStream fs2 = new FileStream(putanjaRez, FileMode.Create, FileAccess.Write);
                    BinaryFormatter bf2 = new BinaryFormatter();
                    bf2.Serialize(fs2, listaRezervacija);
                    fs2.Close();
                    MessageBox.Show("Rezervacija uspesna");
                    FormPrikazKorisnika frmPrikazKorisika = new FormPrikazKorisnika(kupac);
                    frmPrikazKorisika.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Molimo izaberite datum");
            }

            

        }
    }
}
