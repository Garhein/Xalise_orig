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
         * 0°) Colonnes
         *  - modifier
         *  - archiver/désarchiver : si pas réf. interne
         *  - supprimer : si pas réf. interne
         *  - libellé
         *  - numéro d'ordre
         *  - réf. interne ?
         *  - archivé ?
         *  
         * 0°) Si pas de données : afficher une vue générique placée dans "Shared"
         * 0°) Pour faire apparaître la hiérarchie : espaces blancs devant le libellé des enfants ?
         * 0°) Classes CSS de la table : .table, .table-hover, .table-sm, .table-bordered
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
        /// <param name="themeID">Identifiant du thème à modifier.</param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Edit(int themeID)
        {
            IEnumerable<ThemeDTO> listeThemes   = JsonHelper.ReadJsonDataFile<ThemeDTO>(JsonHelper.CSTS_FILENAME_THEMES);
            ThemeEditModel model                = new ThemeEditModel();

            // =-=-=-
            // Gestion des informations du thème et du mode d'ouverture
            // =-=-=-

            if (themeID <= 0)
            {
                model.ModeOuverture = eModeOuverture.CREATION;
            }
            else
            {
                if (listeThemes.IsEmpty())
                {
                    model.ErrorModel.AddErreur("Impossible de trouver le thème que vous souhaitez modifier : aucun thème n'a été trouvé.");
                }
                else
                {
                    IEnumerable<ThemeDTO> resRecherche = listeThemes.Where(x => x.ID.Equals(themeID));
                    if (resRecherche.IsEmpty())
                    {
                        model.ErrorModel.AddErreur("Le thème que vous souhaitez modifier n'a pas été trouvé.");
                    }
                    else
                    {
                        model.ThemeDTO              = resRecherche.First();
                        model.ModeOuverture         = eModeOuverture.MODIFICATION;
                        model.EstParentAvecEnfants  = listeThemes.Any(x => x.ParentID.HasValue && x.ParentID.Value.Equals(themeID));
                    }
                }
            }

            // =-=-=-
            // Initialisation de la liste déroulante de sélection du thème parent
            // // Exclusion du thème modifié pour empêcher de le lier avec lui-même
            // =-=-=-

            if (!model.AvecErreur)
            {
                if (listeThemes.IsNotEmpty())
                {
                    listeThemes = listeThemes.Where(x => !x.ParentID.HasValue && !x.ID.Equals(themeID)).OrderBy(x => x.NumOrdre);
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

            //TODO: en modification, on ne peut pas sélectionner comme parent soit-même !!
            //TODO: gestion des erreurs, jeton de validité du formulaire (possible avec 'Continuer la saisie' ?), ...

            // Récupération des thèmes
            List<Theme> listeThemes = JsonHelper.ReadJsonDataFile<Theme>(JsonHelper.CSTS_FILENAME_THEMES);

            // =-=-=-
            // Gestion des différents modes d'ouverture
            // =-=-=-

            Theme theme = new Theme(model.ThemeDTO);

            if (model.ModeOuverture.Equals(eModeOuverture.CREATION))
            {
                theme.ID = CalculerNumOrdre(ref listeThemes, null); // Ne calcule pas correctement l'identifiant s'il existe des enfants
                theme.NumOrdre = CalculerNumOrdre(ref listeThemes, theme.ParentID);
                listeThemes.Add(theme);
            }
            else if (model.ModeOuverture.Equals(eModeOuverture.MODIFICATION))
            {
                int index = listeThemes.ToList().FindIndex(x => x.ID == model.ThemeDTO.ID);
                if (index < 0)
                {
                    retModel.AddErreur("Impossible de trouver le thème que vous souhaitez modifier.");
                }
                else
                {
                    // Si changement de parent : retrait du parent de départ, changement de parent ou sélection d'un parent
                    if (listeThemes[index].ParentID != theme.ParentID)
                    {
                        // Retrait du parent de départ
                        if (listeThemes[index].ParentID.HasValue && !theme.ParentID.HasValue)
                        {
                            // Réordonner les éléments associés au parent de départ qui ont un numéro d'ordre supérieur
                            RemonterOrdreThemes(ref listeThemes, listeThemes[index].ParentID, listeThemes[index].NumOrdre);

                            // Numéroter le thème, qui devient parent, pour le placer en dernière position
                            theme.NumOrdre = CalculerNumOrdre(ref listeThemes, theme.ParentID);
                        }
                        // Sélection d'un parent
                        else if (!listeThemes[index].ParentID.HasValue && theme.ParentID.HasValue)
                        {
                            // Réordonner les parents qui ont un numéro d'ordre supérieur
                            RemonterOrdreThemes(ref listeThemes, null, listeThemes[index].NumOrdre);

                            // Numéroter le thème, qui devient enfant, pour le placer en dernière position du parent
                            theme.NumOrdre = CalculerNumOrdre(ref listeThemes, theme.ParentID);
                        }
                        // Changement de parent
                        else
                        {
                            // Réordonner les éléments associés au parent de départ qui ont un numéro d'ordre supérieur
                            RemonterOrdreThemes(ref listeThemes, listeThemes[index].ParentID, listeThemes[index].NumOrdre);

                            // Numéroter le thème pour le placer en dernière position du parent sélectionné
                            theme.NumOrdre = CalculerNumOrdre(ref listeThemes, theme.ParentID);
                        }
                    }

                    listeThemes[index] = theme;
                }
            }
            else
            {
                retModel.AddErreur($"Le mode d'ouverture {model.ModeOuverture.ToString()} n'est pas pris en charge.");
            }

            if (!retModel.AvecErreur)
            {
                JsonHelper.WriteJsonDataFile(JsonHelper.CSTS_FILENAME_THEMES, listeThemes);
            }

            return new JsonResult(retModel);
        }

        /// <summary>
        /// Calcul du prochaine numéro d'ordre.
        /// </summary>
        /// <param name="themes">Liste des thèmes.</param>
        /// <param name="parentID">ID du thème parent.</param>
        /// <returns></returns>
        private int CalculerNumOrdre(ref List<Theme> themes, int? parentID)
        {
            int numOrdre = 1;

            if (!parentID.HasValue)
            {
                numOrdre = themes.IsNotEmpty() ? themes.Where(x => !x.ParentID.HasValue).Max(x => x.ID) + 1 : 1;
            }
            else
            {
                numOrdre = themes.Any(x => x.ParentID.Equals(parentID)) ? themes.Where(x => x.ParentID.Equals(parentID)).Max(x => x.NumOrdre) + 1 : 1;
            }

            return numOrdre;
        }

        /// <summary>
        /// Réordonne l'ordre des thèmes en retirant 1 à la position de départ.
        /// </summary>
        /// <param name="themes">Liste des thèmes.</param>
        /// <param name="parentID">ID du parent utilisé pour retrouver les thèmes à réordonner.</param>
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