using System;

namespace Xalise.Interop.HL7.Helpers
{
    /// <summary>
    /// Fonctions utilitaires pour manipuler les champs.
    /// </summary>
    public static class FieldHelper
    {
        /// <summary>        
        /// Construit la numérotation d'un champ.
        /// </summary>
        /// <param name="segmentName">Nom du segment.</param>
        /// <param name="numField">Numéro du champ.</param>
        /// <param name="numRepetition">Numéro de la répétition.</param>
        /// <param name="numSubComponent">Numéro du sous-composant.</param>
        /// <exception cref="ArgumentNullException">Si le nom du segment n'est pas renseigné.</exception>
        /// <exception cref="ArgumentException">Si le numéro de champ est inférieur ou égal à 0.</exception>
        /// <returns></returns>
        public static string ConstructFieldNumber(string segmentName, int numField, int? numRepetition = null, int? numSubComponent = null)
        {
            if (string.IsNullOrWhiteSpace(segmentName))
            {
                throw new ArgumentNullException(nameof(segmentName));
            }

            if (numField <= 0)
            {
                throw new ArgumentException($"Numéro de champ non valide.");
            }

            string retVal = $"{segmentName}-{numField}";

            if (numRepetition.HasValue && numRepetition.Value > 0)
            {
                retVal += $".{numRepetition.Value}";

                if (numSubComponent.HasValue && numSubComponent.Value > 0)
                {
                    retVal += $"/{numSubComponent}";
                }
            }

            return retVal;
        }
    }
}
