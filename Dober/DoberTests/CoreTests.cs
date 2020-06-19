using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dober.logic;
using System;
using System.Collections.Generic;

namespace DoberTests
{
    [TestClass]
    public class CoreTests
    {
        Core core = new Core();
       // [TestMethod]
        public void CheckEmail()
        {
            string emailToCheck = "Dennisvepc@gmail.com";
            Gebruiker gebruiker = core.GetUserData(emailToCheck);

            Assert.AreEqual(gebruiker.Emailadres, emailToCheck);
        }
        //[TestMethod]
        public void CheckLogin()
        {
            bool logincheck = true;
            Assert.AreEqual(logincheck, core.LoginCheck("Dennisvepc@gmail.com", "Koekjes"));
        }
        //[TestMethod]
        public void GetUserDataTest()
        {
            Gebruiker verwachteGebruiker = new Gebruiker("Dennis van Engelen", "0636222163", "Dennisvepc@gmail.com", "Nieuwstraat 100 Gilze 5126CG",Convert.ToChar("M"), 7, "Gebruiker");
            Gebruiker gebruiker = core.GetUserData("Dennisvepc@gmail.com");

            Assert.AreEqual(verwachteGebruiker.Naam, gebruiker.Naam);
            Assert.AreEqual(verwachteGebruiker.Telefoonnummer, gebruiker.Telefoonnummer);
            Assert.AreEqual(verwachteGebruiker.Emailadres, gebruiker.Emailadres);
            Assert.AreEqual(verwachteGebruiker.AdresGegevens, gebruiker.AdresGegevens);
            Assert.AreEqual(verwachteGebruiker.Geslacht, gebruiker.Geslacht);
            Assert.AreEqual(verwachteGebruiker.ID, gebruiker.ID);
            Assert.AreEqual(verwachteGebruiker.Accounttype, gebruiker.Accounttype);

        }

        [TestMethod]
        public void GetHondenTest()
        {
            string g = "2";
            string t  = core.GetAllHonden(5);
            Assert.AreEqual(g, t);
        }
    }

}
