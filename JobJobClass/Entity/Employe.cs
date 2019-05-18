using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobJobClass.Entity
{
    public class Employe
    {
        private int Id { get; set; }

        private String Nom { get; set; }
        
        private String Prenom { get; set; }
        
        private DateTime DateNaissance { get; set; }
        
        private String Anciennete { get; set; }
        
        private String Biographie { get; set; }
    }
}
