using System;
using Xalise.Interop.HL7.Core;

namespace Xalise.Interop.HL7.Structure.Table
{
    /// <summary>
    /// 0444 - Name assembly order.
    /// </summary>
    [Serializable]
    public class NameAssemblyOrder : AbstractTable
    {
        public static NameAssemblyOrder PREFIX_FAMILY_MIDDLE_GIVEN_SUFFIX = new NameAssemblyOrder("F", "Prefix Family Middle Given Suffix");
        public static NameAssemblyOrder PREFIX_GIVEN_MIDDLE_FAMILY_SUFFIX = new NameAssemblyOrder("G", "Prefix Given Middle Family Suffix");

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="value">Valeur de la table.</param>
        /// <param name="description">Description de la donnée.</param>
        public NameAssemblyOrder(string value, string description) : base(value, description) { }

        /// <summary>
        /// Numéro de la table de données HL7.
        /// </summary>
        public override string TableNumber
        {
            get
            {
                return "0444";
            }
        }
    }
}
