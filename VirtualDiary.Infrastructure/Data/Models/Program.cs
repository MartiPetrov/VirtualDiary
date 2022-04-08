using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace VirtualDiary.Infrastructure.Data.Models
{
    public class Program
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        [ForeignKey(nameof(Class))]
        public Guid ClassId { get; set; }
        public virtual Class Class { get; set; }
    }
}
