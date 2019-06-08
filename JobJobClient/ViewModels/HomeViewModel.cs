using JobJobClient.viewmodel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobJobClient.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        #region Variables

        private ListeOffreViewModel _listeOffreViewModel = null;

        #endregion

        #region Constructeurs

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public HomeViewModel()
        {
            _listeOffreViewModel = new ListeOffreViewModel();
        }

        #endregion

        #region Data Bindings

        /// <summary>
        /// Obtient ou définit le ListeProduitViewModel
        /// </summary>
        public ListeOffreViewModel ListeOffreViewModel
        {
            get { return _listeOffreViewModel; }
            set { _listeOffreViewModel = value; }
        }

        #endregion

    }
}
