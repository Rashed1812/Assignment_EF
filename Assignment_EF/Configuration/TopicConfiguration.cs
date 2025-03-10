using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03_EF.Configuration
{
    class TopicConfiguration : IEntityTypeConfiguration<Topic>
    {
        public void Configure(EntityTypeBuilder<Topic> t)
        {
            t.ToTable("Topics");
            t.HasKey(t => t.Id);
            t.Property(t => t.Id)
                .UseIdentityColumn(1, 1);
            t.Property(t => t.Name)
                .HasColumnType("varchar")
                .HasMaxLength(20)
                .IsRequired(true);
        }
    }
}
