using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using espaceVertV2.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace espaceVertV2.Gestion
{
    class AdminGestion : Gestion
    {
        // --- rechercher Admin --- //

        public Admin FindAdminId(int id)
        {
            return Context.Admins.Find(id);
        }
        public Admin FindAdminIdentifiant(string log)
            => Context.Admins.FirstOrDefault(admin => admin.Identifiant == log);

        public List<Admin> FindAdminPassword(string password)
        {
            var list = Context.Admins.Where(p => p.Identifiant.StartsWith(password));
            return list.ToList();
        }

        // ----- ADD -----
        public Admin AddAdmin(Admin admin)
        {
            //ajouter le produit à l'orm ef
            Context.Admins.Add(admin);
            //valider les changements dnas la bd
            if (Context.SaveChanges() > 0)
                return admin;
            return null;
        }

        // ----- DELETE -----
        public bool DeleteAdmin(Admin admin)
        {
            if (admin != null)
            {
                Context.Admins.Remove(admin);
                return (Context.SaveChanges() > 0);
            }
            return false;
        }
        public bool DeleteAdmin(int id)
        {
            Admin admin = FindAdminId(id);
            if (admin == null)
                return false;
            return DeleteAdmin(admin);
        }

        // ----- EDIT -----
        public bool Edit(Admin admin)
        {
            //mettre le status de l'entité à modifier dans l'orm
            Context.Entry(admin).State = EntityState.Modified;
            //valider les changement dans la bd
            return (Context.SaveChanges() > 0);
        }

        // --- recuperer les Produits---//

        public List<Models.Admin> TousLesAdmin()
        {
            return Context.Admins.ToList();
        }


       

        // --- Modification d'un produit---//

        public void ModifierProduit(int id, string identifiant, string password)
        {

            Models.Admin admin = FindAdminId(id);
            if (admin.Identifiant != identifiant)
                admin.Identifiant = identifiant;
            Context.SaveChanges();
            if (admin.Password != password)
                admin.Password = password;
            Context.SaveChanges();
            


        }

    }
}
