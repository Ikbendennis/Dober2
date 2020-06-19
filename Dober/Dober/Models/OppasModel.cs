using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dober.Models
{
    public class OppasModel
    {
        public int Id { get; set; }
        public int GebruikersId { get; set; }
        public bool Beschikbaar { get; set; }
        public int Capaciteit { get; set; }
        public int Score { get; set; }
    }
}
