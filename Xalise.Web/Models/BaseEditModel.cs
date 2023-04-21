using Xalise.Web.Enums;

namespace Xalise.Web.Models
{
    /// <summary>
    /// Modèle de données utilisé pour l'édition (création, modification, visualisation).
    /// </summary>
    [Serializable]
    public class BaseEditModel
    {
        // En mode création, permet de saisir un nouvel élément après l'enregistrement
        public bool             ContinuerSaisie { get; set; }

        public BaseErrorModel   ErrorModel { get; set; }

        public eModeOuverture   ModeOuverture { get; set; }

        /// <summary>
        /// Constructeur par défaut.
        /// </summary>
        public BaseEditModel()
        {
            ContinuerSaisie = false;
            ErrorModel      = new BaseErrorModel();
            ModeOuverture   = eModeOuverture.VISUALISATION;
        }

        /// <summary>
        /// Indique s'il y a une erreur dans le modèle de données.
        /// </summary>
        public bool AvecErreur
        {
            get
            {
                return ErrorModel.AvecErreur;
            }
        }
    }
}
