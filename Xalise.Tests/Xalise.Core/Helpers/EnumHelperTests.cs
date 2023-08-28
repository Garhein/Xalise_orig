using NUnit.Framework;
using System;
using Xalise.Core.Helpers;

namespace Xalise.Tests.Xalise.Core.Helpers
{
    public class EnumHelperTests
    {
        /// <summary>
        /// Valeur inférieure ou égale à zéro => ArgumentException levée.
        /// </summary>
        [Test]
        public void VerifierValidite_Int_ValueZero()
        {
            int valInt = -1;
            Assert.Throws<ArgumentException>(() => EnumHelper.VerifierValidite<eHelperTestsInt>(valInt, nameof(valInt)));
        }

        /// <summary>
        /// Valeur non valide => True.
        /// </summary>
        [Test]
        public void VerifierValidite_Int_ValueValid()
        {
            int valInt = 2;
            Assert.True(EnumHelper.VerifierValidite<eHelperTestsInt>(valInt, nameof(valInt)));
        }

        /// <summary>
        /// Valeur valide => False.
        /// </summary>
        [Test]
        public void VerifierValidite_Int_ValueInvalid()
        {
            int valInt = 4;
            Assert.False(EnumHelper.VerifierValidite<eHelperTestsInt>(valInt, nameof(valInt)));
        }

        /// <summary>
        /// Valeur inférieure ou égale à zéro => ArgumentException levée.
        /// </summary>
        [Test]
        public void VerifierValidite_Short_ValueZero()
        {
            short valShort = -1;
            Assert.Throws<ArgumentException>(() => EnumHelper.VerifierValidite<eHelperTestShort>(valShort, nameof(valShort)));
        }

        /// <summary>
        /// Valeur non valide => True.
        /// </summary>
        [Test]
        public void VerifierValidite_Short_ValueValid()
        {
            short valShort = 2;
            Assert.True(EnumHelper.VerifierValidite<eHelperTestShort>(valShort, nameof(valShort)));
        }

        /// <summary>
        /// Valeur valide => False.
        /// </summary>
        [Test]
        public void VerifierValidite_Short_ValueInvalid()
        {
            short valShort = 4;
            Assert.False(EnumHelper.VerifierValidite<eHelperTestShort>(valShort, nameof(valShort)));
        }
    }

    public enum eHelperTestsInt : int
    {
        VAL_1 = 1,
        VAL_2 = 2
    }

    public enum eHelperTestShort : short
    {
        VAL_1 = 1,
        VAL_2 = 2
    }
}
