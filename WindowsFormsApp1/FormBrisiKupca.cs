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

    

    public partial class FormBrisiKupca : Form
    {
        string putanjaKupci = "Kupci.bin";
        List<Kupac> listaKupaca;
        public FormBrisiKupca()
        {
            InitializeComponent();
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream(putanjaKupci, FileMode.Open, FileAccess.Read);
            listaKupaca = bf.Deserialize(fs) as List<Kupac>;
            fs.Close();
            for (int i = 0; i < listaKupaca.Count; i++)
            {
                cmbKupac.Items.Add(listaKupaca[i].UID + " " +listaKupaca[i].Ime+" "+listaKupaca[i].Prezime);
            }

            if (listaKupaca.Count > 0)
            {
                cmbKupac.SelectedIndex = 0;
            }
        }

        private void btnVratiSeSaBrisanjaKupca_Click(object sender, EventArgs e)
        {
            FormAdmin fadmin = new FormAdmin();
            fadmin.Show();
            this.Close();
        }

        private void btnBrisiKupca_Click(object sender, EventArgs e)
        {
            if (cmbKupac.Text != "")
            {
                if (listaKupaca.Count > 1) { 
                for(int i = 0; i < listaKupaca.Count; i++)
                {
                    if(cmbKupac.Text.Split(' ').First().Equals(listaKupaca[i].UID.ToString()))
                    {
                        listaKupaca.RemoveAt(i);
                        MessageBox.Show("Kupac izbrisan");
                           
                        cmbKupac.Items.Clear();
                        for (int j = 0; j < listaKupaca.Count; j++)
                        {
                            cmbKupac.Items.Add(listaKupaca[j].UID + " " + listaKupaca[j].Ime + " " + listaKupaca[j].Prezime);
                        }

                        FileStream fs2 = new FileStream(putanjaKupci, FileMode.Open, FileAccess.Write);
                        BinaryFormatter bf2 = new BinaryFormatter();
                        bf2.Serialize(fs2, listaKupaca);
                        fs2.Close();
                            cmbKupac.SelectedIndex = 0;

                        }
                }
                }
                else
                {
                    MessageBox.Show("Ne mozete izbrisati poslednjeg kupca");
                }
            }
            else
            {
                MessageBox.Show("Morate izabrati kupca");
            }
        }
    }
}
