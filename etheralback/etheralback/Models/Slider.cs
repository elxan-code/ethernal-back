using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace etheralback.Models
{
    public class Slider
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(500)]
        public string Content { get; set; }
        [MaxLength(100)]
        public string Fullname { get; set; }
        [MaxLength(100)]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }

    }
}
