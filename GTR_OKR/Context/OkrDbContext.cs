using GTR_OKR.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace GTR_OKR.Context
{
    public class OkrDbContext : DbContext
    {
        public OkrDbContext(DbContextOptions options) :base(options)
        {
            
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Tasks> Tasks { get; set; }
        public DbSet<Template> Templates { get; set; }
        public DbSet<Understanding> Understandings { get; set; }
        public DbSet<ProjTempRelation> ProjTempRelations { get; set; }
        public DbSet<UserProjectAssign> UserProjectAssigns { get; set; }
        public DbSet<UserTempAssign> UserTempAssigns { get; set; }
        public DbSet<UserTaskAssign> UserTaskAssigns { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProjTempRelation>()
                .HasKey(pc=> new {pc.PId, pc.TempId});
            modelBuilder.Entity<ProjTempRelation>()
                .HasOne(p => p.Project)
                .WithMany(pt => pt.PTemplates)
                .HasForeignKey(c=>c.TempId);
            modelBuilder.Entity<ProjTempRelation>()
                .HasOne(p => p.Template)
                .WithMany(pt => pt.PTemplates)
                .HasForeignKey(c=>c.PId);

            modelBuilder.Entity<UserProjectAssign>()
                .HasKey(pc => new { pc.PId, pc.UserId });
            modelBuilder.Entity<UserProjectAssign>()
                .HasOne(p => p.Project)
                .WithMany(pt => pt.UserProjects)
                .HasForeignKey(c => c.UserId);
            modelBuilder.Entity<UserProjectAssign>()
                .HasOne(p => p.User)
                .WithMany(pt => pt.UserProjects)
                .HasForeignKey(c => c.PId);

            modelBuilder.Entity<UserTaskAssign>()
                .HasKey(pc => new { pc.TaskId, pc.UserId });
            modelBuilder.Entity<UserTaskAssign>()
                .HasOne(p => p.User)
                .WithMany(pt => pt.UserTasks)
                .HasForeignKey(c => c.TaskId);
            modelBuilder.Entity<UserTaskAssign>()
                .HasOne(p => p.Tasks)
                .WithMany(pt => pt.UserTasks)
                .HasForeignKey(c => c.UserId);

            modelBuilder.Entity<UserTempAssign>()
                .HasKey(pc => new { pc.TempId, pc.UserId });
            modelBuilder.Entity<UserTempAssign>()
                .HasOne(p => p.User)
                .WithMany(pt => pt.UserTemps)
                .HasForeignKey(c => c.TempId);
            modelBuilder.Entity<UserTempAssign>()
                .HasOne(p => p.Template)
                .WithMany(pt => pt.UserTemps)
                .HasForeignKey(c => c.UserId);
        }
    }
}
