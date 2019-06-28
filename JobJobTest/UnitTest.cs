using System;
using JobJobClass.Entity;
using JobJobClass.Mapping;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JobJobService;
using System.Collections.Generic;

namespace JobJobTest
{
    [TestClass]
    public class UnitTest
    {
        Service service = new Service();

        Offre offre = new Offre
        {
            Date = DateTime.Today,
            Intitule = "Mon offre",
            Responsable = "Moi",
            Salaire = 25000,
            StatutId = 1,
            Description = "Ma description",
        };

        [TestMethod]
        public void AddOffre()
        { 
            service.addOffre(offre);

            Assert.IsNotNull(service.getOffre(offre.Id));
        }

        [TestMethod]
        public void UpdateOffre()
        {
            service.addOffre(offre);

            offre.Intitule = "Ma nouvelle offre";
            service.updateOffre(offre);

            Assert.AreEqual(service.getOffre(offre.Id).Intitule, "Ma nouvelle offre");
        }

        [TestMethod]
        public void DeleteOffre()
        {
            
            service.addOffre(offre);
            service.removeOffre(offre);

            Assert.IsNull(service.getOffre(offre.Id));

        }

        [TestMethod]
        public void GetOffres()
        {
            service.addOffre(offre);

            Assert.IsNotNull(service.getOffres());
        }
    }
}
