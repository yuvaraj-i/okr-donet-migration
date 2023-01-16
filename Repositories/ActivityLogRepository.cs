using System;
using helloWorld.DBContex;
using helloWorld.Models;

namespace helloWorld.Repositories
{
	public class ActivityLogRepository : IActivityLogRepository
	{
        private readonly AppDbContex _DbContext;
        private readonly int LIMIT = 10;

        public ActivityLogRepository(AppDbContex DbContext)
		{
            _DbContext = DbContext;
        }

        public void addUserActivityLog(ActivityLog activityLog)
        {
            _DbContext.activityLogs.Add(activityLog);
            _DbContext.SaveChanges();
        }

        public List<ActivityLog> getUserActivityLog(int userId)
        {
           return _DbContext.activityLogs.Where(s => s.user.id == userId).ToList();
        }

        public List<ActivityLog> getUserActivityLogsByLimit(int page, int userId, int skipLimit)
        {
            return _DbContext.activityLogs.Where(s => s.user.id == userId).OrderByDescending(s => s.date).Skip(skipLimit).Take(LIMIT).ToList();
        }
    }
}

