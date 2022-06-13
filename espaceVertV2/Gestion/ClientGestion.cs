using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using espaceVertV2.Models;
using Microsoft.EntityFrameworkCore;

namespace espaceVertV2.Gestion
{
    class ClientGestion : Gestion
    {

        public Models.Client FindClientId(int id)
        {
            return Context.Clients.Find(id);
        }
        public List<Models.Client> FindClientNom(string name)
        {
            var list = Context.Clients.Where(p => p.Nomclient.StartsWith(name));
            return list.ToList();
        }

        public Models.Client FirstClientNom(string name)
        {
            return Context.Clients.Where(p => p.Nomclient.Equals(name)).FirstOrDefault();
            
        }

        public List<Models.Client> FindClientPrenom(string nom)
        {
            var list = Context.Clients.Where(p => p.Prenomclient.StartsWith(nom));
            return list.ToList();
        }

        public List<Models.Client> FindClientEmail(string nom)
        {
            var list = Context.Clients.Where(p => p.Emailclient.StartsWith(nom));
            return list.ToList();
        }

        public List<Models.Client> FindClientAdresse(string nom)
        {
            var list = Context.Clients.Where(p => p.Adresseclient.StartsWith(nom));
            return list.ToList();
        }

        public Models.Client FindClientCodepostal(int code)
        {
            return Context.Clients.Find(code);
        }



        //--- ajouter---//

        public Models.Client AddClient(Models.Client client)
        {
            //ajouter le produit à l'orm ef
            Context.Clients.Add(client);
            //valider les changements dnas la bd
            if (Context.SaveChanges() > 0)
                return client;
            return null;
        }

        //--- Supprimer---//
        public bool DeleteClient(Models.Client client)
        {
            if (client != null)
            {
                Context.Clients.Remove(client);
                return (Context.SaveChanges() > 0);
            }
            return false;
        }
        public bool DeleteClient(int id)
        {
            Models.Client client = FindClientId(id);
            if (client == null)
                return false;
            return DeleteClient(client);
        }

        // --- recuperer les clients---//

        public List<Models.Client> TousLesClient()
        {
            var list = Context.Clients.AsQueryable();
            return list.ToList();
        }

        // --- Modification d'un clients---//

        public void ModifierClients(int id, string nom, string prenom, string adresse, string ville, int code, string email)
        {

            Models.Client client = FindClientId(id);
            if (client.Nomclient != nom)
                client.Nomclient = nom;
                Context.SaveChanges();
            if(client.Prenomclient != prenom)
                client.Nomclient = prenom;
                Context.SaveChanges();
            if(client.Adresseclient != adresse)
                client.Adresseclient = adresse;
                Context.SaveChanges();
            if (client.Villeclient != ville)
                client.Villeclient = ville;
                Context.SaveChanges();
            if (client.Codepostalclient != code)
                client.Codepostalclient = code;
                Context.SaveChanges();
            if (client.Emailclient != email) { 
                client.Emailclient = email;
                Context.SaveChanges();
            }
           
        }
    }
}
