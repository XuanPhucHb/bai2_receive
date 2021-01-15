using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawlerReceive
{
    class MyDbContext : DbContext
    {
        public MyDbContext() : base("CrawReceivecontext")
        {

        }
        public DbSet<Member> Members { get; set; }
    }
}
