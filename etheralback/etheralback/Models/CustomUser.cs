using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace etheralback.Models
{
    public class CustomUser:IdentityUser
    {
        [MaxLength(100)]
        public string Fullname { get; set; }
    }
}
