using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmberOOP2
{
    public class Ember
    {
        private string nev;
        private int szuletesiEv;
        private int magassag;

        // konstruktor: létrehozza az objektumot
        // mindig public és mindig megegyezik az osztály nevével
        // 3 paraméteres konstruktor: 

        public Ember (string nev, int szuletesiEv, int magassag)
        {
            this.nev = nev;
            this.szuletesiEv = szuletesiEv;
            this.magassag = magassag;
        }

        public string Nev
        {
            get
            {
                return nev;
            }
            set
            {
                this.nev = value;
            }
        }

        public int SzuletesiEv { get => szuletesiEv; }
        public int Magassag { get => magassag; set => magassag = value; }
    }
}
