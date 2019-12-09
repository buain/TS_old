using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSystem.DAL.Entities;

namespace TestSystem.DAL.DB
{
    public class TestContext : DbContext
    {
        public DbSet<Test> Tests { get; set; }    
    }
}
