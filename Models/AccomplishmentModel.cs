using System;
using System.ComponentModel.DataAnnotations;
using helloWorld.Common;

namespace helloWorld.Models
{
	public class AccomplishmentModel
	{
        [Key]
        public Guid id { get; set; }
		public User User { get; set; }
		public string accomplishmentTitle { get; set; }
        public string accomplishmentDescription { get; set; }
        public DateTime accomplishedDate { get; set; }
        public AccomplishmentType accomplishmentType { get; set; }
    }

}

