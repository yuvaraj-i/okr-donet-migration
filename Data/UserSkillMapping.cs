using System;
using System.Collections.Generic;

namespace helloWorld.Data
{
    public partial class UserSkillMapping
    {
        public int SkillId { get; set; }
        public int UserId { get; set; }
        public int Rating { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsDeleted { get; set; }

        public virtual SkillSet Skill { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
