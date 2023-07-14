using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Xalise.Core.Extensions
{
    /// <summary>
    /// Extensions applicables aux <see cref="Enum"/>.
    /// </summary>
    public static class EnumExtension
    {
        /// <summary>
        /// Convertit une valeur d'énumération en un <see cref="int"/>.
        /// </summary>
        /// <typeparam name="TEnum"></typeparam>
        /// <param name="enumValue"></param>
        /// <returns></returns>
        public static int AsInteger<TEnum>(this TEnum enumValue) where TEnum : Enum
        {
            if (Unsafe.SizeOf<TEnum>() != Unsafe.SizeOf<int>())
            {
                throw new Exception("Type incompatible.");
            }

            int valInt = Unsafe.As<TEnum, int>(ref enumValue);

            return valInt;
        }

        /// <summary>
        /// Récupère la valeur de l'attribut <see cref="DescriptionAttribute"/> indiqué
        /// sur l'élément de l'énumération.
        /// </summary>
        /// <param name="enumValue"></param>
        /// <returns></returns>
        public static string Description(this Enum enumValue)
        {
            string descrValue = string.Empty;

            Type type = enumValue.GetType();
            if (type != null)
            {
                FieldInfo? fi = type.GetField(enumValue.ToString());
                if (fi != null)
                {
                    IEnumerable<Attribute> attributes = fi.GetCustomAttributes(typeof(DescriptionAttribute));
                    if (attributes.IsNotEmpty())
                    {
                        descrValue = ((DescriptionAttribute)attributes.First()).Description;
                    }
                }
            }

            return descrValue;
        }
    }
}
