using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmberOOP2
{
    public class Ember
    {
        // mindig private
        // 1.: 

        private string nev;
        private int szuletesiEv;
        private int magassag;

        // konstruktor: létrehozza az objektumot
        // mindig public és mindig megegyezik az osztály nevével
        // 3 paraméteres konstruktor: 

        // 2.: konstrukorok
        public Ember (string nev, int szuletesiEv, int magassag)
        {
            this.nev = nev;
            this.szuletesiEv = szuletesiEv;
            this.magassag = magassag;
        }

        public Ember (string nev, int magassag)
        {
            this.nev = nev;
            this.magassag = magassag;
            this.szuletesiEv = DateTime.Now.Year;
        }

        public Ember (int magassag)
        {
            this.nev = "Margaréta";
            this.magassag = magassag;
            this.szuletesiEv = DateTime.Now.Year;
        }

        // 3. Property - get: tulajdonsagok lekerdezese; set: tulajdonsagok modositasa:
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
        
        // 4.: egyéb metodusok
        public int EletkorMetodus()
        {
            return DateTime.Now.Year - this.SzuletesiEv;
        }

        public int Eletkor
        {
            get
            {
                return DateTime.Now.Year - this.szuletesiEv;
            }
        }

        // 5.: ToString: kiiratas
        public override string ToString()
        {
            return $"{this.nev} {this.szuletesiEv} {this.magassag}cm";
        }
    }
}
