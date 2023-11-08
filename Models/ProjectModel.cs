using System.ComponentModel.DataAnnotations;
using TicketingSystem.DBEntities;

namespace TicketingSystem.Models
{
    public class ProjectModel
    {
        public int ProjectId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "This feild is requirmet")]
        public string ProjectName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "This feild is requirmet")]
        public DateTime DeliverDate { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "This feild is requirmet")]
        public string ClientName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "This feild is requirmet")]
        public string ClientContactPerson { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "This feild is requirmet")]
        public bool IsUnderSupport { get; set; }

        
    }
}
