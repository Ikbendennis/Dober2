using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dober.Models
{
    public class HondModel
    {
        public int Id { get; set; }
        public int GebruikersId { get; set; }
        public string Naam { get; set; }
        public int Leeftijd { get; set; }
        public char Gewicht { get; set; }
        public string Formaat { get; set; }
        public string SpecialeEisen { get; set; }
        public int Score { get; set; }
    }
    // dit is een DTO(dto heeft geen methodes, domeinmodel wel)
}
