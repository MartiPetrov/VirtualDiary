using System;
using System.ComponentModel.DataAnnotations;

namespace VirtualDiary.Infrastructure.Data.Models
{
    public class Parent
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public int MyProperty { get; set; }
    }
}
