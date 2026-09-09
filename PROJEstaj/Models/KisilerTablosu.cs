using System.ComponentModel.DataAnnotations;

namespace PROJEstaj.Models
{
    public class KisilerTablosu
    {
        [Key]
        public int ID { get; set; }

        [Required]//Satır boş geçilemez.
        [StringLength(11, MinimumLength = 11, ErrorMessage = "TC 11 haneli olmalıdır.")]
        public string TC { get; set; }

        [Required]
        [StringLength(50)]
        public string Ad { get; set; }

        [Required]
        [StringLength(50)]
        public string Soyad { get; set; }

        [Required]
        [Range(18, 99, ErrorMessage = "Yaş 18 ve üzeri olmalı")]
        public int Yas { get; set; }

        [Required]
        public string Cinsiyet { get; set; }
    }
}
