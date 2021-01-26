using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BackendApi.Model.Dto
{
    public class PersonDto
    {

        public int Id { get; set; }
        
       
       
        public string Adi { get; set; }

       
        public string Soyadi { get; set; }

       
        //[RegularExpression(pattern:"\\D")]
        public int Telefonu { get; set; }


        public string Email { get; set; }

        public bool Silindi_mi { get; set; }
        
        public bool Aktif { get; set; }
    }
}
