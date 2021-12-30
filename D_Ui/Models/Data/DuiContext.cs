using D_Ui.Models.Data.Entity;
using D_Ui.Models.Domain.Auth;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace D_Ui.Models.Data
{
    public class DuiContext:IdentityDbContext<ApplicationUser>
    {
        public DuiContext(DbContextOptions<DuiContext> option) : base(option)
        {

        }
        public virtual DbSet<Event> Event { get; set; }
        public virtual DbSet<EventApplication> EventApplication { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            FixedData.SeedData(modelBuilder);
        }
    }
}
