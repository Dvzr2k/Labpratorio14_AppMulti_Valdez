using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Laboratorio14DesAppMulti_Valdez.Models

namespace Laboratorio14DesAppMulti_Valdez.DataContext
{
    public class AppDbContext: DbContext
    {
        string DbPath = string.Empty;

        public DbSet<Student> Students { get; set; }

        public AppDbContext(string dbPath)
        {
            this.DbPath = dbPath;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={DbPath}");
        }
    }
}
