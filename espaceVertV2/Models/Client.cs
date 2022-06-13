using espaceVertV2.Gestion;
using System;
using System.Collections.Generic;

#nullable disable

namespace espaceVertV2.Models
{
    public partial class Client
    {
        public Client(string nomclient, string prenomclient, string adresseclient, string villeclient, int? codepostalclient, string emailclient)
        {
            Nomclient = nomclient;
            Prenomclient = prenomclient;
            Adresseclient = adresseclient;
            Villeclient = villeclient;
            Codepostalclient = codepostalclient;
            Emailclient = emailclient;
        }

        public int Idclient { get; set; }
        public string Nomclient { get; set; }
        public string Prenomclient { get; set; }
        public string Adresseclient { get; set; }
        public string Villeclient { get; set; }
        public int? Codepostalclient { get; set; }
        public string Emailclient { get; set; }

     

}
}
