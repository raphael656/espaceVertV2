using System;
using System.Collections.Generic;

#nullable disable

namespace espaceVertV2.Models
{
    public partial class Admin
    {

        public Admin(string identifiant, string password)
        {
            Identifiant = identifiant;
            Password = password;
        }
        public int Idadmin { get; set; }
        public string Identifiant { get; set; }
        public string Password { get; set; }
    }


}
