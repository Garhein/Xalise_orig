using NUnit.Framework;
using System;
using System.IO;
using Xalise.Core.Helpers;

namespace Xalise.Tests.Xalise.Core.Helpers
{
    public class ArgumentHelperTests
    {
        #region NULL/Empty

        /// <summary>
        /// Objet <seealso langword="null"/> => exception levée.
        /// </summary>
        [Test]
        public void ThrowIfNull_IsNull()
        {
            object obj = null;
            Assert.Throws<ArgumentNullException>(() => ArgumentHelper.ThrowIfNull(obj, nameof(obj)));
        }

        /// <summary>
        /// Objet non <seealso langword="null"/> => exception non levée.
        /// </summary>
        [Test]
        public void ThrowIfNull_IsNotNull()
        {
            object obj = new object();
            Assert.DoesNotThrow(() => ArgumentHelper.ThrowIfNull(obj, nameof(obj)));
        }

        /// <summary>
        /// Chaîne <seealso langword="null"/> => exception levée.
        /// </summary>
        [Test]
        public void ThrowIfNullOrEmpty_IsNull()
        {
            string strVal = null;
            Assert.Throws<ArgumentNullException>(() => ArgumentHelper.ThrowIfNullOrEmpty(strVal, nameof(strVal)));
        }

        /// <summary>
        /// Chaîne non <seealso langword="null"/> mais vide => exception levée.
        /// </summary>
        [Test]
        public void ThrowIfNullOrEmpty_IsEmpty()
        {
            string strVal = "";
            Assert.Throws<ArgumentException>(() => ArgumentHelper.ThrowIfNullOrEmpty(strVal, nameof(strVal)));
        }

        /// <summary>
        /// Chaîne non <seealso langword="null"/> et non vide => exception non levée.
        /// </summary>
        [Test]
        public void ThrowIfNullOrEmpty_IsValid()
        {
            string strVal = "Test";
            Assert.DoesNotThrow(() => ArgumentHelper.ThrowIfNullOrEmpty(strVal, nameof(strVal)));
        }

        /// <summary>
        /// Chaîne <seealso langword="null"/> => exception levée.
        /// </summary>
        [Test]
        public void ThrowIfNullOrWhiteSpace_IsNull()
        {
            string strVal = null;
            Assert.Throws<ArgumentNullException>(() => ArgumentHelper.ThrowIfNullOrWhiteSpace(strVal, nameof(strVal)));
        }

        /// <summary>
        /// Chaîne non <seealso langword="null"/> mais vide => exception levée.
        /// </summary>
        [Test]
        public void ThrowIfNullOrWhiteSpace_IsEmpty()
        {
            string strVal = "";
            Assert.Throws<ArgumentException>(() => ArgumentHelper.ThrowIfNullOrWhiteSpace(strVal, nameof(strVal)));
        }

        /// <summary>
        /// Chaîne non <seealso langword="null"/>, non vide mais composée uniquement d'espaces => exception levée.
        /// </summary>
        [Test]
        public void ThrowIfNullOrWhiteSpace_OnlyWhiteSpaces()
        {
            string strVal = "   ";
            Assert.Throws<ArgumentException>(() => ArgumentHelper.ThrowIfNullOrWhiteSpace(strVal, nameof(strVal)));
        }

        /// <summary>
        /// Chaîne non <seealso langword="null"/>, non vide et pas composée uniquement d'espaces => exception non levée.
        /// </summary>
        [Test]
        public void ThrowIfNullOrWhiteSpace_IsValid()
        {
            string strVal = "Test";
            Assert.DoesNotThrow(() => ArgumentHelper.ThrowIfNullOrWhiteSpace(strVal, nameof(strVal)));
        }

        #endregion

        #region Répertoires et fichiers

        /// <summary>
        /// Le répertoire n'existe pas => exception levée.
        /// </summary>
        [Test]
        public void ThrowIfDirectoryNotFound_NotFound()
        {
            string dirProject = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;
            string dirTest    = Path.Combine(dirProject, "notFound");
            Assert.Throws<DirectoryNotFoundException>(() => ArgumentHelper.ThrowIfDirectoryNotFound(dirTest));
        }

        /// <summary>
        /// Le répertoire existe => exception non levée.
        /// </summary>
        [Test]
        public void ThrowIfDirectoryNotFound_Found()
        {
            string dirProject = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;
            string dirBin     = Path.Combine(dirProject, "bin");
            Assert.DoesNotThrow(() => ArgumentHelper.ThrowIfDirectoryNotFound(dirBin));
        }

        /// <summary>
        /// Le fichier n'existe pas => exception levée.
        /// </summary>
        [Test]
        public void ThrowIfFileNotFound_NotFound()
        {
            string dirProject = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;
            string dirFile    = Path.Combine(dirProject, "notFound.txt");
            Assert.Throws<FileNotFoundException>(() => ArgumentHelper.ThrowIfFileNotFound(dirFile));
        }

        /// <summary>
        /// Le fichier existe => exception non levée.
        /// </summary>
        [Test]
        public void ThrowIfFileNotFound_Found()
        {
            string dirProject = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;
            string dirFile    = Path.Combine(dirProject, "Xalise.Tests.csproj");
            Assert.DoesNotThrow(() => ArgumentHelper.ThrowIfFileNotFound(dirFile));
        }

        #endregion
    }
}
