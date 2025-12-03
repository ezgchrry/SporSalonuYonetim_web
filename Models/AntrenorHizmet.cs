using System.ComponentModel.DataAnnotations.Schema;

namespace SporSalonuYonetim_web.Models
{
    public class AntrenorHizmet
    {
        [Column(Order = 1)]
        public int AntrenorId { get; set; }

        [Column(Order = 2)]
        public int HizmetId { get; set; }

        public Antrenor Antrenor { get; set; }
        public Hizmet Hizmet { get; set; }
    }
}
