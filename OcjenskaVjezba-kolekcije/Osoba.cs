using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OcjenskaVjezba_kolekcije
{
    internal class Osoba
    {
        string ime, prezime;
        char spol;
        int godRod;

        public Osoba(string ime, string prezime, char spol, int godRod)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.Spol = spol;
            this.GodRod = godRod;
        }

        #region get/set
        string Ime { get => ime; set => ime = value; }
        string Prezime { get => prezime; set => prezime = value; }
        char Spol { get => spol; set => spol = value; }
        int GodRod { get => godRod; set => godRod = value; }
        #endregion

        public override string ToString()
        {
            string ispis = null;

            switch(spol)
            {
                case 'M':
                    ispis = "\n" + this.Ime + "\t\t" + this.Prezime + "\t\t"
                        + this.GodRod + "\t\t" + this.Spol + "\t\t" + "Ima brkove";
                    break;

                case 'F':
                    ispis = "\n" + this.Ime + "\t\t" + this.Prezime + "\t\t"
                        + this.GodRod + "\t\t" + this.Spol + "\t\t" + "Nema brkove";
                    break;

            }

            return ispis;
        }
    }
}
