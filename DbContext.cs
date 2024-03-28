using Microsoft.EntityFrameworkCore;
using System;

namespace AzureDevopsQuiz4
{
    public class MyDbContext : DbContext
    {
        public DbSet<DbModel> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=MyDatabase;Trusted_Connection=True;");
        }
    }
    using (var context = new MyDbContext())
{
    var dbModel = context.Users.ToList();
}
}



