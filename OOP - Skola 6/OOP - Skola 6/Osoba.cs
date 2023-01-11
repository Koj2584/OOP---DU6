using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Skola_6
{
    class Osoba
    {
        string jmeno;
        string prijmeni;
        short hmotnost;
        float vyska;
        public string Jmeno { get => jmeno; set { jmeno = value; } }
        public string Prijmeni { get => prijmeni; set { prijmeni = value; } }
        public short Hmotnost
        {
            get => hmotnost;
            set
            {
                if (value <= 300 && value > 0)
                    hmotnost = value;
            }
        }
        public float Vyska
        {
            get => vyska;
            set
            {
                if (value < 3)
                    vyska = value;
                else
                    vyska = value / 100;
            }
        }

        public Osoba(string jmeno, string prijmeni, short hmotnost, float vyska)
        {
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.hmotnost = hmotnost;
            this.Vyska = vyska;
        }

        public virtual float BMI()
        {
            return (float)Math.Round(hmotnost / (vyska * vyska), 2);
        }

        public override string ToString()
        {
            return String.Format("Jméno: {0}\nPříjmení: {1}\nHmotnost: {2}\nVýška: {3}\nBMI: {4}", jmeno, prijmeni, hmotnost, vyska, BMI());
        }
    }
}
