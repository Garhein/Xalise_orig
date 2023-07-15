using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using Xalise.Core.Entite.GED;
using Xalise.Core.Exceptions;
using Xalise.Core.Extensions;
using Xalise.Core.Helpers;
using Xalise.Web.Areas.Repertoires.Models;
using Xalise.Web.Controllers;
using Xalise.Web.Enums;
using Xalise.Web.Helpers;
using Xalise.Web.Helpers.WebHelpers;
using Xalise.Web.Models;

namespace Xalise.Web.Areas.Repertoires.Controllers
{
    [Area("Repertoires")]
    public class ThemeGEDController : XaliseMvcController
    {
        private readonly ILogger<ThemeGEDController> _logger;

        public ThemeGEDController(ILogger<ThemeGEDController> logger)
        {
            this._logger = logger;
        }

        /// <summary>
        /// Affiche la page du répertoire de gestion des thèmes.
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            this.InitViewDataPageTitle("Thèmes GED");
            return View(this.RechercherThemes(new ThemeCriteresRechercheModel()));
        }

        /// <summary>
        /// Exécute la recherche et actualise la liste des thèmes GED.
        /// </summary>
        /// <param name="criteres"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult ActualiserRepertoire(ThemeCriteresRechercheModel criteres)
        {
            return PartialView("List", this.RechercherThemes(criteres));
        }

        /// <summary>
        /// Affiche la fenêtre de dialogue de création/modification d'un thème.
        /// </summary>
        /// <param name="modeOuverture">Mode d'ouverture de la fenêtre de dialogue.</param>
        /// <param name="themeID">Identifiant du thème.</param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult AfficherTheme(short modeOuverture, int themeID)
        {
            IEnumerable<ThemeDTO> listeThemes   = new List<ThemeDTO>();
            ThemeGEDEditModel model             = new ThemeGEDEditModel();

            try
            {
                EnumHelper.VerifierValidite<eModeOuverture>(modeOuverture, nameof(modeOuverture));

                // =-=-=-
                // Gestion des informations du thème et du mode d'ouverture
                // =-=-=-

                model.ModeOuverture = (eModeOuverture)modeOuverture;
                listeThemes         = JsonHelper.ReadJsonDataFile<ThemeDTO>(JsonHelper.CSTS_FILENAME_THEMES);

                if (model.ModeOuverture != eModeOuverture.CREATION)
                {
                    this.VerifierThemeID(themeID, nameof(themeID));

                    if (listeThemes.IsEmpty())
                    {
                        throw new XaliseException($"{model.ModeOuverture.Description()} impossible : le répertoire des thèmes est vide.");
                    }
                    else
                    {
                        int posTheme = listeThemes.ToList().FindIndex(x => x.ID == themeID);
                        if (posTheme < 0)
                        {
                            throw new XaliseException($"{model.ModeOuverture.Description()} impossible : le thème n'a pas été trouvé.");
                        }
                        else
                        {
                            model.ThemeDTO = listeThemes.ElementAt(posTheme);
                            model.EstParentAvecEnfants = listeThemes.Any(x => x.ParentID.HasValue && x.ParentID.Value.Equals(themeID));
                        }
                    }
                }

                // =-=-=-
                // Initialisation de la liste déroulante de sélection du thème parent
                //  - exclusion du thème modifié pour empêcher de le lier avec lui-même
                //  - exclusion des thèmes archivés, sauf s'il s'agit du parent du thème visualisé
                // =-=-=-

                if (listeThemes.IsNotEmpty())
                {
                    listeThemes = listeThemes.Where(x => !x.ParentID.HasValue
                                                         && !x.ID.Equals(themeID)
                                                         && ((model.ThemeDTO.ParentID.HasValue && x.ID.Equals(model.ThemeDTO.ParentID)) || !x.EstArchive))
                                             .OrderBy(x => x.NumOrdre);
                }

                model.ListeThemesParents = SelectListHelper.ConstruireListeThemesParents(listeThemes, model.ThemeDTO.ParentID);
            }
            catch (Exception ex)
            {
                model.ErrorModel.AddErreur(ex.Message);
            }

            return PartialView("Editer", model);
        }

