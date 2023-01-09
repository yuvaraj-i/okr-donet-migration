using System;
using helloWorld.Data;
using helloWorld.Interfaces;
using helloWorld.Interfaces.Reposistory;

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
            List<ActivityLog> activityList = _dashboardReposistory.getAllActivity(page);

            return activityList;
        } 
    }
}

