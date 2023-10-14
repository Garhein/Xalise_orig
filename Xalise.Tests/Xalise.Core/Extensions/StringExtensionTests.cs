using NUnit.Framework;
using System;
using Xalise.Core.Extensions;

namespace Xalise.Tests.Xalise.Core.Extensions
{
    public class StringExtensionTests
    {
        #region IsNullOrEmpty

        /// <summary>
        /// La chaîne est <see langword="null"/>.<br/>
        /// Résultat attendu : <see langword="true"/>.
        /// </summary>
        [Test]
        public void IsNullOrEmpty_Null()
        {
            string strVal = null;
            Assert.True(strVal.IsNullOrEmpty());
        }

        /// <summary>
        /// La chaîne est <seealso cref="string.Empty"/>.<br/>
        /// Résultat attendu : <see langword="true"/>.
        /// </summary>
        [Test]
        public void IsNullOrEmpty_Empty()
        {
            string strVal = string.Empty;
            Assert.True(strVal.IsNullOrEmpty());
        }

        /// <summary>
        /// La chaîne n'est pas <see langword="null"/> et contient du texte.<br/>
        /// Résultat attendu : <see langword="false"/>.
        /// </summary>
        [Test]
        public void IsNullOrEmpty_NotEmpty()
        {
            string strVal = "abc";
            Assert.False(strVal.IsNullOrEmpty());
        }

        #endregion

        #region IsNotNullOrEmpty

        /// <summary>
        /// La chaîne est <see langword="null"/>.<br/>
        /// Résultat attendu : <see langword="false"/>.
        /// </summary>
        [Test]
        public void IsNotNullOrEmpty_Null()
        {
            string strVal = null;
            Assert.False(strVal.IsNotNullOrEmpty());
        }

        /// <summary>
        /// La chaîne est <seealso cref="string.Empty"/>.<br/>
        /// Résultat attendu : <see langword="false"/>.
        /// </summary>
        [Test]
        public void IsNotNullOrEmpty_Empty()
        {
            string strVal = string.Empty;
            Assert.False(strVal.IsNotNullOrEmpty());
        }

        /// <summary>
        /// La chaîne n'est pas <see langword="null"/> et contient du texte.<br/>
        /// Résultat attendu : <see langword="true"/>.
        /// </summary>
        [Test]
        public void IsNotNullOrEmpty_NotEmpty()
        {
            string strVal = "abc";
            Assert.True(strVal.IsNotNullOrEmpty());
        }

        #endregion

        #region IsNullOrWhiteSpace

        /// <summary>
        /// La chaîne est <see langword="null"/>.<br/>
        /// Résultat attendu : <see langword="true"/>.
        /// </summary>
        [Test]
        public void IsNullOrWhiteSpace_Null()
        {
            string strVal = null;
            Assert.True(strVal.IsNullOrWhiteSpace());
        }

        /// <summary>
        /// La chaîne est <seealso cref="string.Empty"/>.<br/>
        /// Résultat attendu : <see langword="true"/>.
        /// </summary>
        [Test]
        public void IsNullOrWhiteSpace_Empty()
        {
            string strVal = string.Empty;
            Assert.True(strVal.IsNullOrWhiteSpace());
        }

        /// <summary>
        /// La chaîne est composée uniquement d'espaces blancs.<br/>
        /// Résultat attendu : <see langword="true"/>.
        /// </summary>
        [Test]
        public void IsNullOrWhiteSpace_WhiteSpaces()
        {
            string strVal = "   ";
            Assert.True(strVal.IsNullOrWhiteSpace());
        }

        /// <summary>
        /// La chaîne n'est pas <see langword="null"/>, n'est pas vide (<c>""</c>) et ne contient pas uniquement des espaces blancs.<br/>
        /// Résultat attendu : <see langword="false"/>.
        /// </summary>
        [Test]
        public void IsNullOrWhiteSpace_NotEmpty()
        {
            string strVal = "abc";
            Assert.False(strVal.IsNullOrWhiteSpace());
        }

        #endregion

        #region IsNotNullOrWhiteSpace

        /// <summary>
        /// La chaîne est <see langword="null"/>.<br/>
        /// Résultat attendu : <see langword="false"/>.
        /// </summary>
        [Test]
        public void IsNotNullOrWhiteSpace_Null()
        {
            string strVal = null;
            Assert.False(strVal.IsNotNullOrWhiteSpace());
        }

        /// <summary>
        /// La chaîne est <seealso cref="string.Empty"/>.<br/>
        /// Résultat attendu : <see langword="false"/>.
        /// </summary>
        [Test]
        public void IsNotNullOrWhiteSpace_Empty()
        {
            string strVal = string.Empty;
            Assert.False(strVal.IsNotNullOrWhiteSpace());
        }

        /// <summary>
        /// La chaîne est composée uniquement d'espaces blancs.<br/>
        /// Résultat attendu : <see langword="false"/>.
        /// </summary>
        [Test]
        public void IsNotNullOrWhiteSpace_WhiteSpaces()
        {
            string strVal = "   ";
            Assert.False(strVal.IsNotNullOrWhiteSpace());
        }

        /// <summary>
        /// La chaîne n'est pas <see langword="null"/>, n'est pas vide (<c>""</c>) et ne contient pas uniquement des espaces blancs.<br/>
        /// Résultat attendu : <see langword="true"/>.
        /// </summary>
        [Test]
        public void IsNotNullOrWhiteSpace_NotEmpty()
        {
            string strVal = "abc";
            Assert.True(strVal.IsNotNullOrWhiteSpace());
        }

