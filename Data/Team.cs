using System;
using System.Collections.Generic;

namespace helloWorld.Data
{
    public partial class Team
    {
        public Team()
        {
            Memberships = new HashSet<Membership>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Status { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
        public int CompanyId { get; set; }
        /// <summary>
        /// It will be the user id of the manager
        /// </summary>
        public int? ManagerId { get; set; }
        /// <summary>
        /// number of members in the team
        /// </summary>
        public int? TeamCount { get; set; }
        /// <summary>
        /// for soft delete of teams
        /// </summary>
        public int? IsDeleted { get; set; }

        public virtual ICollection<Membership> Memberships { get; set; }
    }
}
