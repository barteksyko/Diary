using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using WpfApp1.Models.Configurations;
using WpfApp1.Models.Domains;
using WpfApp1.Properties;

namespace WpfApp1
{
    public class ApplicationDbContext : DbContext
    {
        private static string _connectionString = $@"Server={Settings.Default.ServerAddress}\{Settings.Default.ServerName};Database={Settings.Default.Database};User Id={Settings.Default.User};Password={Settings.Default.Password};";

        public ApplicationDbContext()
            : base(_connectionString)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new StudentConfiguration());
            modelBuilder.Configurations.Add(new GroupConfiguration());
            modelBuilder.Configurations.Add(new RatingConfiguration());
        }
    }
}
