using System;
using System.Collections.Generic;

namespace TicketingSystem.DBEntities
{
    public partial class IssueStatus
    {
        public IssueStatus()
        {
            IssueDetails = new HashSet<IssueDetail>();
            IssueDetailsLogs = new HashSet<IssueDetailsLog>();
        }

        public int IssueStatusId { get; set; }
        public string IssueStatusName { get; set; }

        public virtual ICollection<IssueDetail> IssueDetails { get; set; }
        public virtual ICollection<IssueDetailsLog> IssueDetailsLogs { get; set; }
    }
}
