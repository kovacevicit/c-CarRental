using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public class Kupac : Korisnik
    {
        protected string jmbg;
        protected string datum;
        protected string telefon;
        protected int uID;

        public Kupac(string ime,string prezime,string username,string sifra, string jmbg, string datum, string telefon,int uID) : base(ime,prezime,username,sifra) {
            this.jmbg = jmbg;
            this.datum = datum;
            this.telefon = telefon;
            this.uID = uID;
        }

        public string Jmbg { get => jmbg; set => jmbg = value; }
        public string Datum { get => datum; set => datum = value; }
        public string Telefon { get => telefon; set => telefon = value; }
        public int UID { get => uID; set => uID = value; }
    }
}
