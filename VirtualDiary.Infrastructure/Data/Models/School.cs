using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VirtualDiary.Infrastructure.Data.Models
{
    public class School
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public virtual IList<Student> Students { get; set; } = new List<Student>();
        public virtual IList<Teacher> Teachers { get; set; } =new List<Teacher>();
        [MaxLength(200)]
        public string Name { get; set; }
        [MaxLength(70)]
        public string Town { get; set; }
    }
}
