using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace VirtualDiary.Infrastructure.Data.Models
{
    public class TeacherClass
    {
        [ForeignKey(nameof(Teacher))]
        public Guid TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        [ForeignKey(nameof(Class))]
        public Guid ClassId { get; set; }
        public virtual Class Class { get; set; }
    }
}
