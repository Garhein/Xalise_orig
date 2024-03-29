﻿using System;
using Xalise.Core.Extensions;
using Xalise.Core.Helpers;
using Xalise.Interop.InteropHL7.Core;
using Xalise.Interop.InteropHL7.Exceptions;
using Xalise.Interop.InteropHL7.Helpers;

namespace Xalise.Interop.InteropHL7.Structure.DataType.Primitive
{
    /// <summary>
    /// NM - Numeric.
    /// </summary>
    /// <remarks>
    /// Nombre représenté sous la forme d'une série de caractères numériques, composé :<br/>
    ///  - d'un signe arithmétique facultatif (<seealso cref="NumberHelper.CSTS_DEFAULT_POSITIVE_SIGN"/> ou <seealso cref="NumberHelper.CSTS_DEFAULT_NEGATIVE_SIGN"/>)<br/>
    ///  - de chiffres<br/>
    ///  - d'un point décimal facultatif<br/>
    /// En l'absence de signe, le nombre est supposé positif.<br/>
    /// S'il n'y a pas de point décimal, le nombre est supposé être un entier.
    /// </remarks>
    [Serializable]
    public class NM : AbstractTypePrimitive
    {
        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="description">Description de la donnée.</param>
        /// <param name="maxLength">Longueur maximale autorisée de la donnée.</param>
        /// <param name="required">Indique si la donnée est obligatoire.</param>
        public NM(string description, int maxLength, bool required) : base(description, maxLength, required) { }

        /// <summary>
        /// Accès, en lecture et écriture, à la valeur du type de données.
        /// </summary>
        /// <remarks>
        /// La donnée est nettoyée et vérifiée au moment de son affectation.
        /// </remarks>
        public new string Value
        {
            get
            {
                return this.Value;
            }
            set
            {
                this.Value = NumberHelperHL7.SanitizeAndCheckNM(value);
            }
        }

        /// <summary>
        /// Détermine si la valeur est positive.
        /// </summary>
        /// <remarks>
        /// La valeur est considérée comme positive si le signe arithmétique est <seealso cref="NumberHelper.CSTS_DEFAULT_POSITIVE_SIGN"/> ou n'est pas renseigné.
        /// </remarks>
        public bool IsPositive
        {
            get
            {
                if (this.Value.IsNullOrWhiteSpace())
                {
                    throw new DataTypeException($"Impossible de déterminer si la valeur du type '{this.TypeName}' est positive : valeur NULL ou composée uniquement d'espaces.");
                }

                return this.Value.StartsWith(NumberHelper.CSTS_DEFAULT_POSITIVE_SIGN) || char.IsDigit(this.Value[0]);
            }
        }

        /// <summary>
        /// Détermine si la valeur est négative.
        /// </summary>
        /// <remarks>
        /// La valeur est considérée comme négative si le signe arithmétique est <seealso cref="NumberHelper.CSTS_DEFAULT_NEGATIVE_SIGN"/>.
        /// </remarks>
        public bool IsNegative
        {
            get
            {
                if (this.Value.IsNullOrWhiteSpace())
                {
                    throw new DataTypeException($"Impossible de déterminer si la valeur du type '{this.TypeName}' est négative : valeur NULL ou composée uniquement d'espaces.");
                }

                return this.Value.StartsWith(NumberHelper.CSTS_DEFAULT_NEGATIVE_SIGN);
            }
        }

        /// <summary>
        /// Détermine si la valeur est un décimal.
        /// </summary>
        /// <remarks>
        /// La valeur est considérée comme un décimal si elle contient un <seealso cref="NumberHelper.CSTS_DEFAULT_DECIMAL_SEPARATOR"/>.
        /// </remarks>
        public bool IsDecimal
        {
            get
            {
                if (this.Value.IsNullOrWhiteSpace())
                {
                    throw new DataTypeException($"Impossible de déterminer si la valeur du type '{this.TypeName}' est un décimal : valeur NULL ou composée uniquement d'espaces.");
                }

                return this.Value.Contains(NumberHelper.CSTS_DEFAULT_DECIMAL_SEPARATOR);
            }
        }

        /// <summary>
        /// Récupère la valeur sous forme d'un <see cref="int"/>.
        /// </summary>
        public int GetInt
        {
            get
            {
                int retInt = 0;

                if (!int.TryParse(this.Value, out retInt))
                {
                    throw new DataTypeException($"Impossible de convertir la valeur '{this.Value}' en un entier.");
                }

                return retInt;
            }
        }

        /// <summary>
        /// Affecte un entier.
        /// </summary>
        /// <param name="value">Valeur à affecter.</param>
        /// <exception cref="DataTypeException">Si une erreur est détectée à la conversion en <see cref="string"/>.</exception>
        public void SetInt(int value)
        {
            try
            {
                this.Value = value.ToStringFormat("");
            }
            catch (Exception ex)
            {
                throw new DataTypeException("Erreur de conversion d'un entier vers une chaîne de caractères.", ex);
            }
        }

        /// <summary>
        /// Récupère la valeur sous forme d'un <see cref="decimal"/>.
        /// </summary>
        public decimal GetDecimal
        {
            get
            {
                decimal retDecimal = 0;

                if (!decimal.TryParse(this.Value, out retDecimal))
                {
                    throw new DataTypeException($"Impossible de convertir la valeur '{this.Value}' en un décimal.");
                }

                return retDecimal;
            }
        }

        /// <summary>
        /// Affecte un décimal.
        /// </summary>
        /// <param name="value">Valeur à affecter.</param>
        /// <param name="nbDecimales">Nombre de décimales à conserver.</param>
        /// <exception cref="DataTypeException">Si une erreur est détectée à la conversion en <see cref="string"/>.</exception>
        public void SetDecimal(decimal value, int nbDecimales)
        {
            try
            {
                this.Value = value.ToStringFormat(nbDecimales, "");
            }
            catch (Exception ex)
            {
                throw new DataTypeException("Erreur de conversion d'un décimal vers une chaîne de caractères.", ex);
            }
        }
    }
}
