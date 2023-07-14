using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.IO;
using System.Text.Encodings.Web;
using Xalise.Web.Enums;
using Xalise.Web.Helpers.WebHelpers;
using Xalise.Web.Utils;

namespace Xalise.Web.Helpers.TagHelpers
{
    /// <summary>
    /// Lien d'action affichant une icône fontawesome et éventuellement un texte.
    /// </summary>
    public class XaliseActionLinkTagHelper : TagHelper
    {
        public string                   Title { get; set; }
        public string                   LinkTitle { get; set; }
        public eFontAwesomeIconStyle    IconStyle { get; set; }
        public eFontAwesomeIcon         Icon { get; set; }

        /// <summary>
        /// Constructeur par défaut.
        /// </summary>
        public XaliseActionLinkTagHelper()
        {
            this.Title      = string.Empty;
            this.LinkTitle  = string.Empty;
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            // =-=-=-
            // Définition du contenu
            // =-=-=-

            if (this.Icon != eFontAwesomeIcon.icon_default)
            {
                HtmlString iconHtml = new HtmlString("");
                HtmlString spanHtml = new HtmlString("");

                // Avec icône
                TagBuilder faIcon = new TagBuilder("i");
                faIcon.AddCssClass(FontAwesomeHelper.FontAwesomeClass(this.IconStyle, this.Icon));

                using (StringWriter writer = new StringWriter())
                {
                    faIcon.WriteTo(writer, HtmlEncoder.Default);
                    iconHtml = new HtmlString(writer.ToString());
                }

                // Ajout du texte du lien
                if (!string.IsNullOrWhiteSpace(this.LinkTitle))
                {
                    TagBuilder span = new TagBuilder("span");
                    span.InnerHtml.Append(this.LinkTitle);

                    using (StringWriter writerSpan = new StringWriter())
                    {
                        span.WriteTo(writerSpan, HtmlEncoder.Default);
                        spanHtml = new HtmlString(writerSpan.ToString());
                    }
                }

                output.Content.AppendHtml(new HtmlString(iconHtml.Value + spanHtml.Value));
            }
            else
            {
                // Sans icône
                output.Content.SetContent(this.LinkTitle);
            }

            // =-=-=-
            // Gestion finale du tag
            // =-=-=-

            output.TagMode = TagMode.StartTagAndEndTag;
            output.TagName = "a";
            output.Attributes.SetAttribute("title", this.Title);
            output.Attributes.SetAttribute("class", IdentifiantfHtmlElement.CLASS_ACTION_LINK);
        }
    }
}
