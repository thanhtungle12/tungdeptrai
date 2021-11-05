using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopANMET.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopANMET.Data.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable("Roles");

            builder.Property(x => x.Description).HasMaxLength(200).IsRequired();

        }
    }
}
