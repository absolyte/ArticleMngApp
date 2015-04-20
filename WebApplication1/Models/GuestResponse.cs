using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    using System.Net.Configuration;
    using System.Runtime.Remoting.Services;

    public class GuestResponse
    {
        [Required(ErrorMessage = "please, input your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please input email")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "please Enter valid email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please, input phone number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please choose one option yes or no")]
        public bool? WillAttend { get; set; }
    }
}