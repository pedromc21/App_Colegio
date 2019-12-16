
namespace Cole.Web.Data
{
    using Cole.Web.Helpers;
    using Microsoft.AspNetCore.Identity;
    using System.Threading.Tasks;

    public class SeedDb
    {
        private readonly DataContext context;
        private readonly IUserHelper userHelper;
        public SeedDb(DataContext context, IUserHelper userHelper)
        {
            this.context = context;
            this.userHelper = userHelper;
        }

        public async Task SeedAsync()
        {
            await this.context.Database.EnsureCreatedAsync();
            var user = await this.userHelper.GetUserByEmailAsync("pedromc219@gmail.com");
            if (user != null)
            {
                //Actualziar la contraseña encriptada
                var result = await this.userHelper.UpdateUserAsync(user, "123456");
                if (result != IdentityResult.Success)
                {

                }
            }
        }
    }
}
