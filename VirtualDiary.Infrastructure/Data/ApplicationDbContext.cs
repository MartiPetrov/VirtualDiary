using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using VirtualDiary.Infrastructure.Data.Models;

namespace VirtualDiary.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<TeacherClass>()
                .HasKey(c => new { c.TeacherId, c.ClassId });
            builder.Entity<SchoolDayLessons>()
                .HasKey(c => new { c.SchoolDayId, c.LessonId });
            builder.Entity<ProgramSchoolDay>()
                .HasKey(c => new { c.SchoolDayId, c.ProgramId });

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<School> Schools { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Program> Programs { get; set; }
        public DbSet<ProgramSchoolDay> ProgramSchoolDays { get; set; }
        public DbSet<SchoolAdministrator> SchoolAdministrators { get; set; }
        public DbSet<SchoolDay> SchoolDays { get; set; }
        public DbSet<SchoolDayLessons> SchoolDayLessons { get; set; }
        public DbSet<TeacherClass> TeachersClasses { get; set; }



    }
}
