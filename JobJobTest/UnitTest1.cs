using System;
using System.Collections.Generic;
using JobJobClass.Entity;
using JobJobClass.Mapping;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JobJobTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddOffre()
        {
            //var service = new Service();

            var offre = new Offre();
            AppContexte app = new AppContexte();
            app.Offres.Add(offre);

            Assert.AreEqual(app.Offres.Find(offre.Id), offre);
        }

        [TestMethod]
        public void UpdateOffre()
        {
            var offre = new Offre();
            AppContexte app = new AppContexte();
            app.Offres.Add(offre);

            String intitule = "monOffre";
            app.Offres.Find(offre.Id).Intitule = intitule;

            Assert.AreEqual(app.Offres.Find(offre.Id).Intitule, intitule);
        }

        [TestMethod]
        public void DeleteOffre()
        {
            var offre = new Offre();
            AppContexte app = new AppContexte();
            app.Offres.Add(offre);

            app.Offres.Remove(offre);

            Assert.IsNull(app.Offres.Find(offre.Id));

        }

        [TestMethod]
        public void GetOffres()
        {
            Offre offre1 = new Offre();
            AppContexte app = new AppContexte();
            app.Offres.Add(offre1);

            Assert.IsNotNull(app.Offres.Find(offre1.Id));
        }
    }
}
