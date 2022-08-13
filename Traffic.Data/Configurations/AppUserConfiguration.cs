using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Traffic.Data.Entities;

namespace Traffic.Data.Configurations
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.ToTable("AppUsers");
            builder.Property(x => x.FullName).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Dob).IsRequired();
            builder.Property(x => x.Address).IsRequired().HasMaxLength(512); 
            builder.Property(x => x.Address).HasMaxLength(8);
            builder.Property(x => x.IpAddress).IsRequired().HasMaxLength(32);
           
    }
    }
}
