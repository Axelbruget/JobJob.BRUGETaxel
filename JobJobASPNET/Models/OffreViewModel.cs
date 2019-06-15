using JobJobClass.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JobJobASPNET.Models
{
    public class OffreViewModel
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "Intitule")]
        public String Intitule { get; set; }

        [Display(Name = "Date")]
        public DateTime Date { get; set; }

        [Display(Name = "Salaire")]
        public Double Salaire { get; set; }

        [Display(Name = "Description")]
        public String Description { get; set; }

        [Display(Name = "StatutId")]
        public int StatutId { get; set; }

        [Display(Name = "Statut")]
        public Statut Statut { get; set; }

        [Display(Name = "Responsable")]
        public String Responsable { get; set; }
    }
}