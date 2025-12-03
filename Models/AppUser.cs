using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.ComponentModel.DataAnnotations;

namespace SporSalonuYonetim_web.Models
{
    public class AppUser : IdentityUser // temel alanlar dışında kendi alanlarımızı eklemek için miras aldık
    {
        [Required(ErrorMessage = "Ad alanı zorunludur.")]
        [StringLength(30)]
        [Display(Name = "Ad")]
        public string Ad {  get; set; }

        [Required(ErrorMessage = "Soyad alanı zorunludur.")]
        [StringLength(30)]
        [Display(Name = "Soyad")]
        public string Soyad { get; set; }
    }
}
