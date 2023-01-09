using System;
using System.Collections.Generic;

namespace helloWorld.Data
{
    public partial class ApplicationSetting
    {
        public int Id { get; set; }
        public string Description { get; set; } = null!;
        public bool Value { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int LastModifiedBy { get; set; }

        public virtual User LastModifiedByNavigation { get; set; } = null!;
    }
}
