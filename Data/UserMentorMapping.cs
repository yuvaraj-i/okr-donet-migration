using System;
using System.Collections.Generic;

namespace helloWorld.Data
{
    public partial class UserMentorMapping
    {
        public int MentorId { get; set; }
        public int MenteeId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsDeleted { get; set; }

        public virtual User Mentee { get; set; } = null!;
        public virtual User Mentor { get; set; } = null!;
    }
}
