using System;
using System.Web.Mvc;

namespace MVC5i18n.Models
{
    /// <summary>
    /// Classe définissant le modèle d'un element du menu
    /// </summary>
    public class LanguageItemModel 
    {
        public string Name { get; set; }
        /// <summary>
        /// Gets the action URL.
        /// </summary>
        /// <value>The action URL.</value>
        public string ActionUrl { get; set; }

        /// <summary>
        /// Gets the picto URL.
        /// </summary>
        /// <value>The picto URL.</value>
        public string PictoUrl { get; set; }
    }
}
