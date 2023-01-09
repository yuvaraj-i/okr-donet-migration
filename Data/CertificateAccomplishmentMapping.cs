using System;
using System.Collections.Generic;

namespace helloWorld.Data
{
    public partial class CertificateAccomplishmentMapping
    {
        public int CertificateAccomplishmentMappingId { get; set; }
        public int CertificateId { get; set; }
        public int AccomplishmentId { get; set; }

        public virtual Accomplishment Accomplishment { get; set; } = null!;
        public virtual CertificateDetail Certificate { get; set; } = null!;
    }
}
