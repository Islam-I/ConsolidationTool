using ConsolidationTool.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolidationTool.Data.EntityTypeConfigurations
{
    public class BaseEntityTypeConfiguration : IEntityTypeConfiguration<Customer>
    {
        public virtual void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.Property<bool>("IsDeleted")
                .IsRequired()
                .HasDefaultValue(false);
            builder.Property<DateTime>("InsertedAt")
                .IsRequired()
                .HasDefaultValueSql("SYSDATETIME()")
                .ValueGeneratedOnAdd();
            builder.Property<int>("InsertedBy")
                .IsRequired()
                .HasDefaultValue(-99);
            builder.Property<DateTime>("UpdatedAt")
                .IsRequired()
                .HasDefaultValueSql("SYSDATETIME()")
                .ValueGeneratedOnUpdate();
            builder.Property<int>("UpdatedBy");
            builder.Property<int>("FormID");
        }
    }
}
