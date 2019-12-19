namespace Cole.Web.Helpers
{
    using Data.Entities;
    using Microsoft.AspNetCore.Identity;
    using System.Threading.Tasks;
    public interface IUserHelper
    {
        //Clase para ayudar a transportar de proyecto a proyecto
        Task<User> GetUserByEmailAsync(string email);

        Task<IdentityResult> AddUserAsync(User user, string password);

    }
}
