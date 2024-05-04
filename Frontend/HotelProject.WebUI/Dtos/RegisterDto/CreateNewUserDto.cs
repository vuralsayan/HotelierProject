using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.RegisterDto
{
    public class CreateNewUserDto
    {
        [Required(ErrorMessage = "Lütfen isminizi giriniz!")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Lütfen soy isminizi giriniz!")]
        public string? Surname { get; set; }

        [Required(ErrorMessage = "Lütfen kullanıcı adınızı giriniz!")]
        public string? Username { get; set; }

        [Required(ErrorMessage = "Lütfen mail adresinizi giriniz!")]
        public string? Mail { get; set; }

        [Required(ErrorMessage = "Lütfen şifrenizi giriniz!")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Şifre tekrar alanı gereklidir!")]
        [Compare("Password", ErrorMessage = "Şifreler uyuşmuyor!")] 
        public string? ConfirmPassword { get; set; }

    }
}
