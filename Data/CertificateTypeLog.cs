using System;
using System.Collections.Generic;

namespace helloWorld.Data
{
    public partial class CertificateTypeLog
    {
        public int CertificateTypeLogId { get; set; }
        public int UserId { get; set; }
        public int OldIssuerId { get; set; }
        public string? OldIssuerName { get; set; }
        public int NewIssuerId { get; set; }
        public string? NewIssuerName { get; set; }
        public int OldTypeId { get; set; }
        public string? OldTypeName { get; set; }
        public int NewTypeId { get; set; }
        public string? NewTypeName { get; set; }
        /// <summary>
        /// It can be changed, renamed or unchanged.
        /// </summary>
        public string CertificateStatus { get; set; } = null!;
        /// <summary>
        /// It can be changed, renamed or unchanged.
        /// </summary>
        public string IssuerStatus { get; set; } = null!;
        public DateTime ActionDate { get; set; }
        public int? IsDeleted { get; set; }

        public virtual CertificateIssuer NewIssuer { get; set; } = null!;
        public virtual CertificateTypeDetail NewType { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
