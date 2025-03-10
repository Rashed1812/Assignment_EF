using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03_EF.Configuration
{
    class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> c)
        {
            c.ToTable("Courses");
            c.HasKey(c => c.Id);
            c.Property(c => c.Id)
                .UseIdentityColumn(1, 1);
            c.Property(c => c.Name)
                .HasColumnType("varchar")
                .HasMaxLength(20)
                .IsRequired(true);
            c.Property(c => c.Description)
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired(true);

            c.HasOne(c => c.topic)
                .WithMany(c => c.courses)
                .HasForeignKey(s => s.Top_Id);
            c.HasMany(c => c.stud_Courses)
                .WithOne(sc => sc.Course);
            c.HasMany(c => c.course_Insts)
                .WithOne(sc => sc.course);
        }
    }
}
