using System.ComponentModel.DataAnnotations;

namespace MTrackerAdminWeb.Models
{
    public class Organization
    {
        [Key]
        public int OrgID { get; set; }
        public string? OrgName { get; set; }
        public string? OrgEmail { get; set; }
        public string? OrgContact { get; set; }
        public string? OrgAddress { get; set; }
        public string? GST { get; set; }
        public string? State { get; set; }
        public string? City { get; set; }
        public string? Zip { get; set; }
    }
}
