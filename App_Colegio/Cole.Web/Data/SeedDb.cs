
namespace Cole.Web.Data
{
    using Cole.Web.Data.Entities;
    using Cole.Web.Helpers;
    using Microsoft.AspNetCore.Identity;
    using System;
    using System.Linq;
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
            var user_1 = await this.userHelper.GetUserByEmailAsync ("invernaderosjc@hotmail.com");
            if (user_1 == null)
            {
                user_1 = new User
                {
                    Persona_Id = 28071,
                    Clave_Familia = "GOR001",
                    Email = "invernaderosjc@hotmail.com",
                    UserName = "invernaderosjc@hotmail.com",
                    PhoneNumber = ""
                };
                var result = await this.userHelper.AddUserAsync(user_1, "M3N6BCYK");
                if (result != IdentityResult.Success)
                {
                    throw new InvalidOperationException("Could not create the user in seeder");
                }
            }
            var user_2 = await this.userHelper.GetUserByEmailAsync("jucar2502@hotmail.com");
            if (user_2 == null)
            {
                user_2 = new User
                {
                    Persona_Id = 28285,
                    Clave_Familia = "GOR001",
                    Email = "jucar2502@hotmail.com",
                    UserName = "jucar2502@hotmail.com",
                    PhoneNumber = ""
                };
                var result = await this.userHelper.AddUserAsync(user_2, "XA8V5YK7");
                if (result != IdentityResult.Success)
                {
                    throw new InvalidOperationException("Could not create the user in seeder");
                }
            }
            var user_3 = await this.userHelper.GetUserByEmailAsync("pablor.regordosa@gmail.com");
            if (user_3 == null)
            {
                user_3 = new User
                {
                    Persona_Id = 28309,
                    Clave_Familia = "RODRIRODR2",
                    Email = "pablor.regordosa@gmail.com",
                    UserName = "pablor.regordosa@gmail.com",
                    PhoneNumber = ""
                };
                var result = await this.userHelper.AddUserAsync(user_3, "BESARTUC");
                if (result != IdentityResult.Success)
                {
                    throw new InvalidOperationException("Could not create the user in seeder");
                }
            }
            await this.context.Database.EnsureCreatedAsync();
            if (!this.context.Tutors.Any())
            {
                this.AddTutor(28071, "GOR001", "GONZÁLEZ", "LAZO", "OSCAR", "PADRE", true, user_1);
                this.AddTutor(28285, "GOR001", "RAMIREZ", "ZAVALETA", "ADRIANA", "MADRE", false, user_2) ;
                this.AddTutor(28309, "RODRIRODR2", "RODRIGUEZ", "REGORDOSA", "PABLO", "PADRE", true, user_3);
                await this.context.SaveChangesAsync();
            }
        }
        private void AddTutor(int persona_Id, string clave_familia, string apellido_paterno, string apellido_materno, string nombres, string parentesco, bool tutor_principal, User user)
        {
            this.context.Tutors.Add(new Tutor
            {
                Persona_Id = persona_Id,
                Clave_Familia = clave_familia,
                Apellido_Paterno = apellido_paterno,
                Apellido_Materno = apellido_materno,
                Nombres = nombres,
                Parentesco = parentesco,
                Tutor_Principal = tutor_principal,
                User = user 
            });
        }
    }
}
