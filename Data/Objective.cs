using System;
using System.Collections.Generic;

namespace helloWorld.Data
{
    public partial class Objective
    {
        public Objective()
        {
            AbandonedObjectives = new HashSet<AbandonedObjective>();
            KeyResults = new HashSet<KeyResult>();
        }

        public int Id { get; set; }
        public string Title { get; set; } = null!;
        /// <summary>
        /// It can be user id, team id or company id.
        /// </summary>
        public int ParentId { get; set; }
        /// <summary>
        /// It can be user, team or company.
        /// </summary>
        public string ParentType { get; set; } = null!;
        public int AssessmentPeriodId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal Score { get; set; }
        public int PercentageDone { get; set; }
        public int NoOfComments { get; set; }
        public string Status { get; set; } = null!;
        public DateTime? UpdatedDate { get; set; }
        public int? IsDeleted { get; set; }
        public string? QuarterPeriod { get; set; }
        public string? QuarterYear { get; set; }

        public virtual ICollection<AbandonedObjective> AbandonedObjectives { get; set; }
        public virtual ICollection<KeyResult> KeyResults { get; set; }
    }
}
