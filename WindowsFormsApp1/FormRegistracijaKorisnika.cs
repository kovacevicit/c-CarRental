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
    public partial class FormRegistracijaKorisnika : Form
    {
        string putanjaKupca = "Kupci.bin";
        List<Kupac> listaKupaca;
        int pomocna = 100;
        bool kupacPostoji = false;

        public FormRegistracijaKorisnika()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtNoviKupacIme.Text != "" || txtNoviKupacJMBG.Text != "" || txtNoviKupacPassword.Text != "" ||
               txtNoviKupacPrezime.Text != "" || txtNoviKupacTelefon.Text!= "" || txtNoviKupacUser.Text != "") {

               if( MessageBox.Show("Da li ste sigurni?", "Upozorenje", MessageBoxButtons.OKCancel)== DialogResult.OK){
                    Form1 fGlavna = new Form1();
                    fGlavna.Show();
                    this.Hide();
                }
                else
                {
                   //Nista
                }
            }
            else
            {
                Form1 fGlavna = new Form1();
                fGlavna.Show();
                this.Hide();
            }

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
                    if (kupacPostoji == false) {
                        string ime = txtNoviKupacIme.Text;
                        string prezime = txtNoviKupacPrezime.Text;
                        string jmbg = txtNoviKupacJMBG.Text;
                        string telefon = txtNoviKupacTelefon.Text;
                        string password = txtNoviKupacPassword.Text;
                        string user = txtNoviKupacUser.Text;
                        if (ime.Length < 3 || prezime.Length < 3 || jmbg.Length<13 || password.Length<8 || user.Length < 3)
                        {
                            MessageBox.Show("Napravili ste neku od sledecih gresaka \n" +
                                "Ime je manje od 3 slova \n" +
                                "Prezime je manje od 3 slova \n" +
                                "JMBG je manji od 13 brojeva \n" +
                                "Password je manji od 8 karaktera \n" +
                                "username je manji od 3 karaktera");

                        }
                        else
                        {
                            int tmp = listaKupaca.Count;
                            listaKupaca.Add(new Kupac(txtNoviKupacIme.Text, txtNoviKupacPrezime.Text, txtNoviKupacUser.Text, txtNoviKupacPassword.Text, txtNoviKupacJMBG.Text, dtpNoviKupacRodjenje.Value.ToShortDateString(), txtNoviKupacTelefon.Text, listaKupaca[tmp - 1].UID + 1));
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
                    
                    }
                    else
                    {
                        
                        
                    }
                }
                
            }
            else
            {
                listaKupaca = new List<Kupac>();
                listaKupaca.Add(new Kupac(txtNoviKupacIme.Text, txtNoviKupacPrezime.Text, txtNoviKupacUser.Text, txtNoviKupacPassword.Text, txtNoviKupacJMBG.Text, dtpNoviKupacRodjenje.Value.ToShortDateString(), txtNoviKupacTelefon.Text, pomocna));
                FileStream fs = new FileStream(putanjaKupca, FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, listaKupaca);
                fs.Close();
                MessageBox.Show("Kupac uspesno napravljen");
                txtNoviKupacIme.Text = "";
                txtNoviKupacJMBG.Text = "";
                txtNoviKupacPassword.Text = "";
                txtNoviKupacPrezime.Text = "";
                txtNoviKupacTelefon.Text = "";
                txtNoviKupacUser.Text = "";
                txtNoviKupacIme.Focus();
            }
        }

        private void FormRegistracijaKorisnika_Load(object sender, EventArgs e)
        {
          //  BinaryFormatter bf = new BinaryFormatter();
          //  FileStream fs = new FileStream(putanjaKupca, FileMode.Open, FileAccess.Read);
          //  listaKupaca = bf.Deserialize(fs) as List<Kupac>;
          //  fs.Close();
          //  MessageBox.Show(listaKupaca.Count.ToString());
        }

        private void FormRegistracijaKorisnika_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(1);
        }
    }
}
