using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace BudgetManagerApp.Data
{
    public class DataContext : DbContext
    {

        public DataContext()
        {

        }

        public DataContext(  DbContextOptions<DataContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
