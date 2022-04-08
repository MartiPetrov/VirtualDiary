using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace VirtualDiary.Infrastructure.Data.Models
{
    public class Grade
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public virtual Lesson Lesson { get; set; }
        [ForeignKey(nameof(Student))]
        public Guid StudentId { get; set; }
        public virtual Student Student { get; set; }
    }
}
