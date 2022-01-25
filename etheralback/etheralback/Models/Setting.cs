using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace etheralback.Models
{
    public class Settings
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(150)]
        public string Logo { get; set; }
        [MaxLength(100)]
        public string Title { get; set; }
        [MaxLength(150)]
        public string Subtitle { get; set; }
        [MaxLength(250)]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        [MaxLength(100)]
        public string Adress { get; set; }
        [MaxLength(100)]
        public string Email { get; set; }
        [MaxLength(50)]
        public string Phone { get; set; }
     
    }
}
