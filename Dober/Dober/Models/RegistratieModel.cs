using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Dober.Models
{
    public enum Geslachten
    {
        M,
        V
        
    }
    public class RegistratieModel
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public string Telefoonnummer { get; set; }
        public string Emailadres { get; set; }
        public string Adresgegevens { get; set; }
        public Geslachten Geslacht { get; set; }
        public string Accounttype { get; set; }
        public string Wachtwoord { get; set; }

        public override string ToString()
        {
            if (Geslacht == Geslachten.M)
            {
                return "M";
            }
            if(Geslacht == Geslachten.V)
            {
                return "V";
            }
            return "A";
        }
    }
    
}
