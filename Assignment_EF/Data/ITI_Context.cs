using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03_EF.Data
{
    class ITI_Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=rashed\\sqlexpress;Initial Catalog=ITI_ASS;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Student>()
            //            .HasMany(s => s.stud_Courses)
            //            .WithOne(sc => sc.Student)
            //            .HasForeignKey(sc => sc.stud_ID);

            //modelBuilder.Entity<Course>()
            //            .HasMany(c => c.stud_Courses)
            //            .WithOne(sc => sc.Course)
            //            .HasForeignKey(sc => sc.Course_ID);

            //modelBuilder.Entity<Instructor>()
            //            .HasMany(i => i.course_Insts)
            //            .WithOne(sc => sc.instructor)
            //            .HasForeignKey(sc => sc.inst_ID);

            //modelBuilder.Entity<Course>()
            //            .HasMany(c => c.course_Insts)
            //            .WithOne(sc => sc.course)
            //            .HasForeignKey(sc => sc.Course_ID);

            //modelBuilder.Entity<Course_Inst>()
            //            .HasKey(ci => new { ci.Course_ID, ci.inst_ID });

            //modelBuilder.Entity<Stud_Course>()
            //            .HasKey(sc => new { sc.Course_ID, sc.stud_ID });
        }
        public DbSet<Course_Inst> course_Insts { get; set; }
        public DbSet<Stud_Course> stud_Courses { get; set; }

    }
}
