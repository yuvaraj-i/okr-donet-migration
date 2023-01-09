using System;
using System.Collections.Generic;

namespace helloWorld.Data
{
    public partial class KeyResult
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public int ParentObjectiveId { get; set; }
        public string KeyResultType { get; set; } = null!;
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

        public virtual Objective ParentObjective { get; set; } = null!;
    }
}
