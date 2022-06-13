using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace espaceVertV2.Gestion
{
    class LocationGestion : Gestion
    {
        public Models.Location FindLocationId(int id)
        {
            return Context.Locations.Find(id);
        }


        public Models.Location Findlocationidclient(int idclient)
        {
          
            return Context.Locations.Where(p => p.FaireClientIdclient.Equals(idclient)).FirstOrDefault();
             
        }



        //--- ajouter---//

        public Models.Location AddLocation(Models.Location location)
        {
            Context.Locations.Add(location);
            if (Context.SaveChanges() > 0)
                return location;
            return null;

        }

        //--- Supprimer---//
        public bool DeleteLocation(Models.Location location)
        {
            if (location != null)
            {
                Context.Locations.Remove(location);
                return (Context.SaveChanges() > 0);
            }
            return false;
        }
        public bool DeleteLocation(int id)
        {
            Models.Location location = FindLocationId(id);
            if (location == null)
                return false;
            return DeleteLocation(location);
        }

        // --- recuperer les Locations---//

        public List<Models.Location> ToutLesLocation()
        {
            var list = Context.Locations.AsQueryable();
            return list.ToList();
        }




        // --- Modification d'un produit---//

        public void ModifierLocation(int id, string datedebut, string datefin, string prix )
        {

            Models.Location location = FindLocationId(id);
            if (location.Datedebutlocation != datedebut)
                location.Datedebutlocation = datedebut;
            Context.SaveChanges();
            if (location.Datefinlocation != datefin)
                location.Datefinlocation = datefin;
            Context.SaveChanges();
            if (location.Prixlocation != prix)
                location.Prixlocation  = prix;
            Context.SaveChanges();
            }


        }
    
}
