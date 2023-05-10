using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MultiLanguage.Models
{
    public class UserCreateRequestModel
    {
        [Required(ErrorMessage = "{0} is required")]
        [DisplayName ("Name" )]
        public string Name { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [DisplayName("JobTitle")]
        public string JobTitle { get; set; }
    }
}
