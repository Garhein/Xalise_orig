using System;
using Xalise.Core.Extensions;
using Xalise.Core.Helpers;
using Xalise.Interop.InteropHL7.Enums;
using Xalise.Interop.InteropHL7.Exceptions;
using Xalise.Interop.InteropHL7.Structure.DataType.Primitive;

namespace Xalise.Interop.InteropHL7.Helpers
{
    /// <summary>
    /// Fonctions utilitaires pour manipuler les types de données <seealso cref="DTM"/> et <seealso cref="DT"/>.
    /// </summary>
    public static class DateTimeHelperHL7
    {
        /// <summary>
        /// Détermine le format d'une date/heure.
        /// </summary>
        /// <param name="value">Valeur représentant la date/heure.</param>
        /// <returns>Une valeur <seealso cref="ePrecisionFormatDate"/> représentant le format de la date/heure.</returns>
        /// <exception cref="ArgumentException">Si <paramref name="value"/> est <seealso langword="null"/> ou composée uniquement d'espaces.</exception>
        /// <exception cref="DataTypeException">Si la longueur de <paramref name="value"/> ne correspond à aucun format pris en charge.</exception>
        public static ePrecisionFormatDate GetPrecisionFormatDate(string value)
        {
            if (value.IsNullOrWhiteSpace())
            {
                throw new ArgumentException("Impossible de déterminer le format car la chaîne est NULL ou composée uniquement d'espaces.", nameof(value));
            }

            short valEnum = 0;

            switch (value.Length)
            {
                case 4:
                    {
                        valEnum = (short)ePrecisionFormatDate.YEAR;
                        break;
                    }
                case 6:
                    {
                        valEnum = (short)ePrecisionFormatDate.MONTH;
                        break;
                    }
                case 8:
                    {
                        valEnum = (short)ePrecisionFormatDate.DAY;
                        break;
                    }
                case 10:
                    {
                        valEnum = (short)ePrecisionFormatDate.HOUR;
                        break;
                    }
                case 12:
                    {
                        valEnum = (short)ePrecisionFormatDate.MINUTE;
                        break;
                    }
                case 14:
                    {
                        valEnum = (short)ePrecisionFormatDate.SECOND;
                        break;
                    }
                default:
                    {
                        break;
                    }
            }

            if (valEnum <= 0)
            {
                throw new DataTypeException($"Le format de la donnée '{value}' n'est pas pris en charge.");
            }

            return (ePrecisionFormatDate)valEnum;
        }

        /// <summary>
        /// Détermine si le format est supporté par le type de données <seealso cref="DT"/>.
        /// </summary>
        /// <remarks>
        /// Les formats supportés par le type <seealso cref="DT"/> sont :<br/>
        ///  - <see cref="ePrecisionFormatDate.YEAR"/><br/>
        ///  - <see cref="ePrecisionFormatDate.MONTH"/><br/>
        ///  - <see cref="ePrecisionFormatDate.DAY"/>
        /// </remarks>
        /// <param name="format">Format à vérifier.</param>
        /// <returns><seealso langword="true"/> si le format est supporté, sinon <seealso langword="false"/>.</returns>
        public static bool IsSupportedFormatForDT(ePrecisionFormatDate format)
        {
            return format == ePrecisionFormatDate.YEAR || format == ePrecisionFormatDate.MONTH || format == ePrecisionFormatDate.DAY;
        }

        /// <summary>
        /// Détermine si le format est supporté par le type de données <seealso cref="DTM"/>.
        /// </summary>
        /// <remarks>
        /// L'ensemble des formats <see cref="ePrecisionFormatDate"/> sont supportés par le type <seealso cref="DTM"/>.
        /// </remarks>
        /// <param name="format">Format à vérifier.</param>
        /// <returns><seealso langword="true"/> si le format est supporté, sinon <seealso langword="false"/>.</returns>
        public static bool IsSupportedFormatForDTM(ePrecisionFormatDate format)
        {
            return EnumHelper.VerifierValidite<ePrecisionFormatDate>(format);
        }





        /// <summary>
        /// Détermine si le format de la valeur est supporté par le type de données <seealso cref="Structure.DataType.Primitive.DTM"/>.
        /// </summary>
        /// <param name="value">Donnée permettant de vérifier si le format est supporté.</param>
        /// <returns>True si le format est supporté, sinon False.</returns>
        public static bool IsSupportedFormatForDTM(string value)
        {
            bool supported = false;

            try
            {
                supported = DateTimeHelperHL7.IsSupportedFormatForDTM(DateTimeHelperHL7.GetPrecisionFormatDate(value));
            }
            catch (ArgumentException)
            {
                throw;
            }
            catch (DataTypeException)
            {
                supported = false;
            }

            return supported;
        }


        /// <summary>
        /// Détermine si le format de la valeur est supporté par le type de données <seealso cref="Structure.DataType.Primitive.DT"/>.
        /// </summary>
        /// <param name="value">Donnée permettant de vérifier si le format est supporté.</param>
        /// <returns>True si le format est supporté, sinon False.</returns>
        public static bool IsSupportedFormatForDT(string value)
        {
            bool supported = false;

            try
            {
                supported = DateTimeHelperHL7.IsSupportedFormatForDT(DateTimeHelperHL7.GetPrecisionFormatDate(value));
            }
            catch (ArgumentException)
            {
                throw;
            }
            catch (DataTypeException)
            {
                supported = false;
            }

            return supported;
        }

        

        
    }
}
