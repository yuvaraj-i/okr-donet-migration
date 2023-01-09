using System;
using System.Collections.Generic;

namespace helloWorld.Data
{
    public partial class CertificateIssuer
    {
        public CertificateIssuer()
        {
            CertificateTypeDetails = new HashSet<CertificateTypeDetail>();
            CertificateTypeLogs = new HashSet<CertificateTypeLog>();
        }

        public int IssuerId { get; set; }
        public string? IssuerName { get; set; }
        public int? IsDeleted { get; set; }

        public virtual ICollection<CertificateTypeDetail> CertificateTypeDetails { get; set; }
        public virtual ICollection<CertificateTypeLog> CertificateTypeLogs { get; set; }
    }
}
