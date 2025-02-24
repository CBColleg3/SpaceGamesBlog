﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SpaceBlogBackend.Models.Blog;

namespace SpaceBlogBackend.Helpers
{
    public class DataContext: DbContext
    {

        protected readonly IConfiguration Configuration;

        public DataContext(IConfiguration configuration)
        {
            Configuration = configuration;
        } 

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // in memory database used for simplicity, change to a real db for production applications
            options.UseNpgsql(Configuration.GetConnectionString("postgresDatabase"));
        }
    }
}
