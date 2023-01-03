using System;
using Xalise.Interop.HL7.Core;

namespace Xalise.Interop.HL7.Structure.Table
{
    /// <summary>
    /// 0104 - Version ID.
    /// </summary>
    [Serializable]
    public class T0104_VersionID : AbstractTable
    {
        public static T0104_VersionID V2_0    = new T0104_VersionID("2.0", "Release 2.0");
        public static T0104_VersionID V2_0D   = new T0104_VersionID("2.0D", "Demo 2.0");
        public static T0104_VersionID V2_1    = new T0104_VersionID("2.1", "Release 2.1");
        public static T0104_VersionID V2_2    = new T0104_VersionID("2.2", "Release 2.2");
        public static T0104_VersionID V2_3    = new T0104_VersionID("2.3", "Release 2.3");
        public static T0104_VersionID V2_3_1  = new T0104_VersionID("2.3.1", "Release 2.3.1");
        public static T0104_VersionID V2_4    = new T0104_VersionID("2.4", "Release 2.4");
        public static T0104_VersionID V2_5    = new T0104_VersionID("2.5", "Release 2.5");
        public static T0104_VersionID V2_5_1  = new T0104_VersionID("2.5.1", "Release 2.5.1");

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="value">Valeur de la table.</param>
        /// <param name="description">Description de la donnée.</param>
        public T0104_VersionID(string value, string description) : base(value, description) { }

        /// <summary>
        /// Numéro de la table de données HL7.
        /// </summary>
        public override string TableNumber
        {
            get
            {
                return "0104";
            }
        }
    }
}
