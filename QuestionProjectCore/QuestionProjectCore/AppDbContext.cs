using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Options;
using QuestionProjectCore.Models;

namespace QuestionProjectCore
{

    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Answer>()
                .HasOne(q => q.question)
                .WithMany(a => a.Answers)
                .OnDelete(DeleteBehavior.NoAction);


            modelBuilder.Entity<Answer>()
                .HasOne(u => u.member)
                .WithMany(a => a.answers)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Admin",
                    NormalizedName = "admin",
                    ConcurrencyStamp = Guid.NewGuid().ToString()
                },

                new IdentityRole()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "User",
                    NormalizedName = "user",
                    ConcurrencyStamp = Guid.NewGuid().ToString()
                });

            //foreach(var relationShip in modelBuilder.Model.GetEntityTypes()
            //    .SelectMany(e=>e.GetForeignKeys()))
            //{
            //    relationShip.DeleteBehavior = DeleteBehavior.NoAction;
        }
        public DbSet<Member> Members { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Moderator> Moderators { get; set; }
    }
    public class YourDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer(Connections.sqlConnectionString);

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}
