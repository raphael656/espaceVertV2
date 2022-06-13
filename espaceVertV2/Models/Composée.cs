using System;
using System.Collections.Generic;

#nullable disable

namespace espaceVertV2.Models
{
    public partial class Composée
    {
        public int CommandeIdcommande { get; set; }
        public int CommandeClientIdclient { get; set; }
        public int ProduitIdproduit { get; set; }
    }
}
