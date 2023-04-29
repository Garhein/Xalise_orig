using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using Xalise.Core.Entite.GED;
using Xalise.Core.Extensions;
using Xalise.Web.Areas.Repertoires.Models;
using Xalise.Web.Controllers;
using Xalise.Web.Enums;
using Xalise.Web.Helpers;
using Xalise.Web.Helpers.WebHelpers;
using Xalise.Web.Models;

namespace Xalise.Web.Areas.Repertoires.Controllers
{
    [Area("Repertoires")]
    public class ThemeController : XaliseMvcController
    {
        private readonly ILogger<ThemeController> _logger;

        public ThemeController(ILogger<ThemeController> logger)
        {
            _logger = logger;
        }

        /*
         *  
         * 0°) Si pas de données : afficher une vue générique placée dans "Shared"
         * 0°) Pour faire apparaître la hiérarchie : espaces blancs devant le libellé des enfants ?
         * 0°) Titre des colonnes : structure ?
         * 0°) Les thèmes de référence interne :
         *  - ne peuvent être que des parents
         *  - ne peuvent pas avoir d'enfants
         *  
         * Réordonner les thèmes : quelle solution ?
         * 
         * Mise en place d'un export Excel ?
         *  - pouvoir dire que certaines colonnes ne doivent pas être exportées (fixes) et d'autres facultatives (en fonction d'option) : attributs personnalisés
         *  - ordre des colonnes (attribut personnalisé)
         *  - Delegate qui exécute une fonction du contrôleur, qui :
         *      - initialise les données : colonnes facultatives
         *      - exécute la recherche
         *      - génère les fichier Excel et le propose au téléchargement
         *      - ...
         *  - gestion des différents types de données : string, date, heure, date/heure, booléen, entier, décimal, ...
         *  
         * 
         * 1°) Suppression
         *  - si thème utilisé : proposer le remplacement
         *  - s'il s'agit d'un parent avec un/des enfants : proposer de rattacher les enfant à un autre parent où en faire des parents
         *  - penser à gérer les numéros d'ordre
         * 
         */

        // TODO: à l'archivage d'un parent avec enfant, archiver aussi les enfants ?
        // TODO: liste des thèmes, changer icône pour ouvrir la fenêtre en mode 'Visualisation' ? Prévoir une action JS différente pour la visualisation ?

        /// <summary>
        /// Affiche la page de gestion des thèmes.
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            InitViewDataPageTitle("Thèmes GED");

            ThemeViewModel model = new ThemeViewModel();
            model.ListeThemes    = RechercherThemes(model.CriteresRecherche);

            return View(model);
        }

