using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace The_wall.Models
{
    public class login{
        
        [Required]
        [EmailAddress]
        public string email { get; set; }
        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        public string password { get; set; }
        
    }
}