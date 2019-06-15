using JobJobClass.Entity;
using JobJobClass.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobJobService
{
    public class Service : ServiceInterface
    {
        private AppContexte contexte;
        
        public Service()
        {
            this.contexte = new AppContexte();
        }

        public void addEmploye(Employe employe)
        {
            Employe entity = this.contexte.Employes.Where(e => e.Id == employe.Id).FirstOrDefault();

            if (entity != null)
            {
                Console.WriteLine("Cet employé existe déjà en base");
            }
            else
            {
                this.contexte.Employes.Add(employe);
                this.contexte.SaveChanges();
            }
        }

        public void addExperience(Experience experience)
        {
            Experience entity = this.contexte.Experiences.Where(e => e.Id == experience.Id).FirstOrDefault();

            if (entity != null)
            {
                Console.WriteLine("Cette expérience existe déjà en base");
            }
            else
            {
                this.contexte.Experiences.Add(experience);
                this.contexte.SaveChanges();
            }
        }

        public void addFormation(Formation formation)
        {
            Formation entity = this.contexte.Formations.Where(e => e.Id == formation.Id).FirstOrDefault();

            if (entity != null)
            {
                Console.WriteLine("Cette formation existe déjà en base");
            }
            else
            {
                this.contexte.Formations.Add(formation);
                this.contexte.SaveChanges();
            }
        }

        public void addOffre(Offre offre)
        {
            Offre entity = this.contexte.Offres.Where(e => e.Id == offre.Id).FirstOrDefault();

            if (entity != null)
            {
                Console.WriteLine("Cette offre existe déjà en base");
            }
            else
            {
                this.contexte.Offres.Add(offre);
                this.contexte.SaveChanges();
            }
        }

        public void addPostulation(Postulation postulation)
        {
            Postulation entity = this.contexte.Postulations.Where(e => e.Id == postulation.Id).FirstOrDefault();

            if (entity != null)
            {
                Console.WriteLine("Cette postulation existe déjà en base");
            }
            else
            {
                this.contexte.Postulations.Add(postulation);
                this.contexte.SaveChanges();
            }
        }

        public void addStatut(Statut statut)
        {
            Statut entity = this.contexte.Statuts.Where(e => e.Id == statut.Id).FirstOrDefault();

            if (entity != null)
            {
                Console.WriteLine("Ce statut existe déjà en base");
            }
            else
            {
                this.contexte.Statuts.Add(statut);
                this.contexte.SaveChanges();
            }
        }

        public List<Employe> getEmployes()
        {
            return this.contexte.Employes.ToList();
        }

        public List<Experience> getExperiences()
        {
            return this.contexte.Experiences.ToList();
        }

        public List<Formation> getFormations()
        {
            return this.contexte.Formations.ToList();
        }

        public List<Offre> getOffres()
        {
            return this.contexte.Offres.ToList();
        }

        public List<Postulation> getPostulations()
        {
            return this.contexte.Postulations.ToList();
        }

        public List<Statut> getStatuts()
        {
            return this.contexte.Statuts.ToList();
        }

        public void removeEmploye(Employe employe)
        {
            Employe entity = this.contexte.Employes.Where(e => e.Id == employe.Id).FirstOrDefault();

            if (entity == null)
            {
                Console.WriteLine("Cet employé n'existe pas en base");
            }
            else
            {
                this.contexte.Employes.Remove(employe);
                this.contexte.SaveChanges();
            }
        }

        public void removeExperience(Experience experience)
        {
            Experience entity = this.contexte.Experiences.Where(e => e.Id == experience.Id).FirstOrDefault();

            if (entity == null)
            {
                Console.WriteLine("Cette expérience n'existe pas en base");
            }
            else
            {
                this.contexte.Experiences.Remove(experience);
                this.contexte.SaveChanges();
            }
        }

        public void removeFormation(Formation formation)
        {
            Formation entity = this.contexte.Formations.Where(e => e.Id == formation.Id).FirstOrDefault();

            if (entity == null)
            {
                Console.WriteLine("Cette formation n'existe pas en base");
            }
            else
            {
                this.contexte.Formations.Remove(formation);
                this.contexte.SaveChanges();
            }
        }

        public void removeOffre(Offre offre)
        {
            Offre entity = this.contexte.Offres.Where(e => e.Id == offre.Id).FirstOrDefault();

            if (entity == null)
            {
                Console.WriteLine("Cette offre n'existe pas en base");
            }
            else
            {
                this.contexte.Offres.Remove(offre);
                this.contexte.SaveChanges();
            }
        }

        public void removePostulation(Postulation postulation)
        {
            Postulation entity = this.contexte.Postulations.Where(e => e.Id == postulation.Id).FirstOrDefault();

            if (entity == null)
            {
                Console.WriteLine("Cette postulation n'existe pas en base");
            }
            else
            {
                this.contexte.Postulations.Remove(postulation);
                this.contexte.SaveChanges();
            }
        }

        public void removeStatut(Statut statut)
        {
            Statut entity = this.contexte.Statuts.Where(e => e.Id == statut.Id).FirstOrDefault();

            if (entity == null)
            {
                Console.WriteLine("Ce statut n'existe pas en base");
            }
            else
            {
                this.contexte.Statuts.Remove(statut);
                this.contexte.SaveChanges();
            }
        }

        public void updateEmploye(Employe employe)
        {
            Employe entity = this.contexte.Employes.Where(e => e.Id == employe.Id).FirstOrDefault();

            if (entity != null)
            {
                entity.Nom = employe.Nom;
                entity.Prenom = employe.Prenom;
                entity.DateNaissance = employe.DateNaissance;
                entity.Anciennete = employe.Anciennete;
                entity.Biographie = employe.Biographie;
                this.contexte.SaveChanges();
            }
            else
            {
                Console.WriteLine("Cet employé n'existe pas en base");
            }
        }

        public void updateExperience(Experience experience)
        {
            Experience entity = this.contexte.Experiences.Where(e => e.Id == experience.Id).FirstOrDefault();

            if (entity != null)
            {
                entity.Date = experience.Date;
                entity.EmployeId = experience.EmployeId;
                entity.Employe = experience.Employe;
                entity.Intitule = experience.Intitule;
                this.contexte.SaveChanges();
            }
            else
            {
                Console.WriteLine("Cette expérience n'existe pas en base");
            }
        }

        public void updateFormation(Formation formation)
        {
            Formation entity = this.contexte.Formations.Where(e => e.Id == formation.Id).FirstOrDefault();

            if (entity != null)
            {
                entity.Date = formation.Date;
                entity.Employe = formation.Employe;
                entity.EmployeId = formation.EmployeId;
                entity.Intitule = formation.Intitule;
                this.contexte.SaveChanges();
            }
            else
            {
                Console.WriteLine("Cette formation n'existe pas en base");
            }
        }

        public void updateOffre(Offre offre)
        {
            Offre entity = this.contexte.Offres.Where(e => e.Id == offre.Id).FirstOrDefault();

            if (entity != null)
            {
                entity.Intitule = offre.Intitule;
                entity.Responsable = offre.Responsable;
                entity.Salaire = offre.Salaire;
                entity.Statut = offre.Statut;
                entity.StatutId = offre.StatutId;
                entity.Description = offre.Description;
                entity.Date = offre.Date;
                this.contexte.SaveChanges();
            }
            else
            {
                Console.WriteLine("Cette offre n'existe pas en base");
            }
        }

        public void updatePostulation(Postulation postulation)
        {
            Postulation entity = this.contexte.Postulations.Where(e => e.Id == postulation.Id).FirstOrDefault();

            if (entity != null)
            {
                entity.Date = postulation.Date;
                entity.Employe = postulation.Employe;
                entity.EmployeId = postulation.EmployeId;
                entity.Offre = postulation.Offre;
                entity.OffreId = postulation.OffreId;
                entity.Statut = postulation.Statut;
                this.contexte.SaveChanges();
            }
            else
            {
                Console.WriteLine("Cette postulation n'existe pas en base");
            }
        }

        public void updateStatut(Statut statut)
        {
            Statut entity = this.contexte.Statuts.Where(e => e.Id == statut.Id).FirstOrDefault();

            if (entity != null)
            {
                entity.Libelle = statut.Libelle;
                this.contexte.SaveChanges();
            }
            else
            {
                Console.WriteLine("Ce libelle n'existe pas en base");
            }
        }

        public Employe getEmploye(int id)
        {
            return this.contexte.Employes.Where(e => e.Id == id).FirstOrDefault();
        }

        public Experience getExperience(int id)
        {
            return this.contexte.Experiences.Where(e => e.Id == id).FirstOrDefault();
        }

        public Formation getFormation(int id)
        {
            return this.contexte.Formations.Where(e => e.Id == id).FirstOrDefault();
        }

        public Offre getOffre(int id)
        {
            return this.contexte.Offres.Where(e => e.Id == id).FirstOrDefault();
        }

        public Postulation getPostulation(int id)
        {
            return this.contexte.Postulations.Where(e => e.Id == id).FirstOrDefault();
        }

        public Statut getStatut(int id)
        {
            return this.contexte.Statuts.Where(e => e.Id == id).FirstOrDefault();
        }
    }

}
