using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Xalise.Web.Helpers
{
    public static class JsonHelper
    {
        public const string CSTS_FILENAME_EXT       = "json";
        public const string CSTS_FILENAME_THEMES    = "ref-themes";
        public const string CSTS_FILENAME_FICHIERS  = "ref-fichiers";

        #region Gestion des données

        /// <summary>
        /// Construction du chemin du fichier de données.
        /// </summary>
        /// <param name="fileName">Nom du fichier.</param>
        /// <returns></returns>
        private static string ConstructFilePath(string fileName)
        {
            return Path.Combine($"{fileName}.{CSTS_FILENAME_EXT}");
        }

        /// <summary>
        /// Écriture dans un fichier JSON.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="fileName">Nom du fichier JSON, sans son extension.</param>
        /// <param name="objects">Objets à écrire dans le fichier JSON.</param>
        public static void WriteJsonDataFile<T>(string fileName, IEnumerable<T> objects) where T : class
        {
            using (FileStream fstream = File.Create(ConstructFilePath(fileName)))
            {
                JsonSerializer.Serialize(fstream, objects, new JsonSerializerOptions { WriteIndented = true });
            }
        }

        /// <summary>
        /// Lecture d'un fichier JSON.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="fileName">Nom du fichier JSON, sans son extension.</param>
        /// <returns>Liste des objets enregistrés dans le fichier JSON.</returns>
        public static List<T> ReadJsonDataFile<T>(string fileName) where T : class
        {
            List<T> objects;

            using (FileStream fstream = File.OpenRead(ConstructFilePath(fileName)))
            {
                objects = JsonSerializer.Deserialize<List<T>>(fstream) ?? new List<T>();
            }

            return objects;
        }

        #endregion
    }
}
