using System;
using helloWorld.Common;

namespace helloWorld.Models
{
	public class AccomplishmentRequest
	{
        public string accomplishmentTitle { get; set; }
        public string accomplishmentDescription { get; set; }
        public DateTime accomplishedDate { get; set; }
	}

    public class EditAccomplishmentRequest
    {
        public int accomplishmentId { get; set; }
        public string accomplishmentTitle { get; set; }
        public string accomplishmentDescription { get; set; }
        public DateTime accomplishedDate { get; set; }
    }
}

