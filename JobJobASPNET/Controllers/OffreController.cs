using JobJobASPNET.Models;
using JobJobClass.Entity;
using JobJobService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace JobJobASPNET.Controllers
{
    public class OffreController : Controller
    {
        private Service service = new Service();
        public ActionResult List()
        {
            return View(getOffres());
        }
        public ActionResult Details(int id)
        {
            return View(getDetails(id));
        }

        public OffreViewModel getDetails(int id)
        {
            OffreViewModel offreViewModel = new OffreViewModel();
            try{
                Offre offre = service.getOffre(id);
                offreViewModel.Date = offre.Date;
                offreViewModel.Description = offre.Description;
                offreViewModel.Id = offre.Id;
                offreViewModel.Intitule = offre.Intitule;
                offreViewModel.Responsable = offre.Responsable;
                offreViewModel.Salaire = offre.Salaire;
                offreViewModel.Statut = offre.Statut;
                offreViewModel.StatutId = offre.StatutId;
            }
            catch (Exception e)
            {
                throw e;
            }
            return offreViewModel;
        }
        public List<OffreViewModel> getOffres() { 
            List<OffreViewModel> listeOffreViewModel = new List<OffreViewModel>();
            try
            {
                List<Offre> listOffres = service.getOffres();
                foreach(Offre offre in listOffres)
                {
                    OffreViewModel offreViewModel = new OffreViewModel();
                    offreViewModel.Date = offre.Date;
                    offreViewModel.Description = offre.Description;
                    offreViewModel.Id = offre.Id;
                    offreViewModel.Intitule = offre.Intitule;
                    offreViewModel.Responsable = offre.Responsable;
                    offreViewModel.Salaire = offre.Salaire;
                    offreViewModel.Statut = offre.Statut;
                    offreViewModel.StatutId = offre.StatutId;
                    listeOffreViewModel.Add(offreViewModel);
                }
            }catch(Exception e)
            {
                throw e;
            }
            return listeOffreViewModel;
        }

        public ActionResult SearchOffre(string searchString)
        {
            List<Offre> listeOffre = service.getOffres();

            if (!string.IsNullOrEmpty(searchString))
            {
                listeOffre = listeOffre.Where(s => s.Intitule.Contains(searchString)).ToList();
            }

            List<OffreViewModel> listeOffreViewModel = new List<OffreViewModel>();

            foreach (Offre offre in listeOffre)
            {
                OffreViewModel offreViewModel = new OffreViewModel();
                offreViewModel.Date = offre.Date;
                offreViewModel.Description = offre.Description;
                offreViewModel.Id = offre.Id;
                offreViewModel.Intitule = offre.Intitule;
                offreViewModel.Responsable = offre.Responsable;
                offreViewModel.Salaire = offre.Salaire;
                offreViewModel.Statut = offre.Statut;
                offreViewModel.StatutId = offre.StatutId;
                listeOffreViewModel.Add(offreViewModel);
            }

            return View(listeOffreViewModel);
        }
    }
}