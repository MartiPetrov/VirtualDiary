using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VirtualDiary.Infrastructure.Data.Models
{
    public class Class
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Range(1,12)]
        public int ClassNum { get; set; }
        [MaxLength(1)]
        public string ClassChar { get; set; }
        
        [ForeignKey(nameof(ClassTeacher))]
        public Guid ClassTeacherId { get; set; }
        public virtual Teacher ClassTeacher { get; set; }
        [ForeignKey(nameof(School))]
        public Guid SchoolId { get; set; }
        public virtual School School { get; set; }
        public virtual IList<Student> Students { get; set; }
    }
}
