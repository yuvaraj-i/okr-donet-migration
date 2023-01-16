using System;
namespace helloWorld.Models
{
	public class ActivityLog
	{
		public Guid id { get; set; }
		public User user { get; set; }
		public string acctivityAction {get; set; }
		public string topicType { get; set; }
		public DateTime date { get; set; }
    }
}

