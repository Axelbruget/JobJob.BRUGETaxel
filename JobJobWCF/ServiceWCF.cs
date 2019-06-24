using JobJobClass.Entity;
using JobJobService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service" dans le code, le fichier svc et le fichier de configuration.
public class ServiceWCF : IService
{
    public List<OffreDataContract> getOffres()
    {
        Service service = new Service();
        List<Offre> listOffres = service.getOffres();

        List<OffreDataContract> listOffreDataContract = new List<OffreDataContract>();

        foreach(Offre offre in listOffres)
        {
            OffreDataContract offreDataContract = new OffreDataContract(offre);
            listOffreDataContract.Add(offreDataContract);
        }
        return listOffreDataContract;
    }
}
