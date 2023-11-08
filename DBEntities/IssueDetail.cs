using System;
using System.Collections.Generic;

namespace TicketingSystem.DBEntities
{
    public partial class IssueDetail
    {
        public IssueDetail()
        {
            IssueDetailsLogs = new HashSet<IssueDetailsLog>();
        }

        public int IssueDetailsId { get; set; }
        public string IssueDescription { get; set; }
        public int ProjectId { get; set; }
        public int ServerityId { get; set; }
        public int IssueStatusId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ResolvedDate { get; set; }
        public DateTime? ClosedDate { get; set; }
        public string EnvironmentType { get; set; }

        public virtual IssueStatus IssueStatus { get; set; }
        public virtual Project Project { get; set; }
        public virtual Serverity Serverity { get; set; }
        public virtual ICollection<IssueDetailsLog> IssueDetailsLogs { get; set; }
    }
}
