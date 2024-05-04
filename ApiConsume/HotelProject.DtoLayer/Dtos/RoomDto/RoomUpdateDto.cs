using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.Dtos.RoomDto
{
    public class RoomUpdateDto
    {
        public int RoomID { get; set; }

        [Required(ErrorMessage = "Lütfen oda numarasını yazınız!")]
        public string? RoomNumber { get; set; }

        [Required(ErrorMessage = "Lütfen oda görseli giriniz!")]
        public string? RoomCoverImage { get; set; }

        [Required(ErrorMessage = "Lütfen fiyat bilgisi yazınız!")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Lütfen oda başlığı bilgisi giriniz!")]
        [StringLength(100, ErrorMessage = "Oda başlığı en fazla 100 karakter olabilir!")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Lütfen yatak sayısı giriniz!")]
        public string? BedCount { get; set; }

        [Required(ErrorMessage = "Lütfen banyo sayısı giriniz!")]
        public string? BathCount { get; set; }
        public bool Wifi { get; set; }

        [Required(ErrorMessage = "Lütfen açıklamayı yazınız!")]
        public string? Description { get; set; }
    }
}
