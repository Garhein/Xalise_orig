using NUnit.Framework;
using Xalise.Core.Extensions;

namespace Xalise.Tests.Xalise.Core.Extensions
{
    public class NumberExtensionTests
    {
        #region Int

        /// <summary>
        /// Entier positif avec le séparateure de groupe par défaut => True.
        /// </summary>
        [Test]
        public void ToStringFormat_Int_Positive()
        {
            int valInt = 100000;
            Assert.True(valInt.ToStringFormat() == "100 000");
        }

        /// <summary>
        /// Entier positif avec un séparateur de groupe spécifique => True.
        /// </summary>
        [Test]
        public void ToStringFormat_IntSepGroupes_Positive()
        {
            int valInt = 100000;
            Assert.True(valInt.ToStringFormat(",") == "100,000");
        }

        /// <summary>
        /// Entier négatif avec le séparateure de groupe par défaut => True.
        /// </summary>
        [Test]
        public void ToStringFormat_Int_Negative()
        {
            int valInt = -100000;
            Assert.True(valInt.ToStringFormat() == "-100 000");
        }

        /// <summary>
        /// Entier négatif avec un séparateur de groupe spécifique => True.
        /// </summary>
        [Test]
        public void ToStringFormat_IntSepGroupes_Negative()
        {
            int valInt = -100000;
            Assert.True(valInt.ToStringFormat(",") == "-100,000");
        }

        #endregion

        #region Short

        /// <summary>
        /// Entier positif avec le séparateure de groupe par défaut => True.
        /// </summary>
        [Test]
        public void ToStringFormat_Short_Positive()
        {
            short valShort = 10000;
            Assert.True(valShort.ToStringFormat() == "10 000");
        }

        /// <summary>
        /// Entier positif avec un séparateur de groupe spécifique => True.
        /// </summary>
        [Test]
        public void ToStringFormat_ShortSepGroupes_Positive()
        {
            short valShort = 10000;
            Assert.True(valShort.ToStringFormat(",") == "10,000");
        }

        /// <summary>
        /// Entier négatif avec le séparateure de groupe par défaut => True.
        /// </summary>
        [Test]
        public void ToStringFormat_Short_Negative()
        {
            short valShort = -10000;
            Assert.True(valShort.ToStringFormat() == "-10 000");
        }

        /// <summary>
        /// Entier négatif avec un séparateur de groupe spécifique => True.
        /// </summary>
        [Test]
        public void ToStringFormat_ShortSepGroupes_Negative()
        {
            short valShort = -10000;
            Assert.True(valShort.ToStringFormat(",") == "-10,000");
        }

        #endregion

        #region Decimal

        /// <summary>
        /// Décimal positif sans chiffres après la virgule, avec le séparateur de groupes par défaut => True
        /// </summary>
        [Test]
        public void ToStringFormat_DecimalZeroDecimal_Positive()
        {
            decimal decVal = 150000.269M;
            Assert.True(decVal.ToStringFormat(0) == "150 000");
        }

        /// <summary>
        /// Décimal positif sans chiffres après la virgule, avec un séparateur de groupes spécifique => True
        /// </summary>
        [Test]
        public void ToStringFormat_DecimalZeroDecimalSepGroupes_Positive()
        {
            decimal decVal = 150000.269M;
            Assert.True(decVal.ToStringFormat(0, ",") == "150,000");
        }

        /// <summary>
        /// Décimal négatif sans chiffres après la virgule, avec le séparateur de groupes par défaut => True
        /// </summary>
        [Test]
        public void ToStringFormat_DecimalZeroDecimal_Negative()
        {
            decimal decVal = -150000.269M;
            Assert.True(decVal.ToStringFormat(0) == "-150 000");
        }

        /// <summary>
        /// Décimal négatif sans chiffres après la virgule, avec un séparateur de groupes spécifique => True
        /// </summary>
        [Test]
        public void ToStringFormat_DecimalZeroDecimalSepGroupes_Negative()
        {
            decimal decVal = -150000.269M;
            Assert.True(decVal.ToStringFormat(0, ",") == "-150,000");
        }

