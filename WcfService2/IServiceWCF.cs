using JobJobClass.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace JobJobWCF
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IService" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IServiceWCF
    {
        [OperationContract]
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            UriTemplate = "getOffres")]
        List<OffreDataContract> getOffres();

        // TODO: ajoutez vos opérations de service ici
    }

    // Utilisez un contrat de données comme indiqué dans l'exemple ci-après pour ajouter les types composites aux opérations de service.
    [DataContract]
    public class OffreDataContract
    {
        public OffreDataContract(Offre offre)
        {
            Id = offre.Id;
            Intitule = offre.Intitule;
            Date = offre.Date;
            Salaire = offre.Salaire;
            Description = offre.Description;
            StatutId = offre.StatutId;
            Statut = offre.Statut;
            Responsable = offre.Responsable;
        }

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Intitule { get; set; }

        [DataMember]
        public DateTime Date { get; set; }

        [DataMember]
        public double Salaire { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public int StatutId { get; set; }

        [DataMember]
        public Statut Statut { get; set; }

        [DataMember]
        public string Responsable { get; set; }
    }
}