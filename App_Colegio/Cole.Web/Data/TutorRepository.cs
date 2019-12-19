namespace Cole.Web.Data
{
    using Entities;
    using Microsoft.EntityFrameworkCore;
    using System.Linq;

    public class TutorRepository : GenericRepository<Tutor>, ITutorRepository
	{
		private readonly DataContext context;
		public TutorRepository(DataContext context) : base(context)
		{
			this.context = context;
		}

		public IQueryable GetAllWithUsers()
		{
			return this.context.Tutors.Include(p => p.User);
		}
	}
}
