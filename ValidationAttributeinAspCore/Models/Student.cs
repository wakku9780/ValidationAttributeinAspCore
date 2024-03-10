using System.ComponentModel.DataAnnotations;

namespace ValidationAttributeinAspCore.Models
{
    public class Student
    {
        [Required(ErrorMessage ="Name Is Must")]
        //[StringLength(15,MinimumLength =3)]

        [MaxLength(15)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email Is Must")]
        //[EmailAddress]
        [RegularExpression("^([\\w\\.\\-]+)@([\\w\\-]+)((\\.(\\w){2,3})+)$",ErrorMessage="Invalid Message")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Age Is Must")]
        [Range(10,15,ErrorMessage="Age must be between them ")]
        public int? Age { get; set; }

        [Required(ErrorMessage = "Password  Is Must")]
        [RegularExpression("^((?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])|(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[^a-zA-Z0-9])|(?=.*?[A-Z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])|(?=.*?[a-z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])).{8,}$", ErrorMessage="Uppercase,LowerCase,Symbol,Min 8 Char")]
        public string Password { get; set; }

        [Required(ErrorMessage = "ConfirmPassword  Is Must")]
        [Compare("Password",ErrorMessage="Both Password Must be Identical")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "website URL is must")]
        [Url(ErrorMessage ="Invalid URL")]
        public string WebsiteURL { get; set; }

    }
}
