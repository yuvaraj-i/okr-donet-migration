using System;
using System.Collections.Generic;

namespace helloWorld.Data
{
    public partial class QuarterlyDetail
    {
        public string QuarterPeriod { get; set; } = null!;
        public string QuarterYear { get; set; } = null!;
        public int? ObjectiveCount { get; set; }
        public int? KeyResultCount { get; set; }
        public int? OkrScore { get; set; }
    }
}
