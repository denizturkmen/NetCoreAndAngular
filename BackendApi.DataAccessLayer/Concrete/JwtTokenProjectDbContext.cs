using System;
using System.Collections.Generic;
using System.Text;
using BackendApi.Model.Jwt.Dto;
using BackendApi.Model.Jwt.Entity;
using Microsoft.EntityFrameworkCore;

namespace BackendApi.DataAccessLayer.Concrete
{
    public class JwtTokenProjectDbContext : DbContext
    {
        public JwtTokenProjectDbContext()
        {
        }

        public JwtTokenProjectDbContext(DbContextOptions<JwtTokenProjectDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DENIZ-PC\MSSQLSERVER_1;Database=JwtDB;Integrated Security=true");

        }

        public DbSet<OperationClaim> OperationClaim { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaim { get; set; }
    }
}
