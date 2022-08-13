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
    public class UserCampaignConfiguration : IEntityTypeConfiguration<UserCampaign>
    {
        public void Configure(EntityTypeBuilder<UserCampaign> builder)
        {
            builder.ToTable("UserCampaigns");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.HasKey(x => new { x.ImplementBy, x.CampaignId });
            builder.HasOne(x => x.Campaign).WithMany(x => x.UserCampaigns).HasForeignKey(x => x.CampaignId);
            builder.HasOne(x => x.AppUser).WithMany(x => x.UserCampaigns).HasForeignKey(x => x.ImplementBy);
            builder.Property(x => x.Token).HasMaxLength(512);

        }
    }
}
