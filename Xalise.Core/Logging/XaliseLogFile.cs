using Xalise.Core.Extensions;
using Xalise.Core.Helpers;

namespace Xalise.Core.Logging
{
    /// <summary>
    /// Gestion des logs dans un fichier physique.
    /// </summary>
    /// <typeparam name="TEnum"></typeparam>
    public class XaliseLogFile<TEnum> : AbstractXaliseLog<TEnum> where TEnum : Enum
    {
        private const string CSTS_BASE_FILENAME  = "xaliseLog";
        private const string CSTS_EXT_FILENAME   = "log";
        private readonly object _lock            = new object();

        /// <summary>
        /// Chemin complet du répertoire d'écriture du fichier de log.
        /// </summary>
        private string _directoryFileLog;

        /// <summary>
        /// Nom de base du fichier de log.
        /// </summary>
        private string _BaseFilename;

        /// <summary>
        /// Extension du nom du fichier de log.
        /// </summary>
        private string _extFilename;

        /// <summary>
        /// Nom du fichier de log.
        /// </summary>
        /// <remarks>
        /// Composé du nom de base, de la date courante au format yyyyMMdd et de l'extension.<br/>
        /// Exemple : xaliseLog_20230830.log
        /// </remarks>
        public string Filename
        {
            get
            {
                return $"{this._BaseFilename}_{DateTime.Now.ToString("yyyyMMdd")}.{this._extFilename}";
            }
        }

        /// <summary>
        /// Chemin complet du fichier de log.
        /// </summary>
        /// <remarks>
        /// Composé du chemin complet du répertoire d'écriture du fichier de log et de <see cref="XaliseLogFile.Filename"/>.
        /// </remarks>
        public string FilePath
        {
            get
            {
                return Path.Combine(this._directoryFileLog, this.Filename);
            }
        }

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="niveauMin">Niveau minimum d'écriture.</param>
        /// <param name="directoryFileLog">Chemin complet du répertoire d'écriture du fichier de log.</param>
        public XaliseLogFile(TEnum niveauMin, string directoryFileLog) : this(niveauMin, directoryFileLog, XaliseLogFile<TEnum>.CSTS_BASE_FILENAME) { }

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="niveauMin">Niveau minimum d'écriture.</param>
        /// <param name="directoryFileLog">Chemin complet du répertoire d'écriture du fichier de log.</param>
        /// <param name="baseFilename">Nom de base du fichier de log.</param>
        public XaliseLogFile(TEnum niveauMin, string directoryFileLog, string baseFilename) : this(niveauMin, directoryFileLog, baseFilename, XaliseLogFile<TEnum>.CSTS_EXT_FILENAME) { }

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="niveauMin">Niveau minimum d'écriture.</param>
        /// <param name="directoryFileLog">Chemin complet du répertoire d'écriture du fichier de log.</param>
        /// <param name="baseFilename">Nom de base du fichier de log.</param>
        /// <param name="extFilename">Extension du fichier de log.</param>
        /// <exception cref="ArgumentNullException">
        /// Si <paramref name="directoryFileLog"/>, <paramref name="baseFilename"/> ou <paramref name="extFilename"/> est <seealso langword="null"/>.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// Si <paramref name="directoryFileLog"/>, <paramref name="baseFilename"/> ou <paramref name="extFilename"/> est vide ou composé uniquement d'espaces.
        /// </exception>
        /// <exception cref="DirectoryNotFoundException">Si le répertoire <paramref name="directoryFileLog"/> n'existe pas.</exception>
        public XaliseLogFile(TEnum niveauMin, string directoryFileLog, string baseFilename, string extFilename) : base(niveauMin)
        {
            ArgumentHelper.ThrowIfNullOrWhiteSpace(directoryFileLog, nameof(directoryFileLog));
            ArgumentHelper.ThrowIfNullOrWhiteSpace(baseFilename, nameof(baseFilename));
            ArgumentHelper.ThrowIfNullOrWhiteSpace(extFilename, nameof(extFilename));
            ArgumentHelper.ThrowIfDirectoryNotFound(directoryFileLog);

            // Retrait du premier point de l'extension
            if (extFilename[0].Equals('.'))
            {
                extFilename = extFilename.Substring(1);
            }

            this._directoryFileLog  = directoryFileLog;
            this._BaseFilename      = baseFilename;
            this._extFilename       = extFilename;
        }

        /// <summary>
        /// Écriture d'un message de log.
        /// </summary>
        /// <param name="niveau">Niveau du message.</param>
        /// <param name="emetteur">Émetteur du message.</param>
        /// <param name="log">Message de log.</param>
        /// <exception cref="ArgumentNullException">Si <paramref name="emetteur"/> ou <paramref name="log"/> est <seealso langword="null"/>.</exception>
        /// <exception cref="ArgumentException">Si <paramref name="emetteur"/> ou <paramref name="log"/> est vide ou composé uniquement d'espaces.</exception>
        public override void EcrireMessage(TEnum niveau, string emetteur, string log)
        {
            ArgumentHelper.ThrowIfNullOrWhiteSpace(emetteur, nameof(emetteur));
            ArgumentHelper.ThrowIfNullOrWhiteSpace(log, nameof(log));

            if (niveau.AsInteger() >= this.NiveauMinimum.AsInteger())
            {
                lock (_lock)
                {
                    string logPath  = Path.Combine(this._directoryFileLog, this.Filename);
                    string logMsg   = $"[{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}][{niveau.ToString()}] >> {emetteur} > {log.Trim()}";

                    using (StreamWriter writer = new StreamWriter(logPath, true))
                    {
                        writer.WriteLine(logMsg);
                    }
                }
            }
        }
    }
}
