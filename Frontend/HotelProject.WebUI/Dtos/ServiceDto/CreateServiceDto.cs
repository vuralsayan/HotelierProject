using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
    public class CreateServiceDto
    {
        [Required(ErrorMessage="Hizmet başlığı giriniz")]
        public string? Title { get; set; }
        [Required(ErrorMessage="Hizmet ikon linki giriniz")]
        public string? Icon { get; set; }
        public string? Description { get; set; }
    }
}
