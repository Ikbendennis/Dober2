using System;
using System.Collections.Generic;
using System.Text;

namespace Dober.logic
{
    public class Gebruiker
    {
        private int id;
        public int ID
        {
            get { return id; }
        }
        private string naam;
        public string Naam
        {
            get { return naam; }
        }
        private string telefoonnummer;

        public string Telefoonnummer
        {
            get { return telefoonnummer; }
        }

        private string emailadres;
        public string Emailadres
        {
            get { return emailadres; }
        }
        private string adresGegevens;
        public string AdresGegevens
        {
            get { return adresGegevens; }
        }
        private char geslacht;
        public char Geslacht
        {
            get { return geslacht; }
        }
        private string accounttype;
        public string Accounttype
        {
            get { return accounttype; }
        }


        public Gebruiker(string naam, string telefoonnummer, string emailadres, string adresGegevens, char geslacht, int id,string accounttype)
        {
            this.id = id;
            this.naam = naam;
            this.telefoonnummer = telefoonnummer;
            this.emailadres = emailadres;
            this.adresGegevens = adresGegevens;
            this.geslacht = geslacht;
            this.accounttype = accounttype;
        }
    }
}
