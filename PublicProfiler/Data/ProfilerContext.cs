using Microsoft.EntityFrameworkCore;
using PublicProfiler.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace PublicProfiler.Data
{
    public class ProfilerContext :DbContext
    {

        public ProfilerContext(DbContextOptions<ProfilerContext> options)
            : base(options)
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //   optionsBuilder.UseSqlServer("Data Source-blog.db");
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Blog>().HasOne<Author>(p => p.Author).WithMany(p => p.Blogs);

            modelBuilder.Entity<Author>().HasMany<Blog>(p => p.Blogs).WithOne(p => p.Author);

        }

        //Here we created classes for the Models we added - These are the databases that will get created 
        public DbSet<User> User { get; set; } 
        public DbSet<Social> Social  { get; set; }
        public DbSet<Blog> Blog { get; set; }
        public DbSet<Post> Post { get; set; }
        public DbSet<Author> Author { get; set; }



    }
}