        /// <summary>
        /// Enregistre (création/modification) un thème.
        /// </summary>
        /// <param name="model">Données saisies par l'utilisateur.</param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult EnregistrerTheme(ThemeGEDEditModel model)
        {
            BaseAjaxReturnModel retModel = new BaseAjaxReturnModel();
            List<Theme> listeThemes      = new List<Theme>();

            try
            {
                EnumHelper.VerifierValidite<eModeOuverture>(model.ModeOuverture, nameof(model.ModeOuverture));

                if (model.ModeOuverture != eModeOuverture.CREATION)
                {
                    this.VerifierThemeID(model.ThemeDTO.ID, nameof(model.ThemeDTO.ID));
                }

                listeThemes = JsonHelper.ReadJsonDataFile<Theme>(JsonHelper.CSTS_FILENAME_THEMES);
                Theme theme = new Theme(model.ThemeDTO);

                switch (model.ModeOuverture)
                {
                    case eModeOuverture.CREATION:
                        {
                            theme.ID = this.CalculerProchainID(ref listeThemes);
                            theme.NumOrdre = this.CalculerProchainNumOrdre(ref listeThemes, theme.ParentID);
                            listeThemes.Add(theme);
                            break;
                        }
                    case eModeOuverture.MODIFICATION:
                        {
                            int posTheme = listeThemes.FindIndex(x => x.ID == model.ThemeDTO.ID);
                            if (posTheme < 0)
                            {
                                throw new XaliseException($"{model.ModeOuverture.Description()} du thème impossible : le thème n'a pas été trouvé.");
                            }
                            else
                            {
                                // Si changement de parent : retrait du parent de départ, changement de parent ou sélection d'un parent
                                if (listeThemes[posTheme].ParentID != theme.ParentID)
                                {
                                    // Réordonner les éléments associés au parent de départ qui ont un numéro d'ordre supérieur
                                    this.RemonterOrdreThemes(ref listeThemes, listeThemes[posTheme].ParentID, listeThemes[posTheme].NumOrdre);

                                    // Numéroter le thème pour le placer en dernière position
                                    theme.NumOrdre = this.CalculerProchainNumOrdre(ref listeThemes, theme.ParentID);
                                }

                                listeThemes[posTheme] = theme;
                            }

                            break;
                        }
                    default:
                        {
                            break;
                        }
                }

                JsonHelper.WriteJsonDataFile(JsonHelper.CSTS_FILENAME_THEMES, listeThemes);

                retModel.MessageSucces = $"{model.ModeOuverture.Description()} du thème <b>{theme.Libelle}</b> réalisé avec succès.";
            }
            catch (Exception ex)
            {
                retModel.AddErreur(ex.Message);
            }

            return new JsonResult(retModel);
        }

        /// <summary>
        /// Affiche la fenêtre de dialogue de gestion de l'archivage d'un thème GED.
        /// </summary>
        /// <param name="modeGestion">Mode de gestion de l'archivage.</param>
        /// <param name="themeID">Identifiant du thème.</param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult AfficherDialogueGestionArchivage(short modeGestion, int themeID)
        {
            List<ThemeDTO> listeThemes          = new List<ThemeDTO>();
            ThemeGEDGestionArchivageModel model = new ThemeGEDGestionArchivageModel();

            try
            {
                EnumHelper.VerifierValidite<eModeGestionArchivage>(modeGestion, nameof(modeGestion));
                this.VerifierThemeID(themeID, nameof(themeID));

                model.ModeGestion = (eModeGestionArchivage)modeGestion;
                listeThemes       = JsonHelper.ReadJsonDataFile<ThemeDTO>(JsonHelper.CSTS_FILENAME_THEMES);

                if (listeThemes.IsEmpty())
                {
                    throw new XaliseException($"{model.ModeGestion.Description()} impossible : le répertoire des thèmes est vide.");
                }
                else
                {
                    int posTheme = listeThemes.FindIndex(x => x.ID == themeID);
                    if (posTheme < 0)
                    {
                        throw new XaliseException($"{model.ModeGestion.Description()} impossible : le thème n'a pas été trouvé.");
                    }
                    else
                    {
                        model.ThemeDTO              = listeThemes[posTheme];
                        model.EstParentAvecEnfants  = listeThemes.Any(x => x.ParentID.HasValue && x.ParentID.Value.Equals(themeID));
                    }
                }
            }
            catch (Exception ex)
            {
                model.ErrorModel.AddErreur(ex.Message);
            }

            return PartialView("DialogueGestionArchivage", model);
        }

