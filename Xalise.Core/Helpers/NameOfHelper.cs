using System.Linq.Expressions;
using Xalise.Core.Extensions;

namespace Xalise.Core.Helpers
{
    /// <summary>
    /// Fonctions utilitaires pour récupérer le nom d'une variable, d'un type ou d'un membre.
    /// </summary>
    public static class NameOfHelper
    {
        /// <summary>
        /// Obtention du nom d'une variabme, d'un typê ou d'un membre à partir de la propriété <c>nameof</c>.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="name">Expression à évaluer.</param>
        /// <param name="alias">Alias à inclure dans le résultlat.</param>
        /// <returns>Si <paramref name="alias"/> renseigné renvoie <c>alias.NomPropriété</c>, sinon renvoie <c>NomPropriété</c>.</returns>

        public static string NameOfProperty<T>(Expression<Func<T, object>> name, string alias = "")
        {
            if (!alias.IsNullOrWhiteSpace())
            {
                alias = $"{alias}.";
            }

            return $"{alias}{NameOfHelper.NameOf(name, true)}";
        }

        /// <summary>
        /// Obtention du nom d'une variabme, d'un typê ou d'un membre à partir de la propriété <c>nameof</c>.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="name">Expression à évaluer.</param>
        /// <param name="sansAlias">Indique si l'alias doit être retiré ou inclu dans le résultat.</param>
        /// <returns>Si <paramref name="sansAlias"/> renvoie <c>NomPropriété</c>, sinon <c>alias.NomPropriété</c>.</returns>
        public static string NameOfProperty<T>(Expression<Func<T, object>> name, bool sansAlias)
        {
            return NameOfHelper.NameOf(name, sansAlias);
        }

        /// <summary>
        /// Obtention du nom d'une variabme, d'un typê ou d'un membre à partir de la propriété <c>nameof</c>.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="name">Expression à évaluer.</param>
        /// <param name="sansAlias">Indique si l'alias doit être retiré ou inclu dans le résultat.</param>
        /// <returns>Si <paramref name="sansAlias"/> renvoie <c>NomPropriété</c>, sinon <c>alias.NomPropriété</c>.</returns>
        public static string NameOf<T>(Expression<Func<T, object>> name, bool sansAlias = false)
        {
            Expression body             = name.Body;
            MemberExpression membExpr   = null;

            if (body.NodeType == ExpressionType.Convert || name.NodeType == ExpressionType.Convert)
            {
                membExpr = ((UnaryExpression)body).Operand as MemberExpression;
            }
            else if (name.NodeType == ExpressionType.Lambda)
            {
                membExpr = body as MemberExpression;
            }
            else if (name.NodeType == ExpressionType.MemberAccess)
            {
                membExpr = name as MemberExpression;
            }

            string valeur = membExpr.ToString();

            if (sansAlias)
            {
                string nameAliasExpression = null;

                if (name.Parameters != null && name.Parameters.IsNotEmpty())
                {
                    nameAliasExpression = name.Parameters[0].Name;
                }

                if (!string.IsNullOrWhiteSpace(nameAliasExpression))
                {
                    valeur = valeur.Remove(0, nameAliasExpression.Length + 1);
                }
            }

            return valeur;
        }
    }
}
