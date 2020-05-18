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
    public partial class FormBrisanjePonude : Form
    {
        List<Ponuda> listaPonuda;
        string putanjaPonuda = "Ponuda.bin";
        public FormBrisanjePonude()
        {
            InitializeComponent();
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream(putanjaPonuda, FileMode.Open, FileAccess.Read);
            listaPonuda = bf.Deserialize(fs) as List<Ponuda>;
            fs.Close();
            for (int i = 0; i < listaPonuda.Count; i++)
            {
                comboBox1.Items.Add(listaPonuda[i].UID + " " + listaPonuda[i].DatumOd + " - " + listaPonuda[i].DatumDo);
             }
            if (listaPonuda.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
            }
        }

        private void btnVratiSeIzBrisanjaPonude_Click(object sender, EventArgs e)
        {
            FormAdmin fadmin = new FormAdmin();
            fadmin.Show();
            this.Close();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                for (int i = 0;i<listaPonuda.Count; i++) {

                    if(listaPonuda[i].UID.ToString().Equals(comboBox1.Text.Split(' ').First()) &&
                        listaPonuda[i].DatumOd.Equals(comboBox1.Text.Split(' ').Skip(1).First())
                        && listaPonuda[i].DatumDo.Equals(comboBox1.Text.Split(' ').Last())
                        )
                    {
                        listaPonuda.RemoveAt(i);
                    }
                    FileStream fs = new FileStream(putanjaPonuda, FileMode.Create, FileAccess.Write);
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, listaPonuda);
                    fs.Close();
                    MessageBox.Show("Ponuda izbrisana");

                    comboBox1.Items.Clear();
                    for (int j = 0; j < listaPonuda.Count; j++)
                    {
                        comboBox1.Items.Add(listaPonuda[j].UID + " " + listaPonuda[j].DatumOd + " - " + listaPonuda[j].DatumDo);
                    }
                    if (listaPonuda.Count > 0)
                    {
                        comboBox1.SelectedIndex = 0;
                    }
                    else
                    {
                        comboBox1.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("Izaberite ponudu");
            }
           
        }
    }
}
