using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobJobClass.Entity
{
    public class Offre
    {
        private int Id { get; set; }
        
        private String Intitule { get; set; }
        
        private DateTime Date { get; set; }
        
        private float Salaire { get; set; }
        
        private String Description { get; set; }
        
        [ForeignKey("statutId")]
        private Statut Statut { get; set; }

        private String Responsable { get; set; }
    }
}
