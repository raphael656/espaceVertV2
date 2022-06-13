using espaceVertV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace espaceVertV2.Gestion
{
    class ProduitGestion : Gestion
    {

        // ---rechercher---//

        public Models.Produit FindProduitId(int id)
        {
            return Context.Produits.Find(id);
        }
        public List<Models.Produit> FindProduitNom(string name)
        {
            var list = Context.Produits.Where(p => p.Nomproduit.StartsWith(name));
            return list.ToList();
        }

        public List<Models.Produit> FindProduitType(string nom)
        {
            var list = Context.Produits.Where(p => p.Typeproduit.StartsWith(nom));
            return list.ToList();
        }

        public List<Models.Produit> FindProduitquantitetotal(string nom)
        {
            var list = Context.Produits.Where(p => p.Quantitetotalproduit.StartsWith(nom));
            return list.ToList();
        }

        public List<Models.Produit> FindProduitquantitestock(int nom)
        {
            var list = Context.Produits.Where(p => p.Quantitestockproduit.Equals(nom));
            return list.ToList();
        }



        public List<Models.Produit> FindProduitquantitelouer(string nom)
        {
            var list = Context.Produits.Where(p => p.Quantitetotalproduit.StartsWith(nom));
            return list.ToList();
        }





        //--- ajouter---//

        public Models.Produit AddProduit(Models.Produit produit)
        {
            Context.Produits.Add(produit);
            if (Context.SaveChanges() > 0)
                return produit;
            return null;

        }

        //--- Supprimer---//
        public bool DeleteProduit(Models.Produit produit)
        {
            if (produit != null)
            {
                Context.Produits.Remove(produit);
                return (Context.SaveChanges() > 0);
            }
            return false;
        }
        public bool DeleteProduit(int id)
        {
            Models.Produit produit = FindProduitId(id);
            if (produit == null)
                return false;
            return DeleteProduit(produit);
        }

        // --- recuperer les Produits---//

        public List<Models.Produit> TousLesProduits()
        {
            var list = Context.Produits.AsQueryable();
            return list.ToList();
        }

      

        public List<Models.Produit> ProduitsLespluschere()
        {
            var list = Context.Produits.AsQueryable().OrderByDescending(p => p.Valeurproduit);
            var limitlist = list.Take(2);
            return limitlist.ToList();
        }

        // --- Modification d'un produit---//

        public void ModifierProduit(int id, string nom, string Type, string quantite, int prix, int Stock, string location)
        {

            Models.Produit produit = FindProduitId(id);
            if (produit.Nomproduit != nom)
                produit.Nomproduit = nom;
            Context.SaveChanges();
            if (produit.Typeproduit != Type)
                produit.Typeproduit = Type;
            Context.SaveChanges();
            if (produit.Quantitetotalproduit != quantite)
                produit.Quantitetotalproduit = quantite;
            Context.SaveChanges();
            if (produit.Valeurproduit != prix)
                produit.Valeurproduit = prix;
            Context.SaveChanges();
            if (produit.Quantitestockproduit != Stock)
                produit.Quantitestockproduit = Stock;
            Context.SaveChanges();
            if (produit.Quantitelocationproduit != location)
            {
                produit.Quantitelocationproduit = location;
                Context.SaveChanges();
            }

        
    }


}
}
