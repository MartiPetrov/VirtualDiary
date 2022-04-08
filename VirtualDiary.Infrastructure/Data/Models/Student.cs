using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace VirtualDiary.Infrastructure.Data.Models
{
    public class Student
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        [ForeignKey(nameof(Class))]
        public Guid ClassId { get; set; } 
        public Class Class { get; set; }
        public IList<Grade> Grades { get; set; }
        [ForeignKey(nameof(School))]
        public Guid SchoolId { get; set; }
        public School School { get; set; }
    }
}
