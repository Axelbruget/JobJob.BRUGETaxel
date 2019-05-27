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
        public int Id { get; set; }

        public int EmployeId { get; set; }
        [ForeignKey("EmployeId")]
        public Employe Employe { get; set; }

        public String Intitule { get; set; }

        public DateTime Date { get; set; }
    }
}
