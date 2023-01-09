using System;
using System.Collections.Generic;

namespace helloWorld.Data
{
    public partial class AssessmentPeriod
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public int Quarter { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
