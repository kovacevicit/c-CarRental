using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{ 
    [Serializable]
    public class Automobil
    {
        private string marka;
        private string model;
        private int godiste;
        private string karoserija;
        private string kubikaza;
        private string pogon;
        private string menjac;
        private string brojVrata;
        private string gorivo;
        private int uID;

        public Automobil(string marka, string model, int godiste, string karoserija, string kubikaza, string pogon, string menjac, string brojVrata, string gorivo, int uID)
        {
            this.marka = marka;
            this.model = model;
            this.godiste = godiste;
            this.karoserija = karoserija;
            this.kubikaza = kubikaza;
            this.pogon = pogon;
            this.menjac = menjac;
            this.brojVrata = brojVrata;
            this.gorivo = gorivo;
            this.uID = uID;
        }

        public string Marka { get => marka; set => marka = value; }
        public string Model { get => model; set => model = value; }
        public int Godiste { get => godiste; set => godiste = value; }
        public string Karoserija { get => karoserija; set => karoserija = value; }
        public string Kubikaza { get => kubikaza; set => kubikaza = value; }
        public string Pogon { get => pogon; set => pogon = value; }
        public string Menjac { get => menjac; set => menjac = value; }
        public string BrojVrata { get => brojVrata; set => brojVrata = value; }
        public string Gorivo { get => gorivo; set => gorivo = value; }
        public int UID { get => uID; set => uID = value; }

        
    }
}
