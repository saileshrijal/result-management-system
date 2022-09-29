using Microsoft.EntityFrameworkCore;
using RMS.Modules.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Faculty>? Faculties { get; set; }
        public DbSet<College>? Colleges { get; set; }
        public DbSet<Result>? Results { get; set; }
        public DbSet<Student>? Students { get; set; }
        public DbSet<StudentSubject>? StudentSubjects { get; set; }
        public DbSet<Subject>? Subjects { get; set; }
    }
}
