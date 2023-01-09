using System;
using System.Collections.Generic;

namespace helloWorld.Data
{
    public partial class CertificateTypeDetail
    {
        public CertificateTypeDetail()
        {
            CertificateDetails = new HashSet<CertificateDetail>();
            CertificateTypeLogs = new HashSet<CertificateTypeLog>();
        }

        public int CertificateTypeId { get; set; }
        public int IssuerId { get; set; }
        public string? CertificateTypeName { get; set; }
        public int? IsDeleted { get; set; }

        public virtual CertificateIssuer Issuer { get; set; } = null!;
        public virtual ICollection<CertificateDetail> CertificateDetails { get; set; }
        public virtual ICollection<CertificateTypeLog> CertificateTypeLogs { get; set; }
    }
}
