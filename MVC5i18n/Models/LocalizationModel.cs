using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace MVC5i18n.Models
{
    /// <summary>
    /// Classe définissant le modèle des choix de langues 
    /// </summary>
    public class LocalizationModel
    {

        IEnumerable<LanguageItemModel> languages;

        /// <summary>
        /// Gets or sets the languages items.
        /// </summary>
        /// <value>The items.</value>
        public IEnumerable<LanguageItemModel> Languages
        {
            get
            {
                return languages;
            }
            set { languages = value; }
        }

        /// <summary>
        /// Gets the lauguage items.
        /// </summary>
        /// <value>The lauguage items.</value>
        public SelectList LanguageItems
        {
            get
            {
                if (languages != null && languages.Any())
                    return new SelectList(languages, "Name", "DisplayName", SelectedLanguageCode);//languages.Select(l => new SelectListItem() { Selected = l.Equals(SelectedLanguage), Text = l.DisplayName, Value = l.Name });
                return null;
            }
        }

        /// <summary>
        /// Gets or sets the code of the selected language.
        /// </summary>
        /// <value>The code of the selected language.</value>
        public string SelectedLanguageCode { get; set; }


        /// <summary>
        /// Gets or sets the selected language.
        /// </summary>
        /// <value>The selected language.</value>
        public LanguageItemModel SelectedLanguage
        {
            get
            {
                if (!string.IsNullOrEmpty(SelectedLanguageCode) && Languages != null && Languages.Any())
                    return Languages.FirstOrDefault(l => l.Name == SelectedLanguageCode);
                else return null;
            }
        }
    }
}
