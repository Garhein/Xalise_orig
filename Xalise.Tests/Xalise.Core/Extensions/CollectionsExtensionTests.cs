using NUnit.Framework;
using System.Collections.Generic;
using Xalise.Core.Extensions;

namespace Xalise.Tests.Xalise.Core.Extensions
{
    public  class CollectionsExtensionTests
    {
        #region IsEmpty

        /// <summary>
        /// La liste est <see langword="null"/>.<br/>
        /// Résultat attendu : <see langword="true"/>.
        /// </summary>
        [Test]
        public void IsEmpty_List_NULL()
        {
            IEnumerable<string> liste = null;
            Assert.True(liste.IsEmpty());
        }

        /// <summary>
        /// La liste n'est pas <see langword="null"/> et contient des valeurs.</br>
        /// Résultat attendu : <see langword="false"/>.
        /// </summary>
        [Test]
        public void IsEmpty_List_WithValues()
        {
            IEnumerable<string> liste = new List<string>() { "abc", "def", "ghi", "jkl" };
            Assert.False(liste.IsEmpty());
        }

        /// <summary>
        /// La liste n'est pas <see langword="null"/> et ne contient aucune valeur.<br/>
        /// Résultat attendu : <see langword="true"/>.
        /// </summary>
        [Test]
        public void IsEmpty_List_WithoutValues()
        {
            IEnumerable<string> liste = new List<string>();
            Assert.True(liste.IsEmpty());
        }

        /// <summary>
        /// Le dictionnaire est <see langword="null"/>.<br/>
        /// Résultat attendu : <see langword="true"/>
        /// </summary>
        [Test]
        public void IsEmpty_Dictionary_NULL()
        {
            IDictionary<int, string> dico = null;
            Assert.True(dico.IsEmpty());
        }

        /// <summary>
        /// Le dictionnaire n'est pas <see langword="null"/> et contient des valeurs.<br/>
        /// Résultat attendu : <see langword="false"/>
        /// </summary>
        [Test]
        public void IsEmpty_Dictionary_WithValues()
        {
            IDictionary<int, string> dico = new Dictionary<int, string>()
            {
                { 1, "abc" },
                { 2, "def" },
                { 3, "ghi" },
                { 4, "jkl" }
            };

            Assert.False(dico.IsEmpty());
        }

        /// <summary>
        /// Le dictionnaire n'est pas <see langword="null"/> et ne contient aucune valeur.<br/>
        /// Résultat attendu : <see langword="true"/>
        /// </summary>
        [Test]
        public void IsEmpty_Dictionary_WithoutValues()
        {
            IDictionary<int, string> dico = new Dictionary<int, string>();
            Assert.True(dico.IsEmpty());
        }

        #endregion

        #region IsNotEmpty

        /// <summary>
        /// La liste est <see langword="null"/>.<br/>
        /// Résultat attendu : <see langword="false"/>.
        /// </summary>
        [Test]
        public void IsNotEmpty_List_NULL()
        {
            IEnumerable<string> liste = null;
            Assert.False(liste.IsNotEmpty());
        }

        /// <summary>
        /// La liste n'est pas <see langword="null"/> et contient des valeurs.<br/>
        /// Résultat attendu : <see langword="true"/>.
        /// </summary>
        [Test]
        public void IsNotEmpty_List_WithValues()
        {
            IEnumerable<string> liste = new List<string>() { "abc", "def", "ghi", "jkl" };
            Assert.True(liste.IsNotEmpty());
        }

        /// <summary>
        /// La liste n'est pas <see langword="null"/> et ne contient aucune valeur.<br/>
        /// Résultat attendu : <see langword="false"/>.
        /// </summary>
        [Test]
        public void IsNotEmpty_List_WithoutValues()
        {
            IEnumerable<string> liste = new List<string>();
            Assert.False(liste.IsNotEmpty());
        }

        /// <summary>
        /// Le dictionnaire est <see langword="null"/>.<br/>
        /// Résultat attendu : <see langword="false"/>.
        /// </summary>
        [Test]
        public void IsNotEmpty_Dictionary_NULL()
        {
            IDictionary<int, string> dico = null;
            Assert.False(dico.IsNotEmpty());
        }

        /// <summary>
        /// Le dictionnaire n'est pas <see langword="null"/> et contient des valeurs.<br/>
        /// Résultat attendu : <see langword="true"/>.
        /// </summary>
        [Test]
        public void IsNotEmpty_Dictionary_WithValues()
        {
            IDictionary<int, string> dico = new Dictionary<int, string>()
            {
                { 1, "abc" },
                { 2, "def" },
                { 3, "ghi" },
                { 4, "jkl" }
            };

            Assert.True(dico.IsNotEmpty());
        }

        /// <summary>
        /// Le dictionnaire n'est pas <see langword="null"/> et ne contient aucune valeur.<br/>
        /// Résultat attendu : <see langword="false"/>.
        /// </summary>
        [Test]
        public void IsNotEmpty_Dictionary_WithoutValues()
        {
            IDictionary<int, string> dico = new Dictionary<int, string>();
            Assert.False(dico.IsNotEmpty());
        }

        #endregion
    }
}
