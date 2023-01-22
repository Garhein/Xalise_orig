using System;
using System.Linq.Expressions;
using Xalise.Util.Extensions;

namespace Xalise.Util.Helpers
{
    /// <summary>
    /// Fonctions utilitaires pour récupérer le nom d'une variable, d'un type ou d'un membre.
    /// </summary>
    public static class NameOfHelper
    {
        /// <summary>
        /// Permet d'obtenir le nom de chaîne simple avec son alias d'une variable, d'un type ou d'un membre.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="name">Expression à évaluer.</param>
        /// <param name="alias">Alias à inclure dans le résultlat.</param>
        /// <returns>Si <paramref name="alias"/> renseigné renvoie "alias.NomPropriété", sinon renvoie "NomPropriété".</returns>
        public static string NameOfProperty<T>(Expression<Func<T, object>> name, string alias = null)
        {
            if (!string.IsNullOrWhiteSpace(alias))
            {
                alias = $"{alias}.";
            }

            return $"{alias}{NameOfHelper.NameOf(name, true)}";
        }

        /// <summary>
        /// Permet d'obtenir le nom de chaîne simple avec son alias d'une variable, d'un type ou d'un membre.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="name">Expression à évaluer.</param>
        /// <param name="sansAlias">Indique si l'alias doit être retiré ou inclu dans le résultat.</param>
        /// <returns>Si <paramref name="sansAlias"/> renvoie "NomPropriété", sinon "alias.NomPropriété".</returns>
        public static string NameOfProperty<T>(Expression<Func<T, object>> name, bool sansAlias)
        {
            return NameOfHelper.NameOf(name, sansAlias);
        }

        /// <summary>
        /// Permet d'obtenir le nom de chaîne simple (non qualifié) d'une variable, d'un type ou d'un membre à partir de la propriété **nameof**.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="name">Expression à évaluer.</param>
        /// <param name="sansAlias">Indique si l'alias doit être retiré ou inclu dans le résultat.</param>
        /// <returns>Si <paramref name="sansAlias"/> renvoie "NomPropriété", sinon "alias.NomPropriété".</returns>
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
