using GTR_OKR.Models;
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
        public DbSet<ProjTempRelation> projTempRelations { get; set; }
        public DbSet<Tasks> Tasks { get; set; }
        public DbSet<UserProjectAssign> UserProjectAssigns { get; set; }
        public DbSet<UserTaskAssign> UserTaskAssigns { get; set; }
        public DbSet<Template> Templates { get; set; }
        public DbSet<Understanding> Understandings { get; set; }
        public DbSet<UserTempAssign> UserTempAssigns { get; set; }
    }
}
