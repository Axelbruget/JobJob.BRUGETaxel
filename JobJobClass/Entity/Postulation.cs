using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobJobClass.Entity
{
    public class Postulation
    {
        [ForeignKey("offreId")]
        private Offre Offre { get; set; }

        [ForeignKey("employeId")]
        private Employe Employe { get; set; }

        private DateTime Date { get; set; }

        private String Statut { get; set; }

    }
}
