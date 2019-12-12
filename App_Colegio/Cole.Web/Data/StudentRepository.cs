namespace Cole.Web.Data
{
	using Entities;
	public class StudentRepository : GenericRepository<Student>, IStudentRepository
	{
		public StudentRepository(DataContext context) : base(context)
		{
		}
	}
}
