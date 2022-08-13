using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Traffic.Data.Configurations;
using Traffic.Data.Entities;
using Traffic.Data.Extensions;

namespace Traffic.Data.EF
{
    public class TrafficDbContext : IdentityDbContext<AppUser, AppRole, Guid>
    {
        public TrafficDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configure using Fluent API
            modelBuilder.ApplyConfiguration(new AppUserConfiguration());
            modelBuilder.ApplyConfiguration(new AppRoleConfiguration());
            modelBuilder.Entity<IdentityUserClaim<Guid>>().ToTable("AppUserClaims");
            modelBuilder.Entity<IdentityUserRole<Guid>>().ToTable("AppUserRoles").HasKey(x => new { x.UserId, x.RoleId });
            modelBuilder.Entity<IdentityUserLogin<Guid>>().ToTable("AppUserLogins").HasKey(x => x.UserId);
            modelBuilder.Entity<IdentityRoleClaim<Guid>>().ToTable("AppRoleClaims");
            modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("AppUserTokens").HasKey(x => x.UserId);

            modelBuilder.ApplyConfiguration(new LanguageConfiguration());
            modelBuilder.ApplyConfiguration(new CampaignConfiguration());
            modelBuilder.ApplyConfiguration(new CampaignHistoryConfiguration());
            modelBuilder.ApplyConfiguration(new UserCampaignConfiguration());
            modelBuilder.ApplyConfiguration(new UserCampaignConfigConfiguration());
            //Data seeding
            modelBuilder.Seed();
        }
        //public DbSet<User> Users { set; get; }
        public DbSet<Campaign> Campaigns { set; get; }
        public DbSet<UserCampaignConfig> UserCampaignConfigs { set; get; }
        public DbSet<CampaignHistory> CampaignHistories { set; get; }
        public DbSet<UserCampaign> UserCampaigns { set; get; }
        public DbSet<Language> Languages { get; set; }


    }
}