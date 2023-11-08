using System;
using System.Collections.Generic;

namespace TicketingSystem.DBEntities
{
    public partial class IssueDetailsLog
    {
        public int IssueDetailsLog1 { get; set; }
        public int IssueDetailsId { get; set; }
        public int IssueStatusId { get; set; }
        public DateTime ActionDate { get; set; }

        public virtual IssueDetail IssueDetails { get; set; }
        public virtual IssueStatus IssueStatus { get; set; }
    }
}
