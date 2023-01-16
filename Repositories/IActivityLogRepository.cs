using System;
using helloWorld.Models;

namespace helloWorld.Repositories
{
    public interface IActivityLogRepository
    {
        List<ActivityLog> getUserActivityLog(int userId);
        List<ActivityLog> getUserActivityLogsByLimit(int page, int userId, int skipLimit);
        void addUserActivityLog(ActivityLog activityLog);
    }
}

