using NUnit.Framework;
using Xalise.Util.Helpers;

namespace Xalise.Tests
{
    public class NameOfHelperTests
    {
        public class NameOfHelperDTO
        {
            public string PropDTO { get; set; }

            public NameOfHelperDTO() { }
        }

        [Test]
        public void NameOfProperty_WithStrAlias()
        {
            string ret = NameOfHelper.NameOfProperty<NameOfHelperDTO>(dto => dto.PropDTO, "alias");
            Assert.AreEqual("alias.PropDTO", ret);
        }

        [Test]
        public void NameOfProperty_WithoutStrAlias()
        {
            string ret = NameOfHelper.NameOfProperty<NameOfHelperDTO>(dto => dto.PropDTO);
            Assert.AreEqual("PropDTO", ret);
        }

        [Test]
        public void NameOfProperty_BoolWithoutAliasTrue()
        {
            string ret = NameOfHelper.NameOfProperty<NameOfHelperDTO>(dto => dto.PropDTO, true);
            Assert.AreEqual("PropDTO", ret);
        }

        [Test]
        public void NameOfProperty_BoolWithoutAliasFalse()
        {
            string ret = NameOfHelper.NameOfProperty<NameOfHelperDTO>(alias => alias.PropDTO, false);
            Assert.AreEqual("alias.PropDTO", ret);
        }
    }
}
