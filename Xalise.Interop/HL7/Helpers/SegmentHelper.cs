namespace Xalise.Interop.HL7.Helpers
{
    /// <summary>
    /// Fonctions utilitaires pour manipuler les segments.
    /// </summary>
    public static class SegmentHelper
    {
        /// <summary>
        /// Indique si le segment définit les caractères d'encodage.
        /// </summary>
        /// <param name="segmentName">Nom du segment.</param>
        /// <returns></returns>
        public static bool IsSegmentDefDelimiters(string segmentName)
        {
            //TODO: ne plus utiliser des valeurs en "dur"
            return segmentName.Equals("MSH") || segmentName.Equals("FHS") || segmentName.Equals("BHS");
        }
    }
}
