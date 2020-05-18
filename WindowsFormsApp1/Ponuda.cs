using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public class Ponuda
    {
        private int uID;
        private string datumOd;
        private string datumDo;
        private int cena;

        public Ponuda(int uID, string datumOd, string datumDo, int cena)
        {
            this.uID = uID;
            this.datumOd = datumOd;
            this.datumDo = datumDo;
            this.cena = cena;
        }

        public int UID { get => uID; set => uID = value; }
        public string DatumOd { get => datumOd; set => datumOd = value; }
        public string DatumDo { get => datumDo; set => datumDo = value; }
        public int Cena { get => cena; set => cena = value; }
    }
}
