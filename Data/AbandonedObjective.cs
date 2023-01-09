using System;
using System.Collections.Generic;

namespace helloWorld.Data
{
    public partial class AbandonedObjective
    {
        public int Id { get; set; }
        public int ObjectiveId { get; set; }
        public string Reason { get; set; } = null!;

        public virtual Objective Objective { get; set; } = null!;
    }
}
