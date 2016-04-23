using System.Data.Entity;

namespace SkilltreeMvcHomework.Models
{
    public class HomeworkDbContext : DbContext
    {
        public HomeworkDbContext()
            : base("name=HomeworkDbContext")
        {
        }

        public virtual DbSet<AccountBook> AccountBook { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}