using NUnit.Framework;
using Xalise.Interop.HL7.Core;
using Xalise.Interop.HL7.Structure;
using Xalise.Interop.HL7.Structure.Message;

namespace Xalise.Tests
{
    public class InteropHL7
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            EncodingCharacters encodingChars = new EncodingCharacters();
            AbstractMessage msgA01           = new ADT_A01(encodingChars);

            // MSH

            // SFT (x2)


            // EVN

            // PID

            // PID (x2)
            
            Assert.Pass();
        }
    }
}