using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BackendApi.Model.Dto
{
    public class PersonDto
    {

        public int Id { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string Adi { get; set; }

        [Required]
        [MaxLength(length:50,ErrorMessage = "Zorunlu Alandır")]
        public string Soyadi { get; set; }

        [Required]
        [MaxLength(length: 11, ErrorMessage = "Zorunlu Alandır")]
        //[RegularExpression(pattern:"\\D")]
        public int Telefonu { get; set; }


        [Required]
        [MaxLength(length: 11, ErrorMessage = "Zorunlu Alandır")]
        public string Email { get; set; }

        public bool Silindi_mi { get; set; }
        
        public bool Aktif { get; set; }
    }
}
