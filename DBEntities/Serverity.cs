using System;
using System.Collections.Generic;

namespace TicketingSystem.DBEntities
{
    public partial class Serverity
    {
        public Serverity()
        {
            IssueDetails = new HashSet<IssueDetail>();
        }

        public int ServerityId { get; set; }
        public string ServerityName { get; set; }
        public int? ResponseTims { get; set; }

        public virtual ICollection<IssueDetail> IssueDetails { get; set; }
    }
}
