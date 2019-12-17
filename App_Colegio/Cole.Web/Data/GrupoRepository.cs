namespace Cole.Web.Data
{
    using Entities;
    public class GrupoRepository : GenericRepository<Grupo>, IGrupoRepository
	{
		public GrupoRepository(DataContext context) : base(context)
		{
		
		}
	}    
}
