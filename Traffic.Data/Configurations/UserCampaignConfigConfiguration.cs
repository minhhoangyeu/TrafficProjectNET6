using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traffic.Data.Entities;

namespace Traffic.Data.Configurations
{
    public class UserCampaignConfigConfiguration : IEntityTypeConfiguration<UserCampaignConfig>
    {
        public void Configure(EntityTypeBuilder<UserCampaignConfig> builder)
        {
            builder.ToTable("UserCampaignConfigs");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

        }
    }
}
