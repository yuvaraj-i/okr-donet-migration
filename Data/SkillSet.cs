using System;
using System.Collections.Generic;

namespace helloWorld.Data
{
    public partial class SkillSet
    {
        public SkillSet()
        {
            UserSkillMappings = new HashSet<UserSkillMapping>();
        }

        public int SkillId { get; set; }
        public string SkillDescription { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<UserSkillMapping> UserSkillMappings { get; set; }
    }
}
