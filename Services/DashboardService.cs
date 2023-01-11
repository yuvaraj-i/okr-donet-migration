using System;

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

        public List<string> getAllActivity(int page)
        {
            List<string> activityList = new List<string>();

            return activityList;
        }
    }
}

