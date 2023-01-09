using System;
using System.Collections.Generic;

namespace helloWorld.Data
{
    public partial class Accomplishment
    {
        public Accomplishment()
        {
            CertificateAccomplishmentMappings = new HashSet<CertificateAccomplishmentMapping>();
        }

        public int AccomplishmentId { get; set; }
        public int AccomplishedBy { get; set; }
        public int CreatedBy { get; set; }
        public int? LastModifiedBy { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime? AccomplishedDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsDeleted { get; set; }
        public string Type { get; set; } = null!;

        public virtual User AccomplishedByNavigation { get; set; } = null!;
        public virtual User CreatedByNavigation { get; set; } = null!;
        public virtual ICollection<CertificateAccomplishmentMapping> CertificateAccomplishmentMappings { get; set; }
    }
}
