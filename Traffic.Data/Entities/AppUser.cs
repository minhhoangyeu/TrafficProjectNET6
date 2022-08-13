using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Traffic.Data.Entities
{
    public class AppUser : IdentityUser<Guid>
    {
        public string FullName { get; set; }

        public DateTime Dob { get; set; }
        public string Address { get; set; }
        public int LevelId { get; set; }
        public string Gender { get; set; }
        public string IpAddress { get; set; } // Unique
        public decimal Balance { get; set; }
        public List<Campaign> Campaigns { get; set; }

        public List<CampaignHistory> CampaignHistories { get; set; }

        public List<UserCampaign> UserCampaigns { get; set; }
    }
}