        /// <summary>
        /// Affiche la fenêtre de dialogue de création/modification d'un thème.
        /// </summary>
        /// <param name="modeOuverture">Mode d'ouverture de la fenêtre de dialogue.</param>
        /// <param name="themeID">Identifiant du thème à modifier.</param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Edit(int modeOuverture, int themeID)
        {
            IEnumerable<ThemeDTO> listeThemes   = JsonHelper.ReadJsonDataFile<ThemeDTO>(JsonHelper.CSTS_FILENAME_THEMES);
            ThemeEditModel model                = new ThemeEditModel();

            // =-=-=-
            // Gestion des informations du thème et du mode d'ouverture
            // =-=-=-

            model.ModeOuverture = (eModeOuverture)modeOuverture;

            if (model.ModeOuverture != eModeOuverture.CREATION)
            {
                if (listeThemes.IsEmpty())
                {
                    model.ErrorModel.AddErreur("Modification impossible : le répertoire des thèmes est vide.");
                }
                else
                {
                    IEnumerable<ThemeDTO> resRecherche = listeThemes.Where(x => x.ID.Equals(themeID));
                    if (resRecherche.IsEmpty())
                    {
                        model.ErrorModel.AddErreur("Modification impossible : les informations du thème n'ont pas été trouvées.");
                    }
                    else
                    {
                        model.ThemeDTO              = resRecherche.First();
                        model.EstParentAvecEnfants  = listeThemes.Any(x => x.ParentID.HasValue && x.ParentID.Value.Equals(themeID));

                        if (model.ThemeDTO.ParentID.HasValue)
                        {
                            model.EstEnfantAvecParentArchive = listeThemes.Any(x => x.ID.Equals(model.ThemeDTO.ParentID.Value) && x.EstArchive);
                        }
                    }
                }
            }

            // =-=-=-
            // Initialisation de la liste déroulante de sélection du thème parent
            //  - exclusion du thème modifié pour empêcher de le lier avec lui-même
            //  - exclusion des thèmes archivés (sauf si mode 'VISUALISATION')
            // =-=-=-

            if (!model.AvecErreur)
            {
                if (listeThemes.IsNotEmpty())
                {
                    if (model.ModeOuverture != eModeOuverture.VISUALISATION)
                    {
                        listeThemes = listeThemes.Where(x => !x.ParentID.HasValue
                                                             && !x.ID.Equals(themeID)
                                                             && !x.EstArchive)
                                                 .OrderBy(x => x.NumOrdre);
                    }
                    else
                    {
                        // En 'VISUALISATION' on prend aussi les thèmes archivés : dans le cas d'un enfant
                        // dont le parent est archivé il faut pouvoir visualiser son parent
                        listeThemes = listeThemes.Where(x => !x.ParentID.HasValue
                                                             && !x.ID.Equals(themeID))
                                                 .OrderBy(x => x.NumOrdre);
                    }
                }

                model.ListeThemesParents = SelectListHelper.ConstruireListeThemesParents(listeThemes, model.ThemeDTO.ParentID);
            }

            return PartialView("Edit", model);
        }

        /// <summary>
        /// Enregistre (création/modification) un thème.
        /// </summary>
        /// <param name="model">Données saisies par l'utilisateur.</param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Save(ThemeEditModel model)
        {
            BaseErrorModel retModel = new BaseErrorModel();
            List<Theme> listeThemes = JsonHelper.ReadJsonDataFile<Theme>(JsonHelper.CSTS_FILENAME_THEMES);

            // =-=-=-
            // Gestion des différents modes d'ouverture
            // =-=-=-

            Theme theme = new Theme(model.ThemeDTO);

            switch (model.ModeOuverture)
            {
                case eModeOuverture.CREATION:
                    {
                        theme.ID        = this.CalculerProchainID(ref listeThemes);
                        theme.NumOrdre  = this.CalculerProchainNumOrdre(ref listeThemes, theme.ParentID);
                        listeThemes.Add(theme);
                        break;
                    }
                case eModeOuverture.MODIFICATION:
                    {
                        int index = listeThemes.ToList().FindIndex(x => x.ID == model.ThemeDTO.ID);
                        if (index < 0)
                        {
                            retModel.AddErreur("Enregistrement des modifications impossible : les informations du thème n'ont pas été trouvées.");
                        }
                        else
                        {
                            // Si changement de parent : retrait du parent de départ, changement de parent ou sélection d'un parent
                            if (listeThemes[index].ParentID != theme.ParentID)
                            {
                                // Réordonner les éléments associés au parent de départ qui ont un numéro d'ordre supérieur
                                this.RemonterOrdreThemes(ref listeThemes, listeThemes[index].ParentID, listeThemes[index].NumOrdre);

                                // Numéroter le thème, qui devient parent, pour le placer en dernière position
                                theme.NumOrdre = this.CalculerProchainNumOrdre(ref listeThemes, theme.ParentID);
                            }
                        }

                        listeThemes[index] = theme;

                        break;
                    }
                default:
                    {
                        retModel.AddErreur($"Le mode d'ouverture {model.ModeOuverture.ToString()} n'est pas pris en charge.");
                        break;
                    }
            }

            if (!retModel.AvecErreur)
            {
                JsonHelper.WriteJsonDataFile(JsonHelper.CSTS_FILENAME_THEMES, listeThemes);
            }

            return new JsonResult(retModel);

            //TODO: en modification, on ne peut pas sélectionner comme parent soit-même !!
            //TODO: gestion des erreurs, jeton de validité du formulaire (possible avec 'Continuer la saisie' ?), ...
        }

