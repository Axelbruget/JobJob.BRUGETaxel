using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobJobClass.Entity
{
    public class Employe
    {
        public int Id { get; set; }

        public String Nom { get; set; }
        
        public String Prenom { get; set; }
        
        public DateTime DateNaissance { get; set; }
        
        public String Anciennete { get; set; }
        
        public String Biographie { get; set; }
    }
}
