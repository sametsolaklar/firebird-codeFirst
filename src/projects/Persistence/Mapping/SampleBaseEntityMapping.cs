using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Mapping
{
    public class SampleBaseEntityMapping : IEntityTypeConfiguration<SampleBaseEntity>
    {
        public void Configure(EntityTypeBuilder<SampleBaseEntity> builder)
        {
            builder.HasKey(k => k.Id);
            builder.Property(p=>p.Id).UseIdentityColumn().HasColumnName("Id").IsRequired();
            builder.Property(k => k.Name).HasColumnName("Name").IsRequired().HasMaxLength(25);
            builder.Property(k=>k.DeleteDate).HasColumnName("DeleteDate");
            builder.Property(k => k.DeleteDate).HasColumnName("CreateDate").IsRequired();
            builder.Property(k => k.DeleteDate).HasColumnName("EditDate");

        }
    }
}
