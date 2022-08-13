using System;

namespace Traffic.Data.Entities
{
    public class UserCampaignConfig 
    {
        public int Id { get; set; }
        public int LevelId { get; set; }   //Unique
        public int CampaignAmount { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
    }
}
