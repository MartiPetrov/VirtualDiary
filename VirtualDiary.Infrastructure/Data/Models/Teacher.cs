using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VirtualDiary.Infrastructure.Data.Models
{
    public class Teacher
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [MaxLength(50)]
        public string Name { get; init; }

        public string Subject { get; set; }
        public virtual IList<Class> Classes { get; set; } = new List<Class>();
        [ForeignKey(nameof(Program))]
        public Guid ProgramId { get; set; }
        public Program Program { get; set; }
        [ForeignKey(nameof(School))]
        public Guid SchoolId { get; set; }
        public School School { get; set; }

    }
}
