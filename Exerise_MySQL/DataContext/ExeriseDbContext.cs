using System;
using Microsoft.EntityFrameworkCore;
using Exerise_MySQL.Models;

namespace Exerise_MySQL.DataContext
{
    public class ExeriseDbContext:DbContext
    {
        public ExeriseDbContext(DbContextOptions<ExeriseDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public virtual DbSet<Account> Account { get; set; }
    }
}
