using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BackendApi.Model.Entity
{
    [Table(name:"Person")]
    public class Person
    {
        [Column(name:"Id")]
        public int Id { get; set; }
        
        [Column(name: "Adi")]
        public string Adi { get; set; }
        
        [Column(name: "Soyadi")]
        public string Soyadi { get; set; }
        
        [Column(name: "Telefonu")]
        public int Telefonu { get; set; }
        
        [Column(name: "Email")]
        public string Email { get; set; }
        
        [Column(name: "Silindi_mi")]
        public bool Silindi_mi { get; set; }

        [Column(name: "Aktif")]
        public bool Aktif { get; set; }
    }
}
