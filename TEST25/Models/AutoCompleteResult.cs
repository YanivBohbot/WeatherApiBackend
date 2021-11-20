using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TEST25.Models
{
    public class AutoCompleteResult
    {
        public int Version { get; set; }
        public string Key { get; set; }
        public string Type { get; set; }
        public int Rank { get; set; }
        public string LocalizedName { get; set; }
        public Country Country { get; set; }
        public Administrativearea AdministrativeArea { get; set; }
    
}
}
