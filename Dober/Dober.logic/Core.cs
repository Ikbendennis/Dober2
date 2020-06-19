using System;
using System.Collections.Generic;
using System.Text;

namespace Dober.logic
{
    public class Core
    {

        DBRequester dBRequester;
        static Gebruiker loggedGebruiker;
        public Gebruiker LoggedGebruiker { get => loggedGebruiker; }
        public Core()
        {
            dBRequester = new DBRequester();
        }

        public bool LoginCheck(string email, string ww)
        {
            if (ww != dBRequester.OutputRequest("SELECT Wachtwoord FROM gebruikers WHERE Emailadres = '" + email + "'", "Wachtwoord"))
            {
                return false;
            }
            else
            {
               loggedGebruiker = GetUserData(email);
                return true;
            }
        }
        public Gebruiker GetUserData(string email)
        {
            List<string> UserData = null;
            UserData = dBRequester.ListOutputRequest("SELECT ID, Naam, Telefoonnummer, Emailadres, Adresgegevens, Geslacht, Accounttype FROM gebruikers WHERE Emailadres = '" +email+ "'", new List<string> { "ID", "Naam", "Telefoonnummer", "Emailadres", "Adresgegevens", "Geslacht", "Accounttype" });
        
            Gebruiker gebruiker = new Gebruiker(UserData[1],UserData[2],UserData[3],UserData[4],Convert.ToChar(UserData[5]),Convert.ToInt32(UserData[0]),UserData[6]);
            return gebruiker;
        }
        public void AddUserToDatabase(string naam, string telnr, string email, string adres, char geslacht,string ww)
        {
            dBRequester.InputRequest("INSERT INTO gebruikers (Naam,Telefoonnummer,EmailAdres,Adresgegevens,Geslacht,Wachtwoord) VALUES" + "(" + "'" +naam+ "'" + "," + "'" + telnr + "'" + "," + "'" + email + "'" + "," + "'" + adres + "'" + "," + "'" + geslacht+ "'" + "," + "'" + ww + "'" + ")");
        }

        public string GetAllHonden(int gebruikersid)
        {
            List<List<string>> honden = null;
            honden = dBRequester.RequestHonden("SELECT Naam, Leeftijd, Gewicht, Formaat, Geslacht, 'Speciale Eisen' FROM hond WHERE BaasjeID ='" + gebruikersid + "'", new List<string> { "Naam", "Leeftijd", "Gewicht", "Formaat", "Geslacht", "Speciale Eisen" }, gebruikersid);
            return honden[0][0];
        }

    }
}
