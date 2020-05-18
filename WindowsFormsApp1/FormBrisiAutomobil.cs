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
    public partial class FormBrisiAutomobil : Form
    {
        List<Automobil> listaAutomobila;
        string putanjaAuta = "Automobili.bin";
        public FormBrisiAutomobil()
        {
            InitializeComponent();
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream(putanjaAuta, FileMode.Open, FileAccess.Read);
            listaAutomobila = bf.Deserialize(fs) as List<Automobil>;
            fs.Close();
            for(int i = 0; i < listaAutomobila.Count; i++)
            {
                cmbUIDAuta.Items.Add(listaAutomobila[i].UID + " " + listaAutomobila[i].Marka+" "+listaAutomobila[i].Model);
                 
            }
            
        }

        private void btnVratiSeSaBrisanjaAuta_Click(object sender, EventArgs e)
        {
            FormAdmin fadmin = new FormAdmin();
            fadmin.Show();
            this.Close();
        }

        private void btnBrisiAuto_Click(object sender, EventArgs e)
        {
            if (cmbUIDAuta.Text != "")
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = new FileStream(putanjaAuta, FileMode.Open, FileAccess.Read);
                listaAutomobila = bf.Deserialize(fs) as List<Automobil>;
                fs.Close();
                int tmp = int.Parse(cmbUIDAuta.SelectedItem.ToString().Substring(0, 3));
                //MessageBox.Show(tmp.ToString());
                for (int i = 0; i < listaAutomobila.Count; i++)
                {
                    if (listaAutomobila[i].UID == tmp)
                    {
                        listaAutomobila.RemoveAt(i);
                        BinaryFormatter bf2 = new BinaryFormatter();
                        FileStream fs2 = new FileStream(putanjaAuta, FileMode.Open, FileAccess.Write);
                        bf2.Serialize(fs2, listaAutomobila);
                        fs2.Close();
                        MessageBox.Show("Auto uspesno izbrisan");

                    }
                }
                cmbUIDAuta.Items.Clear();
                BinaryFormatter bf3 = new BinaryFormatter();
                FileStream fs3 = new FileStream(putanjaAuta, FileMode.Open, FileAccess.Read);
                listaAutomobila = bf3.Deserialize(fs3) as List<Automobil>;
                fs3.Close();
                for (int i = 0; i < listaAutomobila.Count; i++)
                {
                    cmbUIDAuta.Items.Add(listaAutomobila[i].UID + " " + listaAutomobila[i].Marka + " " + listaAutomobila[i].Model);
                }
                cmbUIDAuta.Text = "";
            } else
            {
                MessageBox.Show("Izaberite Auto");
            }
        }

        private void FormBrisiAutomobil_Load(object sender, EventArgs e)
        {

        }
    }
}
