using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.EntityLayer.Concrete
{
    public class Staff
    {
        public int StaffID { get; set; }
        public string? Name { get; set; }
        public string? Title { get; set; }
        public string? Image { get; set; }
        public string? Github { get; set; }
        public string? Instagram { get; set; }
        public string? Linkedin { get; set; }
    }
}
