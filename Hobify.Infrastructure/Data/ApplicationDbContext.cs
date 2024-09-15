using Hobify.Core.Entity;
using Hobify.Core.Entity.Security;
using Microsoft.EntityFrameworkCore;

namespace Hobify.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }


        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Events> Events { get; set; }
        public DbSet<ChatRoom> ChatRooms { get; set; }
        public DbSet<ForumTopic> ForumTopics { get; set; }


        //Security
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppRole> AppRoles { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Entity configurations
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.id);
                entity.Property(e => e.username).IsRequired().HasMaxLength(100);
                entity.Property(e => e.email).IsRequired().HasMaxLength(100);
                entity.Property(e => e.password).IsRequired();
            });

            modelBuilder.Entity<Post>(entity =>
            {
                entity.HasKey(e => e.id);
                entity.Property(e => e.title).IsRequired().HasMaxLength(200);
                entity.Property(e => e.content).IsRequired();
                entity.Property(e => e.createdAt).HasDefaultValue(DateTime.UtcNow);
                entity.Property(e => e.updatedAt).HasDefaultValue(DateTime.UtcNow);
                entity.HasOne(e => e.user)
                      .WithMany(u => u.posts)
                      .HasForeignKey(e => e.userId)
                      .OnDelete(DeleteBehavior.Restrict);
                entity.HasOne(e => e.subCategory)
                      .WithMany(c => c.posts)
                      .HasForeignKey(e => e.subCategoryId);
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.HasKey(e => e.id);
                entity.Property(e => e.content).IsRequired();
                entity.Property(e => e.createdAt).HasDefaultValue(DateTime.UtcNow);
                entity.HasOne(e => e.post)
                      .WithMany(p => p.comments)
                      .HasForeignKey(e => e.postId)
                      .OnDelete(DeleteBehavior.Cascade);
                entity.HasOne(e => e.user)
                      .WithMany(u => u.comments)
                      .HasForeignKey(e => e.userId)
                      .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.id);
                entity.Property(e => e.name).IsRequired().HasMaxLength(100);
                entity.Property(e => e.description).HasMaxLength(1000);
                entity.Property(e => e.createdAt).HasDefaultValue(DateTime.UtcNow);
                entity.Property(e => e.updatedAt).HasDefaultValue(DateTime.UtcNow);
            });

            modelBuilder.Entity<SubCategory>(entity =>
            {
                entity.HasKey(e => e.id);
                entity.Property(e => e.name).IsRequired().HasMaxLength(100);
                entity.Property(e => e.description).HasMaxLength(1000);
                entity.Property(e => e.createdAt).HasDefaultValue(DateTime.UtcNow);
                entity.Property(e => e.updatedAt).HasDefaultValue(DateTime.UtcNow);
                entity.HasOne(e => e.category)
                      .WithMany(c => c.subCategories)
                      .HasForeignKey(e => e.categoryId);
            });

            modelBuilder.Entity<Events>(entity =>
            {
                entity.HasKey(e => e.id);
                entity.Property(e => e.title).IsRequired().HasMaxLength(200);
                entity.Property(e => e.description).HasMaxLength(1000);
                entity.Property(e => e.startDate).IsRequired();
                entity.Property(e => e.endDate).IsRequired();
                entity.Property(e => e.createdAt).HasDefaultValue(DateTime.UtcNow);
                entity.HasOne(e => e.subCategory)
                      .WithMany(u => u.events)
                      .HasForeignKey(e => e.subCategoryId);
            });

            modelBuilder.Entity<ChatRoom>(entity =>
            {
                entity.HasKey(e => e.id);
                entity.Property(e => e.name).IsRequired().HasMaxLength(100);
                entity.Property(e => e.createdAt).HasDefaultValue(DateTime.UtcNow);
               
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.id);
                entity.Property(e => e.name).IsRequired().HasMaxLength(200);
                entity.Property(e => e.description).HasMaxLength(1000);
                entity.Property(e => e.price).IsRequired().HasColumnType("decimal(18,2)");
                entity.Property(e => e.createdAt).HasDefaultValue(DateTime.UtcNow);
                entity.HasOne(e => e.subCategories)
                      .WithMany(c => c.products)
                      .HasForeignKey(e => e.subCategoryId);
                entity.HasOne(e => e.user)
                      .WithMany(u => u.products)
                      .HasForeignKey(e => e.userId)
                      .OnDelete(DeleteBehavior.Restrict);
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
