using System;
namespace Traffic.Data.Entities
{
    public class UserCampaign 
    {
        public int Id { get; set; } 
        public int CampaignId { get; set; } //int (FK)
        public Guid ImplementBy { get; set; } // FK
        public string Token { get; set; }   //Unique, Hash
        public bool IsExpiredToken { get; set; }
        public bool IsDoneTask { get; set; }
        public  Campaign Campaign { set; get; }
        public  AppUser AppUser { set; get; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
    }
}
