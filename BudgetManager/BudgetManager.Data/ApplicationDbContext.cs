namespace BudgetManager.Data
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models.Entities;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("BudgetManagerContext", throwIfV1Schema: false)
        {
        }

        // public virtual DbSet<MyEntity> MyEntities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}