        /// <summary>
        /// Calcul du prochain identifiant.
        /// </summary>
        /// <param name="themes">Liste des thèmes.</param>
        /// <returns></returns>
        private int CalculerProchainID(ref List<Theme> themes)
        {
            int ret = 1;

            if (themes.IsNotEmpty())
            {
                ret = themes.Max(x => x.ID) + 1;
            }

            return ret;
        }

        /// <summary>
        /// Calcul du prochain numéro d'ordre.
        /// </summary>
        /// <param name="themes">Liste des thèmes.</param>
        /// <param name="parentID">ID du thème parent.</param>
        /// <returns></returns>
        private int CalculerProchainNumOrdre(ref List<Theme> themes, int? parentID)
        {
            int numOrdre = 1;

            if (themes.IsNotEmpty())
            {
                if (!parentID.HasValue)
                {
                    // Pour un thème parent
                    numOrdre = themes.Where(x => !x.ParentID.HasValue).Max(x => x.NumOrdre) + 1;
                }
                else if (themes.Any(x => x.ParentID.Equals(parentID)))
                {
                    // Pour un thème enfant
                    numOrdre = themes.Where(x => x.ParentID.Equals(parentID)).Max(x => x.NumOrdre) + 1;
                }
            }

            return numOrdre;
        }

        /// <summary>
        /// Réordonne l'ordre des thèmes en retirant 1 à la position de départ.
        /// </summary>
        /// <param name="themes">Liste des thèmes.</param>
        /// <param name="parentID">ID du parent utilisé pour trouver les thèmes à réordonner.</param>
        /// <param name="ordreDepart">Numéro d'ordre à partir duquel les thèmes doivent être réordonnés.</param>
        private void RemonterOrdreThemes(ref List<Theme> themes, int? parentID, int ordreDepart)
        {
            themes.Where(x => x.ParentID.Equals(parentID) && x.NumOrdre > ordreDepart).ToList().ForEach(x => x.NumOrdre = x.NumOrdre - 1);
        }

        /// <summary>
        /// Recherche des thèmes.
        /// </summary>
        /// <param name="criteres">Critères de recherche.</param>
        /// <returns></returns>
        private List<ThemeDTO> RechercherThemes(ThemeCriteresRechercheModel criteres)
        {
            // =-=-=-
            // Exécution de la recherche
            // =-=-=-

            IEnumerable<ThemeDTO> listeDTO = JsonHelper.ReadJsonDataFile<ThemeDTO>(JsonHelper.CSTS_FILENAME_THEMES);

            // TODO: si recherche et que l'on trouve un/des enfants, il faut aussi afficher le parent ?

            // =-=-=-
            // Construction du retour
            // =-=-=-

            List<ThemeDTO> retListe = new List<ThemeDTO>();

            if (listeDTO.IsNotEmpty())
            {
                // Gestion des parents
                IEnumerable<ThemeDTO> parents = listeDTO.Where(x => !x.ParentID.HasValue).OrderBy(x => x.NumOrdre);
                if (parents.IsNotEmpty())
                {
                    foreach (ThemeDTO parent in parents)
                    {
                        retListe.Add(parent);

                        // Gestion des enfants
                        IEnumerable<ThemeDTO> enfants = listeDTO.Where(x => x.ParentID.HasValue && x.ParentID.Equals(parent.ID))
                                                                .OrderBy(x => x.NumOrdre);

                        if (enfants.IsNotEmpty())
                        {
                            foreach (ThemeDTO enfant in enfants)
                            {
                                enfant.ParentLibelle = parent.Libelle;
                                retListe.Add(enfant);
                            }
                        }
                    }
                }
            }

            return retListe;
        }
    }
}