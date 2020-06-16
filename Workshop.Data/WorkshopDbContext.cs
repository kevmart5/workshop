using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Workshop.Core;

namespace Workshop.Data
{
    public class WorkshopDbContext : DbContext
    {
        public DbSet<Car> Cars { set; get; }

        public WorkshopDbContext(DbContextOptions<WorkshopDbContext> options): base(options)
        {

        }
    }
}
