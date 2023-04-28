using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using Xalise.Core.Entite.GED;
using Xalise.Core.Extensions;

namespace Xalise.Web.Helpers.WebHelpers
{
    public static class SelectListHelper
    {
        /// <summary>
        /// Ajout d'une option dans les éléments d'une liste déroulante.
        /// </summary>
        /// <param name="liste">Liste à laquelle ajouter l'option.</param>
        /// <param name="text">Texte à afficher.</param>
        /// <param name="value">Valeur de l'option.</param>
        /// <param name="selected">Indique si l'option est sélectionnée.</param>
        private static void _AddItem(ref List<SelectListItem> liste, string text, string value, bool selected)
        {
            liste.Add(
                new SelectListItem()
                {
                    Text = text,
                    Value = value,
                    Selected = selected
                }
            );
        }

        /// <summary>
        /// Construction de la liste déroulante des thèmes parents.
        /// </summary>
        /// <param name="listeThemes">Liste des thèmes parents.</param>
        /// <param name="valSelectionnee">Thème sélectionné par défaut.</param>
        /// <param name="ajouterLigneVide">Indique si une ligne vide doit être ajoutée à la liste déroulante.</param>
        /// <param name="titreLigneVide">Titre de la ligne vide.</param>
        /// <param name="titreSansResultat">Titre de l'option indiquant qu'aucune valeur n'est disponible.</param>
        /// <returns></returns>
        public static List<SelectListItem> ConstruireListeThemesParents(IEnumerable<ThemeDTO> listeThemes,
                                                                        int? valSelectionnee = null,
                                                                        bool ajouterLigneVide = true,
                                                                        string titreLigneVide = "Sélectionnez un thème parent",
                                                                        string titreSansResultat = "Aucun thème parent disponible")
        {
            List<SelectListItem> retListe = new List<SelectListItem>();

            if (listeThemes.IsEmpty())
            {
                _AddItem(ref retListe, titreSansResultat, string.Empty, true);
            }
            else
            {
                if (ajouterLigneVide)
                {
                    _AddItem(ref retListe, titreLigneVide, string.Empty, !valSelectionnee.HasValue);
                }

                foreach (ThemeDTO dto in listeThemes)
                {
                    _AddItem(ref retListe, dto.Libelle, dto.ID.ToString(), valSelectionnee.HasValue && valSelectionnee.Value == dto.ID);
                }
            }

            return retListe;
        }
    }
}
