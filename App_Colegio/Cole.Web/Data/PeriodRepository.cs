namespace Cole.Web.Data
{
	using Entities;
	public class PeriodRepository : GenericRepository<Period>, IPeriodRepository
	{
		public PeriodRepository(DataContext context) : base(context)
		{

		}
	}
}
