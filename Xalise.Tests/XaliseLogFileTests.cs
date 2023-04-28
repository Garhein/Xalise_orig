using NUnit.Framework;
using Xalise.Core.Logging;

namespace Xalise.Tests
{
    public class XaliseLogFileTests
    {
        public enum EnumTest : int
        {
            DEBUG       = 10,
            INFORMATION = 20,
            WARNING     = 30,
            ERROR       = 40
        }

        [Test]
        public void LogFileDEBUG()
        {
            XaliseLogFile<EnumTest> logger = new XaliseLogFile<EnumTest>(EnumTest.DEBUG, "C:\\Users\\Xavier\\Documents\\Sources\\NET");
            string methodName              = $"{nameof(LogFileDEBUG)}()";

            logger.EcrireMessage(EnumTest.DEBUG, methodName, $"Niveau {EnumTest.DEBUG.ToString()}");
            logger.EcrireMessage(EnumTest.INFORMATION, methodName, $"Niveau {EnumTest.INFORMATION.ToString()}");
            logger.EcrireMessage(EnumTest.WARNING, methodName, $"Niveau {EnumTest.WARNING.ToString()}");
            logger.EcrireMessage(EnumTest.ERROR, methodName, $"Niveau {EnumTest.ERROR.ToString()}");
        }

        [Test]
        public void LogFileINFORMATION()
        {
            XaliseLogFile<EnumTest> logger = new XaliseLogFile<EnumTest>(EnumTest.INFORMATION, "C:\\Users\\Xavier\\Documents\\Sources\\NET");
            string methodName              = $"{nameof(LogFileINFORMATION)}()";

            logger.EcrireMessage(EnumTest.DEBUG, methodName, $"Niveau {EnumTest.DEBUG.ToString()}");
            logger.EcrireMessage(EnumTest.INFORMATION, methodName, $"Niveau {EnumTest.INFORMATION.ToString()}");
            logger.EcrireMessage(EnumTest.WARNING, methodName, $"Niveau {EnumTest.WARNING.ToString()}");
            logger.EcrireMessage(EnumTest.ERROR, methodName, $"Niveau {EnumTest.ERROR.ToString()}");
        }

        [Test]
        public void LogFileWARNING()
        {
            XaliseLogFile<EnumTest> logger = new XaliseLogFile<EnumTest>(EnumTest.WARNING, "C:\\Users\\Xavier\\Documents\\Sources\\NET");
            string methodName              = $"{nameof(LogFileWARNING)}()";

            logger.EcrireMessage(EnumTest.DEBUG, methodName, $"Niveau {EnumTest.DEBUG.ToString()}");
            logger.EcrireMessage(EnumTest.INFORMATION, methodName, $"Niveau {EnumTest.INFORMATION.ToString()}");
            logger.EcrireMessage(EnumTest.WARNING, methodName, $"Niveau {EnumTest.WARNING.ToString()}");
            logger.EcrireMessage(EnumTest.ERROR, methodName, $"Niveau {EnumTest.ERROR.ToString()}");
        }

        [Test]
        public void LogFileERROR()
        {
            XaliseLogFile<EnumTest> logger = new XaliseLogFile<EnumTest>(EnumTest.ERROR, "C:\\Users\\Xavier\\Documents\\Sources\\NET");
            string methodName              = $"{nameof(LogFileERROR)}()";

            logger.EcrireMessage(EnumTest.DEBUG, methodName, $"Niveau {EnumTest.DEBUG.ToString()}");
            logger.EcrireMessage(EnumTest.INFORMATION, methodName, $"Niveau {EnumTest.INFORMATION.ToString()}");
            logger.EcrireMessage(EnumTest.WARNING, methodName, $"Niveau {EnumTest.WARNING.ToString()}");
            logger.EcrireMessage(EnumTest.ERROR, methodName, $"Niveau {EnumTest.ERROR.ToString()}");
        }

        [Test]
        public void LogFileSetSeuil()
        {
            XaliseLogFile<EnumTest> logger = new XaliseLogFile<EnumTest>(EnumTest.ERROR, "C:\\Users\\Xavier\\Documents\\Sources\\NET");
            string methodName              = $"{nameof(LogFileSetSeuil)}()";

            logger.EcrireMessage(EnumTest.DEBUG, methodName, $"Niveau initial {EnumTest.DEBUG.ToString()}");
            logger.EcrireMessage(EnumTest.INFORMATION, methodName, $"Niveau initial {EnumTest.INFORMATION.ToString()}");
            logger.EcrireMessage(EnumTest.WARNING, methodName, $"Niveau initial {EnumTest.WARNING.ToString()}");
            logger.EcrireMessage(EnumTest.ERROR, methodName, $"Niveau initial {EnumTest.ERROR.ToString()}");

            logger.SetNiveauMinimum(EnumTest.INFORMATION);
            logger.EcrireMessage(EnumTest.DEBUG, methodName, $"Niveau modifié {EnumTest.DEBUG.ToString()}");
            logger.EcrireMessage(EnumTest.INFORMATION, methodName, $"Niveau modifié {EnumTest.INFORMATION.ToString()}");
            logger.EcrireMessage(EnumTest.WARNING, methodName, $"Niveau modifié {EnumTest.WARNING.ToString()}");
            logger.EcrireMessage(EnumTest.ERROR, methodName, $"Niveau modifié {EnumTest.ERROR.ToString()}");
        }

        [Test]
        public void LogFileNameAndExtension()
        {
            XaliseLogFile<EnumTest> logger = new XaliseLogFile<EnumTest>(EnumTest.WARNING, "C:\\Users\\Xavier\\Documents\\Sources\\NET", "customLogName", ".clog");
            string methodName              = $"{nameof(LogFileNameAndExtension)}()";

            logger.EcrireMessage(EnumTest.DEBUG, methodName, $"Niveau {EnumTest.DEBUG.ToString()}");
            logger.EcrireMessage(EnumTest.INFORMATION, methodName, $"Niveau {EnumTest.INFORMATION.ToString()}");
            logger.EcrireMessage(EnumTest.WARNING, methodName, $"Niveau {EnumTest.WARNING.ToString()}");
            logger.EcrireMessage(EnumTest.ERROR, methodName, $"Niveau {EnumTest.ERROR.ToString()}");
        }
    }
}
