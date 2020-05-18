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
    

    public partial class FormNovaPonuda : Form
    {
        List<Ponuda> listaPonuda;
        List<Automobil> listaAutomobila;
        int pomocna = 100;
        string putanjaPonuda = "Ponuda.bin";
        string putanjaAuta = "Automobili.bin";
        public FormNovaPonuda()
        {
            InitializeComponent();
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream(putanjaAuta, FileMode.Open, FileAccess.Read);
            listaAutomobila = bf.Deserialize(fs) as List<Automobil>;
            fs.Close();
            for(int i = 0; i < listaAutomobila.Count; i++)
            {
                cmbUIDAuta.Items.Add(listaAutomobila[i].UID+" "+listaAutomobila[i].Marka+" "+listaAutomobila[i].Model );
            }
          //  FileStream fs2 = new FileStream(putanjaAuta, FileMode.Open, FileAccess.Write);
          //  BinaryFormatter bf2 = new BinaryFormatter();
           // bf2.Serialize(fs2, listaAutomobila);
           // fs2.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormAdmin fadmin = new FormAdmin();
            fadmin.Show();
            this.Close();
        }

        private void FormNovaPonuda_QueryAccessibilityHelp(object sender, QueryAccessibilityHelpEventArgs e)
        {
            //Slucajno
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists(putanjaPonuda) && dtpDatumDo.Value>=dtpDatumOd.Value) {

                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = new FileStream(putanjaPonuda, FileMode.Open, FileAccess.Read);
                listaPonuda = bf.Deserialize(fs) as List<Ponuda>;
                fs.Close();
                if (cmbUIDAuta.SelectedIndex > -1 && txtCena.Text!="" && txtCena.Text.All(char.IsNumber)) { 
                listaPonuda.Add(new Ponuda(int.Parse(cmbUIDAuta.Text.Split(' ').First()), dtpDatumOd.Value.ToShortDateString(), dtpDatumDo.Value.ToShortDateString(), int.Parse(txtCena.Text)));
                FileStream fs2 = new FileStream(putanjaPonuda, FileMode.Open, FileAccess.Write);
                BinaryFormatter bf2 = new BinaryFormatter();
                bf2.Serialize(fs2, listaPonuda);
                fs2.Close();
                MessageBox.Show("Ponuda uspesno napravljena");
                }
                else
                {
                    MessageBox.Show("Niste izabrali sva polja ili ste pogresili u polju za cenu");
                }
            }
            else
            {
                if (dtpDatumDo.Value >= dtpDatumOd.Value) { 
                listaPonuda = new List<Ponuda>();
                listaPonuda.Add(new Ponuda(int.Parse(cmbUIDAuta.Text.Split(' ').First()), dtpDatumOd.Value.ToShortDateString(), dtpDatumDo.Value.ToShortDateString(), int.Parse(txtCena.Text)));
                FileStream fs = new FileStream(putanjaPonuda, FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, listaPonuda);
                fs.Close();
                MessageBox.Show("Ponuda uspesno napravljena");
                }
                else
                {
                    MessageBox.Show("Datum do mora biti veci od datuma od");
                }
            }
        }
    }
}
