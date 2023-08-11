using NUnit.Framework;
using System.Collections.Generic;
using Xalise.Core.Extensions;

namespace Xalise.Tests.Xalise.Core.Extensions
{
    public  class CollectionsExtensionTests
    {
        #region IsEmpty

        /// <summary>
        /// La liste est NULL => True.
        /// </summary>
        [Test]
        public void IsEmpty_List_NULL()
        {
            IEnumerable<string> liste = null;
            Assert.True(liste.IsEmpty());
        }

        /// <summary>
        /// La liste n'est pas NULL et contient des valeurs => False.
        /// </summary>
        [Test]
        public void IsEmpty_List_WithValues()
        {
            IEnumerable<string> liste = new List<string>() { "abc", "def", "ghi", "jkl" };
            Assert.False(liste.IsEmpty());
        }

        /// <summary>
        /// La liste n'est pas NULL et ne contient aucune valeur => True.
        /// </summary>
        [Test]
        public void IsEmpty_List_WithoutValues()
        {
            IEnumerable<string> liste = new List<string>();
            Assert.True(liste.IsEmpty());
        }

        /// <summary>
        /// Le dictionnaire est NULL => True.
        /// </summary>
        [Test]
        public void IsEmpty_Dictionary_NULL()
        {
            IDictionary<int, string> dico = null;
            Assert.True(dico.IsEmpty());
        }

        /// <summary>
        /// Le dictionnaire n'est pas NULL et contient des valeurs => False.
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
        /// Le dictionnaire n'est pas NULL et ne contient aucune valeur => True.
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
        /// La liste est NULL => False.
        /// </summary>
        [Test]
        public void IsNotEmpty_List_NULL()
        {
            IEnumerable<string> liste = null;
            Assert.False(liste.IsNotEmpty());
        }

        /// <summary>
        /// La liste n'est pas NULL et contient des valeurs => True.
        /// </summary>
        [Test]
        public void IsNotEmpty_List_WithValues()
        {
            IEnumerable<string> liste = new List<string>() { "abc", "def", "ghi", "jkl" };
            Assert.True(liste.IsNotEmpty());
        }

        /// <summary>
        /// La liste n'est pas NULL et ne contient aucune valeur => False.
        /// </summary>
        [Test]
        public void IsNotEmpty_List_WithoutValues()
        {
            IEnumerable<string> liste = new List<string>();
            Assert.False(liste.IsNotEmpty());
        }

        /// <summary>
        /// Le dictionnaire est NULL => False.
        /// </summary>
        [Test]
        public void IsNotEmpty_Dictionary_NULL()
        {
            IDictionary<int, string> dico = null;
            Assert.False(dico.IsNotEmpty());
        }

        /// <summary>
        /// Le dictionnaire n'est pas NULL et contient des valeurs => True.
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
        /// Le dictionnaire n'est pas NULL et ne contient aucune valeur => False.
        /// </summary>
        [Test]
        public void IsNotEmpty_Dictionary_WithoutValues()
        {
            IDictionary<int, string> dico = new Dictionary<int, string>();
            Assert.False(dico.IsNotEmpty());
        }

        #endregion

        #region ExistAndContainsValue

        /// <summary>
        /// La liste est NULL => False.
        /// </summary>
        [Test]
        public void ExistAndContainsValue_List_NULL()
        {
            IEnumerable<string> liste = null;
            Assert.False(liste.ExistAndContainsValue("abc"));
        }

        /// <summary>
        /// La liste n'est pas NULL et ne contient aucune valeur => False.
        /// </summary>
        [Test]
        public void ExistAndContainsValue_List_WithoutValues()
        {
            IEnumerable<string> liste = new List<string>();
            Assert.False(liste.ExistAndContainsValue("abc"));
        }

        /// <summary>
        /// La liste n'est pas NULL et contient des valeurs, mais la valeur cherchée est NULL => False.
        /// </summary>
        [Test]
        public void ExistAndContainsValue_List_ValueNull()
        {
            IEnumerable<string> liste = new List<string>() { "abc", "def", "ghi", "jkl" };
            Assert.False(liste.ExistAndContainsValue(null));
        }

        /// <summary>
        /// La liste n'est pas NULL et contient la valeur cherchée => True.
        /// </summary>
        [Test]
        public void ExistAndContainsValue_List_WithValue()
        {
            IEnumerable<string> liste = new List<string>() { "abc", "def", "ghi", "jkl" };
            Assert.True(liste.ExistAndContainsValue("def"));
        }

        /// <summary>
        /// La liste n'est pas NULL et ne contient pas la valeur cherchée => False.
        /// </summary>
        [Test]
        public void ExistAndContainsValue_List_WithoutValue()
        {
            IEnumerable<string> liste = new List<string>() { "abc", "def", "ghi", "jkl" };
            Assert.False(liste.ExistAndContainsValue("mno"));
        }

        #endregion

        #region ExistAndContainsKey

        /// <summary>
        /// Le dictionnaire est NULL => False.
        /// </summary>
        [Test]
        public void ExistAndContainsKey_Dictionary_NULL()
        {
            IDictionary<int, string> dico = null;
            Assert.False(dico.ExistAndContainsKey(1));
        }

        /// <summary>
        /// Le dictionnaire n'est pas NULL et ne contient aucune entrée => False.
        /// </summary>
        [Test]
        public void ExistAndContainsKey_Dictionary_WithoutValues()
        {
            IDictionary<int, string> dico = new Dictionary<int, string>();
            Assert.False(dico.ExistAndContainsKey(1));
        }

        /// <summary>
        /// Le dictionnaire n'est pas NULL et contient des entrées, et la clé cherchée existe => True.
        /// </summary>
        [Test]
        public void ExistAndContainsKey_Dictionary_WithKey()
        {
            IDictionary<int, string> dico = new Dictionary<int, string>()
            {
                { 1, "abc" },
                { 2, "def" },
                { 3, "ghi" },
                { 4, "jkl" }
            };

            Assert.True(dico.ExistAndContainsKey(3));
        }

        /// <summary>
        /// Le dictionnaire n'est pas NULL et contient des entrées, mais la clé cherchée n'existe pas => False.
        /// </summary>
        [Test]
        public void ExistAndContainsKey_Dictionary_WithoutKey()
        {
            IDictionary<int, string> dico = new Dictionary<int, string>()
            {
                { 1, "abc" },
                { 2, "def" },
                { 3, "ghi" },
                { 4, "jkl" }
            };

            Assert.False(dico.ExistAndContainsKey(0));
        }

        #endregion
    }
}
