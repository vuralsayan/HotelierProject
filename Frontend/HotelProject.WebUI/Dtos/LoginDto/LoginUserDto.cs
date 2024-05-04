using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.LoginDto
{
    public class LoginUserDto
    {
        [Required(ErrorMessage = "Lütfen kullanıcı adınızı giriniz!")]
        public string? Username { get; set; }

        [Required(ErrorMessage = "Lütfen şifrenizi giriniz!")]
        public string? Password { get; set; }
    }
}
