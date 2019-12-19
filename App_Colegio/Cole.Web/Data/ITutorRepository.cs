namespace Cole.Web.Data
{
    using Entities;
    using System.Linq;

    public interface ITutorRepository : IGenericRepository<Tutor>
    {
        IQueryable GetAllWithUsers();
    }
}
