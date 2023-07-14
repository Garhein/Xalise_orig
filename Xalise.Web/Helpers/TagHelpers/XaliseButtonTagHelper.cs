using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.IO;
using System.Text.Encodings.Web;
using Xalise.Web.Enums;
using Xalise.Web.Helpers.WebHelpers;

namespace Xalise.Web.Helpers.TagHelpers
{
    /// <summary>
    /// Bouton bootstrap pouvant contenir une icône fontawesome.
    /// </summary>
    public class XaliseButtonTagHelper : TagHelper
    {
        public string                   Title { get; set; }
        public eBootstrapButtonSize     Size { get; set; }
        public eBootstrapButtonStyle    Style { get; set; }
        public eFontAwesomeIconStyle    IconStyle { get; set; }
        public eFontAwesomeIcon         Icon { get; set; }

        /// <summary>
        /// Constructeur par défaut.
        /// </summary>
        public XaliseButtonTagHelper()
        {
            this.Title = string.Empty;
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            // =-=-=-
            // Définition des classes CSS
            // =-=-=-

            string cssClasses = "btn";

            if (this.Size != eBootstrapButtonSize.size_default)
            {
                cssClasses = $"{cssClasses} {this.Size.ToString().Replace("_", "-")}";
            }

            if (this.Style != eBootstrapButtonStyle.style_default)
            {
                cssClasses = $"{cssClasses} {this.Style.ToString().Replace("_", "-")}";
            }

            // =-=-=-
            // Définition du contenu
            // =-=-=-

            if (this.Icon != eFontAwesomeIcon.icon_default)
            {
                // Avec icône
                HtmlString iconHtml = new HtmlString("");
                TagBuilder faIcon   = new TagBuilder("i");
                faIcon.AddCssClass(FontAwesomeHelper.FontAwesomeClass(this.IconStyle, this.Icon) + " me-1");

                using (StringWriter writer = new StringWriter())
                {
                    faIcon.WriteTo(writer, HtmlEncoder.Default);
                    iconHtml = new HtmlString(writer.ToString());
                }

                output.Content.AppendHtml(iconHtml + this.Title);
            }
            else
            {
                // Sans icône
                output.Content.SetContent(this.Title);
            }

            // =-=-=-
            // Gestion finale du tag
            // =-=-=-

            output.TagMode = TagMode.StartTagAndEndTag;
            output.TagName = "button";
            output.Attributes.SetAttribute("type", "button");
            output.Attributes.SetAttribute("class", cssClasses);
        }
    }
}
