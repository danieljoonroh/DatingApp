using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    public class DataContext : DbContext  // DbContext sends query to the database via Entity Framework
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}

        public DbSet<Value> Values { get; set; }

        public DbSet<User> Users { get; set; }  // whenever we add a new class, we need to add a new migration and add it to the database  'dotnet ef migrations add AddedUserEntity' then 'dotnet ef database update'

        public DbSet<Photo> Photos { get; set; }

        public DbSet<Like> Likes { get; set; }  // creating a new table in dataset for the likes

        protected override void OnModelCreating(ModelBuilder builder)  // overriding like table, then creating a new migration for this so entity framework can know this and database will be updated
        {
            builder.Entity<Like>()
                .HasKey(k => new { k.LikerId, k.LikeeId });

            builder.Entity<Like>()
                .HasOne(u => u.Likee)
                .WithMany(u => u.Likers)
                .HasForeignKey(u => u.LikeeId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Like>()
                .HasOne(u => u.Liker)
                .WithMany(u => u.Likees)
                .HasForeignKey(u => u.LikerId)
                .OnDelete(DeleteBehavior.Restrict);


        }

        // now we can create a method in the controller and repository once the datbase has been updated with the likes table

    }
}