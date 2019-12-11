namespace Cole.Web.Data
{
    using Entities;
    public class Repository
    {
        private readonly DataContext context;
        public Repository(DataContext context)
        {
            this.context = context;
        }

    }
}
