using System;
using System.Linq;
using Xalise.Core.Extensions;
using Xalise.Interop.InteropHL7.Exceptions;

namespace Xalise.Interop.InteropHL7.Structure
{
    /// <summary>
    /// Définition du séparateur de champ et des caractères d'encodage d'un message HL7.
    /// </summary>
    [Serializable]
    public class EncodingCharacters
    {
        public const char DEF_FIELD_SEP         = '|';
        public const char DEF_COMPONENT_SEP     = '^';
        public const char DEF_REPETITION_SEP    = '~';
        public const char DEF_ESCAPE_CHAR       = '\\';
        public const char DEF_SUB_COMPONENT_SEP = '&';

        private char    _fieldSeparator;
        private char[]  _encodingCharacters;

        /// <summary>
        /// Constructeur vide.
        /// Initialise le séparateur de champ et les caractères d'encodage à leur valeur par défaut.
        /// </summary>
        public EncodingCharacters() 
               : this(EncodingCharacters.DEF_FIELD_SEP, 
                      EncodingCharacters.DEF_COMPONENT_SEP,
                      EncodingCharacters.DEF_REPETITION_SEP,
                      EncodingCharacters.DEF_ESCAPE_CHAR,
                      EncodingCharacters.DEF_SUB_COMPONENT_SEP) { }

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="fieldSep">Séparateur de champ.</param>
        /// <param name="componentSep">Séparateur de composant.</param>
        /// <param name="repetitionSep">Séparateur de répétition.</param>
        /// <param name="escapeChar">Caractère d'échappement.</param>
        /// <param name="subComponentSep">Séparateur de sous-composant.</param>
        public EncodingCharacters(
               char fieldSep,
               char componentSep,
               char repetitionSep,
               char escapeChar,
               char subComponentSep) 
               : this (fieldSep, new string(new[] { componentSep, repetitionSep, escapeChar, subComponentSep })) { }

        /// <summary>
        /// Séparateur.
        /// Le séparateur de champ est initialisé à la valeur par défaut s'il s'agit d'un espace.
        /// </summary>
        /// <param name="fieldSep">Séparateur de champ.</param>
        /// <param name="encodingChars">Chaîne représentant les caractères d'encodage.</param>
        /// <exception cref="HL7Exception">Si <paramref name="encodingChars"/> contient au moins un espace ou des caractères en doublons.</exception>
        public EncodingCharacters(char fieldSep, string encodingChars)
        {
            if (char.IsWhiteSpace(fieldSep))
            {
                this._fieldSeparator = EncodingCharacters.DEF_FIELD_SEP;
            }
            else
            {
                this._fieldSeparator = fieldSep;
            }

            if (string.IsNullOrWhiteSpace(encodingChars))
            {
                this._encodingCharacters    = new char[4];
                this._encodingCharacters[0] = EncodingCharacters.DEF_COMPONENT_SEP;
                this._encodingCharacters[1] = EncodingCharacters.DEF_REPETITION_SEP;
                this._encodingCharacters[2] = EncodingCharacters.DEF_ESCAPE_CHAR;
                this._encodingCharacters[3] = EncodingCharacters.DEF_SUB_COMPONENT_SEP;
            }
            else
            {
                if (encodingChars.Any(x => char.IsWhiteSpace(x)))
                {
                    throw new HL7Exception("Les caractères d'encodage ne peuvent pas contenir de caractère non imprimable.");
                }
                else if (!encodingChars.ContainsUniqueChars())
                {
                    throw new HL7Exception("Les caractères d'encodage doivent être uniques.");
                }

                this._encodingCharacters = encodingChars.ToCharArray(0, 4);
            }
        }

        /// <summary>
        /// Séparateur de champ.
        /// </summary>
        public char FieldSeparator
        {
            get
            {
                return this._fieldSeparator;
            }
        }

        /// <summary>
        /// Séparateur de composant.
        /// </summary>
        public char ComponentSeparator
        {
            get
            {
                return this._encodingCharacters[0];
            }
        }

        /// <summary>
        /// Séparateur de répétition.
        /// </summary>
        public char RepetitionSeparator
        {
            get
            {
                return this._encodingCharacters[1];
            }
        }

        /// <summary>
        /// Caractère d'échappement.
        /// </summary>
        public char EscapeChar
        {
            get
            {
                return this._encodingCharacters[2];
            }
        }

        /// <summary>
        /// Séparateur de sous-composant.
        /// </summary>
        public char SubComponentSeparator
        {
            get
            {
                return this._encodingCharacters[3];
            }
        }

        /// <summary>
        /// Caractères d'encodage.
        /// </summary>
        public char[] EncodingChars
        {
            get
            {
                return this._encodingCharacters;
            }
        }
    }
}
