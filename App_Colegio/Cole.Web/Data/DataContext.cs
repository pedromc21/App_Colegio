namespace Cole.Web.Data.Entities
{
    using Microsoft.EntityFrameworkCore;
    public class DataContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
    }
}
