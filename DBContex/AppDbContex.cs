using System;
using helloWorld.Datas;
using helloWorld.Models;
using Microsoft.EntityFrameworkCore;

namespace helloWorld.DBContex
{
	public class AppDbContex: DbContext
    {
        public AppDbContex() { }

        public AppDbContex(DbContextOptions<AppDbContex> options): base(options)
        {

        }

        public DbSet<Skill> skills { get; set; }
        public DbSet<SkillSetMapping> skillSetMappings { get; set; }
        public DbSet<User> users { get; set; }

    }

}