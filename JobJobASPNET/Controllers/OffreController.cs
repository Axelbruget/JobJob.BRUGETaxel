using JobJobASPNET.Models;
using JobJobClass.Entity;
using JobJobService;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public ActionResult Edit(int id)
        {
            return View(getDetails(id));
        }
        public ActionResult Delete(int id)
        {
            return View(getDetails(id));
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public ActionResult EditConfirmed(OffreViewModel offreViewModel)
        {
            Offre offre = OffreVMToOffre(offreViewModel);
            service.updateOffre(offre);
            return RedirectToAction("List");
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Offre offre = service.getOffre(id);
            service.removeOffre(offre);
            return RedirectToAction("List");
        }

        [HttpPost]
        public ActionResult Create(OffreViewModel offreViewModel)
        {
            if (ModelState.IsValid)
            {
                Offre offre = OffreVMToOffre(offreViewModel);
                service.addOffre(offre);
                return RedirectToAction("List");
            }
            else
            {
                return View(offreViewModel);
            }
        }

        public OffreViewModel getDetails(int id)
        {
            OffreViewModel offreViewModel = new OffreViewModel();
            try{
                offreViewModel = OffreToOffreVM(service.getOffre(id));
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
                    listeOffreViewModel.Add(OffreToOffreVM(offre));
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
                listeOffreViewModel.Add(OffreToOffreVM(offre));
            }

            return View(listeOffreViewModel);
        }

        public OffreViewModel OffreToOffreVM(Offre offre)
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
            return offreViewModel;
        }

        public Offre OffreVMToOffre(OffreViewModel offreViewModel)
        {
            Offre offre = new Offre();
            offre.Date = offreViewModel.Date;
            offre.Description = offreViewModel.Description;
            offre.Id = offreViewModel.Id;
            offre.Intitule = offreViewModel.Intitule;
            offre.Responsable = offreViewModel.Responsable;
            offre.Salaire = offreViewModel.Salaire;
            offre.Statut = offreViewModel.Statut;
            offre.StatutId = offreViewModel.StatutId;
            return offre;
        }
    }
}