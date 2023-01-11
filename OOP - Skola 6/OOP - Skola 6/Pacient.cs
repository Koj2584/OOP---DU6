using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Skola_6
{
    internal class Pacient : Osoba
    {
        float obvodPasu;
        public float ObvodPasu { get => obvodPasu; set { obvodPasu = value; } }

        public Pacient(string jmeno, string prijmeni, short hmotnost, float vyska, float obvodPasu) : base(jmeno, prijmeni, hmotnost, vyska)
        {
            this.obvodPasu = obvodPasu;
        }

        public float ABSI()
        {
            return (float)Math.Round(obvodPasu/(Math.Pow(BMI(),2/3)*Math.Pow(Vyska,1/2)),3);
        }

        public override string ToString()
        {
            return base.ToString()+"\nABSI: "+ABSI();
        }
    }
}
