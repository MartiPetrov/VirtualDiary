using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace VirtualDiary.Infrastructure.Data.Models
{
    public class User : IdentityUser
    {
        [Required]
        [MaxLength(50)]
        public string Role { get; set; }
    }
}
