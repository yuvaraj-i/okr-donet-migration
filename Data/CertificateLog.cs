using System;
using System.Collections.Generic;

namespace helloWorld.Data
{
    public partial class CertificateLog
    {
        public int CertificateLogsId { get; set; }
        public int CertificateId { get; set; }
        public int? ApproverId { get; set; }
        public DateTime ActionDate { get; set; }
        /// <summary>
        /// It can be approved ,declined ,created ,edited ,deleted.
        /// </summary>
        public string ActionStatus { get; set; } = null!;
    }
}
