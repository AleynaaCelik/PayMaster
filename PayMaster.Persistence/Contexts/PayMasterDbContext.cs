using Microsoft.EntityFrameworkCore;
using PayMaster.Domain.Entities;

namespace PayMaster.Persistence.Contexts
{
    public class PayMasterDbContext : DbContext
    {
        public PayMasterDbContext(DbContextOptions<PayMasterDbContext> options)
           : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<Bill> Bills { get; set; }


        //Override işlemleri gelebilir
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Ek yapılandırmalar burada yapılabilir
        }
    }
}