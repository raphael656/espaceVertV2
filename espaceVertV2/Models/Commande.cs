using System;
using System.Collections.Generic;

#nullable disable

namespace espaceVertV2.Models
{
    public partial class Commande
    {
        public int Idcommande { get; set; }
        public string Datecommande { get; set; }
        public DateTime? Delaicommande { get; set; }
        public string Prixdecommande { get; set; }
        public int ClientIdclient { get; set; }
        public int PasseClientIdclient { get; set; }
    }
}
