using System;
using Microsoft.EntityFrameworkCore;

namespace helloWorld.DBContex
{
	public class AppDbContex: DbContext
    {
        public AppDbContex(DbContextOptions<DbContext> options): base(options)
        {

        }

    }


}

