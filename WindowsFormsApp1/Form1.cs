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
    public partial class Form1 : Form
    {
        string putanjaKupca = "Kupci.bin";
        List<Kupac> listaKupaca;
        string putanjaAdmina = "listaAdmina.bin";
        List<Administrator> listaAdmina;
        public Form1()
        {
            InitializeComponent();
            
        }
        bool userFail = false;
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            string s = txtUsername.Text;
            string p = txtPassword.Text;
            if (s != "" && p != "" && s.Length > 3 && p.Length > 7)
            {
                foreach (char c in s)
                {
                    if (char.IsLetterOrDigit(c)) { userFail = false; ; }
                    else { userFail = true; break; }
                }
                if (userFail == false)
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    FileStream fs = new FileStream(putanjaAdmina, FileMode.Open, FileAccess.Read);
                    listaAdmina = bf.Deserialize(fs) as List<Administrator>;
                    fs.Close();
                    for(int i = 0; i < listaAdmina.Count; i++)
                    {
                        if (listaAdmina[i].Username.ToLower().Equals(txtUsername.Text.ToLower()))
                        {

                            if (listaAdmina[i].Sifra.ToLower().Equals(txtPassword.Text.ToLower()))
                            {
                                
                                FormAdmin fAdmin = new FormAdmin();
                                fAdmin.Show();
                                this.Hide();

                            }

                        }
                    }
                   
                }
                else
                {
                    MessageBox.Show("Niste uneli dobro username/password,molimo pokusajte ponovo");
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtUsername.Focus();
                }
            }
            else
            {
                MessageBox.Show("Niste uneli dobro username/password,molimo pokusajte ponovo");
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtUsername.Focus();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormRegistracijaKorisnika fRegistracija = new FormRegistracijaKorisnika();
            fRegistracija.Show();
            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void btnKorisnik_Click(object sender, EventArgs e)
        {
            string s = txtUsername.Text;
            string p = txtPassword.Text;
            if (s != "" && p!="" && s.Length>3 && p.Length>7)
            {
                foreach (char c in s)
                {
                    if (char.IsLetterOrDigit(c)) { userFail = false; ; }
                    else { userFail = true; break; }
                }
                if (userFail == false)
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    FileStream fs = new FileStream(putanjaKupca, FileMode.Open, FileAccess.Read);
                    listaKupaca = bf.Deserialize(fs) as List<Kupac>;
                    fs.Close();

                    bool gr = false;
                    for(int i = 0; i< listaKupaca.Count; i++)
                    {
                        if (listaKupaca[i].Username.Equals(txtUsername.Text))
                        {
                          
                            if (listaKupaca[i].Sifra.Equals(txtPassword.Text))
                            {
                                
                                FormPrikazKorisnika fPrikazKorisnik = new FormPrikazKorisnika(listaKupaca[i]);
                                fPrikazKorisnik.Show();
                                this.Hide();
                                gr = true;
                            }
                            
                        
                        }
                    }

                    if (gr == false)
                    {
                        MessageBox.Show("Korisnik ne postoji");

                        
                    }
                   // FormPrikazKorisnika fPrikzKorisnika = new FormPrikazKorisnika();
                    //fPrikzKorisnika.Show();
                   // this.Hide();
                }
                else
                {
                    MessageBox.Show("Niste uneli dobro username/password,molimo pokusajte ponovo");
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtUsername.Focus();
                }
            }
            else
            {
                MessageBox.Show("Niste uneli dobro username/password,molimo pokusajte ponovo");
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtUsername.Focus();
            }
        }
    }
}
