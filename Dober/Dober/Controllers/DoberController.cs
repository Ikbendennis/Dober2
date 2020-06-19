using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Dober.Models;
using Dober.logic;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Dober.Controllers
{
    public class DoberController : Controller
    {
        Core core;
        public DoberController()
        {
            core = new Core();
        }

        // GET: /<controller>/
        public IActionResult Home()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Registreren()
        {
            return View();
        }

        public IActionResult MainMenu(GebruikerModel model)
        {
            return View(model);
        }

        public ActionResult GoToProfiel()
        {
            GebruikerModel gebruiker = new GebruikerModel();
            SetUserData(core.LoggedGebruiker, gebruiker);
            return View("Profiel", gebruiker);
        }
        
        public IActionResult Profiel(GebruikerModel model)
        {
            return View(model);
        }

        public IActionResult Verzoeken()
        {
            return View();
        }

        public IActionResult Verzoeken2()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoginClick(GebruikerModel model)
        {
            if (core.LoginCheck(model.Emailadres,model.Wachtwoord))
            {
                return View("MainMenu", model);
            }
            return RedirectToAction("Onjuist wachtwoord");
        }
        [HttpPost]
        public ActionResult RegistreerClick(RegistratieModel model)
        {
            core.AddUserToDatabase(model.Naam,model.Telefoonnummer,model.Emailadres,model.Adresgegevens,Convert.ToChar(model.ToString()),model.Wachtwoord);
            return View("Home");
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public void SetUserData(Gebruiker gebruiker,GebruikerModel model)
        {
            model.Naam = gebruiker.Naam;
            model.Emailadres = gebruiker.Emailadres;
            model.Adresgegevens = gebruiker.AdresGegevens;
            model.Telefoonnummer = gebruiker.Telefoonnummer;
            model.Geslacht = gebruiker.Geslacht;
            model.Accounttype = gebruiker.Accounttype;
        }
    }
}
