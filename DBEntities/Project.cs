using System;
using System.Collections.Generic;

namespace TicketingSystem.DBEntities
{
    public partial class Project
    {
        public Project()
        {
            IssueDetails = new HashSet<IssueDetail>();
        }

        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public DateTime DeliverDate { get; set; }
        public string ClientName { get; set; }
        public string ClientContactPerson { get; set; }
        public bool IsUnderSupport { get; set; }

        public virtual ICollection<IssueDetail> IssueDetails { get; set; }
    }
}
