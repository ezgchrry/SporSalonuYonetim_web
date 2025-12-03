using System.ComponentModel.DataAnnotations;

namespace SporSalonuYonetim_web.Models
{ 
    public class Antrenor
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "İsim zorunludur.")]
        [StringLength(50)]
        [Display(Name = "Ad")]
        public string Ad { get; set; }

        [Required(ErrorMessage = "Soyisim zorunludur.")]
        [StringLength(50)]
        [Display(Name = "Soyad")]
        public string Soyad { get; set; }

        [Required(ErrorMessage = "Uzmanlık alanı zorunludur.")]
        [StringLength(150)]
        [Display(Name = "Uzmanlık Alanları")]
        public string UzmanlikAlanlari {  get; set; }

        [EmailAddress(ErrorMessage = "Lütfen geçerli bir e-posta adresi giriniz.")]
        public string Email { get; set; }

        public ICollection<AntrenorHizmet> AntrenorHizmetleri { get; set; } = new List<AntrenorHizmet>();
    }
}
