using System;
using System.IO;
using Xalise.Util.Extensions;
using Xalise.Util.Helpers;

namespace Xalise.Util.Logging
{
    /// <summary>
    /// Gestion des logs dans un fichier physique.
    /// </summary>
    /// <typeparam name="TEnum"></typeparam>
    public class XaliseLogFile<TEnum> : AbstractXaliseLog<TEnum> where TEnum : Enum
    {
        private const string BASE_FILENAME  = "xaliseLog";
        private const string EXT_FILENAME   = "log";
        private readonly object _lockObj    = new object();

        private string _baseDirectory;
        private string _baseFilename;
        private string _extFileName;

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="niveauMin">Niveau minimum d'écriture.</param>
        /// <param name="baseDirectory">Chemin du répertoire d'écriture du fichier de log.</param>
        public XaliseLogFile(TEnum niveauMin, string baseDirectory) : this(niveauMin, baseDirectory, XaliseLogFile<TEnum>.BASE_FILENAME) { }

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="niveauMin">Niveau minimum d'écriture.</param>
        /// <param name="baseDirectory">Chemin du répertoire d'écriture du fichier de log.</param>
        /// <param name="baseFilename">Nom de base du fichier de log.</param>
        public XaliseLogFile(TEnum niveauMin, string baseDirectory, string baseFilename) : this(niveauMin, baseDirectory, baseFilename, XaliseLogFile<TEnum>.EXT_FILENAME) { }

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="niveauMin">Niveau minimum d'écriture.</param>
        /// <param name="baseDirectory">Chemin du répertoire d'écriture du fichier de log.</param>
        /// <param name="baseFilename">Nom de base du fichier de log.</param>
        /// <param name="extFilename">Extension du fichier de log.</param>
        public XaliseLogFile(TEnum niveauMin, string baseDirectory, string baseFilename, string extFilename) : base(niveauMin)
        {
            ArgumentHelper.ThrowIfNullOrWhiteSpace(baseDirectory, nameof(baseDirectory));
            ArgumentHelper.ThrowIfNullOrWhiteSpace(extFilename, nameof(extFilename));
            ArgumentHelper.ThrowIfDirectoryNotFound(baseDirectory);

            // Retrait du premier point de l'extension
            if (extFilename[0].Equals('.'))
            {
                extFilename = extFilename.Substring(1);
            }

            this._baseDirectory = baseDirectory;
            this._baseFilename  = baseFilename;
            this._extFileName   = extFilename;
        }

        /// <summary>
        /// Écriture d'un message de log.
        /// </summary>
        /// <param name="niveau">Niveau du message.</param>
        /// <param name="emetteur">Émetteur du message.</param>
        /// <param name="log">Message de log.</param>
        /// <exception cref="ArgumentNullException">L'émetteur du log est NULL.</exception>
        /// <exception cref="ArgumentException">L'émetteur du log est vide ou composé uniquement d'espaces.</exception>
        public override void EcrireMessage(TEnum niveau, string emetteur, string log)
        {
            ArgumentHelper.ThrowIfNullOrWhiteSpace(emetteur, nameof(emetteur));

            if (!string.IsNullOrWhiteSpace(log) && niveau.AsInteger() >= this.NiveauMinimum.AsInteger())
            {
                lock (_lockObj)
                {
                    string logPath = Path.Combine(this._baseDirectory, $"{this._baseFilename}_{DateTime.Now.ToString("yyyyMMdd")}.{this._extFileName}");
                    string logMsg  = $"[{DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss")}][{niveau.ToString()}] >> {emetteur} > {log.Trim()}";

                    using (StreamWriter writer = new StreamWriter(logPath, true))
                    {
                        writer.WriteLine(logMsg);
                    }
                }
            }
        }
    }
}
