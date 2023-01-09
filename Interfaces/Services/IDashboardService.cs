using System;
using helloWorld.Data;

namespace helloWorld.Interfaces
{
	public interface IDashboardService
	{
        public List<ActivityLog> getAllActivity(int page);

    }
}

