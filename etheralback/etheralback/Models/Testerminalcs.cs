using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace etheralback.Models
{
    public class Testerminalcs
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(150)]
        public string Title { get; set; }
        [MaxLength(150)]
        public string Context { get; set; }
        [MaxLength(150)]
        public string MyProperty { get; set; }
    }
}
