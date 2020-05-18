using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public class Korisnik
    {
        private string sifra;
        private string username;
        private string ime;
        private string prezime;

        public string Sifra { get => sifra; set => sifra = value; }
        public string Username { get => username; set => username = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }

        public Korisnik(string ime,string prezime,string username,string sifra) {
            this.sifra = sifra;
            this.username = username;
            this.ime = ime;
            this.prezime = prezime;
        }


    }
}