        /// <summary>
        /// Exécute les traitements d'archivage d'un thème GED.
        /// </summary>
        /// <param name="modeGestion">Mode de gestion de l'archivage.</param>
        /// <param name="themeID">Identifiant du thème.</param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult ExecuterGestionArchivage(short modeGestion, int themeID) 
        {
            BaseAjaxReturnModel retModel = new BaseAjaxReturnModel();
            List<Theme> listeThemes      = new List<Theme>();

            try
            {
                EnumHelper.VerifierValidite<eModeGestionArchivage>(modeGestion, nameof(modeGestion));
                this.VerifierThemeID(themeID, nameof(themeID));

                // =-=-=-
                // Exécution des traitements
                // =-=-=-

                // TODO: gérer une exception personnalisée pour la lecture/écriture dans le fichier JSON (le message indique le nom du fichier JSON)
                listeThemes  = JsonHelper.ReadJsonDataFile<Theme>(JsonHelper.CSTS_FILENAME_THEMES);
                int posTheme = 0;

                if (listeThemes.IsEmpty())
                {
                    throw new XaliseException($"{((eModeGestionArchivage)modeGestion).Description()} du thème impossible : le répertoire des thèmes est vide.");
                }
                else
                {
                    posTheme = listeThemes.FindIndex(x => x.ID == themeID);
                    if (posTheme < 0)
                    {
                        throw new XaliseException($"{((eModeGestionArchivage)modeGestion).Description()} du thème impossible : le thème n'a pas été trouvé.");
                    }
                    else
                    {
                        // Modification du thème
                        listeThemes[posTheme].EstArchive = modeGestion == (int)eModeGestionArchivage.ARCHIVAGE;

                        // Modification des enfants du thème
                        listeThemes.Where(x => x.ParentID.Equals(themeID)).ToList().ForEach(x => x.EstArchive = modeGestion == (int)eModeGestionArchivage.ARCHIVAGE);
                    }
                }

                // =-=-=-
                // Enregistrement des modifications + construction du message de retour
                // =-=-=-

                JsonHelper.WriteJsonDataFile(JsonHelper.CSTS_FILENAME_THEMES, listeThemes);

                retModel.MessageSucces = $"{((eModeGestionArchivage)modeGestion).Description()} du thème <b>{listeThemes[posTheme].Libelle}</b>";

                if (listeThemes.Any(x => x.ParentID.HasValue && x.ParentID.Value.Equals(themeID)))
                {
                    retModel.MessageSucces += " et de ses enfants";
                }

                retModel.MessageSucces += " réalisé avec succès.";
            }
            catch (Exception ex)
            {
                retModel.AddErreur(ex.Message);
            }

            return new JsonResult(retModel);
        }

        /// <summary>
        /// Vérifie la validité de l'identifiant du thème.
        /// </summary>
        /// <param name="themeID">Identifiant du thème.</param>
        /// <param name="nomParametre">Nom du paramètre.</param>
        /// <exception cref="ArgumentException"></exception>
        private void VerifierThemeID(int themeID, string nomParametre)
        {
            if (themeID <= 0)
            {
                throw new ArgumentException("L'identifiant du thème ne peut pas être inférieur ou égal à 0.", nomParametre);
            }
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
        /// <param name="parentID">Identifiant du thème parent.</param>
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
        private ThemeGEDViewModel RechercherThemes(ThemeCriteresRechercheModel criteres)
        {
            ThemeGEDViewModel model = new ThemeGEDViewModel(criteres);

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

            model.ListeThemes = retListe;

            return model;
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

        // TODO: liste des thèmes, changer icône pour ouvrir la fenêtre en mode 'Visualisation'
    }
}