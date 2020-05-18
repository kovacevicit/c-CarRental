using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormNoviAdmin fNoviAdmin = new FormNoviAdmin();
            fNoviAdmin.Show();
            this.Close();
        }

        private void btnNazadIzKonzole_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 fPocetna = new Form1();
            fPocetna.Show();
        }

        private void btnIzmenaAutomobila_Click(object sender, EventArgs e)
        {
            FormIzmenaAuta fIzmenaAuta = new FormIzmenaAuta();
            this.Close();
            fIzmenaAuta.Show();
        }

        private void btnIzmenaKupca_Click(object sender, EventArgs e)
        {
            FormIzmenaKupca fIzmenaKupca = new FormIzmenaKupca();
            fIzmenaKupca.Show();
            this.Close();
        }

        private void btnIzmenaPonude_Click(object sender, EventArgs e)
        {
            FormIzmenaPonude fIzmenaPonude = new FormIzmenaPonude();
            fIzmenaPonude.Show();
            this.Close();
        }

        private void btnIzmenaRezervacije_Click(object sender, EventArgs e)
        {
            FormIzmenaRezervacije fIzmenaRezervacije = new FormIzmenaRezervacije();
            fIzmenaRezervacije.Show();
            this.Close();

        }

        private void btnBrisanjeAutomobila_Click(object sender, EventArgs e)
        {
            FormBrisiAutomobil fBrisiAuto = new FormBrisiAutomobil();
            fBrisiAuto.Show();
            this.Close();
            
        }

        private void btnBrisanjeKupca_Click(object sender, EventArgs e)
        {
            FormBrisiKupca fBrisiKupca = new FormBrisiKupca();
            fBrisiKupca.Show();
            this.Close();
        }

        private void btnBrisanjePonde_Click(object sender, EventArgs e)
        {
            FormBrisanjePonude fBrisanjePonude = new FormBrisanjePonude();
            fBrisanjePonude.Show();
            this.Close();
        }

        private void btnBrisanjeRezervacije_Click(object sender, EventArgs e)
        {
            FormBrisanjeRezervacije fbrisanjeRezervacije = new FormBrisanjeRezervacije();
            fbrisanjeRezervacije.Show();
            this.Close();
        }

        private void btnNoviAutomobil_Click(object sender, EventArgs e)
        {
            FormNoviAuto fNoviAuto = new FormNoviAuto();
            fNoviAuto.Show();
            this.Close();
        }

        private void btnNoviKupac_Click(object sender, EventArgs e)
        {
            FormNoviKupac fNoviKupac = new FormNoviKupac();
            fNoviKupac.Show();
            this.Close();
        }

        private void btnNovaPonuda_Click(object sender, EventArgs e)
        {
            FormNovaPonuda fNovaPonuda = new FormNovaPonuda();
            fNovaPonuda.Show();
            this.Close();
        }

        private void btnNovaRezervacija_Click(object sender, EventArgs e)
        {
            FormNovaRezervacija fNovaRez = new FormNovaRezervacija();
            fNovaRez.Show();
            this.Close();
        }

        private void btnStatistika_Click(object sender, EventArgs e)
        {
            Statistika fStatistika = new Statistika();
            fStatistika.Show();
            this.Close();
        }
    }
}
