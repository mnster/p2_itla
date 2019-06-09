using System;
using System.Collections.Generic;
using System.Text;
using Model;
using Microsoft.EntityFrameworkCore;


namespace Persistence
{
    public class StudentDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {}
    }
}
