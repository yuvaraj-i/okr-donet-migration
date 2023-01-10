using System;
using helloWorld.Data;

namespace helloWorld.Services
{
	public interface IDashboardService
	{
        public List<ActivityLog> getAllActivity(int page);

    }
}

