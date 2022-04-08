using System;
using System.Collections.Generic;

namespace VirtualDiary.Infrastructure.Data.Models
{
    public class SchoolDay
    {
        public Guid Id { get; set; }
        public DayOfWeek WeekDay { get; set; }
        public virtual IList<Lesson> Lessons { get; set; }


    }
}