        /// <summary>
        /// Décimal positif avec 2 chiffres après la virgule (arrondi supérieur) et les séparateurs par défaut => True
        /// </summary>
        [Test]
        public void ToStringFormat_DecimalRoundSup_Positive()
        {
            decimal decVal = 150000.265M;
            Assert.True(decVal.ToStringFormat(2) == "150 000.27");
        }

        /// <summary>
        /// Décimal négatif avec 2 chiffres après la virgule (arrondi supérieur) et les séparateurs par défaut => True
        /// </summary>
        [Test]
        public void ToStringFormat_DecimalRoundSup_Negative()
        {
            decimal decVal = -150000.265M;
            Assert.True(decVal.ToStringFormat(2) == "-150 000.27");
        }

        /// <summary>
        /// Décimal positif avec 2 chiffres après la virgule (arrondi inférieur) et les séparateurs par défaut => True
        /// </summary>
        [Test]
        public void ToStringFormat_DecimalRoundInf_Positive()
        {
            decimal decVal = 150000.262M;
            Assert.True(decVal.ToStringFormat(2) == "150 000.26");
        }

        /// <summary>
        /// Décimal négatif avec 2 chiffres après la virgule (arrondi inférieur) et les séparateurs par défaut => True
        /// </summary>
        [Test]
        public void ToStringFormat_DecimalRoundInf_Negative()
        {
            decimal decVal = -150000.262M;
            Assert.True(decVal.ToStringFormat(2) == "-150 000.26");
        }

        #endregion

        #region Double

        /// <summary>
        /// Double positif sans chiffres après la virgule, avec le séparateur de groupes par défaut => True
        /// </summary>
        [Test]
        public void ToStringFormat_DoubleZeroDecimal_Positive()
        {
            double decVal = 150000.269;
            Assert.True(decVal.ToStringFormat(0) == "150 000");
        }

        /// <summary>
        /// Double positif sans chiffres après la virgule, avec un séparateur de groupes spécifique => True
        /// </summary>
        [Test]
        public void ToStringFormat_DoubleZeroDecimalSepGroupes_Positive()
        {
            double decVal = 150000.269;
            Assert.True(decVal.ToStringFormat(0, ",") == "150,000");
        }

        /// <summary>
        /// Double négatif sans chiffres après la virgule, avec le séparateur de groupes par défaut => True
        /// </summary>
        [Test]
        public void ToStringFormat_DoubleZeroDecimal_Negative()
        {
            double decVal = -150000.269;
            Assert.True(decVal.ToStringFormat(0) == "-150 000");
        }

        /// <summary>
        /// Double négatif sans chiffres après la virgule, avec un séparateur de groupes spécifique => True
        /// </summary>
        [Test]
        public void ToStringFormat_DoubleZeroDecimalSepGroupes_Negative()
        {
            double decVal = -150000.269;
            Assert.True(decVal.ToStringFormat(0, ",") == "-150,000");
        }

        /// <summary>
        /// Double positif avec 2 chiffres après la virgule (arrondi supérieur) et les séparateurs par défaut => True
        /// </summary>
        [Test]
        public void ToStringFormat_DoubleRoundSup_Positive()
        {
            double decVal = 150000.265;
            Assert.True(decVal.ToStringFormat(2) == "150 000.27");
        }

        /// <summary>
        /// Double négatif avec 2 chiffres après la virgule (arrondi supérieur) et les séparateurs par défaut => True
        /// </summary>
        [Test]
        public void ToStringFormat_DoubleRoundSup_Negative()
        {
            double decVal = -150000.265;
            Assert.True(decVal.ToStringFormat(2) == "-150 000.27");
        }

        /// <summary>
        /// Double positif avec 2 chiffres après la virgule (arrondi inférieur) et les séparateurs par défaut => True
        /// </summary>
        [Test]
        public void ToStringFormat_DoubleRoundInf_Positive()
        {
            double decVal = 150000.262;
            Assert.True(decVal.ToStringFormat(2) == "150 000.26");
        }

        /// <summary>
        /// Double négatif avec 2 chiffres après la virgule (arrondi inférieur) et les séparateurs par défaut => True
        /// </summary>
        [Test]
        public void ToStringFormat_DoubleRoundInf_Negative()
        {
            double decVal = -150000.262;
            Assert.True(decVal.ToStringFormat(2) == "-150 000.26");
        }

        #endregion
    }
}
