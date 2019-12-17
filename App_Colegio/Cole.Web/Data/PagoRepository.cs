namespace Cole.Web.Data
{
    using Entities;
    public class PagoRepository : GenericRepository<Pago>, IPagoRepository
	{
		public PagoRepository(DataContext context) : base(context)
		{

		}
	}
}
