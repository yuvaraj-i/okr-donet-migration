using System;
using helloWorld.Models;

namespace helloWorld.Services
{
	public interface IDashboardService
	{
        public List<ActivityLog> getAllActivity(int userId);
        public List<ActivityLog> getAllActivity(int page, int userId);

    }
}

