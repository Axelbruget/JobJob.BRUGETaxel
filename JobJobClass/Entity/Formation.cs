using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobJobClass.Entity
{
    public class Formation
    {
        private int Id { get; set; }

        [ForeignKey("employeId")]
        private Employe Employe { get; set; }

        private String Intitule { get; set; }

        private DateTime Date { get; set; }
    }
}
