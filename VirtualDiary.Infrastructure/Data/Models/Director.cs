using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VirtualDiary.Infrastructure.Data.Models
{
    public class Director
    {
        [Required]
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        public string Name { get; set; }
        [Required]
        [ForeignKey(nameof(School))]
        public Guid SchoolId { get; set; }
        public virtual School School { get; set; }

    }
}
