namespace Cole.Web.Data
{
    using Entities;
    public class TutorRepository : GenericRepository<Tutor>, ITutorRepository
	{
		public TutorRepository(DataContext context) : base(context)
		{

		}
	}
}
