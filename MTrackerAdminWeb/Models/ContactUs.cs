using System.ComponentModel.DataAnnotations;

namespace MTrackerAdminWeb.Models
{
    public class ContactUs
    {   
        [Key]
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Contact_No { get; set; }
        public string? Message { get; set; }
    }
}
