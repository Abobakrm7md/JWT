using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JWT_Authentication.Model
{
    public class User : IdentityUser
    {
        [Required , MaxLength(50)]
        public string FirestName { get; set; }
        [Required, MaxLength(50)]
        public string LastName { get; set; }

    }
}
