using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03_EF.Configuration
{
    class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> s)
        {
            s.ToTable("Students");
            s.HasKey(s => s.Id);
            s.Property(s => s.Id)
                .UseIdentityColumn(100, 1);
            s.Property(s=>s.FName)
                 .HasColumnType("varchar")
                .HasMaxLength(20)
                .IsRequired(true);
            s.Property(s => s.LName)
               .HasColumnType("varchar")
              .HasMaxLength(20)
              .IsRequired(true);
            s.Property(s => s.Address)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired(true);

            s.HasOne(s => s.Department)
                .WithMany(s => s.Students)
                .HasForeignKey(s => s.Dept_Id);

            s.HasMany(s => s.stud_Courses)
                .WithOne(sc => sc.Student);
        }
    }
}
