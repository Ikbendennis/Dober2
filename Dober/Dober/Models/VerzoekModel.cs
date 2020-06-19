using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dober.Models
{
    public class VerzoekModel
    {
        public int Id { get; set; }
        public int HondId { get; set; }
        public int OppasId { get; set; }
        public bool Bezig { get; set; }
    }
}
