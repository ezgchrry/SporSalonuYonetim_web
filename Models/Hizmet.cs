using System.ComponentModel.DataAnnotations;

namespace SporSalonuYonetim_web.Models
{
    public class Hizmet
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Hizmet adı zorunludur.")]
        [StringLength(80, ErrorMessage = "Hizmet adı en fazla 80 karakter olmalıdır." )]
        [Display(Name = "Hizmet Adı" )]
        public string Ad {  get; set; }

        [StringLength(500, ErrorMessage = "Açıklama en fazla 500 karakter olmalıdır")]
        [Display(Name = "Açıklama")]
        public string Aciklama { get; set; }

        [Required(ErrorMessage = "Ücret zorunludur.")]
        [Range(0,15000, ErrorMessage = "Ücret 0 ile 15000 TL arasında olmalıdır.")]
        [Display(Name = "Saatlik Ücret (TL)")]
        public decimal Ucret {  get; set; }

        [Display(Name = "Standart Süre (Dakika)")]
        [Range(15,180, ErrorMessage = "Süre 15 ile 180 dakika arası olmalıdır.")]
        public int SureDakika { get; set; }

        public ICollection<AntrenorHizmet> AntrenorHizmetleri { get; set; } = new List<AntrenorHizmet>();

    }
}
