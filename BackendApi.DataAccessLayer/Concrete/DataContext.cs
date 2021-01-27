using System;
using System.Collections.Generic;
using System.Text;
using BackendApi.Model.Entity;
using Microsoft.EntityFrameworkCore;

namespace BackendApi.DataAccessLayer.Concrete
{
    public class DataContext : DbContext
    {
        public DbSet<Person> Person { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DENIZ-PC\MSSQLSERVER_1;Database=NsWagDB;Integrated Security=true");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
