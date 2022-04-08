using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VirtualDiary.Infrastructure.Data.Models
{
    public class SchoolAdministrator
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        [MaxLength(50)]
        public string Name { get; set; }
        [ForeignKey(nameof(School))]
        public Guid SchoolId { get; set; }
        public School School { get; set; }
    }
}
