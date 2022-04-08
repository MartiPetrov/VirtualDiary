using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace VirtualDiary.Infrastructure.Data.Models
{
    public class SchoolDayLessons
    {
        [ForeignKey(nameof(SchoolDay))]
        public Guid SchoolDayId { get; set; }
        public SchoolDay SchoolDay { get; set; }
        [ForeignKey(nameof(Lesson))]
        public Guid LessonId { get; set; }
        public Lesson Lesson { get; set; }
    }
}
