using NUnit.Framework;
using System;
using Xalise.Core.Extensions;

namespace Xalise.Tests.Xalise.Core.Extensions
{
    public class StringExtensionTests
    {
        #region IsNullOrEmpty

        /// <summary>
        /// La chaîne est <see langword="null"/> => True.
        /// </summary>
        [Test]
        public void IsNullOrEmpty_Null()
        {
            string strVal = null;
            Assert.True(strVal.IsNullOrEmpty());
        }

        /// <summary>
        /// La chaîne est <seealso cref="string.Empty"/> => True.
        /// </summary>
        [Test]
        public void IsNullOrEmpty_Empty()
        {
            string strVal = string.Empty;
            Assert.True(strVal.IsNullOrEmpty());
        }

        /// <summary>
        /// La chaîne n'est pas <see langword="null"/> et contient du texte => False.
        /// </summary>
        [Test]
        public void IsNullOrEmpty_NotEmpty()
        {
            string strVal = "abc";
            Assert.False(strVal.IsNullOrEmpty());
        }

        #endregion

        #region IsNullOrWhiteSpace

        /// <summary>
        /// La chaîne est <see langword="null"/> => True.
        /// </summary>
        [Test]
        public void IsNullOrWhiteSpace_Null()
        {
            string strVal = null;
            Assert.True(strVal.IsNullOrWhiteSpace());
        }

        /// <summary>
        /// La chaîne est <seealso cref="string.Empty"/> => True.
        /// </summary>
        [Test]
        public void IsNullOrWhiteSpace_Empty()
        {
            string strVal = string.Empty;
            Assert.True(strVal.IsNullOrWhiteSpace());
        }

        /// <summary>
        /// La chaîne est composée uniquement d'espaces blancs => True.
        /// </summary>
        [Test]
        public void IsNullOrWhiteSpace_WhiteSpaces()
        {
            string strVal = "   ";
            Assert.True(strVal.IsNullOrWhiteSpace());
        }

        /// <summary>
        /// La chaîne n'est pas <see langword="null"/>, n'est pas vide et ne contient pas uniquement des espaces blancs.
        /// </summary>
        [Test]
        public void IsNullOrWhiteSpace_NotEmpty()
        {
            string strVal = "abc";
            Assert.False(strVal.IsNullOrWhiteSpace());
        }

        #endregion

        #region RemoveRepeatingCharsFromEnd

        /// <summary>
        /// La chaîne est <see langword="null"/> => retour de la valeur d'origine.
        /// </summary>
        [Test]
        public void RemoveRepeatingCharsFromEnd_Null()
        {
            string strVal = null;
            string strRet = strVal.RemoveRepeatingCharsFromEnd('|');
            Assert.True(strRet == null);
        }

        /// <summary>
        /// La chaîne est <seealso cref="string.Empty"/> => retour de la valeur d'origine.
        /// </summary>
        [Test]
        public void RemoveRepeatingCharsFromEnd_Empty()
        {
            string strVal = string.Empty;
            string strRet = strVal.RemoveRepeatingCharsFromEnd('|');
            Assert.True(strRet == "");
        }

        /// <summary>
        /// La chaîne est composée uniquement d'espaces blancs => retour de la valeur d'origine.
        /// </summary>
        [Test]
        public void RemoveRepeatingCharsFromEnd_WhiteSpaces()
        {
            string strVal = "   ";
            string strRet = strVal.RemoveRepeatingCharsFromEnd('|');
            Assert.True(strRet == "   ");
        }

        /// <summary>
        /// Il n'y a pas de caractères répétitifs en fin de chaîne => retour de la valeur d'origine.
        /// </summary>
        [Test]
        public void RemoveRepeatingCharsFromEnd_WithoutRepeatingChars()
        {
            string strVal = "abc|def|ghi|jkl";
            string strRet = strVal.RemoveRepeatingCharsFromEnd('|');
            Assert.True(strRet == "abc|def|ghi|jkl");
        }

        /// <summary>
        /// Il y a des caractères répétitifs en fin de chaîne => retour de la chaîne nettoyée.
        /// </summary>
        [Test]
        public void RemoveRepeatingCharsFromEnd_WithRepeatingChars()
        {
            string strVal = "abc|def|ghi|jkl|||||";
            string strRet = strVal.RemoveRepeatingCharsFromEnd('|');
            Assert.True(strRet == "abc|def|ghi|jkl");
        }

        #endregion

        #region ContainsUniqueChars

        /// <summary>
        /// La chaîne est NULL => exception.
        /// </summary>
        [Test]
        public void ContainsUniqueChars_Null()
        {
            string strVal = null;
            Assert.Throws<ArgumentException>(() => strVal.ContainsUniqueChars());
        }

        /// <summary>
        /// La chaîne est vide => exception.
        /// </summary>
        [Test]
        public void ContainsUniqueChars_Empty()
        {
            string strVal = string.Empty;
            Assert.Throws<ArgumentException>(() => strVal.ContainsUniqueChars());
        }

        /// <summary>
        /// La chaîne contient uniquement des espaces => exception.
        /// </summary>
        [Test]
        public void ContainsUniqueChars_WhiteSpacesOnly()
        {
            string strVal = "   ";
            Assert.Throws<ArgumentException>(() => strVal.ContainsUniqueChars());
        }

        /// <summary>
        /// La chaîne contient des caractères en double => False.
        /// </summary>
        [Test]
        public void ContainsUniqueChars_RepeatingChars()
        {
            string strVal = "abcdefghijkladgj";
            Assert.False(strVal.ContainsUniqueChars());
        }

        /// <summary>
        /// La chaîne ne contient pas de caractère en double => True.
        /// </summary>
        [Test]
        public void ContainsUniqueChars_UniqueChars()
        {
            string strVal = "abcdefghijkl";
            Assert.True(strVal.ContainsUniqueChars());
        }

        #endregion
    }
}
