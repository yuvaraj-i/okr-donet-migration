using System;
using helloWorld.Data;
using helloWorld.Repositories;

namespace helloWorld.Services
{
	public class DashboardService : IDashboardService
    {
        private readonly IDashboardReposistory _dashboardReposistory;

        public DashboardService(IDashboardReposistory dashboardReposistory)
		{
            _dashboardReposistory = dashboardReposistory;
        }

        public List<ActivityLog> getAllActivity(int page)
        {
            List<ActivityLog> activityList = new List<ActivityLog>();

            return activityList;
        }
    }
}

