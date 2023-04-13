using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.klasy
{
    public class Osoba
    {
        protected string Imie { get; set; }
        protected string Nazwisko { get; set; }
        protected char Plec { get; set; }
        protected DateTime Dataurodzenia { get; set; }

        public Osoba(string imie, string nazwisko, char plec, DateTime dataurodzenia)
        {
            imie = imie;
            nazwisko = nazwisko;
            plec = plec;
            dataurodzenia = dataurodzenia;
        }
        public override string ToString()
        {
            return Imie + " " + Nazwisko + "\n "
                + " Dataurodzenia:" + Dataurodzenia.ToString("D");
        }



    }
}
