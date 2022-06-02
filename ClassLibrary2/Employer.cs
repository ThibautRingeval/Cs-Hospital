using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Employer
    {
        public int id;
        public string id_service_id;
        public string email;
        public List<string> roles;
        public string password;
        public string fonction;
        public string num_secu_social;
        public string nom;
        public string prenom;
        public string telephone;
        public override string ToString()
        {
            return $"{prenom} {nom} {fonction}";
        }
        public Employer(string id_service, string email, List<string> roles, string password, string fonction, string num_secu_social, string nom, string prenom, string telephone)
        {
            this.id_service_id = id_service;
            this.email = email;
            this.roles = roles;
            this.password = password;
            this.fonction = fonction;
            this.num_secu_social = num_secu_social;
            this.nom = nom;
            this.prenom = prenom;
            this.telephone = telephone;
        }
    }
}
