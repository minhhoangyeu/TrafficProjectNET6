using System;
using System.Collections.Generic;

namespace Traffic.Data.Entities
{
    public class Campaign
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AverageCompletionTime { get; set; }
        public decimal BidPerTaskCompletion { get; set; }
        public decimal Budget { get; set; }
        public string Document { get; set; }
        public string LinkYoutube { get; set; }
        public string Guideline { get; set; }
        public string LinkPage { get; set; }
        public int DurationOnPage { get; set; }
        public string Status { get; set; }
        public Guid OwnerBy { get; set; } //varchar(255) : FK
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public AppUser AppUser { set; get; }
        public  List<UserCampaign> UserCampaigns { get; set; }
        public  List<CampaignHistory> CampaignHistories { get; set; }
    }
}
