using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobJobClass.Mapping;

namespace JobJobConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Chargement BDD");
            AppContexte app = new AppContexte();

            app.Offres.ToList();
            //app.Experiences.ToList();
            //app.Formations.ToList();
            //app.Employes.ToList();
        }
    }
}
