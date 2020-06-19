using System;
using System.Collections.Generic;
using System.Text;

namespace Dober.logic
{
    class Hond
    {
        string naam;
        int leeftijd;
        int gewicht;
        string formaat;
        char geslacht;
        string specialeEisen;
        double score;

        public Hond(string Naam, int Leeftijd, int Gewicht, string Formaat, char Geslacht)
        {
            this.naam = Naam;
            this.leeftijd = Leeftijd;
            this.gewicht = Gewicht;
            this.formaat = Formaat;
            this.geslacht = Geslacht;
        }

        public Hond(string Naam, int Leeftijd, int Gewicht, string Formaat, char Geslacht, string SpecialeEisen)
        {
            this.naam = Naam;
            this.leeftijd = Leeftijd;
            this.gewicht = Gewicht;
            this.formaat = Formaat;
            this.geslacht = Geslacht;
            this.specialeEisen = SpecialeEisen;
        }
    }
}
