using System;
using System.Collections.Generic;

#nullable disable

namespace espaceVertV2.Models
{
    public partial class Location
    {


        public int Idlocation { get; set; }
        public string Prixlocation { get; set; }
        public string Datedebutlocation { get; set; }
        public string Datefinlocation { get; set; }
        public int FaireClientIdclient { get; set; }
    }
}
