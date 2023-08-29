using NUnit.Framework;
using Xalise.Core.Helpers;

namespace Xalise.Tests.Xalise.Core.Helpers
{
    public class NameOfHelperTests
    {
        public class NameOfHelperDTO
        {
            public string PropDTO { get; set; }

            public NameOfHelperDTO() { }
        }

        /// <summary>
        /// Avec un alias définit spécifiquement.
        /// </summary>
        [Test]
        public void NameOfProperty_WithStrAlias()
        {
            string ret = NameOfHelper.NameOfProperty<NameOfHelperDTO>(dto => dto.PropDTO, "alias");
            Assert.AreEqual("alias.PropDTO", ret);
        }

        /// <summary>
        /// Sans alias définit spécifiquement.
        /// </summary>
        [Test]
        public void NameOfProperty_WithoutStrAlias()
        {
            string ret = NameOfHelper.NameOfProperty<NameOfHelperDTO>(dto => dto.PropDTO);
            Assert.AreEqual("PropDTO", ret);
        }

        /// <summary>
        /// Avec un alias correspondant à l'expression.
        /// </summary>
        [Test]
        public void NameOfProperty_BoolWithoutAliasTrue()
        {
            string ret = NameOfHelper.NameOfProperty<NameOfHelperDTO>(dto => dto.PropDTO, true);
            Assert.AreEqual("PropDTO", ret);
        }

        /// <summary>
        /// Sans l'alias correspondant à l'expression.
        /// </summary>
        [Test]
        public void NameOfProperty_BoolWithoutAliasFalse()
        {
            string ret = NameOfHelper.NameOfProperty<NameOfHelperDTO>(alias => alias.PropDTO, false);
            Assert.AreEqual("alias.PropDTO", ret);
        }
    }
}
