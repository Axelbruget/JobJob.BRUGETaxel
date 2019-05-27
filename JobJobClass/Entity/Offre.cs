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
        public int Id { get; set; }

        public String Intitule { get; set; }

        public DateTime Date { get; set; }

        public Double Salaire { get; set; }

        public String Description { get; set; }

        public int StatutId { get; set; }
        [ForeignKey("StatutId")]
        public Statut Statut { get; set; }

        public String Responsable { get; set; }
    }
}
