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
    public partial class FormPrikazKorisnika : Form
    {
        private Kupac kupac;
        List<Rezervacija> listaRez;
        string putanjaRez = "Rezervacije.bin";
        public FormPrikazKorisnika(Kupac k)
        {
            InitializeComponent();
            kupac =k;

            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream(putanjaRez, FileMode.Open, FileAccess.Read);
            listaRez = bf.Deserialize(fs) as List<Rezervacija>;
            fs.Close();

            for (int i = 0; i < listaRez.Count; i++) {
                if (listaRez[i].UIDKupac1 == kupac.UID)
                {
                    comboBox1.Items.Add(listaRez[i].DatumOd+" - "+listaRez[i].DatumDo);

                }
            }

        }

        private void btnVratiSe_Click(object sender, EventArgs e)
        {
            Form1 fGlavna = new Form1();
            fGlavna.Show();
            this.Close();
        }

        private void FormPrikazKorisnika_Load(object sender, EventArgs e)
        {

        }

        private void btnNovaRezervacija_Click(object sender, EventArgs e)
        {

        }

        private void FormPrikazKorisnika_Load_1(object sender, EventArgs e)
        {

        }

        private void btnNovaRezervacija_Click_1(object sender, EventArgs e)
        {
            FrmRezervacijaKorisnika frmRez = new FrmRezervacijaKorisnika(kupac);
            frmRez.Show();
            this.Hide();
        }

        private void btnObrisiRezervaciju_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                for (int i = 0; i < listaRez.Count; i++)
                {
                    if (comboBox1.Text.Split(' ').First() == listaRez[i].DatumOd && comboBox1.Text.Split(' ').Last() == listaRez[i].DatumDo)
                    {
                        listaRez.RemoveAt(i);
                        FileStream fss = new FileStream(putanjaRez, FileMode.Open, FileAccess.Write);
                        BinaryFormatter bff = new BinaryFormatter();
                        bff.Serialize(fss, listaRez);
                        fss.Close();
                        MessageBox.Show("Brisanje uspesno");
                        comboBox1.Items.Clear();
                        for (int j = 0; j < listaRez.Count; j++)
                        {
                            if (listaRez[j].UIDKupac1 == kupac.UID)
                            {
                                comboBox1.Items.Add(listaRez[j].DatumOd + " - " + listaRez[j].DatumDo);

                            }
                        }
                    }
                }
            }
        }
    }
}
