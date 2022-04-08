using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace VirtualDiary.Infrastructure.Data.Models
{
    public class ProgramSchoolDay
    {
        [ForeignKey(nameof(Program))]
        public Guid ProgramId { get; set; }
        public Program Program { get; set; }
        [ForeignKey(nameof(SchoolDay))]
        public Guid SchoolDayId { get; set; }
        public SchoolDay SchoolDay { get; set; }
    }
}
