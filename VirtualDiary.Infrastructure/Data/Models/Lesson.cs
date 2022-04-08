using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VirtualDiary.Infrastructure.Data.Models
{
    public class Lesson
    {
        [ForeignKey(nameof(Teacher))]
        public Guid TeacherId { get; set; } 
        public Teacher Teacher { get; set; }
        public DateTime LessonStart { get; set; }
        public TimeSpan DueTime { get; set; }
        [MaxLength(30)]
        public string Subject { get; set; }
        public virtual Class Class { get; set; }
        [ForeignKey(nameof(Class))]
        public Guid ClassId { get; set; }

    }
}
