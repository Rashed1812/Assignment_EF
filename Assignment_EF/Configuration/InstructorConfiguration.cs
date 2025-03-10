using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03_EF.Configuration
{
    class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> i)
        {
            i.ToTable("Instructors");
            i.HasKey(i => i.Id);
            i.Property(i => i.Id)
                .UseIdentityColumn(1, 1);
            i.Property(i => i.Name)
                .HasColumnType("varchar")
                .HasMaxLength(20)
                .IsRequired(true);
            i.Property(i => i.Address)
                .IsRequired(true)
                .HasColumnType("varchar")
                .HasMaxLength(50);

            i.HasMany(i => i.departments)
                .WithOne(d => d.instructor)
                .HasForeignKey(d => d.Ins_Id)
                .OnDelete(DeleteBehavior.Restrict);

            i.HasMany(i => i.course_Insts)
                .WithOne(sc => sc.instructor);
        }
    }
}
