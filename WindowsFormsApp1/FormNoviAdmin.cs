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
    public partial class FormNoviAdmin : Form
    {
        string putanjaAdmina ="listaAdmina.bin";
        List<Administrator> listaAdmina;
        bool adminPostoji = false;
        
        public FormNoviAdmin()
        {
            InitializeComponent();
           
        }

        private void btnVratiSeIzNovogAdmina_Click(object sender, EventArgs e)
        {
            FormAdmin fadmin = new FormAdmin();
            fadmin.Show();
            this.Close();
        }

        private void btnNapraviAdmina_Click(object sender, EventArgs e)
        {

            if (File.Exists(putanjaAdmina)) {

                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = new FileStream(putanjaAdmina, FileMode.Open, FileAccess.Read);
                listaAdmina = bf.Deserialize(fs) as List<Administrator>;
                fs.Close();
                for (int i = 0; i < listaAdmina.Count; i++) {
                    if (listaAdmina[i].Username.Equals(txtUsernameAdmina.Text))
                    {
                        adminPostoji = true;
                       
                    } 
                }

                if (adminPostoji == true)
                {
                    MessageBox.Show("Korisnicko ime je zauzetu, molimo vas pokusajte ponovo");
                    txtUsernameAdmina.Text = "";
                    txtUsernameAdmina.Focus();
                    adminPostoji = false;

                }
                else
                { 
                    if(txtUsernameAdmina.Text.Length>3 && txtSifraAdmina.Text.Length > 7) { 
                    listaAdmina.Add(new Administrator(txtImeAdmina.Text, txtPrezimeAdmina.Text, txtUsernameAdmina.Text, txtSifraAdmina.Text, txtTelefonAdmina.Text));
                    FileStream fs2 = new FileStream(putanjaAdmina, FileMode.Open, FileAccess.Write);
                    BinaryFormatter bf2 = new BinaryFormatter();
                    bf2.Serialize(fs2, listaAdmina);
                    fs2.Close();
                    MessageBox.Show("Admin uspesno napravljen");
                    txtUsernameAdmina.Text = "";
                    txtTelefonAdmina.Text = "";
                    txtSifraAdmina.Text = "";
                    txtPrezimeAdmina.Text = "";
                    txtImeAdmina.Text = "";
                    txtImeAdmina.Focus();
                    } else
                    {
                        MessageBox.Show("Prekratka lozinka", "Upozorenje", MessageBoxButtons.OK);
                        txtSifraAdmina.Text = "";
                        txtSifraAdmina.Focus();
                    }
                }

            }
            else
            {
                listaAdmina = new List<Administrator>();
                listaAdmina.Add(new Administrator(txtImeAdmina.Text, txtPrezimeAdmina.Text, txtUsernameAdmina.Text, txtSifraAdmina.Text, txtTelefonAdmina.Text));
                FileStream fs = new FileStream(putanjaAdmina, FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, listaAdmina);
                fs.Close();
                MessageBox.Show("Admin uspesno napravljen");
                txtUsernameAdmina.Text = "";
                txtTelefonAdmina.Text = "";
                txtSifraAdmina.Text = "";
                txtPrezimeAdmina.Text = "";
                txtImeAdmina.Text = "";
                txtImeAdmina.Focus();

            }
        }
    }
}
