using JobJobClass.Entity;
using JobJobClient.ViewModels;
using JobJobService;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobJobClient.viewmodel
{
    public class ListeOffreViewModel : BaseViewModel
    {
        #region Variables

        private ObservableCollection<DetailOffreViewModel> _offres = null;
        private DetailOffreViewModel _selectedOffre;
        private Service service;

        #endregion

        #region Constructeurs

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public ListeOffreViewModel()
        {
            service = new Service();
            // on appelle le mock pour initialiser une liste de produits
            _offres = new ObservableCollection<DetailOffreViewModel>();
            foreach (Offre o in service.getOffres())
            {
                _offres.Add(new DetailOffreViewModel(o));
            }

            if (_offres != null && _offres.Count > 0)
                _selectedOffre = _offres.ElementAt(0);
        }

        #endregion

        #region Data Bindings

        /// <summary>
        /// Obtient ou définit une collection de DetailProduitViewModel (Observable)
        /// </summary>
        public ObservableCollection<DetailOffreViewModel> Offres
        {
            get { return _offres; }
            set
            {
                _offres = value;
                OnPropertyChanged("Offres");
            }
        }

        /// <summary>
        /// Obtient ou défini le produit en cours de sélection dans la liste de DetailProduitViewModel
        /// </summary>
        public DetailOffreViewModel SelectedOffre
        {
            get { return _selectedOffre; }
            set
            {
                _selectedOffre = value;
                OnPropertyChanged("SelectedOffre");
            }
        }


        #endregion

    }
}
