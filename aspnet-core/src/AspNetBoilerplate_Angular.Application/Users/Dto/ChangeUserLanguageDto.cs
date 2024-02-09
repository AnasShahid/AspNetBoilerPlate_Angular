using System.ComponentModel.DataAnnotations;

namespace AspNetBoilerplate_Angular.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}