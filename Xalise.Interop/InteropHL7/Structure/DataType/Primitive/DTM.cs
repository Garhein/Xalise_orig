using System;
using Xalise.Core.Extensions;
using Xalise.Interop.InteropHL7.Core;
using Xalise.Interop.InteropHL7.Enums;
using Xalise.Interop.InteropHL7.Exceptions;
using Xalise.Interop.InteropHL7.Helpers;

namespace Xalise.Interop.InteropHL7.Structure.DataType.Primitive
{
    /// <summary>
    /// DTM - Date/Time.
    /// </summary>
    /// <remarks>
    /// Notation d'horloge de 24 heures.<br/>
    /// Formats autorisés : YYYY[MM[DD[HH[MM[SS]]]]].
    /// </remarks>
    [Serializable]
    public class DTM : AbstractTypePrimitive
    {
        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="description">Description de la donnée.</param>
        /// <param name="maxLength">Longueur maximale autorisée de la donnée.</param>
        /// <param name="required">Indique si la donnée est obligatoire.</param>
        public DTM(string description, int maxLength, bool required) : base(description, maxLength, required) { }

        /// <summary>
        /// Accès, en lecture et écriture, à la valeur du type de données.
        /// </summary>
        /// <remarks>
        /// La donnée est vérifiée au moment de son affectation.
        /// </remarks>
        public new string Value
        {
            get
            {
                return this.Value;
            }
            set
            {
                try
                {
                    ePrecisionFormatDate format = DateTimeHelperHL7.GetPrecisionFormatDate(value);

                    if (!DateTimeHelperHL7.IsSupportedFormatForDTM(format))
                    {
                        throw new DataTypeException($"Le format spécifié n'est pas pris en charge pour le type de données '{this.TypeName}'.");
                    }
                    else
                    {
                        // 3. Vérifier via la regex

                        base.Value = value;
                    }
                }
                catch (Exception)
                {
                    throw;
                }

                // ==> Dans DateTimeHelperHL7
            }
        }

        
        /// <summary>
        /// Affecte une date/heure au type de données.
        /// </summary>
        /// <param name="dt">Date/heure à affecter.</param>
        /// <param name="format">Format à appliquer à la date/heure.</param>
        /// <exception cref="DataTypeException">Si le format spécifié n'est pas pris en charge.</exception>
        public void SetValueDTM(DateTime dt, ePrecisionFormatDate format)
        {
            if (!DateTimeHelperHL7.IsSupportedFormatForDTM(format))
            {
                throw new DataTypeException($"Le format spécifié n'est pas pris en charge pour le type de données '{this.TypeName}'.");
            }
            else
            {
                base.Value = dt.ToString(format.UsageValue());
            }
        }

        
        
        // TODO: GetDateTime -> return DateTime (récupération du format en fonction de la longueur de la chaîne)
        

        // TODO: DateTimeHelper -> définition dans des constantes des formats, get format en fonction de la longueur des données indiquées ?
    }
}
