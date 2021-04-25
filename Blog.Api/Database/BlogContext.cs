using Blog.Api.Configuration;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Api.Database
{
    public partial class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions options)
            : base(options)
        {
           
        }

        public DbSet<Post> Posts { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BlogConfiguration());
        }




    }
}
