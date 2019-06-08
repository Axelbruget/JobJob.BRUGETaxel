using JobJobClass.Entity;
using JobJobClient.viewmodel;
using JobJobClient.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace JobJobClient.ViewModels
{
    public class DetailOffreViewModel : BaseViewModel
    {
        #region Variables

        private string _intitule;
        private string _description;
        private RelayCommand _addOperation;

        #endregion

        #region Constructeurs

        /// <summary>
        /// Constructeur par défaut
        /// <param name="offre">Offre à transformer en DetailOffreViewModel</param>
        /// </summary>
        public DetailOffreViewModel(Offre offre)
        {
            _intitule = offre.Intitule;
            _description = offre.Description;
        }

        #endregion

        #region Data Bindings

        /// <summary>
        /// Intitule de l'offre
        /// </summary>
        public string Intitule
        {
            get { return _intitule; }
            set { _intitule = value; }
        }

        /// <summary>
        /// Description de l'offre
        /// </summary>
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        #endregion

        #region Commandes

        /// <summary>
        /// Commande pour ouvrir la fenêtre pour ajouter une opération
        /// </summary>
        public ICommand AddOperation
        {
            get
            {
                if (_addOperation == null)
                    _addOperation = new RelayCommand(() => this.ShowWindowOperation());
                return _addOperation;
            }
        }

        /// <summary>
        /// Permet l'ouverture de la fenêtre
        /// </summary>
        private void ShowWindowOperation()
        {
            Views.Operation operationWindow = new Views.Operation();
            operationWindow.DataContext = this;
            operationWindow.ShowDialog();
        }

        #endregion
    }
}
