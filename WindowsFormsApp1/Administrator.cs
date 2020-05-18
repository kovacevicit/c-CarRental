using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public class Administrator : Korisnik
    {
        private string telefon;

        public Administrator(string ime, string prezime, string username, string sifra, string telefon) : base(ime,prezime,username,sifra) {
            this.telefon = telefon;
        }

        public string Telefon { get => telefon; set => telefon = value; }
    }
}
