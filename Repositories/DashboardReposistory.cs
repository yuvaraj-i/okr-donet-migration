using System;
using helloWorld.DBContex;

namespace helloWorld.Repositories
{
    public class DashboardReposistory : IDashboardReposistory
    {
        private readonly AppDbContex _DbContext;

        public DashboardReposistory(AppDbContex okr_DbContext)
        {
            _DbContext = okr_DbContext;

        }
    }
}

