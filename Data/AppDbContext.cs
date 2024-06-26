﻿using Microsoft.EntityFrameworkCore;
using MicrosoftEntityFramework.Model;

namespace MicrosoftEntityFramework.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            String connectionString = $"Server=localhost;Port=3306;Database=test;UID=root;PWD={Config.Load().password}";
            ServerVersion serverVersion = new MariaDbServerVersion(new Version(10, 3, 39));
            optionsBuilder.UseMySql(connectionString, serverVersion);
        }
    }
}