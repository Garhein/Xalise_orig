using NUnit.Framework;
using Xalise.Core.Attributes;
using Xalise.Core.Extensions;

namespace Xalise.Tests.Xalise.Core.Extensions
{
    public class EnumExtensionTests
    {
        #region Description

        private const string CSTS_VAL_DESCRIPTION = "Description du membre";

        /// <summary>
        /// Attribut présent sur le membre de l'énumération => True.
        /// </summary>
        [Test]
        public void Description_WithAttribute()
        {
            Assert.True(eEnumExtensionTests.VAL_AVEC_ATTRIBUT.Description() == EnumExtensionTests.CSTS_VAL_DESCRIPTION);
        }

        /// <summary>
        /// Attribut non présent sur le membre de l'énumération => True.
        /// </summary>
        [Test]
        public void Description_WithoutAttribute()
        {
            Assert.True(string.IsNullOrWhiteSpace(eEnumExtensionTests.VAL_SANS_ATTRIBUT.Description()));
        }

        #endregion

        #region CssClassName

        private const string CSTS_VAL_CLASS_NAME = "css-class-name";

        /// <summary>
        /// Attribut présent sur le membre de l'énumération => True.
        /// </summary>
        [Test]
        public void CssClassName_WithAttribute()
        {
            Assert.True(eEnumExtensionTests.VAL_AVEC_ATTRIBUT.CssClassName() == EnumExtensionTests.CSTS_VAL_CLASS_NAME);
        }

        /// <summary>
        /// Attribut non présent sur le membre de l'énumération => True.
        /// </summary>
        [Test]
        public void CssClassName_WithoutAttribute()
        {
            Assert.True(string.IsNullOrWhiteSpace(eEnumExtensionTests.VAL_SANS_ATTRIBUT.CssClassName()));
        }

        #endregion

        #region UsageValue

        private const string CSTS_VAL_USAGE_VALUE = "yyyyMMdd";

        /// <summary>
        /// Attribut présent sur le membre de l'énumération => True.
        /// </summary>
        [Test]
        public void UsageValue_WithAttribute()
        {
            Assert.True(eEnumExtensionTests.VAL_AVEC_ATTRIBUT.UsageValue() == EnumExtensionTests.CSTS_VAL_USAGE_VALUE);
        }

        /// <summary>
        /// Attribut non présent sur le membre de l'énumération => True.
        /// </summary>
        [Test]
        public void UsageValue_WithoutAttribute()
        {
            Assert.True(string.IsNullOrWhiteSpace(eEnumExtensionTests.VAL_SANS_ATTRIBUT.UsageValue()));
        }

        #endregion
    }

    public enum eEnumExtensionTests : short
    {
        [System.ComponentModel.Description("Description du membre")]
        [CssClassName("css-class-name")]
        [UsageValue("yyyyMMdd")]
        VAL_AVEC_ATTRIBUT = 0,
        VAL_SANS_ATTRIBUT = 1
    }
}
