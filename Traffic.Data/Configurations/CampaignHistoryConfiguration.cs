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
    public class CampaignHistoryConfiguration : IEntityTypeConfiguration<CampaignHistory>
    {
        public void Configure(EntityTypeBuilder<CampaignHistory> builder)
        {
            builder.ToTable("CampaignHistories");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.HasKey(x => new { x.ImplementBy, x.CampaignId });
            builder.HasOne(x => x.Campaign).WithMany(x => x.CampaignHistories).HasForeignKey(x => x.CampaignId);
            builder.HasOne(x => x.AppUser).WithMany(x => x.CampaignHistories).HasForeignKey(x => x.ImplementBy);
            builder.Property(x => x.Status).HasMaxLength(16);

        }
    }
}
