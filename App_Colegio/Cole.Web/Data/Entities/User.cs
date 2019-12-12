namespace Cole.Web.Data.Entities
{
    using Microsoft.AspNetCore.Identity;
    public class User : IdentityUser
    {
        public int Usuario_Id { get; set; }
        public int Persona_Id { get; set; }
        public string Clave_Familia { get; set; }

        /*Borrado y actualizacion de la Base de datos
        dotnet ef database drop
        dotnet ef migrations add Users
        dotnet ef database update*/
    }
}
