using GroceriesListApi.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace GroceriesListApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        private Microsoft.Extensions.Configuration.IConfiguration configuration;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, Microsoft.Extensions.Configuration.IConfiguration iconfig)
            : base(options)
        {
            configuration = iconfig;
        }
        public DbSet<GroceriesList> GroceriesList { get; set; }
        public DbSet<ListItem> ListItem { get; set; }
        public DbSet<Category> Category { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(configuration.GetValue<string>("ConnectionStrings:DefaultConnection"));
        }
    }
}
