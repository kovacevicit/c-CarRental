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
    public partial class FormIzmenaPonude : Form
    {
        List<Ponuda> listaPonuda;
        string putanjaPonuda = "Ponuda.bin";
        public FormIzmenaPonude()
        {
            InitializeComponent();
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream(putanjaPonuda, FileMode.Open, FileAccess.Read);
            listaPonuda = bf.Deserialize(fs) as List<Ponuda>;
            fs.Close();
            for (int i = 0; i < listaPonuda.Count; i++)
            {
                cmbUIDAutaIzmena.Items.Add(listaPonuda[i].UID + " " + listaPonuda[i].DatumOd + " - " + listaPonuda[i].DatumDo);
            }
            if (listaPonuda.Count > 0)
            {
                cmbUIDAutaIzmena.SelectedIndex = 0;
            }
        }

        private void txtNovaCenaPonuda_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVratiSeIzIzmenePonude_Click(object sender, EventArgs e)
        {
            FormAdmin fadmin = new FormAdmin();
            fadmin.Show();
            this.Close();
        }

        private void btnSacuvajNovuPonudu_Click(object sender, EventArgs e)
        {
            if (txtNovaCenaPonuda.Text.All(char.IsNumber))
            {
                if (cmbUIDAutaIzmena.Text != "")
                {
                    for (int i = 0; i < listaPonuda.Count; i++)
                    {

                        if (listaPonuda[i].UID.ToString().Equals(cmbUIDAutaIzmena.Text.Split(' ').First()) &&
                            listaPonuda[i].DatumOd.Equals(cmbUIDAutaIzmena.Text.Split(' ').Skip(1).First())
                            && listaPonuda[i].DatumDo.Equals(cmbUIDAutaIzmena.Text.Split(' ').Last())
                            )
                        {
                            listaPonuda[i].DatumOd = dtpDatumOdIzmenaPonuda.Value.ToShortDateString();
                            listaPonuda[i].DatumDo = dtpDatumDoIzmenaPonuda.Value.ToShortDateString();
                            listaPonuda[i].Cena = int.Parse(txtNovaCenaPonuda.Text);
                            MessageBox.Show("Uspesno azurirana ponuda");
                            FileStream fs1 = new FileStream(putanjaPonuda, FileMode.Create, FileAccess.Write);
                            BinaryFormatter bf1 = new BinaryFormatter();
                            bf1.Serialize(fs1, listaPonuda);
                            fs1.Close();
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Morate izabrati ponudu");
                }
            }
            else
            {
                MessageBox.Show("Cena mora biti ceo broj");
            }
        }

        private void FormIzmenaPonude_Load(object sender, EventArgs e)
        {

        }

        private void cmbUIDAutaIzmena_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtpDatumOdIzmenaPonuda.Value = DateTime.Parse(cmbUIDAutaIzmena.Text.Split(' ').Skip(1).First());
            dtpDatumDoIzmenaPonuda.Value = DateTime.Parse(cmbUIDAutaIzmena.Text.Split(' ').Last());
            if (cmbUIDAutaIzmena.Text != "")
            {
                for (int i = 0; i < listaPonuda.Count; i++)
                {

                    if (listaPonuda[i].UID.ToString().Equals(cmbUIDAutaIzmena.Text.Split(' ').First()) &&
                        listaPonuda[i].DatumOd.Equals(cmbUIDAutaIzmena.Text.Split(' ').Skip(1).First())
                        && listaPonuda[i].DatumDo.Equals(cmbUIDAutaIzmena.Text.Split(' ').Last())
                        )
                    {
                        txtNovaCenaPonuda.Text = listaPonuda[i].Cena.ToString();
                    }

                }
            }
        }
    }
}
