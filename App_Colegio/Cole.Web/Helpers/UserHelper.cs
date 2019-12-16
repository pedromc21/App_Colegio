namespace Cole.Web.Helpers
{
    using Data.Entities;
    using Microsoft.AspNetCore.Identity;
    using System.Threading.Tasks;
    public class UserHelper : IUserHelper
    {
        private readonly UserManager<User> userManager;
        public UserHelper(UserManager<User> userManager)
        {
            this.userManager = userManager;
        }
        public async Task<User> GetUserByEmailAsync(string email)
        {
            return await this.userManager.FindByEmailAsync(email);
        }
        public async Task<IdentityResult> UpdateUserAsync(User user, string password)
        {
            user.PasswordHash = password;  
            return await this.userManager.UpdateAsync(user);
        }
        

    }
}
