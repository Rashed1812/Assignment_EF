using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03_EF.Configuration
{
    class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> d)
        {
            d.ToTable("Departments");
            d.HasKey(d => d.Id);
            d.Property(d => d.Id)
                .UseIdentityColumn(1, 1);
            d.Property(d => d.Name)
                .HasColumnName("DepartmentName")
                .HasColumnType("varchar")
                .HasMaxLength(20)
                .IsRequired(true);
            d.Property(d => d.HiringDate)
                .HasAnnotation("DataType", "DateTime");

            d.HasOne(d => d.instructor)
                .WithMany(i => i.departments)
                .HasForeignKey(d => d.Ins_Id)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
