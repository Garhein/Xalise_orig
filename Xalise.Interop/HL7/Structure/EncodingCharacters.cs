using System;

namespace Xalise.Interop.HL7.Structure
{
    /// <summary>
    /// Définition du séparateur de champ et des caractères d'encodage d'un message.
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
        public EncodingCharacters() : this(EncodingCharacters.DEF_FIELD_SEP, EncodingCharacters.DefaultEncodingChars) { }

        /// <summary>
        /// Constructeur.
        /// Si les valeurs sont incorrectes le séparateur de champ et les caractères d'encodage sont initialisés à leur valeur par défaut.
        /// </summary>
        /// <param name="fieldSeparator">Séparateur de champ.</param>
        /// <param name="encodingCharacters">Caractères d'encodage.</param>
        public EncodingCharacters(char fieldSeparator, string encodingCharacters)
        {
            if (char.IsWhiteSpace(fieldSeparator))
            {
                this._fieldSeparator = EncodingCharacters.DEF_FIELD_SEP;
            }
            else
            {
                this._fieldSeparator = fieldSeparator;
            }

            if (string.IsNullOrWhiteSpace(encodingCharacters) || encodingCharacters.Length < 4)
            {
                encodingCharacters = EncodingCharacters.DefaultEncodingChars;
            }

            this._encodingCharacters = encodingCharacters.ToCharArray(0, 4);
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
        /// Caractères d'encodage.
        /// </summary>
        public char[] EncodingChars
        {
            get
            {
                return this._encodingCharacters;
            }
        }

        /// <summary>
        /// Concaténation des caractères d'encodage par défaut.
        /// </summary>
        public static string DefaultEncodingChars
        {
            get
            {
                return $"{EncodingCharacters.DEF_COMPONENT_SEP}{EncodingCharacters.DEF_REPETITION_SEP}{EncodingCharacters.DEF_ESCAPE_CHAR}{EncodingCharacters.DEF_SUB_COMPONENT_SEP}";
            }
        }
    }
}
