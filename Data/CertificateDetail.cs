using System;
using System.Collections.Generic;

namespace helloWorld.Data
{
    public partial class CertificateDetail
    {
        public CertificateDetail()
        {
            CertificateAccomplishmentMappings = new HashSet<CertificateAccomplishmentMapping>();
        }

        public int CertificateId { get; set; }
        public int UserId { get; set; }
        public int CertificateTypeId { get; set; }
        public DateTime CertifiedDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string VerificationId { get; set; } = null!;
        public string Status { get; set; } = null!;
        public DateTime? CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string? Reason { get; set; }
        public int? IsDeleted { get; set; }

        public virtual CertificateTypeDetail CertificateType { get; set; } = null!;
        public virtual User User { get; set; } = null!;
        public virtual ICollection<CertificateAccomplishmentMapping> CertificateAccomplishmentMappings { get; set; }
    }
}
