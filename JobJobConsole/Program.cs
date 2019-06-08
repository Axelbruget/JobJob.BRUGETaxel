using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobJobClass.Entity;
using JobJobClass.Mapping;

namespace JobJobConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Chargement BDD");
            AppContexte app = new AppContexte();

            Offre offre = new Offre
            {
                Id = 3,
                Intitule = "1ère offre",
                Date = new DateTime(),
                Description = "test",
                Responsable = "Axel",
                Salaire = 2000,
                StatutId = 1,
            };
            app.Offres.Add(offre);
            Console.Write(app.Offres.Count());
        }
    }
}
