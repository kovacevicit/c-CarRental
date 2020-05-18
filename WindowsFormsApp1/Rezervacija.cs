using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    class Rezervacija
    {
        private int UIDAuto;
        private int UIDKupac;
        private string datumOd;
        private string datumDo;
        private double cena;

        public Rezervacija(int uIDAuto, int uIDKupac, string datumOd, string datumDo, double cena)
        {
            UIDAuto1 = uIDAuto;
            UIDKupac1 = uIDKupac;
            this.DatumOd = datumOd;
            this.DatumDo = datumDo;
            this.Cena = cena;
        }

        public int UIDAuto1 { get => UIDAuto; set => UIDAuto = value; }
        public int UIDKupac1 { get => UIDKupac; set => UIDKupac = value; }
        public string DatumOd { get => datumOd; set => datumOd = value; }
        public string DatumDo { get => datumDo; set => datumDo = value; }
        public double Cena { get => cena; set => cena = value; }
    }
}
