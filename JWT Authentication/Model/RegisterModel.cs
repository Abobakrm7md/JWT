using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JWT_Authentication.Model
{
    public class RegisterModel
    {
        public string FirestName { get; set; }
        public string LastName { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required,EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
