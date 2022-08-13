using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Traffic.Data.Entities;

namespace Traffic.Data.Configurations
{
    public class CampaignConfiguration : IEntityTypeConfiguration<Campaign>
    {
        public void Configure(EntityTypeBuilder<Campaign> builder)
        {
            builder.ToTable("Campaigns");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(512);
            builder.Property(x => x.Document).HasMaxLength(512);
            builder.Property(x => x.LinkYoutube).HasMaxLength(512);
            builder.Property(x => x.LinkPage).IsRequired();
            builder.Property(x => x.Status).HasMaxLength(16);

        }
    }
}
