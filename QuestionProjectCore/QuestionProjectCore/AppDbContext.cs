using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Options;
using QuestionProjectCore.Models;

namespace QuestionProjectCore
{

    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Answer>()
                .HasOne(q => q.question)
                .WithMany(a => a.Answers)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<ApplicationUser>().ToTable("Users");
            modelBuilder.Entity<IdentityRole>().ToTable("Roles");
            modelBuilder.Entity<IdentityUserRole<string>>().ToTable("UserRoles");
            modelBuilder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims");
            modelBuilder.Entity<IdentityUserLogin<string>>().ToTable("UserLogins");
            modelBuilder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaims");
            modelBuilder.Entity<IdentityUserToken<string>>().ToTable("UserTokens");


            //modelBuilder.Entity<Answer>()
            //    .HasOne(u => u.member)
            //    .WithMany(a => a.answers)
            //    .OnDelete(DeleteBehavior.NoAction);

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
                    Name = "Member",
                    NormalizedName = "member",
                    ConcurrencyStamp = Guid.NewGuid().ToString()
                });
            base.OnModelCreating(modelBuilder);

            //foreach(var relationShip in modelBuilder.Model.GetEntityTypes()
            //    .SelectMany(e=>e.GetForeignKeys()))
            //{
            //    relationShip.DeleteBehavior = DeleteBehavior.NoAction;
        }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
    //public class YourDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    //{
    //    public AppDbContext CreateDbContext(string[] args)
    //    {
    //        var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
    //        optionsBuilder.UseSqlServer(Connections.sqlConnectionString);

    //        return new AppDbContext(optionsBuilder.Options);
    //    }
    //}
}
