using System;
using System.Collections.Generic;

#nullable disable

namespace espaceVertV2.Models
{


    public partial class Produit
    {
        public Produit(string nomproduit, string quantitetotalproduit, string typeproduit, int? valeurproduit, int quantitestockproduit, string quantitelocationproduit)
        {
            Nomproduit = nomproduit;
            Quantitetotalproduit = quantitetotalproduit;
            Typeproduit = typeproduit;
            Valeurproduit = valeurproduit;
            Quantitestockproduit = quantitestockproduit;
            Quantitelocationproduit = quantitelocationproduit;
        }

        public int Idproduit { get; set; }
        public string Nomproduit { get; set; }
        public string Quantitetotalproduit { get; set; }
        public string Typeproduit { get; set; }
        public int? Valeurproduit { get; set; }
        public int Quantitestockproduit { get; set; }
        public string Quantitelocationproduit { get; set; }
    }
}
