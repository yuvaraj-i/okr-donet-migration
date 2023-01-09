using System;
using System.Collections.Generic;

namespace helloWorld.Data
{
    public partial class Membership
    {
        public int Id { get; set; }
        public int TeamsId { get; set; }
        public string Roles { get; set; } = null!;
        public int UsersId { get; set; }

        public virtual Team Teams { get; set; } = null!;
        public virtual User Users { get; set; } = null!;
    }
}
