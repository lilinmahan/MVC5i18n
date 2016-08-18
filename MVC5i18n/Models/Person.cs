using System.ComponentModel.DataAnnotations;

namespace MVC5i18n.Models
{
    public class Person
    {
        [Display(Name = "FirstName", ResourceType = typeof(Resources.Resource))]
        [Required(ErrorMessageResourceType = typeof(Resources.Resource),
                  ErrorMessageResourceName = "FirstNameRequired")]
        [StringLength(50, ErrorMessageResourceType = typeof(Resources.Resource),
                          ErrorMessageResourceName = "FirstNameLong")]
        public string FirstName { get; set; }

        [Display(Name = "LastName", ResourceType = typeof(Resources.Resource))]
        [Required(ErrorMessageResourceType = typeof(Resources.Resource),
                  ErrorMessageResourceName = "LastNameRequired")]
        [StringLength(50, ErrorMessageResourceType = typeof(Resources.Resource),
                          ErrorMessageResourceName = "LastNameLong")]
        public string LastName { get; set; }


        [Display(Name = "Age", ResourceType = typeof(Resources.Resource))]
        [Required(ErrorMessageResourceType = typeof(Resources.Resource),
                  ErrorMessageResourceName = "AgeRequired")]
        [Range(0, 130, ErrorMessageResourceType = typeof(Resources.Resource),
                       ErrorMessageResourceName = "AgeRange")]
        public int Age { get; set; }


        [Display(Name = "Email", ResourceType = typeof(Resources.Resource))]
        [Required(ErrorMessageResourceType = typeof(Resources.Resource),
                  ErrorMessageResourceName = "EmailRequired")]
        [RegularExpression(".+@.+\\..+", ErrorMessageResourceType = typeof(Resources.Resource),
                                         ErrorMessageResourceName = "EmailInvalid")]
        public string Email { get; set; }


        [Display(Name = "Biography", ResourceType = typeof(Resources.Resource))]
        public string Biography { get; set; }
    }
}