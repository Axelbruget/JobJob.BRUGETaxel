using JobJobClass.Entity;
using System;
using System.Collections.Generic;
using System.Linq;


namespace JobJobService
{
    interface ServiceInterface
    {

        void addEmploye(Employe employe);
        void removeEmploye(Employe employe);
        void updateEmploye(Employe employe);
        List<Employe> getEmployes();



        void addExperience(Experience experience);
        void removeExperience(Experience experience);
        void updateExperience(Experience experience);
        List<Experience> getExperiences();



        void addFormation(Formation formation);
        void removeFormation(Formation formation);
        void updateFormation(Formation formation);
        List<Formation> getFormations();


        void addOffre(Offre offre);
        void removeOffre(Offre offre);
        void updateOffre(Offre offre);
        List<Offre> getOffres();



        void addPostulation(Postulation postulation);
        void removePostulation(Postulation postulation);
        void updatePostulation(Postulation postulation);
        List<Postulation> getPostulations();


        void addStatut(Statut statut);
        void removeStatut(Statut statut);
        void updateStatut(Statut statut);
        List<Statut> getStatuts();

    }
}
