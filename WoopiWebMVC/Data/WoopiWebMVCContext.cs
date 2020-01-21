using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WoopiWebMVC.Models;

namespace WoopiWebMVC.Data
{
    public class WoopiWebMVCContext : DbContext
    {
        public WoopiWebMVCContext (DbContextOptions<WoopiWebMVCContext> options)
            : base(options)
        {
        }

        public DbSet<WoopiWebMVC.Models.Department> Department { get; set; }
    }
}
