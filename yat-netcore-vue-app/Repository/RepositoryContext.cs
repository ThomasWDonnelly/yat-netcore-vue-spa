using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using YatVueApp.Model;

namespace YatVueApp.Repository
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options)
         : base(options)
        {}

        public DbSet<Product> Products { get; set; }
    }
}