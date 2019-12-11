namespace Cole.Web.Data.Entities
{
    using Microsoft.EntityFrameworkCore;
    public class DataContext : DbContext
    {
        //public DbSet<Alumno> Alumnos { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
    }
}
