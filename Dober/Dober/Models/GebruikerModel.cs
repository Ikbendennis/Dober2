using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dober.Models
{
    public class GebruikerModel
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public string Telefoonnummer { get; set; }
        public string Emailadres { get; set; }
        public string Adresgegevens { get; set; }
        public char Geslacht { get; set; }
        public string Accounttype { get; set; }
        public string Wachtwoord { get; set; }
    }
}
