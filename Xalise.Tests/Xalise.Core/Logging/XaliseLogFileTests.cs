using NUnit.Framework;
using System.IO;
using Xalise.Core.Extensions;
using Xalise.Core.Logging;

namespace Xalise.Tests.Xalise.Core.Logging
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
            string methodName               = $"{nameof(LogFileDEBUG)}()";
            XaliseLogFile<EnumTest> logger  = new XaliseLogFile<EnumTest>(EnumTest.DEBUG, "C:\\Users\\Xavier\\Documents\\Sources\\NET", nameof(LogFileDEBUG), "xlog");
            
            logger.EcrireMessage(EnumTest.DEBUG, methodName, $"Niveau {EnumTest.DEBUG.ToString()}");
            logger.EcrireMessage(EnumTest.INFORMATION, methodName, $"Niveau {EnumTest.INFORMATION.ToString()}");
            logger.EcrireMessage(EnumTest.WARNING, methodName, $"Niveau {EnumTest.WARNING.ToString()}");
            logger.EcrireMessage(EnumTest.ERROR, methodName, $"Niveau {EnumTest.ERROR.ToString()}");

            string[] lines = File.ReadAllLines(logger.FilePath);
            File.Delete(logger.FilePath);
            Assert.True(lines.IsNotEmpty() && lines.Length == 4);
        }

        [Test]
        public void LogFileINFORMATION()
        {
            string methodName               = $"{nameof(LogFileINFORMATION)}()";
            XaliseLogFile<EnumTest> logger  = new XaliseLogFile<EnumTest>(EnumTest.INFORMATION, "C:\\Users\\Xavier\\Documents\\Sources\\NET", nameof(LogFileINFORMATION), "xlog");
            
            logger.EcrireMessage(EnumTest.DEBUG, methodName, $"Niveau {EnumTest.DEBUG.ToString()}");
            logger.EcrireMessage(EnumTest.INFORMATION, methodName, $"Niveau {EnumTest.INFORMATION.ToString()}");
            logger.EcrireMessage(EnumTest.WARNING, methodName, $"Niveau {EnumTest.WARNING.ToString()}");
            logger.EcrireMessage(EnumTest.ERROR, methodName, $"Niveau {EnumTest.ERROR.ToString()}");

            string[] lines = File.ReadAllLines(logger.FilePath);
            File.Delete(logger.FilePath);
            Assert.True(lines.IsNotEmpty() && lines.Length == 3);
        }

        [Test]
        public void LogFileWARNING()
        {
            string methodName               = $"{nameof(LogFileWARNING)}()";
            XaliseLogFile<EnumTest> logger  = new XaliseLogFile<EnumTest>(EnumTest.WARNING, "C:\\Users\\Xavier\\Documents\\Sources\\NET", nameof(LogFileWARNING), "xlog");
            
            logger.EcrireMessage(EnumTest.DEBUG, methodName, $"Niveau {EnumTest.DEBUG.ToString()}");
            logger.EcrireMessage(EnumTest.INFORMATION, methodName, $"Niveau {EnumTest.INFORMATION.ToString()}");
            logger.EcrireMessage(EnumTest.WARNING, methodName, $"Niveau {EnumTest.WARNING.ToString()}");
            logger.EcrireMessage(EnumTest.ERROR, methodName, $"Niveau {EnumTest.ERROR.ToString()}");

            string[] lines = File.ReadAllLines(logger.FilePath);
            File.Delete(logger.FilePath);
            Assert.True(lines.IsNotEmpty() && lines.Length == 2);
        }

        [Test]
        public void LogFileERROR()
        {
            string methodName               = $"{nameof(LogFileERROR)}()";
            XaliseLogFile<EnumTest> logger  = new XaliseLogFile<EnumTest>(EnumTest.ERROR, "C:\\Users\\Xavier\\Documents\\Sources\\NET", nameof(LogFileERROR), "xlog");
            

            logger.EcrireMessage(EnumTest.DEBUG, methodName, $"Niveau {EnumTest.DEBUG.ToString()}");
            logger.EcrireMessage(EnumTest.INFORMATION, methodName, $"Niveau {EnumTest.INFORMATION.ToString()}");
            logger.EcrireMessage(EnumTest.WARNING, methodName, $"Niveau {EnumTest.WARNING.ToString()}");
            logger.EcrireMessage(EnumTest.ERROR, methodName, $"Niveau {EnumTest.ERROR.ToString()}");

            string[] lines = File.ReadAllLines(logger.FilePath);
            File.Delete(logger.FilePath);
            Assert.True(lines.IsNotEmpty() && lines.Length == 1);
        }

        [Test]
        public void LogFileSetSeuil()
        {
            string methodName               = $"{nameof(LogFileSetSeuil)}()";
            XaliseLogFile<EnumTest> logger  = new XaliseLogFile<EnumTest>(EnumTest.ERROR, "C:\\Users\\Xavier\\Documents\\Sources\\NET", nameof(LogFileSetSeuil), "xlog");
            

            logger.EcrireMessage(EnumTest.DEBUG, methodName, $"Niveau initial {EnumTest.DEBUG.ToString()}");
            logger.EcrireMessage(EnumTest.INFORMATION, methodName, $"Niveau initial {EnumTest.INFORMATION.ToString()}");
            logger.EcrireMessage(EnumTest.WARNING, methodName, $"Niveau initial {EnumTest.WARNING.ToString()}");
            logger.EcrireMessage(EnumTest.ERROR, methodName, $"Niveau initial {EnumTest.ERROR.ToString()}");

            logger.SetNiveauMinimum(EnumTest.INFORMATION);
            logger.EcrireMessage(EnumTest.DEBUG, methodName, $"Niveau modifié {EnumTest.DEBUG.ToString()}");
            logger.EcrireMessage(EnumTest.INFORMATION, methodName, $"Niveau modifié {EnumTest.INFORMATION.ToString()}");
            logger.EcrireMessage(EnumTest.WARNING, methodName, $"Niveau modifié {EnumTest.WARNING.ToString()}");
            logger.EcrireMessage(EnumTest.ERROR, methodName, $"Niveau modifié {EnumTest.ERROR.ToString()}");

            string[] lines = File.ReadAllLines(logger.FilePath);
            File.Delete(logger.FilePath);
            Assert.True(lines.IsNotEmpty() && lines.Length == 4);
        }
    }
}
