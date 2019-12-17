namespace Cole.Web.Data
{
	using Entities;
	public class CargoRepository : GenericRepository<Cargo>, ICargoRepository
	{
		public CargoRepository(DataContext context) : base(context)
		{

		}
	}
}
