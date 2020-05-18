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
    public partial class FormNoviKupac : Form
    {
        string putanjaKupca = "Kupci.bin";
        List<Kupac> listaKupaca;
        int pomocna = 100;
        bool kupacPostoji = false;
        public FormNoviKupac()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormAdmin fadmin = new FormAdmin();
            fadmin.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists(putanjaKupca))
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = new FileStream(putanjaKupca, FileMode.Open, FileAccess.Read);
                listaKupaca = bf.Deserialize(fs) as List<Kupac>;
                fs.Close();
                for (int i = 0; i < listaKupaca.Count; i++)
                {
                    if (listaKupaca[i].Username.Equals(txtNoviKupacUser.Text))
                    {
                        kupacPostoji = true;

                    }
                }
                if (kupacPostoji == true)
                {
                    MessageBox.Show("Korisnicko ime je zauzeto, pokusajte ponovo", "Greska", MessageBoxButtons.OK);
                    txtNoviKupacUser.Text = "";
                    txtNoviKupacUser.Focus();
                    kupacPostoji = false;
                }
                else
                {
                    if(txtNoviKupacPassword.Text.Length>7 && txtNoviKupacUser.Text.Length>3 && txtNoviKupacJMBG.Text.Length==13)
                    {

                        int tmp = listaKupaca.Count;
                    listaKupaca.Add(new Kupac(txtNoviKupacIme.Text, txtNoviKupacPrezime.Text, txtNoviKupacUser.Text, txtNoviKupacPassword.Text, txtNoviKupacJMBG.Text, dtpNoviKupacRodjenje.Value.ToShortDateString(), txtNoviKupacTelefon.Text, listaKupaca[tmp-1].UID+1));
                    FileStream fs2 = new FileStream(putanjaKupca, FileMode.Open, FileAccess.Write);
                    BinaryFormatter bf2 = new BinaryFormatter();
                    bf2.Serialize(fs2, listaKupaca);
                    fs2.Close();
                    MessageBox.Show("Kupac uspesno napravljen");
                    txtNoviKupacIme.Text = "";
                    txtNoviKupacJMBG.Text = "";
                    txtNoviKupacPassword.Text = "";
                    txtNoviKupacPrezime.Text = "";
                    txtNoviKupacTelefon.Text = "";
                    txtNoviKupacUser.Text = "";
                    txtNoviKupacIme.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Pogresan unos,pokusajte ponovo", "Gresa", MessageBoxButtons.OK);
                        txtNoviKupacPassword.Text = "";
                        txtNoviKupacPassword.Focus();
                    }
                }
                
                
            }
            else
            {
                listaKupaca = new List<Kupac>();
                listaKupaca.Add(new Kupac(txtNoviKupacIme.Text, txtNoviKupacPrezime.Text, txtNoviKupacUser.Text, txtNoviKupacPassword.Text,txtNoviKupacJMBG.Text, dtpNoviKupacRodjenje.Value.ToShortDateString(), txtNoviKupacTelefon.Text, pomocna));
                FileStream fs = new FileStream(putanjaKupca, FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, listaKupaca);
                fs.Close();
                MessageBox.Show("Kupac uspesno napravljen");
            }
        }

        private void FormNoviKupac_Load(object sender, EventArgs e)
        {
          //slucajno
        }
    }
}
