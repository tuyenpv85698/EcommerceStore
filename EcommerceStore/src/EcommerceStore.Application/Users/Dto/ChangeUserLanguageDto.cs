using System.ComponentModel.DataAnnotations;

namespace EcommerceStore.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}