using System;

namespace Traffic.Data.Entities
{
    public class CampaignHistory 
    {
        public int Id { get; set; }
        public int CampaignId { get; set; }// Unique FK
        public Guid ImplementBy { get; set; }
        public string Status { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public  Campaign Campaign { set; get; }
        public  AppUser AppUser { set; get; }
    }
}
