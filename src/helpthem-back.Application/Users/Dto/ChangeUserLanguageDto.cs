using System.ComponentModel.DataAnnotations;

namespace helpthem-back.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}