using System.ComponentModel.DataAnnotations;

namespace TicketingSystem.Models
{
    public class IssueDetailsModel
    {
        public int IssueDetailsId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "This feild is requirmet")]
        public string IssueDescription { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "This feild is requirmet")]
        public int ProjectId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "This feild is requirmet")]
        public int ServerityId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "This feild is requirmet")]
        public int IssueStatusId { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime? ResolvedDate { get; set; }
        public DateTime? ClosedDate { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "This feild is requirmet")]
        public string EnvironmentType { get; set; }

        public string ProjectName { get; set; }
        public string ServerityName { get; set; }
        public string IssueStatusName { get; set; }


    }
}