        #endregion

        #region RemoveRepeatingCharsFromEnd

        /// <summary>
        /// La chaîne est <see langword="null"/>.<br/>
        /// Résultat attendu : retour de la valeur d'origine.
        /// </summary>
        [Test]
        public void RemoveRepeatingCharsFromEnd_Null()
        {
            string strVal = null;
            string strRet = strVal.RemoveRepeatingCharsFromEnd('|');
            Assert.True(strRet == null);
        }

        /// <summary>
        /// La chaîne est <seealso cref="string.Empty"/>.<br/>
        /// Résultat attendu : retour de la valeur d'origine.
        /// </summary>
        [Test]
        public void RemoveRepeatingCharsFromEnd_Empty()
        {
            string strVal = string.Empty;
            string strRet = strVal.RemoveRepeatingCharsFromEnd('|');
            Assert.True(strRet == "");
        }

        /// <summary>
        /// Il n'y a pas de caractères répétitifs en fin de chaîne.<br/>
        /// Résultat attendu : retour de la valeur d'origine.
        /// </summary>
        [Test]
        public void RemoveRepeatingCharsFromEnd_WithoutRepeatingChars()
        {
            string strVal = "abc|def|ghi|jkl";
            string strRet = strVal.RemoveRepeatingCharsFromEnd('|');
            Assert.True(strRet == "abc|def|ghi|jkl");
        }

        /// <summary>
        /// Il y a des caractères répétitifs en fin de chaîne.<br/>
        /// Résultat attendu : retour de la valeur nettoyée.
        /// </summary>
        [Test]
        public void RemoveRepeatingCharsFromEnd_WithRepeatingChars()
        {
            string strVal = "abc|def|ghi|jkl|||||";
            string strRet = strVal.RemoveRepeatingCharsFromEnd('|');
            Assert.True(strRet == "abc|def|ghi|jkl");
        }

        #endregion

        #region RemoveRepeatingCharsFromStart

        /// <summary>
        /// La chaîne est <see langword="null"/>.<br/>
        /// Résultat attendu : retour de la valeur d'origine.
        /// </summary>
        [Test]
        public void RemoveRepeatingCharsFromStart_Null()
        {
            string strVal = null;
            string strRet = strVal.RemoveRepeatingCharsFromStart('|');
            Assert.True(strRet == null);
        }

        /// <summary>
        /// La chaîne est <seealso cref="string.Empty"/>.<br/>
        /// Résultat attendu : retour de la valeur d'origine.
        /// </summary>
        [Test]
        public void RemoveRepeatingCharsFromStart_Empty()
        {
            string strVal = string.Empty;
            string strRet = strVal.RemoveRepeatingCharsFromStart('|');
            Assert.True(strRet == "");
        }

        /// <summary>
        /// Il n'y a pas de caractères répétitifs en début de chaîne.<br/>
        /// Résultat attendu : retour de la valeur d'origine.
        /// </summary>
        [Test]
        public void RemoveRepeatingCharsFromStart_WithoutRepeatingChars()
        {
            string strVal = "abc|def|ghi|jkl";
            string strRet = strVal.RemoveRepeatingCharsFromStart('|');
            Assert.True(strRet == "abc|def|ghi|jkl");
        }

        /// <summary>
        /// Il y a des caractères répétitifs en début de chaîne.<br/>
        /// Résultat attendu : retour de la valeur nettoyée.
        /// </summary>
        [Test]
        public void RemoveRepeatingCharsFromStart_WithRepeatingChars()
        {
            string strVal = "|||||abc|def|ghi|jkl";
            string strRet = strVal.RemoveRepeatingCharsFromStart('|');
            Assert.True(strRet == "abc|def|ghi|jkl");
        }

        #endregion

        #region ContainsUniqueChars

        /// <summary>
        /// La chaîne est NULL.<br/>
        /// Résultat attendu : exception <see cref="ArgumentException"/>.
        /// </summary>
        [Test]
        public void ContainsUniqueChars_Null()
        {
            string strVal = null;
            Assert.Throws<ArgumentException>(() => strVal.ContainsUniqueChars());
        }

        /// <summary>
        /// La chaîne est vide.<br/>
        /// Résultat attendu : exception <see cref="ArgumentException"/>.
        /// </summary>
        [Test]
        public void ContainsUniqueChars_Empty()
        {
            string strVal = string.Empty;
            Assert.Throws<ArgumentException>(() => strVal.ContainsUniqueChars());
        }

        /// <summary>
        /// La chaîne contient uniquement des espaces.<br/>
        /// Résultat attendu : exception <see cref="ArgumentException"/>.
        /// </summary>
        [Test]
        public void ContainsUniqueChars_WhiteSpacesOnly()
        {
            string strVal = "   ";
            Assert.Throws<ArgumentException>(() => strVal.ContainsUniqueChars());
        }

        /// <summary>
        /// La chaîne contient des caractères en double.<br/>
        /// Résultat attendu : <see langword="false"/>.
        /// </summary>
        [Test]
        public void ContainsUniqueChars_RepeatingChars()
        {
            string strVal = "abcdefghijkladgj";
            Assert.False(strVal.ContainsUniqueChars());
        }

        /// <summary>
        /// La chaîne ne contient pas de caractère en double.<br/>
        /// Résultat attendu : <see langword="true"/>.
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
