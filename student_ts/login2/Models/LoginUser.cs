using System;
using System.ComponentModel.DataAnnotations;


namespace login2.Models
{

    public class LoginUser
    {
        [Required]
        [MinLength(2)]
        public string LoginEmail {get; set;}

        [Required]
        public string LoginPassword { get; set; }
    }
}