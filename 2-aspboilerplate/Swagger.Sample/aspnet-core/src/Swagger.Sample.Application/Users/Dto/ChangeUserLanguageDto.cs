using System.ComponentModel.DataAnnotations;

namespace Swagger.Sample.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}