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
    public partial class FormBrisanjeRezervacije : Form
    {
        List<Rezervacija> listaRezervacija;
        string putanjaRez = "Rezervacije.bin";
        public FormBrisanjeRezervacije()
        {
            InitializeComponent();
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream(putanjaRez, FileMode.Open, FileAccess.Read);
            listaRezervacija = bf.Deserialize(fs) as List<Rezervacija>;
            fs.Close();
            for (int i = 0; i < listaRezervacija.Count; i++)
            {
                cmbUIDKupcaBrisanjeRezervacija.Items.Add("Sifra kupca: "+listaRezervacija[i].UIDKupac1 + " UID auta: "+listaRezervacija[i].UIDAuto1+" "+listaRezervacija[i].DatumOd+" - "+listaRezervacija[i].DatumDo);


            }

            if (listaRezervacija.Count > 0)
            {
                cmbUIDKupcaBrisanjeRezervacija.SelectedIndex = 0;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormBrisanjeRezervacije_Load(object sender, EventArgs e)
        {

        }

        private void btnVratiSeSaBrisanjaRezervacije_Click(object sender, EventArgs e)
        {
            FormAdmin fadmin = new FormAdmin();
            fadmin.Show();
            this.Close();
        }
    }
}
